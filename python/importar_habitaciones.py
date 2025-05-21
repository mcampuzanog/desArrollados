import xmlrpc.client
from lxml import etree

# Conectar con Odoo
ODOO_URL = "http://localhost:8069"
DB = "HotelSOL"
USERNAME = "idiazris@uoc.edu"
PASSWORD = "1234"

common = xmlrpc.client.ServerProxy(f"{ODOO_URL}/xmlrpc/2/common")
uid = common.authenticate(DB, USERNAME, PASSWORD, {})

if not uid:
    print("Error en autenticación con Odoo")
    exit()

models = xmlrpc.client.ServerProxy(f"{ODOO_URL}/xmlrpc/2/object")

# Leer el XML generado
xml_file = r"C:\Users\Administrator\OneDrive\Escritorio\uni\producto2CapaDatos(P59)_DiazRisso_Ingrid\HotelSOL\SQLEXPRESS\habitaciones.xml"
tree = etree.parse(xml_file)
root = tree.getroot()

# Obtener habitaciones existentes en Odoo para evitar duplicados
habitaciones_existentes = models.execute_kw(DB, uid, PASSWORD, 'hotel.habitacion', 'search_read', [[]], {'fields': ['id_sql']})
habitaciones_validas = {habitacion['id_sql'] for habitacion in habitaciones_existentes}

habitaciones = []
for habitacion in root.findall("Habitacion"):
    try:
        habitacion_id = int(habitacion.find("HabitacionId").text)  # 🔹 Obtener ID de SQL Server
        tipo = habitacion.find("tipo").text or ""
        capacidad = int(habitacion.find("capacidad").text)
        precio_base = float(habitacion.find("precio_base").text)
        disponibilidad = habitacion.find("disponibilidad").text == "true"

        # Si la habitación ya existe en Odoo, no la duplicamos
        if habitacion_id in habitaciones_validas:
            print(f"Habitación ID {habitacion_id} ya existe en Odoo, se omitirá.")
            continue

        habitaciones.append({
            'id_sql': habitacion_id,  # 🔹 Guardamos el ID de SQL Server
            'tipo': tipo,
            'capacidad': capacidad,
            'precio_base': precio_base,
            'disponibilidad': disponibilidad
        })

    except Exception as e:
        print(f"Error procesando habitación: {e}")

print(f"Habitaciones a importar: {len(habitaciones)}")

# Enviar habitaciones nuevas a Odoo
for habitacion in habitaciones:
    try:
        habitacion_odoo_id = models.execute_kw(DB, uid, PASSWORD,
            'hotel.habitacion', 'create', [habitacion])
        print(f"Habitación creada en Odoo con ID: {habitacion_odoo_id} (SQL ID: {habitacion['id_sql']})")
    except Exception as e:
        print(f"Error al crear habitación en Odoo: {e}")

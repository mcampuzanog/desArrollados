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
xml_file = r"C:\Users\Administrator\OneDrive\Escritorio\uni\producto2CapaDatos(P59)_DiazRisso_Ingrid\HotelSOL\SQLEXPRESS\reservas_habitaciones.xml"
tree = etree.parse(xml_file)
root = tree.getroot()

reservas_habitaciones = []
for reserva_habitacion in root.findall("ReservaHabitacion"):
    reservas_habitaciones.append({
        'reserva_id': int(reserva_habitacion.find("ReservaId").text),
        'habitacion_id': int(reserva_habitacion.find("HabitacionId").text)
    })

print(f" Reservas de Habitaciones extraídas: {len(reservas_habitaciones)}")

# Enviar reservas de habitaciones a Odoo
# Buscar ID interno en Odoo usando `id_sql`
def obtener_reserva_odoo(id_sql):
    resultado = models.execute_kw(DB, uid, PASSWORD, 'hotel.reserva', 'search_read', [[('id_sql', '=', id_sql)]], {'fields': ['id']})
    return resultado[0]['id'] if resultado else None

def obtener_habitacion_odoo(id_sql):
    resultado = models.execute_kw(DB, uid, PASSWORD, 'hotel.habitacion', 'search_read', [[('id_sql', '=', id_sql)]], {'fields': ['id']})
    return resultado[0]['id'] if resultado else None

# Filtrar y vincular correctamente reservas y habitaciones
reservas_habitaciones_filtradas = []
for reserva_habitacion in reservas_habitaciones:
    reserva_id_sql = int(reserva_habitacion['reserva_id'])
    habitacion_id_sql = int(reserva_habitacion['habitacion_id'])

    reserva_odoo_id = obtener_reserva_odoo(reserva_id_sql)
    habitacion_odoo_id = obtener_habitacion_odoo(habitacion_id_sql)

    if not reserva_odoo_id:
        print(f"Reserva SQL ID {reserva_id_sql} no existe en Odoo. Ignorando.")
        continue
    if not habitacion_odoo_id:
        print(f"Habitación SQL ID {habitacion_id_sql} no existe en Odoo. Ignorando.")
        continue

    reservas_habitaciones_filtradas.append({
        'reserva_id': reserva_odoo_id,  # 🔹 Vinculamos con el ID interno de Odoo
        'habitacion_id': habitacion_odoo_id
    })

print(f"Reservas de habitaciones válidas: {len(reservas_habitaciones_filtradas)}")

# Enviar reservas de habitaciones a Odoo
for reserva_habitacion in reservas_habitaciones_filtradas:
    try:
        reserva_habitacion_id = models.execute_kw(DB, uid, PASSWORD,
            'hotel.reserva.habitacion', 'create', [reserva_habitacion])

        print(f"Reserva de Habitación creada en Odoo con ID: {reserva_habitacion_id}")
    except Exception as e:
        print(f"Error al crear reserva de habitación en Odoo: {e}")

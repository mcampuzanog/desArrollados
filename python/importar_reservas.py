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
xml_file = r"C:\Users\Administrator\OneDrive\Escritorio\uni\producto2CapaDatos(P59)_DiazRisso_Ingrid\HotelSOL\SQLEXPRESS\reservas.xml"
tree = etree.parse(xml_file)
root = tree.getroot()

# Obtener reservas existentes en Odoo para evitar duplicados
reservas_existentes = models.execute_kw(DB, uid, PASSWORD, 'hotel.reserva', 'search_read', [[]], {'fields': ['id_sql']})
reservas_validas = {reserva['id_sql'] for reserva in reservas_existentes}

reservas = []
for reserva in root.findall("Reserva"):
    try:
        reserva_id = int(reserva.find("ReservaId").text)  # 🔹 ID de SQL Server
        cliente_id = int(reserva.find("ClienteId").text)
        fecha_inicio = reserva.find("FechaInicio").text
        fecha_fin = reserva.find("FechaFin").text
        estado = reserva.find("Estado").text.lower()
        tipo_alojamiento = reserva.find("TipoAlojamiento").text
        temporada = reserva.find("Temporada").text

        # Si la reserva ya existe en Odoo, no la duplicamos
        if reserva_id in reservas_validas:
            print(f"Reserva ID {reserva_id} ya existe en Odoo, se omitirá.")
            continue

        reservas.append({
            'id_sql': reserva_id,  # 🔹 Guardamos el ID de SQL Server
            'cliente_id': cliente_id,
            'fecha_inicio': fecha_inicio,
            'fecha_fin': fecha_fin,
            'estado': estado,
            'tipo_alojamiento': tipo_alojamiento,
            'temporada': temporada
        })

    except Exception as e:
        print(f"Error procesando reserva: {e}")

print(f"Reservas listas para importar: {len(reservas)}")

# Buscar el ID interno de Odoo usando `cliente_id` de SQL Server
def obtener_cliente_odoo(cliente_sql_id):
    resultado = models.execute_kw(DB, uid, PASSWORD, 'hotel.cliente', 'search_read', [[('cliente_id', '=', cliente_sql_id)]], {'fields': ['id']})
    return resultado[0]['id'] if resultado else None

reservas_filtradas = []
for reserva in reservas:
    reserva_cliente_id = int(reserva['cliente_id'])

    cliente_odoo_id = obtener_cliente_odoo(reserva_cliente_id)
    if not cliente_odoo_id:
        print(f"⚠️ Cliente ID {reserva_cliente_id} no existe en Odoo. La reserva será ignorada.")
        continue

    reservas_filtradas.append({
        'id_sql': reserva['id_sql'],  # 🔹 Mantiene el ID SQL en Odoo
        'cliente_id': cliente_odoo_id,
        'fecha_inicio': reserva['fecha_inicio'],
        'fecha_fin': reserva['fecha_fin'],
        'estado': reserva['estado'],
        'tipo_alojamiento': reserva['tipo_alojamiento'],
        'temporada': reserva['temporada']
    })

print(f"Reservas válidas: {len(reservas_filtradas)}")

# Enviar reservas válidas a Odoo
for reserva in reservas_filtradas:
    try:
        reserva_id = models.execute_kw(DB, uid, PASSWORD,
            'hotel.reserva', 'create', [reserva])
        print(f"Reserva creada en Odoo con ID: {reserva_id} (SQL ID: {reserva['id_sql']})")
    except Exception as e:
        print(f"Error al crear reserva en Odoo: {e}")

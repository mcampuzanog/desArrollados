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
xml_file = r"C:\Users\Administrator\OneDrive\Escritorio\uni\producto2CapaDatos(P59)_DiazRisso_Ingrid\HotelSOL\SQLEXPRESS\facturas.xml"
tree = etree.parse(xml_file)
root = tree.getroot()

# Obtener reservas existentes en Odoo para evitar errores de clave foránea
reservas_existentes = models.execute_kw(DB, uid, PASSWORD, 'hotel.reserva', 'search_read', [[]], {'fields': ['id_sql', 'id']})
reservas_validas = {int(reserva['id_sql']): reserva['id'] for reserva in reservas_existentes}  # 🔹 Relación SQL-Odoo

facturas = []
for factura in root.findall("Factura"):
    try:
        factura_id_sql = int(factura.find("FacturaId").text)  # 🔹 ID de SQL Server
        reserva_id_sql = int(factura.find("ReservaId").text)
        monto_total = float(factura.find("MontoTotal").text)
        fecha_emision = factura.find("FechaEmision").text or ""

        # 🔹 Verificar que la reserva existe en Odoo antes de importar
        reserva_odoo_id = reservas_validas.get(reserva_id_sql)
        if not reserva_odoo_id:
            print(f"Reserva SQL ID {reserva_id_sql} no existe en Odoo. Factura ignorada.")
            continue

        facturas.append({
            'id_sql': factura_id_sql,  # 🔹 Guardamos el ID original de SQL Server
            'reserva_id': reserva_odoo_id,  # 🔹 Vinculamos con el ID de Odoo
            'monto_total': monto_total,
            'fecha_emision': fecha_emision
        })

    except Exception as e:
        print(f"Error procesando factura: {e}")

print(f"Facturas listas para importar: {len(facturas)}")

# Enviar facturas a Odoo
for factura in facturas:
    try:
        factura_odoo_id = models.execute_kw(DB, uid, PASSWORD, 'hotel.factura', 'create', [factura])
        print(f"Factura creada en Odoo con ID: {factura_odoo_id} (SQL ID: {factura['id_sql']})")
    except Exception as e:
        print(f"Error al crear factura en Odoo: {e}")

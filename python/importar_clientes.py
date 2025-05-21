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
xml_file = r"C:\Users\Administrator\OneDrive\Escritorio\uni\producto2CapaDatos(P59)_DiazRisso_Ingrid\HotelSOL\SQLEXPRESS\clientes.xml"
tree = etree.parse(xml_file)
root = tree.getroot()

# Obtener clientes existentes en Odoo para evitar duplicados
clientes_existentes = models.execute_kw(DB, uid, PASSWORD, 'hotel.cliente', 'search_read', [[]], {'fields': ['cliente_id']})
clientes_validos = {cliente['cliente_id'] for cliente in clientes_existentes}

clientes = []
for cliente in root.findall("Cliente"):
    try:
        cliente_id = int(cliente.find("ClienteId").text)

        # Si el cliente ya existe en Odoo, no lo duplicamos
        if cliente_id in clientes_validos:
            print(f"Cliente ID {cliente_id} ya existe en Odoo, se omitirá.")
            continue

        clientes.append({
            'cliente_id': cliente_id,  # 🔹 Guardamos el ID de SQL Server
            'dni': cliente.find("DNI").text or "",
            'nombre': cliente.find("Nombre").text or "",
            'apellido': cliente.find("Apellido").text or "",
            'direccion': cliente.find("Direccion").text or "",
            'email': cliente.find("Email").text or "",
            'telefono': cliente.find("Telefono").text or "",
            'vip': cliente.find("VIP").text == "true"
        })

    except Exception as e:
        print(f"Error procesando cliente: {e}")

print(f"Clientes a importar: {len(clientes)}")

# Enviar clientes nuevos a Odoo
for cliente in clientes:
    try:
        cliente_odoo_id = models.execute_kw(DB, uid, PASSWORD,
            'hotel.cliente', 'create', [cliente])
        print(f"Cliente creado en Odoo con ID: {cliente_odoo_id} (SQL ID: {cliente['cliente_id']})")
    except Exception as e:
        print(f"Error al crear cliente en Odoo: {e}")

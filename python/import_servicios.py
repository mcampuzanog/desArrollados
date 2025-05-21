import xmlrpc.client
from lxml import etree

# Conectar con Odoo
ODOO_URL = "http://localhost:8069"
DB = "HotelSOL"  # Asegúrate de que este nombre es el correcto
USERNAME = "idiazris@uoc.edu"
PASSWORD = "1234"


common = xmlrpc.client.ServerProxy(f"{ODOO_URL}/xmlrpc/2/common")
uid = common.authenticate(DB, USERNAME, PASSWORD, {})

if not uid:
    print(" Error en autenticación con Odoo")
    exit()

models = xmlrpc.client.ServerProxy(f"{ODOO_URL}/xmlrpc/2/object")

# Leer el XML generado
xml_file = r"C:\Users\Administrator\OneDrive\Escritorio\uni\producto2CapaDatos(P59)_DiazRisso_Ingrid\HotelSOL\SQLEXPRESS\servicios.xml"
tree = etree.parse(xml_file)
root = tree.getroot()

servicios = []
for servicio in root.findall("Servicio"):
    servicios.append({
        'descripcion': servicio.find("descripcion").text,
        'precio': float(servicio.find("precio").text)
    })

print(f" Servicios extraídos: {len(servicios)}")

# Enviar servicios a Odoo
for servicio in servicios:
    servicio_id = models.execute_kw(DB, uid, PASSWORD,
        'hotel.servicio', 'create', [servicio])

    print(" Servicio creado en Odoo con ID: {servicio_id}")

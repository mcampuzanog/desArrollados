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
    print("Error en autenticación con Odoo")
    exit()

models = xmlrpc.client.ServerProxy(f"{ODOO_URL}/xmlrpc/2/object")

# Leer el XML generado
xml_file = r"C:\Users\Administrator\OneDrive\Escritorio\uni\producto2CapaDatos(P59)_DiazRisso_Ingrid\HotelSOL\SQLEXPRESS\incidencias.xml"
tree = etree.parse(xml_file)
root = tree.getroot()

incidencias = []
for incidencia in root.findall("Incidencia"):
    incidencias.append({
        'reserva_id': int(incidencia.find("reserva_id").text),
        'descripcion': incidencia.find("descripcion").text,
        'fecha_informe': incidencia.find("fecha_informe").text  # Mantiene el formato como string
    })

print(f" Incidencias extraídas: {len(incidencias)}")

# Enviar incidencias a Odoo
for incidencia in incidencias:
    incidencia_id = models.execute_kw(DB, uid, PASSWORD,
        'hotel.incidencia', 'create', [incidencia])

    print(f"Incidencia creada en Odoo con ID: {incidencia_id}")

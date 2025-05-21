import xmlrpc.client

ODOO_URL = "http://localhost:8069"
DB = "HotelSOL"  # Pon el nombre real de tu BD en Odoo
USERNAME = "idiazris@uoc.edu"
PASSWORD = "1234"

# Autenticación
common = xmlrpc.client.ServerProxy(f"{ODOO_URL}/xmlrpc/2/common")
uid = common.authenticate(DB, USERNAME, PASSWORD, {})

if uid:
    print(f"Conexión exitosa con Odoo, usuario ID: {uid}")
else:
    print("Error en autenticación con Odoo")

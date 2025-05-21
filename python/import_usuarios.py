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
xml_file = r"C:\Users\Administrator\OneDrive\Escritorio\uni\producto2CapaDatos(P59)_DiazRisso_Ingrid\HotelSOL\SQLEXPRESS\usuarios.xml"
tree = etree.parse(xml_file)
root = tree.getroot()

# Mapeo de nombres de rol en XML a valores permitidos en Odoo
rol_mapping = {
    "Administrador": "admin",
    "Recepcionista": "recepcionista",
    "Cliente": "cliente"
}

usuarios = []
for usuario in root.findall("Usuario"):
    try:
        nombre = usuario.find("nombre").text or "Sin nombre"
        rol_xml = usuario.find("rol").text or "Cliente"  # 🔹 Valor por defecto si el rol es `None`
        rol_odoo = rol_mapping.get(rol_xml, "cliente")  # 🔹 Convertir rol al formato correcto

        usuarios.append({
            'nombre': nombre,
            'rol': rol_odoo  # 🔹 Usamos el valor correcto de `Selection` en Odoo
        })
    except Exception as e:
        print(f"Error procesando usuario: {e}")

print(f"Usuarios extraídos: {len(usuarios)}")

# Enviar usuarios a Odoo
for usuario in usuarios:
    try:
        usuario_id = models.execute_kw(DB, uid, PASSWORD,
            'hotel.usuario', 'create', [usuario])
        print(f"Usuario creado en Odoo con ID: {usuario_id}")
    except Exception as e:
        print(f"Error al crear usuario en Odoo: {e}")

import pyodbc
import os
from lxml import etree

# Configuración
server = r'INGRID-PC'  
database = 'HotelSOL'
output_dir = r'C:\Users\Administrator\OneDrive\Escritorio\uni\producto2CapaDatos(P59)_DiazRisso_Ingrid\HotelSOL\SQLEXPRESS'
output_file = os.path.join(output_dir, 'habitaciones.xml')

# Crear carpeta si no existe
os.makedirs(output_dir, exist_ok=True)

# Conexión a SQL Server
conn_str = (
    f"DRIVER={{ODBC Driver 17 for SQL Server}};"
    f"SERVER={server};"
    f"DATABASE={database};"
    f"Trusted_Connection=yes;"
    f"TrustServerCertificate=yes;"
)

try:
    conn = pyodbc.connect(conn_str)
    cursor = conn.cursor()
    
    # 🔹 Asegurar que 'id' es el ID correcto en SQL Server
    cursor.execute("SELECT id, tipo, capacidad, precio_base, disponibilidad FROM Habitaciones")

    root = etree.Element("Habitaciones")
    for row in cursor.fetchall():
        habitacion_elem = etree.SubElement(root, "Habitacion")

        # 🔹 Usar `id` en lugar de `HabitacionId`
        habitacion_id = str(row.id) if row.id is not None else "0"
        etree.SubElement(habitacion_elem, "HabitacionId").text = habitacion_id  # 🔹 Cambio de `ClienteId` a `HabitacionId`

        etree.SubElement(habitacion_elem, "tipo").text = row.tipo or ""
        etree.SubElement(habitacion_elem, "capacidad").text = str(row.capacidad if row.capacidad is not None else 0)
        etree.SubElement(habitacion_elem, "precio_base").text = str(row.precio_base if row.precio_base is not None else 0.0)
        etree.SubElement(habitacion_elem, "disponibilidad").text = "true" if row.disponibilidad else "false"

    # 🔹 Guardar archivo XML correctamente
    etree.ElementTree(root).write(output_file, pretty_print=True, xml_declaration=True, encoding='utf-8')

    print(f" Exportado correctamente: {output_file}")

except Exception as e:
    print(f"Error: {e}")

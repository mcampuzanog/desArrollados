import pyodbc
import os
from lxml import etree

# Configuración
server = r'INGRID-PC'  
database = 'HotelSOL'
output_dir = r'C:\Users\Administrator\OneDrive\Escritorio\uni\producto2CapaDatos(P59)_DiazRisso_Ingrid\HotelSOL\SQLEXPRESS'
output_file = os.path.join(output_dir, 'facturas.xml')

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

    cursor.execute("""
        SELECT id, reserva_id, monto_total, fecha_emision
        FROM Facturas
    """)

    # Crear XML
    root = etree.Element("Facturas")

    for row in cursor.fetchall():
        factura_elem = etree.SubElement(root, "Factura")

        # 🔹 Agregamos `factura_id` para conservar el ID de SQL Server
        factura_id = str(row.id) if row.id is not None else "0"
        etree.SubElement(factura_elem, "FacturaId").text = factura_id

        etree.SubElement(factura_elem, "ReservaId").text = str(row.reserva_id)
        etree.SubElement(factura_elem, "MontoTotal").text = str(row.monto_total)

        # 🔹 Manejo de `None` en `fecha_emision`
        fecha_emision = row.fecha_emision.strftime("%Y-%m-%d") if row.fecha_emision else ""
        etree.SubElement(factura_elem, "FechaEmision").text = fecha_emision

    # Guardar XML con formato correcto
    etree.ElementTree(root).write(output_file, pretty_print=True, xml_declaration=True, encoding='utf-8')

    print(f"Archivo exportado correctamente: {output_file}")

except Exception as e:
    print(f" Error durante la exportación: {e}")

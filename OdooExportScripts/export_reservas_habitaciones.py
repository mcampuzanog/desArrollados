import pyodbc
import os
from lxml import etree

server = r'INGRID-PC'  
database = 'HotelSOL'
output_dir = r'C:\Users\Administrator\OneDrive\Escritorio\uni\producto2CapaDatos(P59)_DiazRisso_Ingrid\HotelSOL\SQLEXPRESS'
output_file = os.path.join(output_dir, 'reservas_habitaciones.xml')
os.makedirs(output_dir, exist_ok=True)

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
    cursor.execute("SELECT id, ReservaId, HabitacionId FROM ReservaHabitaciones")

    root = etree.Element("ReservaHabitaciones")
    for row in cursor.fetchall():
        item = etree.SubElement(root, "ReservaHabitacion")
        etree.SubElement(item, "id").text = str(row.id)
        etree.SubElement(item, "ReservaId").text = str(row.ReservaId)
        etree.SubElement(item, "HabitacionId").text = str(row.HabitacionId)

    etree.ElementTree(root).write(output_file, pretty_print=True, xml_declaration=True, encoding='utf-8')
    print(f"Exportado: {output_file}")
except Exception as e:
    print(f"Error: {e}")

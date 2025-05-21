import pyodbc
import os
from lxml import etree

# Configuración
server = r'INGRID-PC'  
database = 'HotelSOL'
output_dir = r'C:\Users\Administrator\OneDrive\Escritorio\uni\producto2CapaDatos(P59)_DiazRisso_Ingrid\HotelSOL\SQLEXPRESS'
output_file = os.path.join(output_dir, 'reservas.xml')

# Crear carpeta si no existe
os.makedirs(output_dir, exist_ok=True)

# Conexión a SQL Server
conn_str = (
    f"DRIVER={{ODBC Driver 17 for SQL Server}};"
    f"SERVER={server};"
    f"DATABASE={database};"
    f"Trusted_Connection=yes;"
)

try:
    conn = pyodbc.connect(conn_str)
    cursor = conn.cursor()

    # 🔹 Consulta SQL asegurando los campos correctos
    cursor.execute("SELECT id, ClienteId, FechaInicio, FechaFin, Estado, TipoAlojamiento, Temporada FROM Reservas")

    root = etree.Element("Reservas")
    for row in cursor.fetchall():
        reserva_elem = etree.SubElement(root, "Reserva")

        # 🔹 Corrección en IDs para mantener consistencia con SQL Server
        reserva_id = str(row.id) if row.id is not None else "0"
        cliente_id = str(row.ClienteId) if row.ClienteId is not None else "0"

        etree.SubElement(reserva_elem, "ReservaId").text = reserva_id  # 🔹 Cambio de `<id>` a `<ReservaId>`
        etree.SubElement(reserva_elem, "ClienteId").text = cliente_id
        etree.SubElement(reserva_elem, "FechaInicio").text = str(row.FechaInicio) if row.FechaInicio else ""
        etree.SubElement(reserva_elem, "FechaFin").text = str(row.FechaFin) if row.FechaFin else ""
        etree.SubElement(reserva_elem, "Estado").text = row.Estado or "pendiente"
        etree.SubElement(reserva_elem, "TipoAlojamiento").text = row.TipoAlojamiento or "No especificado"
        etree.SubElement(reserva_elem, "Temporada").text = row.Temporada or "General"

    # 🔹 Guardar archivo XML con formato correcto
    etree.ElementTree(root).write(output_file, pretty_print=True, xml_declaration=True, encoding='utf-8')

    print(f"Exportado correctamente: {output_file}")

except Exception as e:
    print(f"Error al exportar reservas: {e}")


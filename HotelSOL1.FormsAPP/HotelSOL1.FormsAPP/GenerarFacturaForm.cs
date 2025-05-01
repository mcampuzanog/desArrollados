using HotelSOL.DataAccess.Models;
using HotelSOL.DataAccess.Services;
using System;
using System.Windows.Forms;

namespace HotelSOL1.FormsAPP
{
    public partial class GenerarFacturaForm : Form
    {
        private readonly FacturaService facturaService;
        private readonly Reserva reserva;

        public GenerarFacturaForm(Reserva reserva)
        {
            InitializeComponent();
            this.reserva = reserva;
            facturaService = new FacturaService(Program.DbContext);
        }

        private void GenerarFacturaForm_Load(object sender, EventArgs e)
        {
            // Verificación de Cliente y corrección de nombres de propiedades
            lblCliente.Text = "Cliente: " + (reserva.Cliente != null ? reserva.Cliente.Nombre : "Sin asignar");
            lblFechaEntrada.Text = "Fecha Entrada: " + reserva.FechaInicio.ToString("dd/MM/yyyy");
            lblFechaSalida.Text = "Fecha Salida: " + reserva.FechaFin.ToString("dd/MM/yyyy");
        }

        private void btnGenerarFactura_Click(object sender, EventArgs e)
        {
            try
            {
                var factura = facturaService.GenerarFactura(reserva.Id, null); // Pasa lista de servicios si es necesario

                lblMonto.Text = "Monto Total: $" + factura.MontoTotal.ToString("0.00");
                MessageBox.Show("✅ Factura generada exitosamente!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error generando la factura: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblFechaEntrada_Click(object sender, EventArgs e)
        {
            // Método vacío para evitar errores de referencia
        }

        private void lblFechaSalida_Click(object sender, EventArgs e)
        {
            // Método vacío para evitar errores de referencia
        }

        private void lblCliente_Click(object sender, EventArgs e)
        {
            // Método vacío para evitar errores de referencia
        }
    }
}


using System;
using System.Linq;
using System.Windows.Forms;
using HotelSOL.DataAccess;
using HotelSOL.DataAccess.Models;
using HotelSOL.DataAccess.Services;

namespace HotelSOL1.FormsAPP
{
    public partial class PagoForm : Form
    {
        private readonly PagoService pagoService;
        private readonly int facturaId;

        public PagoForm(int facturaId)
        {
            InitializeComponent();
            this.pagoService= pagoService;
            this.facturaId = facturaId;

            CargarPagos();
        }

        private void CargarPagos()
        {
            dgvPagos.DataSource = pagoService.ObtenerPagosPorFactura(facturaId)
                .Select(p => new
                {
                    p.Id,
                    Monto = $"${p.Monto:F2}",
                    Método = p.MetodoPago,
                    Fecha = p.FechaPago.ToString("dd/MM/yyyy")
                }).ToList();
        }

        private void btnRegistrarPago_Click(object sender, EventArgs e)
        {
            try
            {
                decimal monto = decimal.Parse(txtMonto.Text);
                string metodoPago = cmbMetodoPago.SelectedItem.ToString();

                pagoService.RegistrarPago(facturaId, monto, metodoPago);
                MessageBox.Show("✅ Pago registrado correctamente!");

                CargarPagos(); // Refrescar la lista de pagos
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error al registrar pago: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

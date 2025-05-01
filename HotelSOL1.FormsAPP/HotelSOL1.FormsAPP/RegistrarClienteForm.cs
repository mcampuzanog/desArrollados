using HotelSOL.DataAccess.Models;
using HotelSOL.DataAccess.Services;
using System;
using System.Windows.Forms;

namespace HotelSOL1.FormsAPP
{
    public partial class RegistrarClienteForm : Form
    {
        private readonly ClienteService clienteService;

        public RegistrarClienteForm(ClienteService clienteService)
        {
            InitializeComponent();
            this.clienteService = clienteService;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                var cliente = new Cliente
                {
                    Nombre = txtNombre.Text,
                    Apellido = txtApellido.Text,
                    DNI = txtDNI.Text,
                    Direccion = txtDireccion.Text,
                    Email = txtEmail.Text,
                    Telefono = txtTelefono.Text,
                    VIP = chkVIP.Checked
                };

                clienteService.AgregarCliente(cliente);

                MessageBox.Show("✅ Cliente registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"❌ Error al registrar cliente:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

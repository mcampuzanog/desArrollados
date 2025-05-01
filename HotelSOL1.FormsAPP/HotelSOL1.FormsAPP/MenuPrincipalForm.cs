using HotelSOL.DataAccess.Services;
using HotelSOL1.FormsAPP;
using System;
using System.Windows.Forms;

namespace HotelSOL1.FormsAPP
{
    public partial class MenuPrincipalForm : Form
    {
        // Constructor del formulario
        public MenuPrincipalForm()
        {
            InitializeComponent();
        }

        // Al cargar el formulario puedes hacer algún pre-carga de datos si es necesario
        private void MenuPrincipalForm_Load(object sender, EventArgs e)
        {
            // Puedes usar esto para cargar datos si lo necesitas más adelante
        }

        // Evento cuando se hace clic en "Registrar Cliente"
        private void btnRegistrarCliente_Click(object sender, EventArgs e)
        {
            var clienteService = new ClienteService(Program.DbContext); // Asegúrate de que Program.DbContext esté bien configurado
            var form = new RegistrarClienteForm(clienteService);
            form.ShowDialog(); // Muestra el formulario de registrar cliente
        }

        // Evento cuando se hace clic en "Crear Reserva"
        private void btnCrearReserva_Click(object sender, EventArgs e)
        {
            var form = new CrearReservaForm(); // Enlaza el formulario de creación de reserva
            form.ShowDialog(); // Muestra el formulario
        }

        // Evento cuando se hace clic en "Generar Factura"
        private void btnGenerarFactura_Click(object sender, EventArgs e)
        {
            MessageBox.Show("🧾 Aquí se generará una factura.");
        }

        // Evento cuando se hace clic en "Ver Reservas"
        private void btnVerReservas_Click(object sender, EventArgs e)
        {
            // Aquí se pasa el servicio de reserva al formulario de ver reservas
            var reservaService = new ReservaService(Program.DbContext); // Asegúrate de que Program.DbContext esté bien configurado
            var form = new VerReservasForm(reservaService);
            form.ShowDialog(); // Muestra el formulario de ver reservas
        }

        // Evento cuando se hace clic en "Salir"
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Cierra la aplicación
        }
    }
}

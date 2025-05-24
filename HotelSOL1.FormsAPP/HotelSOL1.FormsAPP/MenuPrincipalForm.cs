using HotelSOL.DataAccess.Services;
using HotelSOL.DataAccess.Models;
using System;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using HotelSOL.DataAccess.Service;

namespace HotelSOL1.FormsAPP
{
    public partial class MenuPrincipalForm : Form
    {
        private Usuario usuarioAutenticado; // 🔹 Guardamos el usuario autenticado

        public MenuPrincipalForm(Usuario usuario)
        {
            InitializeComponent();
            usuarioAutenticado = usuario;

            if (usuarioAutenticado != null)
            {
                lblUsuario.Text = $"Bienvenido, {usuarioAutenticado.Nombre} ({usuarioAutenticado.Rol})";
                ConfigurarMenuSegunRol();
            }
            else
            {
                lblUsuario.Text = "Bienvenido, Usuario desconocido";
            }
        }


        private void ConfigurarMenuSegunRol()
        {
            lblUsuario.Text = $"Bienvenido, {usuarioAutenticado.Nombre} ({usuarioAutenticado.Rol})";

            switch (usuarioAutenticado.Rol)
            {
                case "Administrador":
                    btnRegistrarCliente.Visible = true;
                    btnCrearReserva.Visible = true;
                    btnVerReservas.Visible = true;
                    btnGenerarFactura.Visible = true;
                    btnExportarOdoo.Visible = true;
                    btnRegistrarUsuario.Visible = true;

                    break;

                case "Encargado":
                    btnRegistrarCliente.Visible = false;
                    btnCrearReserva.Visible = false;
                    btnVerReservas.Visible = true; // 🔹 Supervisa reservas
                    btnGenerarFactura.Visible = false;
                    btnExportarOdoo.Visible = true;
                    btnRegistrarUsuario.Visible = false;// 🔹 Acceso a gestión de proveedores y pedidos
                    break;

                case "Recepcionista":
                    btnRegistrarCliente.Visible = false;
                    btnCrearReserva.Visible = true;
                    btnVerReservas.Visible = true;
                    btnGenerarFactura.Visible = true;
                    btnExportarOdoo.Visible = false;
                    btnRegistrarUsuario.Visible = false;
                    break;

                case "Cliente":
                    btnRegistrarCliente.Visible = false;
                    btnCrearReserva.Visible = true;
                    btnVerReservas.Visible = true;
                    btnGenerarFactura.Visible = true;
                    btnExportarOdoo.Visible = false;
                    btnRegistrarUsuario.Visible = false;
                    break;

                case "Contable":
                    btnRegistrarCliente.Visible = false;
                    btnCrearReserva.Visible = false;
                    btnVerReservas.Visible = false;
                    btnGenerarFactura.Visible = true; // 🔹 Solo consulta facturas y análisis financiero
                    btnExportarOdoo.Visible = true;
                    btnRegistrarUsuario.Visible = false;
                    break;

                case "Personal Limpieza":
                    btnRegistrarCliente.Visible = false;
                    btnCrearReserva.Visible = false;
                    btnVerReservas.Visible = false;
                    btnGenerarFactura.Visible = false;
                    btnExportarOdoo.Visible = false;
                    btnRegistrarUsuario.Visible = false;
                    MessageBox.Show("🔹 Acceso a habitaciones por limpiar.");
                    break;

                case "Personal Restauración":
                    btnRegistrarCliente.Visible = false;
                    btnCrearReserva.Visible = false;
                    btnVerReservas.Visible = false;
                    btnGenerarFactura.Visible = false;
                    btnExportarOdoo.Visible = false;
                    btnRegistrarUsuario.Visible = false;
                    MessageBox.Show("🔹 Acceso a pedidos de clientes.");
                    break;

                case "Marketing y Publicidad":
                    btnRegistrarCliente.Visible = false;
                    btnCrearReserva.Visible = false;
                    btnVerReservas.Visible = false;
                    btnGenerarFactura.Visible = false;
                    btnExportarOdoo.Visible = true; // 🔹 Acceso a gestión de redes y descuentos VIP
                    btnRegistrarUsuario.Visible = false;
                    break;

                default:
                    MessageBox.Show("❌ Rol no reconocido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }


        private void btnRegistrarUsuario_Click(object sender, EventArgs e)
        {
            var usuarioService = new UsuarioService(Program.DbContext);
            var form = new RegistrarUsuarioForm(usuarioService);
            form.ShowDialog();
        }


        private void btnRegistrarCliente_Click(object sender, EventArgs e)
        {
            var clienteService = new ClienteService(Program.DbContext);
            var form = new RegistrarClienteForm(clienteService);
            form.ShowDialog();
        }

        private void btnCrearReserva_Click(object sender, EventArgs e)
        {
            var clienteService = new ClienteService(Program.DbContext);
            var habitacionService = new HabitacionService(Program.DbContext);
            var reservaService = new ReservaService(Program.DbContext);

            var form = new CrearReservaForm(clienteService, habitacionService, reservaService);
            form.ShowDialog();
        }


        private void btnVerReservas_Click(object sender, EventArgs e)
        {
            var reservaService = new ReservaService(Program.DbContext);
            var form = new VerReservasForm(reservaService);
            form.ShowDialog();
        }

        private void btnGenerarFactura_Click(object sender, EventArgs e)
        {
            var facturaService = new FacturaService(Program.DbContext);
            var reservaService = new ReservaService(Program.DbContext);

            // 🔹 Aquí obtienes una reserva específica (puedes obtener el ID desde un TextBox o selección)
            int reservaId = 1; // Reemplázalo con la lógica para obtener el ID dinámicamente
            var reserva = reservaService.ObtenerReservaPorId(reservaId); // Método para buscar la reserva

            if (reserva == null)
            {
                MessageBox.Show("❌ La reserva no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var form = new GenerarFacturaForm(reserva, facturaService); // ✅ Ahora pasamos una reserva válida
            form.ShowDialog();
        }



        private void btnExportarOdoo_Click(object sender, EventArgs e)
        {
            var form = new ExportarOdooForm();
            form.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MenuPrincipalForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}

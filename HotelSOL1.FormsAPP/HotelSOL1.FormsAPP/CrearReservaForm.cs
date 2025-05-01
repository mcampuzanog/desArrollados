using HotelSOL.DataAccess.Models;
using HotelSOL.DataAccess.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace HotelSOL1.FormsAPP
{
    public partial class CrearReservaForm : Form
    {
        private readonly ClienteService clienteService;
        private readonly HabitacionService habitacionService;
        private readonly ReservaService reservaService;

        public CrearReservaForm()
        {
            InitializeComponent();

            clienteService = new ClienteService(Program.DbContext);
            habitacionService = new HabitacionService(Program.DbContext);
            reservaService = new ReservaService(Program.DbContext);
        }

        private void CrearReservaForm_Load(object sender, EventArgs e)
        {
            // Cargar clientes
            var clientes = clienteService.ListarClientes();
            cmbClientes.DataSource = clientes;
            cmbClientes.DisplayMember = "nombre";
            cmbClientes.ValueMember = "ClienteId";


            // Cargar habitaciones disponibles
            var habitaciones = habitacionService.ObtenerHabitacionesDisponibles();

            cmbHabitaciones.DataSource = habitaciones;
            cmbHabitaciones.DisplayMember = "tipo";
            cmbHabitaciones.ValueMember = "Id";
        }

        private void btnGuardarReserva_Click(object sender, EventArgs e)
        {
            int clienteId = (int)cmbClientes.SelectedValue;
            int habitacionId = (int)cmbHabitaciones.SelectedValue;

        

            var reserva = new Reserva
            {
                ClienteId = clienteId,
                FechaInicio = dtpEntrada.Value,
                FechaFin = dtpSalida.Value,
                Estado = "Pendiente",
                TipoAlojamiento = "Normal",
                Temporada = "Baja"
            };
            
            reservaService.RegistrarReserva(reserva, new List<int> { habitacionId });

            MessageBox.Show("✅ Reserva creada correctamente.");
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

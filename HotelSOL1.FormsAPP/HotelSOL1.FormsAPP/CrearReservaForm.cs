using HotelSOL.DataAccess.Models;
using HotelSOL.DataAccess.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HotelSOL1.FormsAPP
{
    public partial class CrearReservaForm : Form
    {
        private readonly ClienteService clienteService;
        private readonly HabitacionService habitacionService;
        private readonly ReservaService reservaService;

        /// <summary>
        /// Constructor principal que recibe los servicios por inyección.
        /// </summary>
        public CrearReservaForm(
            ClienteService clienteService,
            HabitacionService habitacionService,
            ReservaService reservaService)
        {
            InitializeComponent();
            this.clienteService = clienteService;
            this.habitacionService = habitacionService;
            this.reservaService = reservaService;
        }

        /// <summary>
        /// Sobrecarga sin parámetros para uso directo.
        /// </summary>
        public CrearReservaForm()
            : this(
                new ClienteService(Program.DbContext),
                new HabitacionService(Program.DbContext),
                new ReservaService(Program.DbContext))
        {
            // Todos los campos de servicio quedan inicializados
        }

        private void CrearReservaForm_Load(object sender, EventArgs e)
        {
            // 1) Cargar lista de clientes
            var clientes = clienteService.ListarClientes();
            cmbClientes.DataSource = clientes;
            cmbClientes.DisplayMember = "Nombre";
            cmbClientes.ValueMember = "ClienteId";

            // 2) Cargar habitaciones disponibles
            var habitaciones = habitacionService.ObtenerHabitacionesDisponibles();
            cmbHabitaciones.DataSource = habitaciones;
            cmbHabitaciones.DisplayMember = "Tipo";
            cmbHabitaciones.ValueMember = "Id";
        }

        private void btnGuardarReserva_Click(object sender, EventArgs e)
        {
            // Validación básica de fechas
            if (dtpSalida.Value <= dtpEntrada.Value)
            {
                MessageBox.Show(
                    "La fecha de salida debe ser posterior a la fecha de entrada.",
                    "Error de fechas",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            // Obtener los IDs seleccionados
            int clienteId = (int)cmbClientes.SelectedValue;
            int habitacionId = (int)cmbHabitaciones.SelectedValue;

            // Crear objeto Reserva
            var reserva = new Reserva
            {
                ClienteId = clienteId,
                FechaInicio = dtpEntrada.Value,
                FechaFin = dtpSalida.Value,
                Estado = EstadoReserva.Pendiente,
                TipoAlojamiento = TipoAlojamiento.Normal,
                Temporada = Temporada.Baja
            };

            // Registrar en base de datos
            reservaService.RegistrarReserva(reserva, new List<int> { habitacionId });

            MessageBox.Show("✅ Reserva creada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

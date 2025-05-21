using HotelSOL.DataAccess.Models;
using HotelSOL.DataAccess.Services;
using System;
using System.Windows.Forms;

namespace HotelSOL1.FormsAPP
{
    public partial class HabitacionForm : Form
    {
        private readonly HabitacionService habitacionService;
        private Habitacion habitacionActual;

        public HabitacionForm(HabitacionService habitacionService)
        {
            InitializeComponent();
            this.habitacionService = habitacionService;
            cmbTipo.Items.AddRange(new string[] { "Suite", "Doble", "Individual" });
        }

        private void CargarHabitacion(int habitacionId)
        {
            habitacionActual = habitacionService.ObtenerHabitacionPorId(habitacionId);
            if (habitacionActual != null)
            {
                cmbTipo.SelectedItem = habitacionActual.TipoHabitacion.Nombre;
                numCapacidad.Value = habitacionActual.Capacidad;
                txtPrecio.Text = habitacionActual.TipoHabitacion.PrecioBase.ToString("F2");
                chkDisponible.Checked = habitacionActual.Disponible;
                dtpInicio.Value = habitacionActual.FechaInicio;
                dtpFin.Value = habitacionActual.FechaFin;
            }
            else
            {
                MessageBox.Show("No se encontró la habitación.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cmbTipo.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un tipo de habitación.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var tipoHabitacion = habitacionService.ObtenerTipoHabitacionPorNombre(cmbTipo.SelectedItem.ToString());
            if (tipoHabitacion == null)
            {
                MessageBox.Show("Tipo de habitación no válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var nuevaHabitacion = new Habitacion
            {
                TipoId = tipoHabitacion.Id, // Asigna el ID correcto
                Capacidad = (int)numCapacidad.Value,
                Disponible = chkDisponible.Checked,
                FechaInicio = dtpInicio.Value,
                FechaFin = dtpFin.Value
                // Se pueden asignar otras propiedades como Número, etc.
            };
            habitacionService.AgregarHabitacion(nuevaHabitacion);
            MessageBox.Show("Habitación registrada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (habitacionActual == null)
            {
                MessageBox.Show("Seleccione una habitación para modificar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            bool resultado = habitacionService.ModificarHabitacion(habitacionActual.Id, cmbTipo.SelectedItem.ToString(), chkDisponible.Checked);
            MessageBox.Show(resultado ? "Habitación modificada correctamente." : "Error al modificar la habitación.");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (habitacionActual == null)
            {
                MessageBox.Show("Seleccione una habitación para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            bool resultado = habitacionService.EliminarHabitacion(habitacionActual.Id);
            MessageBox.Show(resultado ? "Habitación eliminada correctamente." : "No se puede eliminar esta habitación.");
        }
    }
}

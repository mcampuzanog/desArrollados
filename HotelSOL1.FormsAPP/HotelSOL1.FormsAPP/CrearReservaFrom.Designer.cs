namespace HotelSOL1.FormsAPP
{
    partial class CrearReservaForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblHabitaciones;
        private System.Windows.Forms.Label lblPersonas;
        private System.Windows.Forms.Label lblEntrada;
        private System.Windows.Forms.Label lblSalida;
        protected System.Windows.Forms.ComboBox cmbClientes;
        protected System.Windows.Forms.CheckedListBox clbHabitaciones;
        protected System.Windows.Forms.NumericUpDown numPersonas;
        protected System.Windows.Forms.DateTimePicker dtpEntrada;
        protected System.Windows.Forms.DateTimePicker dtpSalida;
        protected System.Windows.Forms.Button btnBuscarHabitaciones;
        protected System.Windows.Forms.Button btnSugerirCombinaciones;
        protected System.Windows.Forms.Button btnGuardarReserva;
        protected System.Windows.Forms.Button btnCancelar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            this.lblCliente = new System.Windows.Forms.Label();
            this.cmbClientes = new System.Windows.Forms.ComboBox();
            this.lblHabitaciones = new System.Windows.Forms.Label();
            this.clbHabitaciones = new System.Windows.Forms.CheckedListBox();
            this.lblPersonas = new System.Windows.Forms.Label();
            this.numPersonas = new System.Windows.Forms.NumericUpDown();
            this.btnBuscarHabitaciones = new System.Windows.Forms.Button();
            this.btnSugerirCombinaciones = new System.Windows.Forms.Button();
            this.lblEntrada = new System.Windows.Forms.Label();
            this.dtpEntrada = new System.Windows.Forms.DateTimePicker();
            this.lblSalida = new System.Windows.Forms.Label();
            this.dtpSalida = new System.Windows.Forms.DateTimePicker();
            this.btnGuardarReserva = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numPersonas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCliente
            // 
            this.lblCliente.Text = "Seleccione Cliente:";
            this.lblCliente.Location = new System.Drawing.Point(20, 20);
            // 
            // cmbClientes
            // 
            this.cmbClientes.Location = new System.Drawing.Point(150, 20);
            this.cmbClientes.Size = new System.Drawing.Size(200, 23);
            // 
            // lblHabitaciones
            // 
            this.lblHabitaciones.Text = "Habitaciones Disponibles:";
            this.lblHabitaciones.Location = new System.Drawing.Point(20, 60);
            // 
            // clbHabitaciones
            // 
            this.clbHabitaciones.Location = new System.Drawing.Point(150, 60);
            this.clbHabitaciones.Size = new System.Drawing.Size(250, 100);
            // 
            // lblPersonas
            // 
            this.lblPersonas.Text = "Cantidad de Personas:";
            this.lblPersonas.Location = new System.Drawing.Point(20, 180);
            // 
            // numPersonas
            // 
            this.numPersonas.Location = new System.Drawing.Point(150, 180);
            this.numPersonas.Size = new System.Drawing.Size(80, 23);
            this.numPersonas.Minimum = 1;
            this.numPersonas.Maximum = 10;
            // 
            // btnBuscarHabitaciones
            // 
            this.btnBuscarHabitaciones.Text = "Buscar Habitaciones";
            this.btnBuscarHabitaciones.Location = new System.Drawing.Point(250, 180);
            this.btnBuscarHabitaciones.Size = new System.Drawing.Size(150, 30);
            this.btnBuscarHabitaciones.Click += new System.EventHandler(this.btnBuscarHabitaciones_Click);
            // 
            // btnSugerirCombinaciones
            // 
            this.btnSugerirCombinaciones.Text = "Sugerir Combinación";
            this.btnSugerirCombinaciones.Location = new System.Drawing.Point(250, 220);
            this.btnSugerirCombinaciones.Size = new System.Drawing.Size(150, 30);
            this.btnSugerirCombinaciones.Click += new System.EventHandler(this.btnSugerirCombinaciones_Click);
            // 
            // lblEntrada
            // 
            this.lblEntrada.Text = "Fecha Entrada:";
            this.lblEntrada.Location = new System.Drawing.Point(20, 260);
            // 
            // dtpEntrada
            // 
            this.dtpEntrada.Location = new System.Drawing.Point(150, 260);
            this.dtpEntrada.Size = new System.Drawing.Size(200, 23);
            // 
            // lblSalida
            // 
            this.lblSalida.Text = "Fecha Salida:";
            this.lblSalida.Location = new System.Drawing.Point(20, 300);
            // 
            // dtpSalida
            // 
            this.dtpSalida.Location = new System.Drawing.Point(150, 300);
            this.dtpSalida.Size = new System.Drawing.Size(200, 23);
            // 
            // btnGuardarReserva
            // 
            this.btnGuardarReserva.Text = "Guardar Reserva";
            this.btnGuardarReserva.Location = new System.Drawing.Point(150, 350);
            this.btnGuardarReserva.Size = new System.Drawing.Size(150, 30);
            this.btnGuardarReserva.Click += new System.EventHandler(this.btnGuardarReserva_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Location = new System.Drawing.Point(320, 350);
            this.btnCancelar.Size = new System.Drawing.Size(150, 30);
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // CrearReservaForm
            // 
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.cmbClientes);
            this.Controls.Add(this.lblHabitaciones);
            this.Controls.Add(this.clbHabitaciones);
            this.Controls.Add(this.lblPersonas);
            this.Controls.Add(this.numPersonas);
            this.Controls.Add(this.btnBuscarHabitaciones);
            this.Controls.Add(this.btnSugerirCombinaciones);
            this.Controls.Add(this.lblEntrada);
            this.Controls.Add(this.dtpEntrada);
            this.Controls.Add(this.lblSalida);
            this.Controls.Add(this.dtpSalida);
            this.Controls.Add(this.btnGuardarReserva);
            this.Controls.Add(this.btnCancelar);
            this.Text = "Gestor de Reservas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.numPersonas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

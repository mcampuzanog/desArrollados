namespace HotelSOL1.FormsAPP
{
    partial class ExportarOdooForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            CheckBoxUsuarios = new CheckBox();
            CheckBoxFacturas = new CheckBox(); 
            CheckBoxClientes = new CheckBox();
            CheckBoxHabitaciones = new CheckBox();
            CheckBoxReservas = new CheckBox();
            CheckBoxServicios = new CheckBox();
            CheckBoxIncidencias = new CheckBox();
            textBox1 = new TextBox();
            btnExportar = new Button();
            CheckBoxReservasHabitaciones = new CheckBox();
            SuspendLayout();

            // 
            // CheckBoxUsuarios
            // 
            CheckBoxUsuarios.AutoSize = true;
            CheckBoxUsuarios.Location = new Point(76, 107);
            CheckBoxUsuarios.Name = "CheckBoxUsuarios";
            CheckBoxUsuarios.Size = new Size(87, 24);
            CheckBoxUsuarios.TabIndex = 0;
            CheckBoxUsuarios.Text = "Usuarios";
            CheckBoxUsuarios.UseVisualStyleBackColor = true;

            // 
            // CheckBoxClientes
            // 
            CheckBoxClientes.AutoSize = true;
            CheckBoxClientes.Location = new Point(76, 156);
            CheckBoxClientes.Name = "CheckBoxClientes";
            CheckBoxClientes.Size = new Size(83, 24);
            CheckBoxClientes.TabIndex = 2;
            CheckBoxClientes.Text = "Clientes";
            CheckBoxClientes.UseVisualStyleBackColor = true;

            // 
            // CheckBoxHabitaciones
            // 
            CheckBoxHabitaciones.AutoSize = true;
            CheckBoxHabitaciones.Location = new Point(76, 205);
            CheckBoxHabitaciones.Name = "CheckBoxHabitaciones";
            CheckBoxHabitaciones.Size = new Size(118, 24);
            CheckBoxHabitaciones.TabIndex = 3;
            CheckBoxHabitaciones.Text = "Habitaciones";
            CheckBoxHabitaciones.UseVisualStyleBackColor = true;

            // 
            // CheckBoxReservas
            // 
            CheckBoxReservas.AutoSize = true;
            CheckBoxReservas.Location = new Point(76, 254);
            CheckBoxReservas.Name = "CheckBoxReservas";
            CheckBoxReservas.Size = new Size(88, 24);
            CheckBoxReservas.TabIndex = 4;
            CheckBoxReservas.Text = "Reservas";
            CheckBoxReservas.UseVisualStyleBackColor = true;

            // 
            // CheckBoxServicios
            // 
            CheckBoxServicios.AutoSize = true;
            CheckBoxServicios.Location = new Point(76, 304);
            CheckBoxServicios.Name = "CheckBoxServicios";
            CheckBoxServicios.Size = new Size(89, 24);
            CheckBoxServicios.TabIndex = 5;
            CheckBoxServicios.Text = "Servicios";
            CheckBoxServicios.UseVisualStyleBackColor = true;

            // 
            // CheckBoxIncidencias
            // 
            CheckBoxIncidencias.AutoSize = true;
            CheckBoxIncidencias.Location = new Point(76, 354);
            CheckBoxIncidencias.Name = "CheckBoxIncidencias";
            CheckBoxIncidencias.Size = new Size(104, 24);
            CheckBoxIncidencias.TabIndex = 6;
            CheckBoxIncidencias.Text = "Incidencias";
            CheckBoxIncidencias.UseVisualStyleBackColor = true;
            CheckBoxIncidencias.CheckedChanged += this.CheckBoxIncidencias_CheckedChanged;

            // 
            // textBox1
            // 
            textBox1.Location = new Point(76, 58);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(258, 27);
            textBox1.TabIndex = 7;
            textBox1.Text = "Seleccione qué datos quiere exportar";

            // 
            // btnExportar
            // 
            btnExportar.Location = new Point(462, 224);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(223, 82);
            btnExportar.TabIndex = 8;
            btnExportar.Text = "Exportar a Odoo";
            btnExportar.UseVisualStyleBackColor = true;
            btnExportar.Click += btnExportar_Click;

            // 
            // CheckBoxReservasHabitaciones
            // 
            CheckBoxReservasHabitaciones.AutoSize = true;
            CheckBoxReservasHabitaciones.Location = new Point(76, 403);
            CheckBoxReservasHabitaciones.Name = "CheckBoxReservasHabitaciones";
            CheckBoxReservasHabitaciones.Size = new Size(211, 24);
            CheckBoxReservasHabitaciones.TabIndex = 9;
            CheckBoxReservasHabitaciones.Text = "Ocupación de habitaciones";
            CheckBoxReservasHabitaciones.UseVisualStyleBackColor = true;

            // 
            // CheckBoxFacturas 
            // 
            CheckBoxFacturas.AutoSize = true;
            CheckBoxFacturas.Location = new Point(76, 452);
            CheckBoxFacturas.Name = "CheckBoxFacturas";
            CheckBoxFacturas.Size = new Size(87, 24);
            CheckBoxFacturas.TabIndex = 1;
            CheckBoxFacturas.Text = "Facturas";
            CheckBoxFacturas.UseVisualStyleBackColor = true;

            // 
            // ExportarOdooForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(822, 552);
            Controls.Add(btnExportar);
            Controls.Add(textBox1);
            Controls.Add(CheckBoxReservasHabitaciones);
            Controls.Add(CheckBoxIncidencias);
            Controls.Add(CheckBoxServicios);
            Controls.Add(CheckBoxReservas);
            Controls.Add(CheckBoxHabitaciones);
            Controls.Add(CheckBoxClientes);
            Controls.Add(CheckBoxFacturas); 
            Controls.Add(CheckBoxUsuarios);
            Name = "ExportarOdooForm";
            Text = "Exportar a Odoo";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox CheckBoxUsuarios;
        private CheckBox CheckBoxFacturas; 
        private CheckBox CheckBoxClientes;
        private CheckBox CheckBoxHabitaciones;
        private CheckBox CheckBoxReservas;
        private CheckBox CheckBoxServicios;
        private CheckBox CheckBoxIncidencias;
        private TextBox textBox1;
        private Button btnExportar;
        private CheckBox CheckBoxReservasHabitaciones;
    }
}

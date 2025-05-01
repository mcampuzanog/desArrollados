namespace HotelSOL1.FormsAPP
{
    partial class CrearReservaForm
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

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            this.lblCliente = new System.Windows.Forms.Label();
            this.cmbClientes = new System.Windows.Forms.ComboBox();
            this.lblHabitacion = new System.Windows.Forms.Label();
            this.cmbHabitaciones = new System.Windows.Forms.ComboBox();
            this.lblEntrada = new System.Windows.Forms.Label();
            this.dtpEntrada = new System.Windows.Forms.DateTimePicker();
            this.lblSalida = new System.Windows.Forms.Label();
            this.dtpSalida = new System.Windows.Forms.DateTimePicker();
            this.btnGuardarReserva = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(60, 30);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(45, 15);
            this.lblCliente.TabIndex = 0;
            this.lblCliente.Text = "Cliente:";
            // 
            // cmbClientes
            // 
            this.cmbClientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClientes.FormattingEnabled = true;
            this.cmbClientes.Location = new System.Drawing.Point(140, 27);
            this.cmbClientes.Name = "cmbClientes";
            this.cmbClientes.Size = new System.Drawing.Size(200, 23);
            this.cmbClientes.TabIndex = 1;
            // 
            // lblHabitacion
            // 
            this.lblHabitacion.AutoSize = true;
            this.lblHabitacion.Location = new System.Drawing.Point(60, 70);
            this.lblHabitacion.Name = "lblHabitacion";
            this.lblHabitacion.Size = new System.Drawing.Size(66, 15);
            this.lblHabitacion.TabIndex = 2;
            this.lblHabitacion.Text = "Habitación:";
            // 
            // cmbHabitaciones
            // 
            this.cmbHabitaciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHabitaciones.FormattingEnabled = true;
            this.cmbHabitaciones.Location = new System.Drawing.Point(140, 67);
            this.cmbHabitaciones.Name = "cmbHabitaciones";
            this.cmbHabitaciones.Size = new System.Drawing.Size(200, 23);
            this.cmbHabitaciones.TabIndex = 3;
            // 
            // lblEntrada
            // 
            this.lblEntrada.AutoSize = true;
            this.lblEntrada.Location = new System.Drawing.Point(60, 110);
            this.lblEntrada.Name = "lblEntrada";
            this.lblEntrada.Size = new System.Drawing.Size(48, 15);
            this.lblEntrada.TabIndex = 4;
            this.lblEntrada.Text = "Entrada:";
            // 
            // dtpEntrada
            // 
            this.dtpEntrada.Location = new System.Drawing.Point(140, 106);
            this.dtpEntrada.Name = "dtpEntrada";
            this.dtpEntrada.Size = new System.Drawing.Size(200, 23);
            this.dtpEntrada.TabIndex = 5;
            // 
            // lblSalida
            // 
            this.lblSalida.AutoSize = true;
            this.lblSalida.Location = new System.Drawing.Point(60, 150);
            this.lblSalida.Name = "lblSalida";
            this.lblSalida.Size = new System.Drawing.Size(41, 15);
            this.lblSalida.TabIndex = 6;
            this.lblSalida.Text = "Salida:";
            // 
            // dtpSalida
            // 
            this.dtpSalida.Location = new System.Drawing.Point(140, 146);
            this.dtpSalida.Name = "dtpSalida";
            this.dtpSalida.Size = new System.Drawing.Size(200, 23);
            this.dtpSalida.TabIndex = 7;
            // 
            // btnGuardarReserva
            // 
            this.btnGuardarReserva.Location = new System.Drawing.Point(60, 200);
            this.btnGuardarReserva.Name = "btnGuardarReserva";
            this.btnGuardarReserva.Size = new System.Drawing.Size(120, 30);
            this.btnGuardarReserva.TabIndex = 8;
            this.btnGuardarReserva.Text = "Guardar reserva";
            this.btnGuardarReserva.UseVisualStyleBackColor = true;
            this.btnGuardarReserva.Click += new System.EventHandler(this.btnGuardarReserva_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(220, 200);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(120, 30);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // CrearReservaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 270);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardarReserva);
            this.Controls.Add(this.dtpSalida);
            this.Controls.Add(this.lblSalida);
            this.Controls.Add(this.dtpEntrada);
            this.Controls.Add(this.lblEntrada);
            this.Controls.Add(this.cmbHabitaciones);
            this.Controls.Add(this.lblHabitacion);
            this.Controls.Add(this.cmbClientes);
            this.Controls.Add(this.lblCliente);
            this.Name = "CrearReservaForm";
            this.Text = "Crear Reserva";
            this.Load += new System.EventHandler(this.CrearReservaForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.ComboBox cmbClientes;
        private System.Windows.Forms.Label lblHabitacion;
        private System.Windows.Forms.ComboBox cmbHabitaciones;
        private System.Windows.Forms.Label lblEntrada;
        private System.Windows.Forms.DateTimePicker dtpEntrada;
        private System.Windows.Forms.Label lblSalida;
        private System.Windows.Forms.DateTimePicker dtpSalida;
        private System.Windows.Forms.Button btnGuardarReserva;
        private System.Windows.Forms.Button btnCancelar;
    }
}

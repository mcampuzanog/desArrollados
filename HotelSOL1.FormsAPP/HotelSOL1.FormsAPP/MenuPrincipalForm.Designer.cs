namespace HotelSOL1.FormsAPP
{
    partial class MenuPrincipalForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button btnRegistrarUsuario;
        private System.Windows.Forms.Button btnExportarOdoo;
        private System.Windows.Forms.Button btnRegistrarCliente;
        private System.Windows.Forms.Button btnCrearReserva;
        private System.Windows.Forms.Button btnGenerarFactura;
        private System.Windows.Forms.Button btnVerReservas;
        private System.Windows.Forms.Button btnSalir;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblUsuario = new Label();
            btnRegistrarUsuario = new Button();
            btnRegistrarCliente = new Button();
            btnCrearReserva = new Button();
            btnGenerarFactura = new Button();
            btnVerReservas = new Button();
            btnExportarOdoo = new Button();
            btnSalir = new Button();
            btnHabitaciones = new Button();
            btnPago = new Button();
            SuspendLayout();
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Arial", 12F, FontStyle.Bold);
            lblUsuario.Location = new Point(20, 20);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(200, 24);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "Bienvenido, Usuario";
            // 
            // btnRegistrarUsuario
            // 
            btnRegistrarUsuario.Location = new Point(51, 77);
            btnRegistrarUsuario.Name = "btnRegistrarUsuario";
            btnRegistrarUsuario.Size = new Size(220, 50);
            btnRegistrarUsuario.TabIndex = 1;
            btnRegistrarUsuario.Text = "👤 Registrar Usuario";
            btnRegistrarUsuario.Click += btnRegistrarUsuario_Click;
            // 
            // btnRegistrarCliente
            // 
            btnRegistrarCliente.Location = new Point(436, 77);
            btnRegistrarCliente.Name = "btnRegistrarCliente";
            btnRegistrarCliente.Size = new Size(220, 50);
            btnRegistrarCliente.TabIndex = 2;
            btnRegistrarCliente.Text = "\U0001f9d1‍\U0001f91d‍\U0001f9d1 Registrar Cliente";
            btnRegistrarCliente.Click += btnRegistrarCliente_Click;
            // 
            // btnCrearReserva
            // 
            btnCrearReserva.Location = new Point(51, 166);
            btnCrearReserva.Name = "btnCrearReserva";
            btnCrearReserva.Size = new Size(220, 50);
            btnCrearReserva.TabIndex = 3;
            btnCrearReserva.Text = "🛏️ Crear Reserva";
            btnCrearReserva.Click += btnCrearReserva_Click;
            // 
            // btnGenerarFactura
            // 
            btnGenerarFactura.Location = new Point(436, 166);
            btnGenerarFactura.Name = "btnGenerarFactura";
            btnGenerarFactura.Size = new Size(220, 50);
            btnGenerarFactura.TabIndex = 4;
            btnGenerarFactura.Text = "📑 Generar Factura";
            btnGenerarFactura.Click += btnGenerarFactura_Click;
            // 
            // btnVerReservas
            // 
            btnVerReservas.Location = new Point(51, 258);
            btnVerReservas.Name = "btnVerReservas";
            btnVerReservas.Size = new Size(220, 50);
            btnVerReservas.TabIndex = 5;
            btnVerReservas.Text = "📋 Ver Reservas";
            btnVerReservas.Click += btnVerReservas_Click;
            // 
            // btnExportarOdoo
            // 
            btnExportarOdoo.Location = new Point(436, 258);
            btnExportarOdoo.Name = "btnExportarOdoo";
            btnExportarOdoo.Size = new Size(220, 50);
            btnExportarOdoo.TabIndex = 6;
            btnExportarOdoo.Text = "📤 Exportar datos a Odoo";
            btnExportarOdoo.Click += btnExportarOdoo_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(243, 498);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(220, 50);
            btnSalir.TabIndex = 7;
            btnSalir.Text = "❌ Salir";
            btnSalir.Click += btnSalir_Click;
            // 
            // btnHabitaciones
            // 
            btnHabitaciones.Location = new Point(51, 343);
            btnHabitaciones.Name = "btnHabitaciones";
            btnHabitaciones.Size = new Size(220, 50);
            btnHabitaciones.TabIndex = 8;
            btnHabitaciones.Text = "🛏️ Ver Habitaciones";
            // 
            // btnPago
            // 
            btnPago.Location = new Point(436, 343);
            btnPago.Name = "btnPago";
            btnPago.Size = new Size(220, 50);
            btnPago.TabIndex = 9;
            btnPago.Text = "Pago Estancia";
            // 
            // MenuPrincipalForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(729, 600);
            Controls.Add(btnPago);
            Controls.Add(btnHabitaciones);
            Controls.Add(lblUsuario);
            Controls.Add(btnRegistrarUsuario);
            Controls.Add(btnRegistrarCliente);
            Controls.Add(btnCrearReserva);
            Controls.Add(btnGenerarFactura);
            Controls.Add(btnVerReservas);
            Controls.Add(btnExportarOdoo);
            Controls.Add(btnSalir);
            Name = "MenuPrincipalForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "🏨 HotelSOL - Menú Principal";
            Load += MenuPrincipalForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnHabitaciones;
        private Button btnPago;
    }
}

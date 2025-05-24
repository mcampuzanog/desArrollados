namespace HotelSOL1.FormsAPP
{
    partial class MenuPrincipalForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblUsuario;
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
            btnRegistrarCliente = new Button();
            btnCrearReserva = new Button();
            btnGenerarFactura = new Button();
            btnVerReservas = new Button();
            btnExportarOdoo = new Button();
            btnSalir = new Button();
            btnHabitaciones = new Button();
            btnPago = new Button();
            btnContabilidad = new Button();
            btnProveedorStock = new Button();
            btnRegistrarUsuario = new Button();
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
            // btnRegistrarCliente
            // 
            btnRegistrarCliente.BackColor = SystemColors.GradientActiveCaption;
            btnRegistrarCliente.ForeColor = SystemColors.MenuHighlight;
            btnRegistrarCliente.Location = new Point(436, 77);
            btnRegistrarCliente.Name = "btnRegistrarCliente";
            btnRegistrarCliente.Size = new Size(220, 50);
            btnRegistrarCliente.TabIndex = 2;
            btnRegistrarCliente.Text = "\U0001f9d1‍\U0001f91d‍\U0001f9d1 Registrar Cliente";
            btnRegistrarCliente.UseVisualStyleBackColor = false;
            btnRegistrarCliente.Click += btnRegistrarCliente_Click;
            // 
            // btnCrearReserva
            // 
            btnCrearReserva.BackColor = SystemColors.GradientActiveCaption;
            btnCrearReserva.ForeColor = SystemColors.MenuHighlight;
            btnCrearReserva.Location = new Point(51, 166);
            btnCrearReserva.Name = "btnCrearReserva";
            btnCrearReserva.Size = new Size(220, 50);
            btnCrearReserva.TabIndex = 3;
            btnCrearReserva.Text = "🛏️ Crear Reserva";
            btnCrearReserva.UseVisualStyleBackColor = false;
            btnCrearReserva.Click += btnCrearReserva_Click;
            // 
            // btnGenerarFactura
            // 
            btnGenerarFactura.BackColor = SystemColors.GradientActiveCaption;
            btnGenerarFactura.ForeColor = SystemColors.MenuHighlight;
            btnGenerarFactura.Location = new Point(436, 166);
            btnGenerarFactura.Name = "btnGenerarFactura";
            btnGenerarFactura.Size = new Size(220, 50);
            btnGenerarFactura.TabIndex = 4;
            btnGenerarFactura.Text = "📑 Generar Factura";
            btnGenerarFactura.UseVisualStyleBackColor = false;
            btnGenerarFactura.Click += btnGenerarFactura_Click;
            // 
            // btnVerReservas
            // 
            btnVerReservas.BackColor = SystemColors.GradientActiveCaption;
            btnVerReservas.ForeColor = SystemColors.MenuHighlight;
            btnVerReservas.Location = new Point(51, 258);
            btnVerReservas.Name = "btnVerReservas";
            btnVerReservas.Size = new Size(220, 50);
            btnVerReservas.TabIndex = 5;
            btnVerReservas.Text = "📋 Ver Reservas";
            btnVerReservas.UseVisualStyleBackColor = false;
            btnVerReservas.Click += btnVerReservas_Click;
            // 
            // btnExportarOdoo
            // 
            btnExportarOdoo.BackColor = SystemColors.GradientActiveCaption;
            btnExportarOdoo.ForeColor = SystemColors.MenuHighlight;
            btnExportarOdoo.Location = new Point(436, 258);
            btnExportarOdoo.Name = "btnExportarOdoo";
            btnExportarOdoo.Size = new Size(220, 50);
            btnExportarOdoo.TabIndex = 6;
            btnExportarOdoo.Text = "📤 Exportar datos a Odoo";
            btnExportarOdoo.UseVisualStyleBackColor = false;
            btnExportarOdoo.Click += btnExportarOdoo_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(244, 525);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(220, 50);
            btnSalir.TabIndex = 7;
            btnSalir.Text = "❌ Salir";
            btnSalir.Click += btnSalir_Click;
            // 
            // btnHabitaciones
            // 
            btnHabitaciones.BackColor = SystemColors.GradientActiveCaption;
            btnHabitaciones.ForeColor = SystemColors.MenuHighlight;
            btnHabitaciones.Location = new Point(51, 343);
            btnHabitaciones.Name = "btnHabitaciones";
            btnHabitaciones.Size = new Size(220, 50);
            btnHabitaciones.TabIndex = 8;
            btnHabitaciones.Text = "🛏️ Ver Habitaciones";
            btnHabitaciones.UseVisualStyleBackColor = false;
            // 
            // btnPago
            // 
            btnPago.BackColor = SystemColors.GradientActiveCaption;
            btnPago.ForeColor = SystemColors.MenuHighlight;
            btnPago.Location = new Point(436, 343);
            btnPago.Name = "btnPago";
            btnPago.Size = new Size(220, 50);
            btnPago.TabIndex = 9;
            btnPago.Text = "💳Pago Estancia";
            btnPago.UseVisualStyleBackColor = false;
            btnPago.Click += btnPago_Click;
            // 
            // btnContabilidad
            // 
            btnContabilidad.BackColor = SystemColors.GradientActiveCaption;
            btnContabilidad.ForeColor = SystemColors.MenuHighlight;
            btnContabilidad.Location = new Point(51, 430);
            btnContabilidad.Name = "btnContabilidad";
            btnContabilidad.Size = new Size(220, 50);
            btnContabilidad.TabIndex = 10;
            btnContabilidad.Text = "\U0001f9eeContabilidad";
            btnContabilidad.UseVisualStyleBackColor = false;
            btnContabilidad.Click += button1_Click;
            // 
            // btnProveedorStock
            // 
            btnProveedorStock.BackColor = SystemColors.GradientActiveCaption;
            btnProveedorStock.ForeColor = SystemColors.MenuHighlight;
            btnProveedorStock.Location = new Point(436, 430);
            btnProveedorStock.Name = "btnProveedorStock";
            btnProveedorStock.Size = new Size(220, 50);
            btnProveedorStock.TabIndex = 11;
            btnProveedorStock.Text = "📦Proveedores y Stock";
            btnProveedorStock.UseVisualStyleBackColor = false;
            btnProveedorStock.Click += btnStock_Click;
            // 
            // btnRegistrarUsuario
            // 
            btnRegistrarUsuario.BackColor = SystemColors.GradientActiveCaption;
            btnRegistrarUsuario.ForeColor = SystemColors.MenuHighlight;
            btnRegistrarUsuario.Location = new Point(51, 77);
            btnRegistrarUsuario.Name = "btnRegistrarUsuario";
            btnRegistrarUsuario.Size = new Size(220, 50);
            btnRegistrarUsuario.TabIndex = 1;
            btnRegistrarUsuario.Text = "👤 Registrar Usuario";
            btnRegistrarUsuario.UseVisualStyleBackColor = false;
            btnRegistrarUsuario.Click += btnRegistrarUsuario_Click;
            // 
            // MenuPrincipalForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.LogoHotelSOL;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(746, 631);
            Controls.Add(btnProveedorStock);
            Controls.Add(btnContabilidad);
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
            DoubleBuffered = true;
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
        private Button btnContabilidad;
        private Button btnProveedorStock;
        private Button btnRegistrarUsuario;
    }
}

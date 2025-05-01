namespace HotelSOL1.FormsAPP
{
    partial class MenuPrincipalForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private Button btnRegistrarCliente;
        private Button btnCrearReserva;
        private Button btnGenerarFactura;
        private Button btnVerReservas;
        private Button btnSalir;

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
            this.btnRegistrarCliente = new Button();
            this.btnCrearReserva = new Button();
            this.btnGenerarFactura = new Button();
            this.btnVerReservas = new Button();
            this.btnSalir = new Button();
            this.SuspendLayout();

            // 
            // btnRegistrarCliente
            // 
            this.btnRegistrarCliente.Location = new Point(100, 40);
            this.btnRegistrarCliente.Size = new Size(200, 40);
            this.btnRegistrarCliente.Text = "🧍‍♂️ Registrar cliente";
            this.btnRegistrarCliente.Click += new EventHandler(this.btnRegistrarCliente_Click);

            // 
            // btnCrearReserva
            // 
            this.btnCrearReserva.Location = new Point(100, 90);
            this.btnCrearReserva.Size = new Size(200, 40);
            this.btnCrearReserva.Text = "🛏️ Crear reserva";
            this.btnCrearReserva.Click += new EventHandler(this.btnCrearReserva_Click);

            // 
            // btnGenerarFactura
            // 
            this.btnGenerarFactura.Location = new Point(100, 140);
            this.btnGenerarFactura.Size = new Size(200, 40);
            this.btnGenerarFactura.Text = "🧾 Generar factura";
            this.btnGenerarFactura.Click += new EventHandler(this.btnGenerarFactura_Click);

            // 
            // btnVerReservas
            // 
            this.btnVerReservas.Location = new Point(100, 190);
            this.btnVerReservas.Size = new Size(200, 40);
            this.btnVerReservas.Text = "📋 Ver reservas";
            this.btnVerReservas.Click += new EventHandler(this.btnVerReservas_Click);

            // 
            // btnSalir
            // 
            this.btnSalir.Location = new Point(100, 240);
            this.btnSalir.Size = new Size(200, 40);
            this.btnSalir.Text = "❌ Salir";
            this.btnSalir.Click += new EventHandler(this.btnSalir_Click);

            // 
            // MenuPrincipalForm
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(400, 330);
            this.Controls.Add(this.btnRegistrarCliente);
            this.Controls.Add(this.btnCrearReserva);
            this.Controls.Add(this.btnGenerarFactura);
            this.Controls.Add(this.btnVerReservas);
            this.Controls.Add(this.btnSalir);
            this.Name = "MenuPrincipalForm";
            this.Text = "🏨 HotelSOL - Menú Principal";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
        }

        #endregion
    }
}

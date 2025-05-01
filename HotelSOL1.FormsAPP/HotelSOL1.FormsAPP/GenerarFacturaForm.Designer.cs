namespace HotelSOL1.FormsAPP
{
    partial class GenerarFacturaForm
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblCliente;
        private Label lblFechaEntrada;
        private Label lblFechaSalida;
        private Label lblMonto;
        private Button btnGenerarFactura;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblCliente = new Label();
            lblFechaEntrada = new Label();
            lblFechaSalida = new Label();
            lblMonto = new Label();
            btnGenerarFactura = new Button();
            SuspendLayout();

            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(30, 30);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(150, 25);
            lblCliente.TabIndex = 0;
            lblCliente.Text = "Cliente: (Nombre)";
            lblCliente.Click += new System.EventHandler(this.lblCliente_Click);

            // 
            // lblFechaEntrada
            // 
            lblFechaEntrada.AutoSize = true;
            lblFechaEntrada.Location = new Point(30, 60);
            lblFechaEntrada.Name = "lblFechaEntrada";
            lblFechaEntrada.Size = new Size(245, 25);
            lblFechaEntrada.TabIndex = 1;
            lblFechaEntrada.Text = "Fecha Entrada: (dd/mm/yyyy)";
            lblFechaEntrada.Click += new System.EventHandler(this.lblFechaEntrada_Click);

            // 
            // lblFechaSalida
            // 
            lblFechaSalida.AutoSize = true;
            lblFechaSalida.Location = new Point(30, 90);
            lblFechaSalida.Name = "lblFechaSalida";
            lblFechaSalida.Size = new Size(232, 25);
            lblFechaSalida.TabIndex = 2;
            lblFechaSalida.Text = "Fecha Salida: (dd/mm/yyyy)";
            lblFechaSalida.Click += new System.EventHandler(this.lblFechaSalida_Click);

            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Location = new Point(30, 120);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(127, 25);
            lblMonto.TabIndex = 3;
            lblMonto.Text = "Monto Total: $";

            // 
            // btnGenerarFactura
            // 
            btnGenerarFactura.Location = new Point(30, 160);
            btnGenerarFactura.Name = "btnGenerarFactura";
            btnGenerarFactura.Size = new Size(150, 30);
            btnGenerarFactura.TabIndex = 4;
            btnGenerarFactura.Text = "Generar Factura";
            btnGenerarFactura.UseVisualStyleBackColor = true;
            btnGenerarFactura.Click += new System.EventHandler(this.btnGenerarFactura_Click);

            // 
            // GenerarFacturaForm
            // 
            ClientSize = new Size(300, 220);
            Controls.Add(btnGenerarFactura);
            Controls.Add(lblMonto);
            Controls.Add(lblFechaSalida);
            Controls.Add(lblFechaEntrada);
            Controls.Add(lblCliente);
            Name = "GenerarFacturaForm";
            Text = "Generar Factura";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}

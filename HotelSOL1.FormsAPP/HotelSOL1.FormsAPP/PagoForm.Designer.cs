namespace HotelSOL1.FormsAPP
{
    partial class PagoForm
    {
        private System.Windows.Forms.DataGridView dgvPagos;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.ComboBox cmbMetodoPago;
        private System.Windows.Forms.Button btnRegistrarPago;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Label lblMetodoPago;

        private void InitializeComponent()
        {
            this.dgvPagos = new System.Windows.Forms.DataGridView();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.cmbMetodoPago = new System.Windows.Forms.ComboBox();
            this.btnRegistrarPago = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblMonto = new System.Windows.Forms.Label();
            this.lblMetodoPago = new System.Windows.Forms.Label();

            // Configuración de controles
            this.dgvPagos.Location = new System.Drawing.Point(20, 20);
            this.dgvPagos.Size = new System.Drawing.Size(500, 200);
            this.dgvPagos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            this.lblMonto.Text = "Monto:";
            this.lblMonto.Location = new System.Drawing.Point(20, 240);

            this.txtMonto.Location = new System.Drawing.Point(80, 240);
            this.txtMonto.Size = new System.Drawing.Size(100, 22);

            this.lblMetodoPago.Text = "Método:";
            this.lblMetodoPago.Location = new System.Drawing.Point(200, 240);

            this.cmbMetodoPago.Location = new System.Drawing.Point(270, 240);
            this.cmbMetodoPago.Size = new System.Drawing.Size(120, 22);
            this.cmbMetodoPago.Items.AddRange(new string[] { "Tarjeta", "Efectivo", "Transferencia" });

            this.btnRegistrarPago.Text = "Registrar Pago";
            this.btnRegistrarPago.Location = new System.Drawing.Point(420, 240);
            this.btnRegistrarPago.Click += new System.EventHandler(this.btnRegistrarPago_Click);

            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.Location = new System.Drawing.Point(420, 280);
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);

            this.ClientSize = new System.Drawing.Size(550, 320);
            this.Controls.Add(this.dgvPagos);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.lblMetodoPago);
            this.Controls.Add(this.cmbMetodoPago);
            this.Controls.Add(this.btnRegistrarPago);
            this.Controls.Add(this.btnCerrar);
        }
    }
}

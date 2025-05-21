namespace HotelSOL1.FormsAPP
{
    partial class GenerarFacturaForm
    {
        private System.Windows.Forms.DataGridView dgvFacturas;
        private System.Windows.Forms.Button btnGenerarFactura;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.TextBox txtReservaId;
        private System.Windows.Forms.Label lblReservaId;
        private System.Windows.Forms.Button btnCerrar;

        private void InitializeComponent()
        {
            this.dgvFacturas = new System.Windows.Forms.DataGridView();
            this.btnGenerarFactura = new System.Windows.Forms.Button();
            this.lblMonto = new System.Windows.Forms.Label();
            this.txtReservaId = new System.Windows.Forms.TextBox();
            this.lblReservaId = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();

            // 
            // dgvFacturas
            // 
            this.dgvFacturas.Location = new System.Drawing.Point(20, 20);
            this.dgvFacturas.Size = new System.Drawing.Size(500, 200);
            this.dgvFacturas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            // 
            // lblReservaId
            // 
            this.lblReservaId.Text = "ID de Reserva:";
            this.lblReservaId.Location = new System.Drawing.Point(20, 240);

            // 
            // txtReservaId
            // 
            this.txtReservaId.Location = new System.Drawing.Point(120, 240);
            this.txtReservaId.Size = new System.Drawing.Size(100, 22);

            // 
            // btnGenerarFactura
            // 
            this.btnGenerarFactura.Text = "Generar Factura";
            this.btnGenerarFactura.Location = new System.Drawing.Point(250, 240);
            this.btnGenerarFactura.Click += new System.EventHandler(this.btnGenerarFactura_Click);

            // 
            // lblMonto
            // 
            this.lblMonto.Text = "Monto Total: $0.00";
            this.lblMonto.Location = new System.Drawing.Point(20, 280);
            this.lblMonto.AutoSize = true;

            // 
            // btnCerrar
            // 
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.Location = new System.Drawing.Point(420, 240);
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);

            // 
            // GenerarFacturaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 320);
            this.Controls.Add(this.dgvFacturas);
            this.Controls.Add(this.lblReservaId);
            this.Controls.Add(this.txtReservaId);
            this.Controls.Add(this.btnGenerarFactura);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.btnCerrar);
            this.Text = "Generar Factura";
        }
    }
}


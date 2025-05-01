namespace HotelSOL1.FormsAPP
{
    partial class VerReservasForm
    {
        private System.ComponentModel.IContainer components = null;

        private DataGridView dgvReservas;
        private Button btnVerDetalles;

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
            this.dgvReservas = new DataGridView();
            this.btnVerDetalles = new Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).BeginInit();
            this.SuspendLayout();

            // dgvReservas
            this.dgvReservas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservas.Location = new Point(30, 30);
            this.dgvReservas.Name = "dgvReservas";
            this.dgvReservas.Size = new Size(500, 250);
            this.dgvReservas.TabIndex = 0;

            // btnVerDetalles
            this.btnVerDetalles.Location = new Point(30, 300);
            this.btnVerDetalles.Name = "btnVerDetalles";
            this.btnVerDetalles.Size = new Size(100, 30);
            this.btnVerDetalles.TabIndex = 1;
            this.btnVerDetalles.Text = "Ver Detalles";
            this.btnVerDetalles.UseVisualStyleBackColor = true;
            this.btnVerDetalles.Click += new System.EventHandler(this.btnVerDetalles_Click);

            // VerReservasForm
            this.ClientSize = new Size(600, 350);
            this.Controls.Add(this.btnVerDetalles);
            this.Controls.Add(this.dgvReservas);
            this.Name = "VerReservasForm";
            this.Text = "Ver Reservas";
            this.Load += new EventHandler(this.VerReservasForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).EndInit();
            this.ResumeLayout(false);
        }
    }
}

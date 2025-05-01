namespace HotelSOL1.FormsAPP
{
    partial class RegistrarClienteForm
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblNombre;
        private TextBox txtNombre;
        private Label lblApellido;
        private TextBox txtApellido;
        private Label lblDNI;
        private TextBox txtDNI;
        private Label lblDireccion;
        private TextBox txtDireccion;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblTelefono;
        private TextBox txtTelefono;
        private CheckBox chkVIP;
        private Button btnGuardar;
        private Button btnCancelar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblNombre = new Label();
            this.txtNombre = new TextBox();
            this.lblApellido = new Label();
            this.txtApellido = new TextBox();
            this.lblDNI = new Label();
            this.txtDNI = new TextBox();
            this.lblDireccion = new Label();
            this.txtDireccion = new TextBox();
            this.lblEmail = new Label();
            this.txtEmail = new TextBox();
            this.lblTelefono = new Label();
            this.txtTelefono = new TextBox();
            this.chkVIP = new CheckBox();
            this.btnGuardar = new Button();
            this.btnCancelar = new Button();
            this.SuspendLayout();

            // lblNombre
            lblNombre.Text = "Nombre:";
            lblNombre.Location = new Point(30, 20);
            txtNombre.Location = new Point(130, 20);

            // lblApellido
            lblApellido.Text = "Apellido:";
            lblApellido.Location = new Point(30, 60);
            txtApellido.Location = new Point(130, 60);

            // lblDNI
            lblDNI.Text = "DNI:";
            lblDNI.Location = new Point(30, 100);
            txtDNI.Location = new Point(130, 100);

            // lblDireccion
            lblDireccion.Text = "Dirección:";
            lblDireccion.Location = new Point(30, 140);
            txtDireccion.Location = new Point(130, 140);

            // lblEmail
            lblEmail.Text = "Email:";
            lblEmail.Location = new Point(30, 180);
            txtEmail.Location = new Point(130, 180);

            // lblTelefono
            lblTelefono.Text = "Teléfono:";
            lblTelefono.Location = new Point(30, 220);
            txtTelefono.Location = new Point(130, 220);

            // chkVIP
            chkVIP.Text = "¿Cliente VIP?";
            chkVIP.Location = new Point(130, 260);

            // btnGuardar
            btnGuardar.Text = "Guardar";
            btnGuardar.Location = new Point(50, 300);
            btnGuardar.Click += new EventHandler(this.btnGuardar_Click);

            // btnCancelar
            btnCancelar.Text = "Cancelar";
            btnCancelar.Location = new Point(180, 300);
            btnCancelar.Click += new EventHandler(this.btnCancelar_Click);

            // RegistrarClienteForm
            this.ClientSize = new Size(350, 370);
            this.Controls.AddRange(new Control[] {
                lblNombre, txtNombre,
                lblApellido, txtApellido,
                lblDNI, txtDNI,
                lblDireccion, txtDireccion,
                lblEmail, txtEmail,
                lblTelefono, txtTelefono,
                chkVIP,
                btnGuardar, btnCancelar
            });
            this.Text = "Registrar Cliente";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

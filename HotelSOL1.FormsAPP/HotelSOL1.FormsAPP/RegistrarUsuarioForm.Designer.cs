namespace HotelSOL1.FormsAPP
{
    partial class RegistrarUsuarioForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.ComboBox cmbRol;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.lblRol = new System.Windows.Forms.Label();
            this.cmbRol = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // lblNombre
            this.lblNombre.Text = "Nombre:";
            this.lblNombre.Location = new System.Drawing.Point(30, 20);
            this.Controls.Add(this.lblNombre);
            this.txtNombre.Location = new System.Drawing.Point(130, 20);
            this.Controls.Add(this.txtNombre);

            // lblEmail
            this.lblEmail.Text = "Email:";
            this.lblEmail.Location = new System.Drawing.Point(30, 60);
            this.Controls.Add(this.lblEmail);
            this.txtEmail.Location = new System.Drawing.Point(130, 60);
            this.Controls.Add(this.txtEmail);

            // lblContraseña
            this.lblContraseña.Text = "Contraseña:";
            this.lblContraseña.Location = new System.Drawing.Point(30, 100);
            this.Controls.Add(this.lblContraseña);
            this.txtContraseña.Location = new System.Drawing.Point(130, 100);
            this.txtContraseña.UseSystemPasswordChar = true;
            this.Controls.Add(this.txtContraseña);

            // lblRol
            this.lblRol.Text = "Rol:";
            this.lblRol.Location = new System.Drawing.Point(30, 140);
            this.Controls.Add(this.lblRol);
            this.cmbRol.Location = new System.Drawing.Point(130, 140);
            this.cmbRol.Size = new System.Drawing.Size(200, 23);
            this.cmbRol.Items.AddRange(new string[] { "Administrador", "Encargado", "Recepcionista", "Cliente", "Contable", "Personal Limpieza", "Personal Restauración", "Marketing y Publicidad" });
            this.Controls.Add(this.cmbRol);

            // btnGuardar
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Location = new System.Drawing.Point(50, 180);
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            this.Controls.Add(this.btnGuardar);

            // btnCancelar
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Location = new System.Drawing.Point(180, 180);
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            this.Controls.Add(this.btnCancelar);

            // RegistrarUsuarioForm
            this.ClientSize = new System.Drawing.Size(350, 250);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Usuario";
            this.ResumeLayout(false);
        }
    }
}

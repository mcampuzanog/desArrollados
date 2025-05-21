using HotelSOL.DataAccess.Models;
using HotelSOL.DataAccess.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelSOL1.FormsAPP
{
    public partial class RegistrarUsuarioForm : Form
    {
        private readonly UsuarioService usuarioService;

        public RegistrarUsuarioForm(UsuarioService usuarioService)
        {
            InitializeComponent();
            this.usuarioService = usuarioService;
            cmbRol.Items.AddRange(new string[] { "Administrador", "Encargado", "Recepcionista", "Cliente", "Contable", "Personal Limpieza", "Personal Restauración", "Marketing y Publicidad" });
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            string email = txtEmail.Text.Trim();
            string contraseña = txtContraseña.Text.Trim();
            string rol = cmbRol.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(contraseña) || string.IsNullOrWhiteSpace(rol))
            {
                MessageBox.Show("❌ Todos los campos son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var usuario = new Usuario
            {
                Nombre = nombre,
                Email = email,
                Contraseña = contraseña,
                Rol = rol
            };

            usuarioService.RegistrarUsuario(usuario);
            MessageBox.Show("✅ Usuario creado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close(); // 🔹 Cierra el formulario al hacer clic en "Cancelar"
        }


    }
}
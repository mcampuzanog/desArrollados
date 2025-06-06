﻿using HotelSOL.DataAccess.Models;
using HotelSOL.DataAccess.Service;
using HotelSOL.DataAccess.Services;
using HotelSOL1.FormsAPP;
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
    public partial class LoginForm : Form
    {
        private readonly UsuarioService usuarioService;
        public Usuario UsuarioAutenticado { get; private set; }

        public LoginForm()
        {
            InitializeComponent();
            usuarioService = new UsuarioService(Program.DbContext);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string contraseña = txtContraseña.Text.Trim();

            var usuario = usuarioService.AutenticarUsuario(email, contraseña);

            if (usuario != null)
            {
                UsuarioAutenticado = usuario;
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("No estás registrado. Se abrirá el formulario de registro.", "Registro");

                // 🔹 Aquí creamos una instancia válida de ClienteService
                var clienteService = new ClienteService(Program.DbContext);

                // 🔹 Ahora pasamos clienteService correctamente a RegistrarClienteForm
                var registroForm = new RegistrarClienteForm(clienteService);
                registroForm.ShowDialog();
            }
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            var clienteService = new ClienteService(Program.DbContext); // 🔹 Instancia válida de ClienteService
            var registroForm = new RegistrarClienteForm(clienteService);
            registroForm.ShowDialog();
        }




        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Cierra la aplicación si el usuario cancela el login
        }
    }
}

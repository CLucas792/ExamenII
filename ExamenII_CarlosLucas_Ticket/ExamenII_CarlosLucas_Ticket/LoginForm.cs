using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ExamenII_CarlosLucas_Ticket
{
    public partial class LoginForm : Syncfusion.Windows.Forms.Office2010Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Cancelarbutton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Aceptarbutton_Click(object sender, EventArgs e)
        {
            if (CodigoUsuariotextBox.Text == string.Empty)
            {
                errorProvider1.SetError(CodigoUsuariotextBox, "Ingrese un usuario");
                return;
            }
            errorProvider1.Clear();

            if (ContraseñatextBox.Text == string.Empty)
            {
                errorProvider1.SetError(ContraseñatextBox, "Ingrese una contraseña");
                return;
            }
            errorProvider1.Clear();

            //Validar Usuario en la base de datos
            Login login = new Login(CodigoUsuariotextBox.Text, ContraseñatextBox.Text);
            UsuariosBD usuarioDB = new UsuariosBD();
            Usuario usuario = new Usuario();

            usuario = usuarioDB.Autenticar(login);

            //Si son correctos mandarlos al menu
            if (usuario != null)
            {

                //TEMPORAL
                if (usuario.Activo)
                {
                    System.Security.Principal.GenericIdentity identidad = new System.Security.Principal.GenericIdentity(usuario.IdUsuario);
                    System.Security.Principal.GenericPrincipal principal = new System.Security.Principal.GenericPrincipal(identidad, new string[] { usuario.Rol });
                    System.Threading.Thread.CurrentPrincipal = principal;

                    MenuForm menuFormulario = new MenuForm();
                    this.Hide();
                    menuFormulario.Show();
                }
                else
                {
                    MessageBox.Show("Usuario esta inactivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Datos de usuario incorrectos");
            }
        }
    }
}

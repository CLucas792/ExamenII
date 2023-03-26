using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ExamenII_CarlosLucas_Ticket
{
    public partial class UsuariosForm : Syncfusion.Windows.Forms.Office2010Form
    {
        string tipoOperacion;
        UsuariosBD usuariodb = new UsuariosBD();
        Usuario User = new Usuario();
        public UsuariosForm()
        {
            InitializeComponent();
        }

        private void Nuevobutton_Click(object sender, System.EventArgs e)
        {
            HabilitarControles();
            Guardarbutton.Enabled = true;
            tipoOperacion = "Nuevo";
            Nuevobutton.Enabled = false;
            Modificarbutton.Enabled = false;
            Eliminarbutton.Enabled = false;
        }

        private void HabilitarControles()
        {
            FechaNacimientodateTimePicker.Enabled = true;
            CodigotextBox.Enabled = true;
            NombretextBox.Enabled = true;
            ContraseñatextBox.Enabled = true;
            RolcomboBox.Enabled = true;
            ActivocheckBox.Enabled = true;
            Cancelarbutton.Enabled = true;
            Guardarbutton.Enabled = true;
        }

        private void DeshabilitarControles()
        {
            FechaNacimientodateTimePicker.Enabled = false;
            CodigotextBox.Enabled = false;
            NombretextBox.Enabled = false;
            ContraseñatextBox.Enabled = false;
            RolcomboBox.Enabled = false;
            ActivocheckBox.Enabled = false;
            Guardarbutton.Enabled = false;
        }



        private void LimpiarControles()
        {
            CodigotextBox.Clear();
            NombretextBox.Clear();
            ContraseñatextBox.Clear();
            RolcomboBox.Text = "";
            ActivocheckBox.Checked = false;
        }

        private void Guardarbutton_Click(object sender, System.EventArgs e)
        {
            if (tipoOperacion == "Nuevo")
            {
                if (string.IsNullOrEmpty(CodigotextBox.Text))
                {
                    errorProvider1.SetError(CodigotextBox, "Ingrese un codigo");
                    CodigotextBox.Focus();
                    return;
                }
                errorProvider1.Clear();

                if (string.IsNullOrEmpty(NombretextBox.Text))
                {
                    errorProvider1.SetError(NombretextBox, "Ingrese un nombre");
                    NombretextBox.Focus();
                    return;
                }
                errorProvider1.Clear();

                if (string.IsNullOrEmpty(ContraseñatextBox.Text))
                {
                    errorProvider1.SetError(ContraseñatextBox, "Ingrese una contraseña");
                    ContraseñatextBox.Focus();
                    return;
                }
                errorProvider1.Clear();
                if (string.IsNullOrEmpty(RolcomboBox.Text))
                {
                    errorProvider1.SetError(RolcomboBox, "Seleccione un rol");
                    RolcomboBox.Focus();
                    return;
                }
                errorProvider1.Clear();
                if (string.IsNullOrEmpty(FechaNacimientodateTimePicker.Text))
                {
                    errorProvider1.SetError(FechaNacimientodateTimePicker, "Seleccione una fecha");
                    RolcomboBox.Focus();
                    return;
                }
                errorProvider1.Clear();

                User.IdUsuario = CodigotextBox.Text;
                User.Nombre = NombretextBox.Text;
                User.Contraseña = ContraseñatextBox.Text;
                User.Rol = RolcomboBox.Text;
                User.Activo = ActivocheckBox.Checked;
                User.FechaNacimiento = FechaNacimientodateTimePicker.Value;


                // Insertar en la base de datos 

                bool inserto = usuariodb.Insertar(User);
                if (inserto)
                {
                    DeshabilitarControles();
                    LimpiarControles();
                    TraerUsuario();
                    MessageBox.Show("Registro guardad", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Eliminarbutton.Enabled = true;
                    Nuevobutton.Enabled = true;
                    Modificarbutton.Enabled = true;

                }
                else
                {
                    MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //

            }

            else if (tipoOperacion == "Modificar")
            {
                User.IdUsuario = CodigotextBox.Text;
                User.Nombre = NombretextBox.Text;
                User.Contraseña = ContraseñatextBox.Text;
                User.Rol = RolcomboBox.Text;
                User.Activo = ActivocheckBox.Checked;
                User.FechaNacimiento = FechaNacimientodateTimePicker.Value;


                bool edito = usuariodb.Editar(User);
                if (edito)
                {
                    LimpiarControles();
                    DeshabilitarControles();
                    TraerUsuario();
                    MessageBox.Show("Registro Actualizado");

                    Eliminarbutton.Enabled = true;
                    Nuevobutton.Enabled = true;
                    Modificarbutton.Enabled = true;
                }
                else
                {
                    MessageBox.Show("No se pudo actualiar");
                }
            }

        }


        private void TraerUsuario()
        {
            DataTable dt = new DataTable();
            dt = usuariodb.DevolverUsuario();
            UsuariodataGridView.DataSource = dt;
        }


        private void UsuariosForm_Load_1(object sender, EventArgs e)
        {
            TraerUsuario();
        }

        private void Modificarbutton_Click_1(object sender, EventArgs e)
        {
            Eliminarbutton.Enabled = false;
            Nuevobutton.Enabled = false;

            tipoOperacion = "Modificar";

            if (UsuariodataGridView.SelectedRows.Count != 0)
            {
                CodigotextBox.Text = UsuariodataGridView.CurrentRow.Cells["IdUsuario"].Value.ToString();
                NombretextBox.Text = UsuariodataGridView.CurrentRow.Cells["Nombre"].Value.ToString();
                ContraseñatextBox.Text = UsuariodataGridView.CurrentRow.Cells["Contraseña"].Value.ToString();
                RolcomboBox.Text = UsuariodataGridView.CurrentRow.Cells["Rol"].Value.ToString();
                ActivocheckBox.Checked = Convert.ToBoolean(UsuariodataGridView.CurrentRow.Cells["Activo"].Value);
                FechaNacimientodateTimePicker.Value = Convert.ToDateTime(UsuariodataGridView.CurrentRow.Cells["FechaNacimiento"].Value);

                HabilitarControles();

            }
            else
            {
                MessageBox.Show("Debe seleccionar un registro");
            }
        }

        private void Eliminarbutton_Click_1(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("SEGURO DE ELIMINAR ESTE REGISTO?", "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog != DialogResult.Yes)
            {

            }
            else
            {
                if (UsuariodataGridView.SelectedRows.Count != 0)
                {
                    bool elimino = usuariodb.Eliminar(UsuariodataGridView.CurrentRow.Cells["IdUsuario"].Value.ToString());
                    if (elimino)
                    {
                        TraerUsuario();
                        MessageBox.Show("Registo eliminado");
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el registro");
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un registro");
                }
            }
        }

        private void Cancelarbutton_Click_1(object sender, EventArgs e)
        {

            LimpiarControles();
            DeshabilitarControles();
            // Modificarbutton.Enabled = false;
            Guardarbutton.Enabled = false;
            Eliminarbutton.Enabled = false;
            Cancelarbutton.Enabled = false;
            Nuevobutton.Enabled = true;

        }
    }
}

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
    public partial class ClienteForm : Syncfusion.Windows.Forms.Office2010Form
    {
        public ClienteForm()
        {
            InitializeComponent();
        }
        string tipoOperacion;
        ClientesBD clientedb = new ClientesBD();
        Cliente cliente = new Cliente();
        private void ClienteForm_Load(object sender, EventArgs e)
        {

            TraerUsuario();


        }


        private void HabilitarControles()
        {
            CodigotextBox.Enabled = true;
            NombretextBox.Enabled = true;
            TelefonotextBox.Enabled = true;
            CorreotextBox.Enabled = true;
            DirecciontextBox.Enabled = true;
            Cancelarbutton.Enabled = true;
            Guardarbutton.Enabled = true;
        }

        private void DeshabilitarControles()
        {
            CodigotextBox.Enabled = false;
            NombretextBox.Enabled = false;
            TelefonotextBox.Enabled = false;
            CorreotextBox.Enabled = false;
            DirecciontextBox.Enabled = false;
            Guardarbutton.Enabled = false;
        }



        private void LimpiarControles()
        {
            CodigotextBox.Clear();
            NombretextBox.Clear();
            TelefonotextBox.Clear();
            CorreotextBox.Clear();
            DirecciontextBox.Clear();

        }




        private void TraerUsuario()
        {
            DataTable dt = new DataTable();
            dt = clientedb.DevolverCliente();
            ClientesdataGridView.DataSource = dt;
        }







        private void Nuevobutton_Click(object sender, EventArgs e)
        {

            HabilitarControles();
            Guardarbutton.Enabled = true;
            tipoOperacion = "Nuevo";
            Nuevobutton.Enabled = false;
            Modificarbutton.Enabled = false;
            Eliminarbutton.Enabled = false;

        }

        private void Modificarbutton_Click(object sender, EventArgs e)
        {

            Eliminarbutton.Enabled = false;
            Nuevobutton.Enabled = false;

            tipoOperacion = "Modificar";

            if (ClientesdataGridView.SelectedRows.Count != 0)
            {
                CodigotextBox.Text = ClientesdataGridView.CurrentRow.Cells["IdCliente"].Value.ToString();
                NombretextBox.Text = ClientesdataGridView.CurrentRow.Cells["Nombre"].Value.ToString();
                TelefonotextBox.Text = ClientesdataGridView.CurrentRow.Cells["Telefono"].Value.ToString();
                CorreotextBox.Text = ClientesdataGridView.CurrentRow.Cells["Correo"].Value.ToString();
                DirecciontextBox.Text = ClientesdataGridView.CurrentRow.Cells["Direccion"].Value.ToString();


                HabilitarControles();

            }
            else
            {
                MessageBox.Show("Debe seleccionar un registro");
            }

        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {

            if (tipoOperacion == "Nuevo")
            {
                if (string.IsNullOrEmpty(CodigotextBox.Text))
                {
                    errorProvider1.SetError(CodigotextBox, "Ingrese una identidad");
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

                if (string.IsNullOrEmpty(TelefonotextBox.Text))
                {
                    errorProvider1.SetError(TelefonotextBox, "Ingrese un numero de telefono");
                    TelefonotextBox.Focus();
                    return;
                }
                errorProvider1.Clear();

                if (string.IsNullOrEmpty(CorreotextBox.Text))
                {
                    errorProvider1.SetError(CorreotextBox, "Ingrese un correo");
                    TelefonotextBox.Focus();
                    return;
                }
                errorProvider1.Clear();

                if (string.IsNullOrEmpty(DirecciontextBox.Text))
                {
                    errorProvider1.SetError(DirecciontextBox, "Ingrese una direccion");
                    TelefonotextBox.Focus();
                    return;
                }
                errorProvider1.Clear();


                cliente.IdCliente = CodigotextBox.Text;
                cliente.Nombre = NombretextBox.Text;
                cliente.Correo = CorreotextBox.Text;
                cliente.Telefono = TelefonotextBox.Text;
                cliente.Direccion = DirecciontextBox.Text;


                // Insertar en la base de datos 

                bool inserto = clientedb.Insertar(cliente);
                if (inserto)
                {
                    DeshabilitarControles();
                    LimpiarControles();
                    TraerUsuario();
                    MessageBox.Show("Registro guardado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                cliente.IdCliente = CodigotextBox.Text;
                cliente.Nombre = NombretextBox.Text;
                cliente.Correo = CorreotextBox.Text;
                cliente.Telefono = TelefonotextBox.Text;
                cliente.Direccion = DirecciontextBox.Text;


                bool edito = clientedb.Editar(cliente);
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

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {

            DialogResult dialog = MessageBox.Show("SEGURO DE ELIMINAR ESTE REGISTO?", "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog != DialogResult.Yes)
            {

            }
            else
            {
                if (ClientesdataGridView.SelectedRows.Count != 0)
                {
                    bool elimino = clientedb.Eliminar(ClientesdataGridView.CurrentRow.Cells["IdCliente"].Value.ToString());
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

        private void Cancelarbutton_Click(object sender, EventArgs e)
        {


            LimpiarControles();
            DeshabilitarControles();

            Guardarbutton.Enabled = false;
            Eliminarbutton.Enabled = false;
            Cancelarbutton.Enabled = false;
            Nuevobutton.Enabled = true;


        }
    }
}

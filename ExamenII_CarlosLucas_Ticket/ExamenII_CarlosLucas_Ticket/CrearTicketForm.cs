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
    public partial class CrearTicketForm : Syncfusion.Windows.Forms.Office2010Form
    {
        public CrearTicketForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        TicketBD ticketdb = new TicketBD();
        Ticket ticket = new Ticket();
        private void Crearbutton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(IdClientetextBox.Text))
            {
                errorProvider1.SetError(IdClientetextBox, "Ingrese una identidad");
                IdClientetextBox.Focus();
                return;
            }
            errorProvider1.Clear();

            if (string.IsNullOrEmpty(NombreClientetextBox.Text))
            {
                errorProvider1.SetError(NombreClientetextBox, "Ingrese un nombre");
                NombreClientetextBox.Focus();
                return;
            }
            errorProvider1.Clear();

            if (string.IsNullOrEmpty(IdUsuariotextBox.Text))
            {
                errorProvider1.SetError(IdUsuariotextBox, "Ingrese un ID usuario");
                IdUsuariotextBox.Focus();
                return;
            }
            errorProvider1.Clear();

            if (string.IsNullOrEmpty(SoportecomboBox.Text))
            {
                errorProvider1.SetError(SoportecomboBox, "Seleccione un rol");
                SoportecomboBox.Focus();
                return;
            }
            errorProvider1.Clear();

            if (string.IsNullOrEmpty(SolicitudtextBox.Text))
            {
                errorProvider1.SetError(SolicitudtextBox, "Ingrese una solicitud");
                SolicitudtextBox.Focus();
                return;
            }
            errorProvider1.Clear();

            ticket.FechaApertura = FechaAperturadateTimePicker.Value;
            ticket.IdCliente = IdClientetextBox.Text;
            ticket.NombreCliente = NombreClientetextBox.Text;
            ticket.IdUsuario = IdUsuariotextBox.Text;
            ticket.Estado = EstadotextBox.Text;
            ticket.DescripcionSolicitud = SolicitudtextBox.Text;
            ticket.DescripcionRespuesta = "S/R";
            ticket.TipoSoporte = SoportecomboBox.Text;
            ticket.precio = 0;
            ticket.Impuesto = 0;
            ticket.Total = 0;
            ticket.Descuento = 0;
            ticket.Pagado = false;

            bool inserto = ticketdb.Insertar(ticket);
            if (inserto)
            {
                MessageBox.Show("Ticker registado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error al registrar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool inserto = ticketdb.Insertar(ticket);
            if (inserto)
            {
                MessageBox.Show("Ticker registado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Hide();
                Limpiar();
            }
            else
            {
                MessageBox.Show("Error al registrar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Limpiar()
        {
            IdClientetextBox.Clear();
            NombreClientetextBox.Clear();
            IdUsuariotextBox.Clear();
            SoportecomboBox.Text = "";
            SolicitudtextBox.Clear();


        }

        private void IdClientetextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClientesBD cliente = new ClientesBD();
            NombreClientetextBox.Text = cliente.TraerNombreCliente(IdClientetextBox.Text);
        }

        private void CrearTicketForm_Load(object sender, EventArgs e)
        {
            IdUsuariotextBox.Text = System.Threading.Thread.CurrentPrincipal.Identity.Name;
        }
    }
}

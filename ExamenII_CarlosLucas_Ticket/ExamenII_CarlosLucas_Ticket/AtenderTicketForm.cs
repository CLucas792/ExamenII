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
    public partial class AtenderTicketForm : Syncfusion.Windows.Forms.Office2010Form
    {
        public AtenderTicketForm()
        {
            InitializeComponent();
        }
        TicketBD ticketbd = new TicketBD();
        Ticket ticket = new Ticket();
        private void AtenderTicketForm_Load(object sender, EventArgs e)
        {
            TicketdataGridView.DataSource = ticketbd.MostrarTicketsNuevos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TicketdataGridView.SelectedRows.Count != 0)
            {
                TipoSoportetextBox.Text = TicketdataGridView.CurrentRow.Cells["TipoSoporte"].Value.ToString();
                SolicitudtextBox.Text = TicketdataGridView.CurrentRow.Cells["DescripcionSolicitud"].Value.ToString();
                SeleccionarTicketbutton.Enabled = false;
                ResponderTicketbutton.Enabled = true;
            }
            else
            {
                MessageBox.Show("Debe seleccionar un registro");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(RespuestatextBox.Text))
            {
                errorProvider1.SetError(RespuestatextBox, "Ingrese una respuesta");
                RespuestatextBox.Focus();
                return;
            }
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(PreciotextBox.Text))
            {
                errorProvider1.SetError(PreciotextBox, "Ingrese un precio");
                PreciotextBox.Focus();
                return;
            }
            errorProvider1.Clear();

            ticket.IdTicket = Convert.ToInt32(TicketdataGridView.CurrentRow.Cells["IdTicket"].Value);
            ticket.DescripcionRespuesta = RespuestatextBox.Text;
            ticket.precio = Convert.ToDecimal(PreciotextBox.Text);
            ticket.Estado = "Atendido";

            if (ticketbd.Actualizar(ticket))
            {
                MessageBox.Show("Ticker Atendido", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SeleccionarTicketbutton.Enabled = true;
                ResponderTicketbutton.Enabled = false;
                Limpiar();
            }
            else
            {
                MessageBox.Show("Ticker No registro validamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


            TicketdataGridView.DataSource = ticketbd.MostrarTicketsNuevos();

        }

        private void Limpiar()
        {
            TipoSoportetextBox.Clear();
            RespuestatextBox.Clear();
            PreciotextBox.Clear();
            SolicitudtextBox.Clear();
        }

        private void PreciotextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }
    }
}

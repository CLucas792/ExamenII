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
    public partial class CajaForm : Syncfusion.Windows.Forms.Office2010Form
    {
        public CajaForm()
        {
            InitializeComponent();
        }

        TicketBD ticketBD = new TicketBD();
        Ticket ticket = new Ticket();
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void IdTickettextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(IdTickettextBox.Text))
            {
                errorProvider1.SetError(IdTickettextBox, "Ingrese un ID");
                PreciotextBox.Focus();
                return;
            }
            errorProvider1.Clear();

            int num = Convert.ToInt32(IdTickettextBox.Text);
            decimal precio = ticketBD.DevolverTickerPorId(num);

            PreciotextBox.Text = Convert.ToString(precio);
        }

        private void DescuentotextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(PreciotextBox.Text))
            {
                errorProvider1.SetError(PreciotextBox, "Ingrese un precio");
                PreciotextBox.Focus();
                return;
            }
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(DescuentotextBox.Text))
            {
                errorProvider1.SetError(DescuentotextBox, "Ingrese un descuento");
                PreciotextBox.Focus();
                return;
            }
            errorProvider1.Clear();

            decimal precio = Convert.ToDecimal(PreciotextBox.Text);
            decimal descuento = Convert.ToDecimal(DescuentotextBox.Text);
            decimal Impuesto = (precio - descuento) * 0.15M;
            ImpuestotextBox.Text = Impuesto.ToString();
            TotaltextBox.Text = (precio - descuento + Impuesto).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(RecibotextBox.Text))
            {
                errorProvider1.SetError(RecibotextBox, "Ingrese un precio");
                PreciotextBox.Focus();
                return;
            }
            errorProvider1.Clear();
            if (Convert.ToDecimal(RecibotextBox.Text) > Convert.ToDecimal(TotaltextBox.Text))
            {
                CambiotextBox.Text = (Convert.ToDecimal(RecibotextBox.Text) - Convert.ToDecimal(TotaltextBox.Text)).ToString();
            }

            ticket.Descuento = Convert.ToDecimal(DescuentotextBox.Text);
            ticket.Impuesto = Convert.ToDecimal(ImpuestotextBox.Text);
            ticket.Total = Convert.ToDecimal(TotaltextBox.Text);
            ticket.Pagado = true;
            ticket.IdTicket = Convert.ToInt32(IdTickettextBox.Text);



            if (ticketBD.ActualizarCaja(ticket))
            {
                MessageBox.Show("PAGO REGISTRADO", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("PAGO NO REGISTRADOR", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

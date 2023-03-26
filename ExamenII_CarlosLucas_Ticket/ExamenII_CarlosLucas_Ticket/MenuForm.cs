using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ExamenII_CarlosLucas_Ticket
{
    public partial class MenuForm : Syncfusion.Windows.Forms.Office2010Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            UsuariosForm usuariosform = new UsuariosForm();
            usuariosform.MdiParent = this;
            usuariosform.Show();
        }

        private void RibbonPanel_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            ClienteForm clienteForm = new ClienteForm();
            clienteForm.MdiParent = this;
            clienteForm.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            CrearTicketForm crearTicketForm = new CrearTicketForm();
            crearTicketForm.MdiParent = this;
            crearTicketForm.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            AtenderTicketForm atenderTicketForm = new AtenderTicketForm();
            atenderTicketForm.MdiParent = this;
            atenderTicketForm.Show();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            CajaForm cajaForm = new CajaForm();
            cajaForm.MdiParent = this;
            cajaForm.Show();
        }
    }
}

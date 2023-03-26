
namespace ExamenII_CarlosLucas_Ticket
{
    partial class AtenderTicketForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TicketdataGridView = new System.Windows.Forms.DataGridView();
            this.TipoSoportetextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SeleccionarTicketbutton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SolicitudtextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.RespuestatextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PreciotextBox = new System.Windows.Forms.TextBox();
            this.ResponderTicketbutton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.TicketdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // TicketdataGridView
            // 
            this.TicketdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TicketdataGridView.Location = new System.Drawing.Point(1, -1);
            this.TicketdataGridView.Name = "TicketdataGridView";
            this.TicketdataGridView.Size = new System.Drawing.Size(798, 137);
            this.TicketdataGridView.TabIndex = 0;
            // 
            // TipoSoportetextBox
            // 
            this.TipoSoportetextBox.Location = new System.Drawing.Point(171, 189);
            this.TipoSoportetextBox.Name = "TipoSoportetextBox";
            this.TipoSoportetextBox.Size = new System.Drawing.Size(305, 26);
            this.TipoSoportetextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tipo Soporte:";
            // 
            // SeleccionarTicketbutton
            // 
            this.SeleccionarTicketbutton.Location = new System.Drawing.Point(353, 142);
            this.SeleccionarTicketbutton.Name = "SeleccionarTicketbutton";
            this.SeleccionarTicketbutton.Size = new System.Drawing.Size(178, 38);
            this.SeleccionarTicketbutton.TabIndex = 3;
            this.SeleccionarTicketbutton.Text = "Seleccionar Ticket";
            this.SeleccionarTicketbutton.UseVisualStyleBackColor = true;
            this.SeleccionarTicketbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Descripcion solicitud";
            // 
            // SolicitudtextBox
            // 
            this.SolicitudtextBox.Location = new System.Drawing.Point(171, 233);
            this.SolicitudtextBox.Multiline = true;
            this.SolicitudtextBox.Name = "SolicitudtextBox";
            this.SolicitudtextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.SolicitudtextBox.Size = new System.Drawing.Size(617, 69);
            this.SolicitudtextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-2, 324);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Descripcion respuesta";
            // 
            // RespuestatextBox
            // 
            this.RespuestatextBox.Location = new System.Drawing.Point(171, 324);
            this.RespuestatextBox.Multiline = true;
            this.RespuestatextBox.Name = "RespuestatextBox";
            this.RespuestatextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.RespuestatextBox.Size = new System.Drawing.Size(617, 69);
            this.RespuestatextBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 420);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Asignar Precio:";
            // 
            // PreciotextBox
            // 
            this.PreciotextBox.Location = new System.Drawing.Point(171, 420);
            this.PreciotextBox.Name = "PreciotextBox";
            this.PreciotextBox.Size = new System.Drawing.Size(127, 26);
            this.PreciotextBox.TabIndex = 9;
            this.PreciotextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PreciotextBox_KeyPress);
            // 
            // ResponderTicketbutton
            // 
            this.ResponderTicketbutton.Enabled = false;
            this.ResponderTicketbutton.Location = new System.Drawing.Point(362, 414);
            this.ResponderTicketbutton.Name = "ResponderTicketbutton";
            this.ResponderTicketbutton.Size = new System.Drawing.Size(178, 38);
            this.ResponderTicketbutton.TabIndex = 10;
            this.ResponderTicketbutton.Text = "Responder Ticket";
            this.ResponderTicketbutton.UseVisualStyleBackColor = true;
            this.ResponderTicketbutton.Click += new System.EventHandler(this.button2_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AtenderTicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 478);
            this.Controls.Add(this.ResponderTicketbutton);
            this.Controls.Add(this.PreciotextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.RespuestatextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SolicitudtextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SeleccionarTicketbutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TipoSoportetextBox);
            this.Controls.Add(this.TicketdataGridView);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AtenderTicketForm";
            this.Text = "AtenderTicketForm";
            this.Load += new System.EventHandler(this.AtenderTicketForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TicketdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TicketdataGridView;
        private System.Windows.Forms.TextBox TipoSoportetextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SeleccionarTicketbutton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SolicitudtextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox RespuestatextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PreciotextBox;
        private System.Windows.Forms.Button ResponderTicketbutton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
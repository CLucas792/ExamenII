
namespace ExamenII_CarlosLucas_Ticket
{
    partial class CrearTicketForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.FechaAperturadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.IdClientetextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SolicitudtextBox = new System.Windows.Forms.TextBox();
            this.NombreClientetextBox = new System.Windows.Forms.TextBox();
            this.IdUsuariotextBox = new System.Windows.Forms.TextBox();
            this.SoportecomboBox = new System.Windows.Forms.ComboBox();
            this.EstadotextBox = new System.Windows.Forms.TextBox();
            this.Crearbutton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Fecha Apertura";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Identidad Cliente";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 110);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Identidad Usuario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(88, 147);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Estado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 176);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Tipo de soporte";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 212);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "Descripcion Solicitud";
            // 
            // FechaAperturadateTimePicker
            // 
            this.FechaAperturadateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaAperturadateTimePicker.Location = new System.Drawing.Point(177, 16);
            this.FechaAperturadateTimePicker.Name = "FechaAperturadateTimePicker";
            this.FechaAperturadateTimePicker.Size = new System.Drawing.Size(200, 26);
            this.FechaAperturadateTimePicker.TabIndex = 22;
            // 
            // IdClientetextBox
            // 
            this.IdClientetextBox.Location = new System.Drawing.Point(175, 48);
            this.IdClientetextBox.Name = "IdClientetextBox";
            this.IdClientetextBox.Size = new System.Drawing.Size(252, 26);
            this.IdClientetextBox.TabIndex = 23;
            this.IdClientetextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IdClientetextBox_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 78);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 20);
            this.label8.TabIndex = 24;
            this.label8.Text = "Nombre Cliente";
            // 
            // SolicitudtextBox
            // 
            this.SolicitudtextBox.Location = new System.Drawing.Point(167, 215);
            this.SolicitudtextBox.Multiline = true;
            this.SolicitudtextBox.Name = "SolicitudtextBox";
            this.SolicitudtextBox.Size = new System.Drawing.Size(315, 171);
            this.SolicitudtextBox.TabIndex = 25;
            // 
            // NombreClientetextBox
            // 
            this.NombreClientetextBox.Location = new System.Drawing.Point(175, 80);
            this.NombreClientetextBox.Name = "NombreClientetextBox";
            this.NombreClientetextBox.ReadOnly = true;
            this.NombreClientetextBox.Size = new System.Drawing.Size(252, 26);
            this.NombreClientetextBox.TabIndex = 26;
            // 
            // IdUsuariotextBox
            // 
            this.IdUsuariotextBox.Location = new System.Drawing.Point(175, 112);
            this.IdUsuariotextBox.Name = "IdUsuariotextBox";
            this.IdUsuariotextBox.ReadOnly = true;
            this.IdUsuariotextBox.Size = new System.Drawing.Size(252, 26);
            this.IdUsuariotextBox.TabIndex = 27;
            // 
            // SoportecomboBox
            // 
            this.SoportecomboBox.FormattingEnabled = true;
            this.SoportecomboBox.Items.AddRange(new object[] {
            "Mantenimiento Preventivo",
            "Mantenimiento Correctivo",
            "Defecto de fabrica"});
            this.SoportecomboBox.Location = new System.Drawing.Point(177, 176);
            this.SoportecomboBox.Name = "SoportecomboBox";
            this.SoportecomboBox.Size = new System.Drawing.Size(252, 28);
            this.SoportecomboBox.TabIndex = 28;
            // 
            // EstadotextBox
            // 
            this.EstadotextBox.Enabled = false;
            this.EstadotextBox.Location = new System.Drawing.Point(175, 144);
            this.EstadotextBox.Name = "EstadotextBox";
            this.EstadotextBox.Size = new System.Drawing.Size(252, 26);
            this.EstadotextBox.TabIndex = 29;
            this.EstadotextBox.Text = "NUEVO";
            // 
            // Crearbutton
            // 
            this.Crearbutton.Location = new System.Drawing.Point(23, 303);
            this.Crearbutton.Name = "Crearbutton";
            this.Crearbutton.Size = new System.Drawing.Size(92, 71);
            this.Crearbutton.TabIndex = 30;
            this.Crearbutton.Text = "Crear Ticket";
            this.Crearbutton.UseVisualStyleBackColor = true;
            this.Crearbutton.Click += new System.EventHandler(this.Crearbutton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // CrearTicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 404);
            this.Controls.Add(this.Crearbutton);
            this.Controls.Add(this.EstadotextBox);
            this.Controls.Add(this.SoportecomboBox);
            this.Controls.Add(this.IdUsuariotextBox);
            this.Controls.Add(this.NombreClientetextBox);
            this.Controls.Add(this.SolicitudtextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.IdClientetextBox);
            this.Controls.Add(this.FechaAperturadateTimePicker);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CrearTicketForm";
            this.Text = "CrearTicketForm";
            this.Load += new System.EventHandler(this.CrearTicketForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker FechaAperturadateTimePicker;
        private System.Windows.Forms.TextBox IdClientetextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox SolicitudtextBox;
        private System.Windows.Forms.TextBox NombreClientetextBox;
        private System.Windows.Forms.TextBox IdUsuariotextBox;
        private System.Windows.Forms.ComboBox SoportecomboBox;
        private System.Windows.Forms.TextBox EstadotextBox;
        private System.Windows.Forms.Button Crearbutton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
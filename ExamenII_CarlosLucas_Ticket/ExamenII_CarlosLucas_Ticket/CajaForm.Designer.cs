
namespace ExamenII_CarlosLucas_Ticket
{
    partial class CajaForm
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
            this.IdTickettextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.PreciotextBox = new System.Windows.Forms.TextBox();
            this.DescuentotextBox = new System.Windows.Forms.TextBox();
            this.ImpuestotextBox = new System.Windows.Forms.TextBox();
            this.TotaltextBox = new System.Windows.Forms.TextBox();
            this.RecibotextBox = new System.Windows.Forms.TextBox();
            this.CambiotextBox = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese Id de ticket a cancelar";
            // 
            // IdTickettextBox
            // 
            this.IdTickettextBox.Location = new System.Drawing.Point(241, 8);
            this.IdTickettextBox.Name = "IdTickettextBox";
            this.IdTickettextBox.Size = new System.Drawing.Size(229, 26);
            this.IdTickettextBox.TabIndex = 1;
            this.IdTickettextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IdTickettextBox_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Precio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(143, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Descuento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(154, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Impuesto:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(128, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Total a pagar:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(171, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Recibo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(128, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Su cambio es:";
            // 
            // PreciotextBox
            // 
            this.PreciotextBox.Location = new System.Drawing.Point(241, 51);
            this.PreciotextBox.Name = "PreciotextBox";
            this.PreciotextBox.ReadOnly = true;
            this.PreciotextBox.Size = new System.Drawing.Size(140, 26);
            this.PreciotextBox.TabIndex = 8;
            // 
            // DescuentotextBox
            // 
            this.DescuentotextBox.Location = new System.Drawing.Point(241, 85);
            this.DescuentotextBox.Name = "DescuentotextBox";
            this.DescuentotextBox.Size = new System.Drawing.Size(140, 26);
            this.DescuentotextBox.TabIndex = 9;
            this.DescuentotextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DescuentotextBox_KeyPress);
            // 
            // ImpuestotextBox
            // 
            this.ImpuestotextBox.Location = new System.Drawing.Point(241, 117);
            this.ImpuestotextBox.Name = "ImpuestotextBox";
            this.ImpuestotextBox.ReadOnly = true;
            this.ImpuestotextBox.Size = new System.Drawing.Size(140, 26);
            this.ImpuestotextBox.TabIndex = 10;
            // 
            // TotaltextBox
            // 
            this.TotaltextBox.Location = new System.Drawing.Point(241, 152);
            this.TotaltextBox.Name = "TotaltextBox";
            this.TotaltextBox.ReadOnly = true;
            this.TotaltextBox.Size = new System.Drawing.Size(140, 26);
            this.TotaltextBox.TabIndex = 11;
            // 
            // RecibotextBox
            // 
            this.RecibotextBox.Location = new System.Drawing.Point(241, 187);
            this.RecibotextBox.Name = "RecibotextBox";
            this.RecibotextBox.Size = new System.Drawing.Size(140, 26);
            this.RecibotextBox.TabIndex = 12;
            // 
            // CambiotextBox
            // 
            this.CambiotextBox.Location = new System.Drawing.Point(241, 221);
            this.CambiotextBox.Name = "CambiotextBox";
            this.CambiotextBox.ReadOnly = true;
            this.CambiotextBox.Size = new System.Drawing.Size(140, 26);
            this.CambiotextBox.TabIndex = 13;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Location = new System.Drawing.Point(476, 8);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(86, 37);
            this.Buscarbutton.TabIndex = 14;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(423, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 37);
            this.button1.TabIndex = 15;
            this.button1.Text = "Calcular Total";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(408, 215);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 38);
            this.button2.TabIndex = 16;
            this.button2.Text = "Cerrar Pago";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CajaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 340);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.CambiotextBox);
            this.Controls.Add(this.RecibotextBox);
            this.Controls.Add(this.TotaltextBox);
            this.Controls.Add(this.ImpuestotextBox);
            this.Controls.Add(this.DescuentotextBox);
            this.Controls.Add(this.PreciotextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IdTickettextBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CajaForm";
            this.Text = "Descuento:";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IdTickettextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox PreciotextBox;
        private System.Windows.Forms.TextBox DescuentotextBox;
        private System.Windows.Forms.TextBox ImpuestotextBox;
        private System.Windows.Forms.TextBox TotaltextBox;
        private System.Windows.Forms.TextBox RecibotextBox;
        private System.Windows.Forms.TextBox CambiotextBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
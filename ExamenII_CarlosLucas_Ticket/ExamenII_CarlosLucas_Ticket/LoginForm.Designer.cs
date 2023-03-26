
namespace ExamenII_CarlosLucas_Ticket
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.Cancelarbutton = new System.Windows.Forms.Button();
            this.ImagenpictureBox = new System.Windows.Forms.PictureBox();
            this.Aceptarbutton = new System.Windows.Forms.Button();
            this.ContraseñatextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CodigoUsuariotextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ImagenpictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // Cancelarbutton
            // 
            this.Cancelarbutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancelarbutton.Image = ((System.Drawing.Image)(resources.GetObject("Cancelarbutton.Image")));
            this.Cancelarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Cancelarbutton.Location = new System.Drawing.Point(198, 91);
            this.Cancelarbutton.Name = "Cancelarbutton";
            this.Cancelarbutton.Size = new System.Drawing.Size(102, 32);
            this.Cancelarbutton.TabIndex = 14;
            this.Cancelarbutton.Text = "Cancelar";
            this.Cancelarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Cancelarbutton.UseVisualStyleBackColor = true;
            this.Cancelarbutton.Click += new System.EventHandler(this.Cancelarbutton_Click);
            // 
            // ImagenpictureBox
            // 
            this.ImagenpictureBox.BackColor = System.Drawing.Color.Transparent;
            this.ImagenpictureBox.Image = ((System.Drawing.Image)(resources.GetObject("ImagenpictureBox.Image")));
            this.ImagenpictureBox.Location = new System.Drawing.Point(282, 12);
            this.ImagenpictureBox.Name = "ImagenpictureBox";
            this.ImagenpictureBox.Size = new System.Drawing.Size(64, 64);
            this.ImagenpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ImagenpictureBox.TabIndex = 13;
            this.ImagenpictureBox.TabStop = false;
            // 
            // Aceptarbutton
            // 
            this.Aceptarbutton.Image = ((System.Drawing.Image)(resources.GetObject("Aceptarbutton.Image")));
            this.Aceptarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Aceptarbutton.Location = new System.Drawing.Point(99, 91);
            this.Aceptarbutton.Name = "Aceptarbutton";
            this.Aceptarbutton.Size = new System.Drawing.Size(93, 32);
            this.Aceptarbutton.TabIndex = 12;
            this.Aceptarbutton.Text = "Aceptar";
            this.Aceptarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Aceptarbutton.UseVisualStyleBackColor = true;
            this.Aceptarbutton.Click += new System.EventHandler(this.Aceptarbutton_Click);
            // 
            // ContraseñatextBox
            // 
            this.ContraseñatextBox.Location = new System.Drawing.Point(98, 59);
            this.ContraseñatextBox.Name = "ContraseñatextBox";
            this.ContraseñatextBox.PasswordChar = '*';
            this.ContraseñatextBox.Size = new System.Drawing.Size(178, 26);
            this.ContraseñatextBox.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Contraseña:";
            // 
            // CodigoUsuariotextBox
            // 
            this.CodigoUsuariotextBox.Location = new System.Drawing.Point(98, 12);
            this.CodigoUsuariotextBox.Name = "CodigoUsuariotextBox";
            this.CodigoUsuariotextBox.Size = new System.Drawing.Size(178, 26);
            this.CodigoUsuariotextBox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Usuario:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // LoginForm
            // 
            this.AcceptButton = this.Aceptarbutton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancelarbutton;
            this.CaptionFont = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientSize = new System.Drawing.Size(351, 127);
            this.ControlBox = false;
            this.Controls.Add(this.Cancelarbutton);
            this.Controls.Add(this.ImagenpictureBox);
            this.Controls.Add(this.Aceptarbutton);
            this.Controls.Add(this.ContraseñatextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CodigoUsuariotextBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "LoginForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.ImagenpictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Cancelarbutton;
        private System.Windows.Forms.PictureBox ImagenpictureBox;
        private System.Windows.Forms.Button Aceptarbutton;
        private System.Windows.Forms.TextBox ContraseñatextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CodigoUsuariotextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
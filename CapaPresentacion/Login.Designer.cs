namespace CapaPresentacion
{
    partial class Login
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
            this.LLogo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.BCancelar = new System.Windows.Forms.Button();
            this.BIngresar = new System.Windows.Forms.Button();
            this.TBContraseña = new System.Windows.Forms.TextBox();
            this.LContraseña = new System.Windows.Forms.Label();
            this.TBUsuario = new System.Windows.Forms.TextBox();
            this.LUsuario = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LLogo
            // 
            this.LLogo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.LLogo.Location = new System.Drawing.Point(0, 0);
            this.LLogo.Name = "LLogo";
            this.LLogo.Size = new System.Drawing.Size(286, 334);
            this.LLogo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Leelawadee UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(47, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sístemas de Ventas";
            // 
            // panelLogin
            // 
            this.panelLogin.Controls.Add(this.BCancelar);
            this.panelLogin.Controls.Add(this.BIngresar);
            this.panelLogin.Controls.Add(this.TBContraseña);
            this.panelLogin.Controls.Add(this.LContraseña);
            this.panelLogin.Controls.Add(this.TBUsuario);
            this.panelLogin.Controls.Add(this.LUsuario);
            this.panelLogin.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelLogin.Location = new System.Drawing.Point(283, 0);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(303, 334);
            this.panelLogin.TabIndex = 9;
            // 
            // BCancelar
            // 
            this.BCancelar.Image = global::CapaPresentacion.Properties.Resources.cruz_pequena;
            this.BCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BCancelar.Location = new System.Drawing.Point(158, 235);
            this.BCancelar.Name = "BCancelar";
            this.BCancelar.Size = new System.Drawing.Size(99, 38);
            this.BCancelar.TabIndex = 14;
            this.BCancelar.Text = "Cancelar";
            this.BCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BCancelar.UseVisualStyleBackColor = true;
            this.BCancelar.Click += new System.EventHandler(this.BCancelar_Click);
            // 
            // BIngresar
            // 
            this.BIngresar.Image = global::CapaPresentacion.Properties.Resources.ingresar;
            this.BIngresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BIngresar.Location = new System.Drawing.Point(38, 235);
            this.BIngresar.Name = "BIngresar";
            this.BIngresar.Size = new System.Drawing.Size(100, 38);
            this.BIngresar.TabIndex = 13;
            this.BIngresar.Text = "Ingresar";
            this.BIngresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BIngresar.UseVisualStyleBackColor = true;
            this.BIngresar.Click += new System.EventHandler(this.BIngresar_Click);
            // 
            // TBContraseña
            // 
            this.TBContraseña.Location = new System.Drawing.Point(38, 164);
            this.TBContraseña.Name = "TBContraseña";
            this.TBContraseña.PasswordChar = '*';
            this.TBContraseña.Size = new System.Drawing.Size(262, 27);
            this.TBContraseña.TabIndex = 12;
            // 
            // LContraseña
            // 
            this.LContraseña.AutoSize = true;
            this.LContraseña.Location = new System.Drawing.Point(34, 141);
            this.LContraseña.Name = "LContraseña";
            this.LContraseña.Size = new System.Drawing.Size(151, 20);
            this.LContraseña.TabIndex = 11;
            this.LContraseña.Text = "Ingrese su contraseña";
            // 
            // TBUsuario
            // 
            this.TBUsuario.Location = new System.Drawing.Point(38, 90);
            this.TBUsuario.Name = "TBUsuario";
            this.TBUsuario.Size = new System.Drawing.Size(265, 27);
            this.TBUsuario.TabIndex = 10;
            // 
            // LUsuario
            // 
            this.LUsuario.AutoSize = true;
            this.LUsuario.Location = new System.Drawing.Point(34, 67);
            this.LUsuario.Name = "LUsuario";
            this.LUsuario.Size = new System.Drawing.Size(137, 20);
            this.LUsuario.TabIndex = 9;
            this.LUsuario.Text = "Ingrese su  Usuario ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.logo_definitivo;
            this.pictureBox1.Location = new System.Drawing.Point(-8, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(264, 210);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 334);
            this.Controls.Add(this.panelLogin);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Button BCancelar;
        private System.Windows.Forms.Button BIngresar;
        private System.Windows.Forms.TextBox TBContraseña;
        private System.Windows.Forms.Label LContraseña;
        private System.Windows.Forms.TextBox TBUsuario;
        private System.Windows.Forms.Label LUsuario;
    }
}
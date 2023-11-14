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
            this.panelLogin = new System.Windows.Forms.Panel();
            this.Subtitulo = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picMinimizar = new System.Windows.Forms.PictureBox();
            this.picCerrar = new System.Windows.Forms.PictureBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblLogoTitulo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLogin
            // 
            this.panelLogin.BackColor = System.Drawing.Color.Silver;
            this.panelLogin.Controls.Add(this.Subtitulo);
            this.panelLogin.Controls.Add(this.pictureBox3);
            this.panelLogin.Controls.Add(this.panel2);
            this.panelLogin.Controls.Add(this.txtContrasena);
            this.panelLogin.Controls.Add(this.pictureBox2);
            this.panelLogin.Controls.Add(this.panel1);
            this.panelLogin.Controls.Add(this.picMinimizar);
            this.panelLogin.Controls.Add(this.picCerrar);
            this.panelLogin.Controls.Add(this.btnCancelar);
            this.panelLogin.Controls.Add(this.btnIngresar);
            this.panelLogin.Controls.Add(this.txtUsuario);
            this.panelLogin.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelLogin.Location = new System.Drawing.Point(283, 0);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(329, 334);
            this.panelLogin.TabIndex = 9;
            
            // 
            // Subtitulo
            // 
            this.Subtitulo.AutoSize = true;
            this.Subtitulo.Font = new System.Drawing.Font("Leelawadee UI", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Subtitulo.Location = new System.Drawing.Point(61, 50);
            this.Subtitulo.Name = "Subtitulo";
            this.Subtitulo.Size = new System.Drawing.Size(211, 38);
            this.Subtitulo.TabIndex = 23;
            this.Subtitulo.Text = "Inicio de Sesion";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::CapaPresentacion.Properties.Resources.candado;
            this.pictureBox3.Location = new System.Drawing.Point(97, 176);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(24, 35);
            this.pictureBox3.TabIndex = 22;
            this.pictureBox3.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(137, 195);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(94, 1);
            this.panel2.TabIndex = 21;
            // 
            // txtContrasena
            // 
            this.txtContrasena.BackColor = System.Drawing.Color.Silver;
            this.txtContrasena.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContrasena.ForeColor = System.Drawing.Color.Black;
            this.txtContrasena.Location = new System.Drawing.Point(137, 176);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.PasswordChar = '*';
            this.txtContrasena.Size = new System.Drawing.Size(95, 20);
            this.txtContrasena.TabIndex = 2;
            this.txtContrasena.TextChanged += new System.EventHandler(this.txtContrasena_TextChanged);
            this.txtContrasena.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContrasena_KeyPress_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CapaPresentacion.Properties.Resources.usuario11;
            this.pictureBox2.Location = new System.Drawing.Point(97, 122);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 35);
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(137, 141);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(94, 1);
            this.panel1.TabIndex = 18;
            // 
            // picMinimizar
            // 
            this.picMinimizar.Image = global::CapaPresentacion.Properties.Resources.menos;
            this.picMinimizar.Location = new System.Drawing.Point(267, 3);
            this.picMinimizar.Name = "picMinimizar";
            this.picMinimizar.Size = new System.Drawing.Size(24, 23);
            this.picMinimizar.TabIndex = 17;
            this.picMinimizar.TabStop = false;
            this.picMinimizar.Click += new System.EventHandler(this.picMinimizar_Click);
            // 
            // picCerrar
            // 
            this.picCerrar.Image = global::CapaPresentacion.Properties.Resources.cruz_pequena;
            this.picCerrar.Location = new System.Drawing.Point(297, 3);
            this.picCerrar.Name = "picCerrar";
            this.picCerrar.Size = new System.Drawing.Size(29, 23);
            this.picCerrar.TabIndex = 16;
            this.picCerrar.TabStop = false;
            this.picCerrar.Click += new System.EventHandler(this.picCerrar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.LightGray;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(202)))), ((int)(((byte)(210)))));
            this.btnCancelar.Image = global::CapaPresentacion.Properties.Resources.cruz_pequena;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(177, 238);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(95, 35);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.LightGray;
            this.btnIngresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIngresar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnIngresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnIngresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(202)))), ((int)(((byte)(210)))));
            this.btnIngresar.Image = global::CapaPresentacion.Properties.Resources.ingresar;
            this.btnIngresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIngresar.Location = new System.Drawing.Point(68, 238);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(94, 35);
            this.btnIngresar.TabIndex = 3;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.Silver;
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.ForeColor = System.Drawing.Color.Black;
            this.txtUsuario.Location = new System.Drawing.Point(137, 122);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(94, 20);
            this.txtUsuario.TabIndex = 1;
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
            // 
            // lblLogoTitulo
            // 
            this.lblLogoTitulo.BackColor = System.Drawing.Color.Black;
            this.lblLogoTitulo.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblLogoTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblLogoTitulo.Name = "lblLogoTitulo";
            this.lblLogoTitulo.Size = new System.Drawing.Size(286, 334);
            this.lblLogoTitulo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.pictureBox1.BackgroundImage = global::CapaPresentacion.Properties.Resources.infiniteee;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(283, 334);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 334);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelLogin);
            this.Controls.Add(this.lblLogoTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblLogoTitulo;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnIngresar;
        public System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picCerrar;
        private System.Windows.Forms.PictureBox picMinimizar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.Label Subtitulo;
    }
}
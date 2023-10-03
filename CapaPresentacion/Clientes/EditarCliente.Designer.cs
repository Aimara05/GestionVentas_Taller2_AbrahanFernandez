namespace CapaPresentacion.Clientes
{
    partial class EditarCliente
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
            this.panelBotonCerrar = new System.Windows.Forms.Panel();
            this.picCerrar = new System.Windows.Forms.PictureBox();
            this.LTitulo = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textCorreo = new System.Windows.Forms.TextBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblDomicilio = new System.Windows.Forms.Label();
            this.txtDomicilio = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblTel = new System.Windows.Forms.Label();
            this.TBdni = new System.Windows.Forms.TextBox();
            this.LDni = new System.Windows.Forms.Label();
            this.LNombree = new System.Windows.Forms.Label();
            this.Lestado = new System.Windows.Forms.Label();
            this.TBNombree = new System.Windows.Forms.TextBox();
            this.CBRol = new System.Windows.Forms.ComboBox();
            this.LApellido = new System.Windows.Forms.Label();
            this.LRol = new System.Windows.Forms.Label();
            this.TBapellido = new System.Windows.Forms.TextBox();
            this.LUsuario = new System.Windows.Forms.Label();
            this.TBusuario = new System.Windows.Forms.TextBox();
            this.TBcontrasena = new System.Windows.Forms.TextBox();
            this.LContrasena = new System.Windows.Forms.Label();
            this.panelBotonCerrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBotonCerrar
            // 
            this.panelBotonCerrar.BackColor = System.Drawing.Color.DarkGray;
            this.panelBotonCerrar.Controls.Add(this.picCerrar);
            this.panelBotonCerrar.Controls.Add(this.LTitulo);
            this.panelBotonCerrar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBotonCerrar.Location = new System.Drawing.Point(0, 0);
            this.panelBotonCerrar.Name = "panelBotonCerrar";
            this.panelBotonCerrar.Size = new System.Drawing.Size(544, 35);
            this.panelBotonCerrar.TabIndex = 36;
            // 
            // picCerrar
            // 
            this.picCerrar.BackColor = System.Drawing.Color.LightGray;
            this.picCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCerrar.Image = global::CapaPresentacion.Properties.Resources.cruz_pequena;
            this.picCerrar.Location = new System.Drawing.Point(507, 6);
            this.picCerrar.Name = "picCerrar";
            this.picCerrar.Size = new System.Drawing.Size(25, 25);
            this.picCerrar.TabIndex = 35;
            this.picCerrar.TabStop = false;
            this.picCerrar.Click += new System.EventHandler(this.picCerrar_Click);
            // 
            // LTitulo
            // 
            this.LTitulo.BackColor = System.Drawing.Color.Transparent;
            this.LTitulo.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTitulo.ForeColor = System.Drawing.Color.Black;
            this.LTitulo.Image = global::CapaPresentacion.Properties.Resources.Edit_User_icon_icons_com_55920;
            this.LTitulo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LTitulo.Location = new System.Drawing.Point(12, 3);
            this.LTitulo.Name = "LTitulo";
            this.LTitulo.Size = new System.Drawing.Size(156, 28);
            this.LTitulo.TabIndex = 22;
            this.LTitulo.Text = "Editar Cliente";
            this.LTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.LightGray;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(202)))), ((int)(((byte)(210)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = global::CapaPresentacion.Properties.Resources.cruz_pequena;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(411, 237);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(111, 31);
            this.btnCancelar.TabIndex = 81;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.LightGray;
            this.BtnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.BtnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BtnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(202)))), ((int)(((byte)(210)))));
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardar.Font = new System.Drawing.Font("Leelawadee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnGuardar.Image = global::CapaPresentacion.Properties.Resources.flecha_de_circulo_de_disquete_a_la_derecha;
            this.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGuardar.Location = new System.Drawing.Point(411, 173);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.BtnGuardar.Size = new System.Drawing.Size(111, 31);
            this.BtnGuardar.TabIndex = 80;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnGuardar.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.White;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(191, 316);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(185, 21);
            this.comboBox1.TabIndex = 79;
            // 
            // textCorreo
            // 
            this.textCorreo.BackColor = System.Drawing.Color.White;
            this.textCorreo.Location = new System.Drawing.Point(191, 212);
            this.textCorreo.Name = "textCorreo";
            this.textCorreo.Size = new System.Drawing.Size(185, 20);
            this.textCorreo.TabIndex = 78;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.BackColor = System.Drawing.Color.Black;
            this.lblCorreo.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.ForeColor = System.Drawing.Color.White;
            this.lblCorreo.Location = new System.Drawing.Point(52, 212);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(52, 17);
            this.lblCorreo.TabIndex = 77;
            this.lblCorreo.Text = "Correo:";
            // 
            // lblDomicilio
            // 
            this.lblDomicilio.AutoSize = true;
            this.lblDomicilio.BackColor = System.Drawing.Color.Black;
            this.lblDomicilio.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDomicilio.ForeColor = System.Drawing.Color.White;
            this.lblDomicilio.Location = new System.Drawing.Point(52, 187);
            this.lblDomicilio.Name = "lblDomicilio";
            this.lblDomicilio.Size = new System.Drawing.Size(65, 17);
            this.lblDomicilio.TabIndex = 76;
            this.lblDomicilio.Text = "Domicilio:";
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.BackColor = System.Drawing.Color.White;
            this.txtDomicilio.Location = new System.Drawing.Point(191, 187);
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.Size = new System.Drawing.Size(185, 20);
            this.txtDomicilio.TabIndex = 75;
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.Color.White;
            this.txtTelefono.Location = new System.Drawing.Point(191, 162);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(185, 20);
            this.txtTelefono.TabIndex = 74;
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.BackColor = System.Drawing.Color.Black;
            this.lblTel.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTel.ForeColor = System.Drawing.Color.White;
            this.lblTel.Location = new System.Drawing.Point(52, 162);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(62, 17);
            this.lblTel.TabIndex = 73;
            this.lblTel.Text = "Teléfono:";
            // 
            // TBdni
            // 
            this.TBdni.BackColor = System.Drawing.Color.White;
            this.TBdni.Location = new System.Drawing.Point(191, 84);
            this.TBdni.Name = "TBdni";
            this.TBdni.Size = new System.Drawing.Size(185, 20);
            this.TBdni.TabIndex = 65;
            // 
            // LDni
            // 
            this.LDni.AutoSize = true;
            this.LDni.BackColor = System.Drawing.Color.Black;
            this.LDni.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDni.ForeColor = System.Drawing.Color.White;
            this.LDni.Location = new System.Drawing.Point(52, 84);
            this.LDni.Name = "LDni";
            this.LDni.Size = new System.Drawing.Size(115, 17);
            this.LDni.TabIndex = 60;
            this.LDni.Text = "N° de documento:";
            // 
            // LNombree
            // 
            this.LNombree.AutoSize = true;
            this.LNombree.BackColor = System.Drawing.Color.Black;
            this.LNombree.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNombree.ForeColor = System.Drawing.Color.White;
            this.LNombree.Location = new System.Drawing.Point(52, 110);
            this.LNombree.Name = "LNombree";
            this.LNombree.Size = new System.Drawing.Size(60, 17);
            this.LNombree.TabIndex = 61;
            this.LNombree.Text = "Nombre:";
            // 
            // Lestado
            // 
            this.Lestado.AutoSize = true;
            this.Lestado.BackColor = System.Drawing.Color.Black;
            this.Lestado.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lestado.ForeColor = System.Drawing.Color.White;
            this.Lestado.Location = new System.Drawing.Point(52, 318);
            this.Lestado.Name = "Lestado";
            this.Lestado.Size = new System.Drawing.Size(51, 17);
            this.Lestado.TabIndex = 72;
            this.Lestado.Text = "Estado:";
            // 
            // TBNombree
            // 
            this.TBNombree.BackColor = System.Drawing.Color.White;
            this.TBNombree.Location = new System.Drawing.Point(191, 110);
            this.TBNombree.Name = "TBNombree";
            this.TBNombree.Size = new System.Drawing.Size(185, 20);
            this.TBNombree.TabIndex = 66;
            // 
            // CBRol
            // 
            this.CBRol.BackColor = System.Drawing.Color.White;
            this.CBRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBRol.FormattingEnabled = true;
            this.CBRol.Location = new System.Drawing.Point(191, 288);
            this.CBRol.Name = "CBRol";
            this.CBRol.Size = new System.Drawing.Size(185, 21);
            this.CBRol.TabIndex = 70;
            // 
            // LApellido
            // 
            this.LApellido.AutoSize = true;
            this.LApellido.BackColor = System.Drawing.Color.Black;
            this.LApellido.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LApellido.ForeColor = System.Drawing.Color.White;
            this.LApellido.Location = new System.Drawing.Point(52, 136);
            this.LApellido.Name = "LApellido";
            this.LApellido.Size = new System.Drawing.Size(59, 17);
            this.LApellido.TabIndex = 62;
            this.LApellido.Text = "Apellido:";
            // 
            // LRol
            // 
            this.LRol.AutoSize = true;
            this.LRol.BackColor = System.Drawing.Color.Black;
            this.LRol.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LRol.ForeColor = System.Drawing.Color.White;
            this.LRol.Location = new System.Drawing.Point(52, 291);
            this.LRol.Name = "LRol";
            this.LRol.Size = new System.Drawing.Size(30, 17);
            this.LRol.TabIndex = 71;
            this.LRol.Text = "Rol:";
            // 
            // TBapellido
            // 
            this.TBapellido.BackColor = System.Drawing.Color.White;
            this.TBapellido.Location = new System.Drawing.Point(191, 136);
            this.TBapellido.Name = "TBapellido";
            this.TBapellido.Size = new System.Drawing.Size(185, 20);
            this.TBapellido.TabIndex = 67;
            // 
            // LUsuario
            // 
            this.LUsuario.AutoSize = true;
            this.LUsuario.BackColor = System.Drawing.Color.Black;
            this.LUsuario.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LUsuario.ForeColor = System.Drawing.Color.White;
            this.LUsuario.Location = new System.Drawing.Point(52, 237);
            this.LUsuario.Name = "LUsuario";
            this.LUsuario.Size = new System.Drawing.Size(56, 17);
            this.LUsuario.TabIndex = 63;
            this.LUsuario.Text = "Usuario:";
            // 
            // TBusuario
            // 
            this.TBusuario.BackColor = System.Drawing.Color.White;
            this.TBusuario.Location = new System.Drawing.Point(191, 237);
            this.TBusuario.Name = "TBusuario";
            this.TBusuario.Size = new System.Drawing.Size(185, 20);
            this.TBusuario.TabIndex = 68;
            // 
            // TBcontrasena
            // 
            this.TBcontrasena.BackColor = System.Drawing.Color.White;
            this.TBcontrasena.Location = new System.Drawing.Point(191, 263);
            this.TBcontrasena.Name = "TBcontrasena";
            this.TBcontrasena.Size = new System.Drawing.Size(185, 20);
            this.TBcontrasena.TabIndex = 69;
            // 
            // LContrasena
            // 
            this.LContrasena.AutoSize = true;
            this.LContrasena.BackColor = System.Drawing.Color.Black;
            this.LContrasena.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LContrasena.ForeColor = System.Drawing.Color.White;
            this.LContrasena.Location = new System.Drawing.Point(52, 262);
            this.LContrasena.Name = "LContrasena";
            this.LContrasena.Size = new System.Drawing.Size(77, 17);
            this.LContrasena.TabIndex = 64;
            this.LContrasena.Text = "Contraseña:";
            // 
            // EditarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(544, 379);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textCorreo);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.lblDomicilio);
            this.Controls.Add(this.txtDomicilio);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.TBdni);
            this.Controls.Add(this.LDni);
            this.Controls.Add(this.LNombree);
            this.Controls.Add(this.Lestado);
            this.Controls.Add(this.TBNombree);
            this.Controls.Add(this.CBRol);
            this.Controls.Add(this.LApellido);
            this.Controls.Add(this.LRol);
            this.Controls.Add(this.TBapellido);
            this.Controls.Add(this.LUsuario);
            this.Controls.Add(this.TBusuario);
            this.Controls.Add(this.TBcontrasena);
            this.Controls.Add(this.LContrasena);
            this.Controls.Add(this.panelBotonCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditarCliente";
            this.panelBotonCerrar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelBotonCerrar;
        private System.Windows.Forms.PictureBox picCerrar;
        private System.Windows.Forms.Label LTitulo;
        private System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.Button BtnGuardar;
        public System.Windows.Forms.ComboBox comboBox1;
        public System.Windows.Forms.TextBox textCorreo;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblDomicilio;
        public System.Windows.Forms.TextBox txtDomicilio;
        public System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblTel;
        public System.Windows.Forms.TextBox TBdni;
        private System.Windows.Forms.Label LDni;
        private System.Windows.Forms.Label LNombree;
        private System.Windows.Forms.Label Lestado;
        public System.Windows.Forms.TextBox TBNombree;
        public System.Windows.Forms.ComboBox CBRol;
        private System.Windows.Forms.Label LApellido;
        private System.Windows.Forms.Label LRol;
        public System.Windows.Forms.TextBox TBapellido;
        private System.Windows.Forms.Label LUsuario;
        public System.Windows.Forms.TextBox TBusuario;
        public System.Windows.Forms.TextBox TBcontrasena;
        private System.Windows.Forms.Label LContrasena;
    }
}
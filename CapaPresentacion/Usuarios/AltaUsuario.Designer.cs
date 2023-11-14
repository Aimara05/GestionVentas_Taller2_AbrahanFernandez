namespace CapaPresentacion.Usuarios
{
    partial class AltaUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AltaUsuario));
            this.LDni = new System.Windows.Forms.Label();
            this.TBdni = new System.Windows.Forms.TextBox();
            this.LNombree = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.Lestado = new System.Windows.Forms.Label();
            this.LApellido = new System.Windows.Forms.Label();
            this.CBRol = new System.Windows.Forms.ComboBox();
            this.LRol = new System.Windows.Forms.Label();
            this.TBapellido = new System.Windows.Forms.TextBox();
            this.LUsuario = new System.Windows.Forms.Label();
            this.TBusuario = new System.Windows.Forms.TextBox();
            this.lblTel = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtDomicilio = new System.Windows.Forms.TextBox();
            this.lblDomicilio = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.textCorreo = new System.Windows.Forms.TextBox();
            this.CBEstado = new System.Windows.Forms.ComboBox();
            this.LTitulo = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnCancelar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.picCerrar = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblContrasena = new System.Windows.Forms.Label();
            this.TBcontrasena = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // LDni
            // 
            this.LDni.AutoSize = true;
            this.LDni.BackColor = System.Drawing.Color.Black;
            this.LDni.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDni.ForeColor = System.Drawing.Color.White;
            this.LDni.Location = new System.Drawing.Point(312, 147);
            this.LDni.Name = "LDni";
            this.LDni.Size = new System.Drawing.Size(115, 17);
            this.LDni.TabIndex = 1;
            this.LDni.Text = "N° de documento:";
            // 
            // TBdni
            // 
            this.TBdni.BackColor = System.Drawing.Color.White;
            this.TBdni.Location = new System.Drawing.Point(447, 144);
            this.TBdni.Name = "TBdni";
            this.TBdni.Size = new System.Drawing.Size(185, 20);
            this.TBdni.TabIndex = 1;
            this.TBdni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBdni_KeyPress);
            // 
            // LNombree
            // 
            this.LNombree.AutoSize = true;
            this.LNombree.BackColor = System.Drawing.Color.Black;
            this.LNombree.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNombree.ForeColor = System.Drawing.Color.White;
            this.LNombree.Location = new System.Drawing.Point(312, 173);
            this.LNombree.Name = "LNombree";
            this.LNombree.Size = new System.Drawing.Size(60, 17);
            this.LNombree.TabIndex = 2;
            this.LNombree.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.White;
            this.txtNombre.Location = new System.Drawing.Point(447, 170);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(185, 20);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // Lestado
            // 
            this.Lestado.AutoSize = true;
            this.Lestado.BackColor = System.Drawing.Color.Black;
            this.Lestado.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lestado.ForeColor = System.Drawing.Color.White;
            this.Lestado.Location = new System.Drawing.Point(312, 362);
            this.Lestado.Name = "Lestado";
            this.Lestado.Size = new System.Drawing.Size(51, 17);
            this.Lestado.TabIndex = 17;
            this.Lestado.Text = "Estado:";
            // 
            // LApellido
            // 
            this.LApellido.AutoSize = true;
            this.LApellido.BackColor = System.Drawing.Color.Black;
            this.LApellido.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LApellido.ForeColor = System.Drawing.Color.White;
            this.LApellido.Location = new System.Drawing.Point(312, 199);
            this.LApellido.Name = "LApellido";
            this.LApellido.Size = new System.Drawing.Size(59, 17);
            this.LApellido.TabIndex = 3;
            this.LApellido.Text = "Apellido:";
            // 
            // CBRol
            // 
            this.CBRol.BackColor = System.Drawing.Color.White;
            this.CBRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBRol.FormattingEnabled = true;
            this.CBRol.Location = new System.Drawing.Point(447, 326);
            this.CBRol.Name = "CBRol";
            this.CBRol.Size = new System.Drawing.Size(185, 21);
            this.CBRol.TabIndex = 9;
            // 
            // LRol
            // 
            this.LRol.AutoSize = true;
            this.LRol.BackColor = System.Drawing.Color.Black;
            this.LRol.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LRol.ForeColor = System.Drawing.Color.White;
            this.LRol.Location = new System.Drawing.Point(312, 330);
            this.LRol.Name = "LRol";
            this.LRol.Size = new System.Drawing.Size(30, 17);
            this.LRol.TabIndex = 16;
            this.LRol.Text = "Rol:";
            // 
            // TBapellido
            // 
            this.TBapellido.BackColor = System.Drawing.Color.White;
            this.TBapellido.Location = new System.Drawing.Point(447, 196);
            this.TBapellido.Name = "TBapellido";
            this.TBapellido.Size = new System.Drawing.Size(185, 20);
            this.TBapellido.TabIndex = 3;
            this.TBapellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBapellido_KeyPress);
            // 
            // LUsuario
            // 
            this.LUsuario.AutoSize = true;
            this.LUsuario.BackColor = System.Drawing.Color.Black;
            this.LUsuario.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LUsuario.ForeColor = System.Drawing.Color.White;
            this.LUsuario.Location = new System.Drawing.Point(312, 303);
            this.LUsuario.Name = "LUsuario";
            this.LUsuario.Size = new System.Drawing.Size(56, 17);
            this.LUsuario.TabIndex = 4;
            this.LUsuario.Text = "Usuario:";
            // 
            // TBusuario
            // 
            this.TBusuario.BackColor = System.Drawing.Color.White;
            this.TBusuario.Location = new System.Drawing.Point(447, 300);
            this.TBusuario.Name = "TBusuario";
            this.TBusuario.Size = new System.Drawing.Size(185, 20);
            this.TBusuario.TabIndex = 7;
            this.TBusuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBusuario_KeyPress);
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.BackColor = System.Drawing.Color.Black;
            this.lblTel.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTel.ForeColor = System.Drawing.Color.White;
            this.lblTel.Location = new System.Drawing.Point(311, 225);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(62, 17);
            this.lblTel.TabIndex = 23;
            this.lblTel.Text = "Teléfono:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.Color.White;
            this.txtTelefono.Location = new System.Drawing.Point(447, 222);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(185, 20);
            this.txtTelefono.TabIndex = 4;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.BackColor = System.Drawing.Color.White;
            this.txtDomicilio.Location = new System.Drawing.Point(447, 248);
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.Size = new System.Drawing.Size(185, 20);
            this.txtDomicilio.TabIndex = 5;
            // 
            // lblDomicilio
            // 
            this.lblDomicilio.AutoSize = true;
            this.lblDomicilio.BackColor = System.Drawing.Color.Black;
            this.lblDomicilio.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDomicilio.ForeColor = System.Drawing.Color.White;
            this.lblDomicilio.Location = new System.Drawing.Point(311, 251);
            this.lblDomicilio.Name = "lblDomicilio";
            this.lblDomicilio.Size = new System.Drawing.Size(65, 17);
            this.lblDomicilio.TabIndex = 26;
            this.lblDomicilio.Text = "Domicilio:";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.BackColor = System.Drawing.Color.Black;
            this.lblCorreo.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.ForeColor = System.Drawing.Color.White;
            this.lblCorreo.Location = new System.Drawing.Point(311, 274);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(52, 17);
            this.lblCorreo.TabIndex = 27;
            this.lblCorreo.Text = "Correo:";
            // 
            // textCorreo
            // 
            this.textCorreo.BackColor = System.Drawing.Color.White;
            this.textCorreo.Location = new System.Drawing.Point(447, 274);
            this.textCorreo.Name = "textCorreo";
            this.textCorreo.Size = new System.Drawing.Size(185, 20);
            this.textCorreo.TabIndex = 6;
            this.textCorreo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textCorreo_KeyPress);
            // 
            // CBEstado
            // 
            this.CBEstado.BackColor = System.Drawing.Color.White;
            this.CBEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBEstado.FormattingEnabled = true;
            this.CBEstado.Location = new System.Drawing.Point(447, 358);
            this.CBEstado.Name = "CBEstado";
            this.CBEstado.Size = new System.Drawing.Size(185, 21);
            this.CBEstado.TabIndex = 10;
            // 
            // LTitulo
            // 
            this.LTitulo.BackColor = System.Drawing.Color.Transparent;
            this.LTitulo.Font = new System.Drawing.Font("Leelawadee UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTitulo.ForeColor = System.Drawing.Color.Transparent;
            this.LTitulo.Image = ((System.Drawing.Image)(resources.GetObject("LTitulo.Image")));
            this.LTitulo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LTitulo.Location = new System.Drawing.Point(420, 76);
            this.LTitulo.Name = "LTitulo";
            this.LTitulo.Size = new System.Drawing.Size(229, 28);
            this.LTitulo.TabIndex = 0;
            this.LTitulo.Text = "Agregar  de Usuario";
            this.LTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.LightGray;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(202)))), ((int)(((byte)(210)))));
            this.btnCancelar.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = global::CapaPresentacion.Properties.Resources.cruz_pequena;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(504, 425);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(108, 31);
            this.btnCancelar.TabIndex = 12;
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
            this.BtnGuardar.Font = new System.Drawing.Font("Leelawadee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnGuardar.Image = global::CapaPresentacion.Properties.Resources.flecha_de_circulo_de_disquete_a_la_derecha;
            this.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGuardar.Location = new System.Drawing.Point(359, 425);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.BtnGuardar.Size = new System.Drawing.Size(108, 31);
            this.BtnGuardar.TabIndex = 11;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(712, 31);
            this.panel3.TabIndex = 77;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.picCerrar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(676, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(36, 31);
            this.panel2.TabIndex = 75;
            // 
            // picCerrar
            // 
            this.picCerrar.BackColor = System.Drawing.Color.LightGray;
            this.picCerrar.Image = global::CapaPresentacion.Properties.Resources.cruz_pequena;
            this.picCerrar.Location = new System.Drawing.Point(3, 3);
            this.picCerrar.Name = "picCerrar";
            this.picCerrar.Size = new System.Drawing.Size(23, 23);
            this.picCerrar.TabIndex = 75;
            this.picCerrar.TabStop = false;
            this.picCerrar.Click += new System.EventHandler(this.picCerrar_Click_1);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(124, 467);
            this.panel1.TabIndex = 78;
            // 
            // lblContrasena
            // 
            this.lblContrasena.AutoSize = true;
            this.lblContrasena.BackColor = System.Drawing.Color.Black;
            this.lblContrasena.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContrasena.ForeColor = System.Drawing.Color.White;
            this.lblContrasena.Location = new System.Drawing.Point(312, 391);
            this.lblContrasena.Name = "lblContrasena";
            this.lblContrasena.Size = new System.Drawing.Size(77, 17);
            this.lblContrasena.TabIndex = 79;
            this.lblContrasena.Text = "Contraseña:";
            // 
            // TBcontrasena
            // 
            this.TBcontrasena.BackColor = System.Drawing.Color.White;
            this.TBcontrasena.Location = new System.Drawing.Point(447, 391);
            this.TBcontrasena.Name = "TBcontrasena";
            this.TBcontrasena.Size = new System.Drawing.Size(185, 20);
            this.TBcontrasena.TabIndex = 80;
            this.TBcontrasena.TextChanged += new System.EventHandler(this.TBcontrasena_TextChanged);
            this.TBcontrasena.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBcontrasena_KeyPress_1);
            // 
            // AltaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(712, 498);
            this.Controls.Add(this.TBcontrasena);
            this.Controls.Add(this.lblContrasena);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.LTitulo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.CBEstado);
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
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.CBRol);
            this.Controls.Add(this.LApellido);
            this.Controls.Add(this.LRol);
            this.Controls.Add(this.TBapellido);
            this.Controls.Add(this.LUsuario);
            this.Controls.Add(this.TBusuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AltaUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "z";
            this.Load += new System.EventHandler(this.AltaUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LTitulo;
        private System.Windows.Forms.Label LDni;
        private System.Windows.Forms.TextBox TBdni;
        private System.Windows.Forms.Label LNombree;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label Lestado;
        private System.Windows.Forms.Label LApellido;
        private System.Windows.Forms.ComboBox CBRol;
        private System.Windows.Forms.Label LRol;
        private System.Windows.Forms.TextBox TBapellido;
        private System.Windows.Forms.Label LUsuario;
        private System.Windows.Forms.TextBox TBusuario;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtDomicilio;
        private System.Windows.Forms.Label lblDomicilio;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.TextBox textCorreo;
        private System.Windows.Forms.ComboBox CBEstado;
        public System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox picCerrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblContrasena;
        public System.Windows.Forms.TextBox TBcontrasena;
    }
}
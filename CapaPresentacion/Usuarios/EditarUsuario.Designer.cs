namespace CapaPresentacion.Usuarios
{
    partial class EditarUsuario
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblid = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.picCerrar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // LTitulo
            // 
            this.LTitulo.BackColor = System.Drawing.Color.Transparent;
            this.LTitulo.Font = new System.Drawing.Font("Leelawadee UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTitulo.ForeColor = System.Drawing.Color.Transparent;
            this.LTitulo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LTitulo.Location = new System.Drawing.Point(459, 89);
            this.LTitulo.Name = "LTitulo";
            this.LTitulo.Size = new System.Drawing.Size(173, 28);
            this.LTitulo.TabIndex = 0;
            this.LTitulo.Text = "Editar Usuario";
            this.LTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.btnCancelar.Location = new System.Drawing.Point(537, 431);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(111, 31);
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
            this.BtnGuardar.Location = new System.Drawing.Point(406, 431);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.BtnGuardar.Size = new System.Drawing.Size(111, 31);
            this.BtnGuardar.TabIndex = 11;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.White;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(463, 370);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(185, 21);
            this.comboBox1.TabIndex = 10;
            // 
            // textCorreo
            // 
            this.textCorreo.BackColor = System.Drawing.Color.White;
            this.textCorreo.Location = new System.Drawing.Point(463, 266);
            this.textCorreo.Name = "textCorreo";
            this.textCorreo.Size = new System.Drawing.Size(185, 20);
            this.textCorreo.TabIndex = 6;
            this.textCorreo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textCorreo_KeyPress);
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.BackColor = System.Drawing.Color.Black;
            this.lblCorreo.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.ForeColor = System.Drawing.Color.White;
            this.lblCorreo.Location = new System.Drawing.Point(324, 266);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(52, 17);
            this.lblCorreo.TabIndex = 53;
            this.lblCorreo.Text = "Correo:";
            // 
            // lblDomicilio
            // 
            this.lblDomicilio.AutoSize = true;
            this.lblDomicilio.BackColor = System.Drawing.Color.Black;
            this.lblDomicilio.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDomicilio.ForeColor = System.Drawing.Color.White;
            this.lblDomicilio.Location = new System.Drawing.Point(324, 241);
            this.lblDomicilio.Name = "lblDomicilio";
            this.lblDomicilio.Size = new System.Drawing.Size(65, 17);
            this.lblDomicilio.TabIndex = 52;
            this.lblDomicilio.Text = "Domicilio:";
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.BackColor = System.Drawing.Color.White;
            this.txtDomicilio.Location = new System.Drawing.Point(463, 241);
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.Size = new System.Drawing.Size(185, 20);
            this.txtDomicilio.TabIndex = 5;
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.Color.White;
            this.txtTelefono.Location = new System.Drawing.Point(463, 216);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(185, 20);
            this.txtTelefono.TabIndex = 4;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.BackColor = System.Drawing.Color.Black;
            this.lblTel.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTel.ForeColor = System.Drawing.Color.White;
            this.lblTel.Location = new System.Drawing.Point(324, 216);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(62, 17);
            this.lblTel.TabIndex = 49;
            this.lblTel.Text = "Teléfono:";
            // 
            // TBdni
            // 
            this.TBdni.BackColor = System.Drawing.Color.White;
            this.TBdni.Location = new System.Drawing.Point(463, 138);
            this.TBdni.Name = "TBdni";
            this.TBdni.Size = new System.Drawing.Size(185, 20);
            this.TBdni.TabIndex = 1;
            this.TBdni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBdni_KeyPress);
            // 
            // LDni
            // 
            this.LDni.AutoSize = true;
            this.LDni.BackColor = System.Drawing.Color.Black;
            this.LDni.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDni.ForeColor = System.Drawing.Color.White;
            this.LDni.Location = new System.Drawing.Point(324, 138);
            this.LDni.Name = "LDni";
            this.LDni.Size = new System.Drawing.Size(115, 17);
            this.LDni.TabIndex = 36;
            this.LDni.Text = "N° de documento:";
            // 
            // LNombree
            // 
            this.LNombree.AutoSize = true;
            this.LNombree.BackColor = System.Drawing.Color.Black;
            this.LNombree.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNombree.ForeColor = System.Drawing.Color.White;
            this.LNombree.Location = new System.Drawing.Point(324, 164);
            this.LNombree.Name = "LNombree";
            this.LNombree.Size = new System.Drawing.Size(60, 17);
            this.LNombree.TabIndex = 37;
            this.LNombree.Text = "Nombre:";
            // 
            // Lestado
            // 
            this.Lestado.AutoSize = true;
            this.Lestado.BackColor = System.Drawing.Color.Black;
            this.Lestado.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lestado.ForeColor = System.Drawing.Color.White;
            this.Lestado.Location = new System.Drawing.Point(324, 372);
            this.Lestado.Name = "Lestado";
            this.Lestado.Size = new System.Drawing.Size(51, 17);
            this.Lestado.TabIndex = 48;
            this.Lestado.Text = "Estado:";
            // 
            // TBNombree
            // 
            this.TBNombree.BackColor = System.Drawing.Color.White;
            this.TBNombree.Location = new System.Drawing.Point(463, 164);
            this.TBNombree.Name = "TBNombree";
            this.TBNombree.Size = new System.Drawing.Size(185, 20);
            this.TBNombree.TabIndex = 2;
            this.TBNombree.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBNombree_KeyPress);
            // 
            // CBRol
            // 
            this.CBRol.BackColor = System.Drawing.Color.White;
            this.CBRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBRol.FormattingEnabled = true;
            this.CBRol.Location = new System.Drawing.Point(463, 342);
            this.CBRol.Name = "CBRol";
            this.CBRol.Size = new System.Drawing.Size(185, 21);
            this.CBRol.TabIndex = 9;
            // 
            // LApellido
            // 
            this.LApellido.AutoSize = true;
            this.LApellido.BackColor = System.Drawing.Color.Black;
            this.LApellido.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LApellido.ForeColor = System.Drawing.Color.White;
            this.LApellido.Location = new System.Drawing.Point(324, 190);
            this.LApellido.Name = "LApellido";
            this.LApellido.Size = new System.Drawing.Size(59, 17);
            this.LApellido.TabIndex = 38;
            this.LApellido.Text = "Apellido:";
            // 
            // LRol
            // 
            this.LRol.AutoSize = true;
            this.LRol.BackColor = System.Drawing.Color.Black;
            this.LRol.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LRol.ForeColor = System.Drawing.Color.White;
            this.LRol.Location = new System.Drawing.Point(324, 345);
            this.LRol.Name = "LRol";
            this.LRol.Size = new System.Drawing.Size(30, 17);
            this.LRol.TabIndex = 47;
            this.LRol.Text = "Rol:";
            // 
            // TBapellido
            // 
            this.TBapellido.BackColor = System.Drawing.Color.White;
            this.TBapellido.Location = new System.Drawing.Point(463, 190);
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
            this.LUsuario.Location = new System.Drawing.Point(324, 291);
            this.LUsuario.Name = "LUsuario";
            this.LUsuario.Size = new System.Drawing.Size(56, 17);
            this.LUsuario.TabIndex = 39;
            this.LUsuario.Text = "Usuario:";
            // 
            // TBusuario
            // 
            this.TBusuario.BackColor = System.Drawing.Color.White;
            this.TBusuario.Location = new System.Drawing.Point(463, 291);
            this.TBusuario.Name = "TBusuario";
            this.TBusuario.Size = new System.Drawing.Size(185, 20);
            this.TBusuario.TabIndex = 7;
            this.TBusuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBusuario_KeyPress);
            // 
            // TBcontrasena
            // 
            this.TBcontrasena.BackColor = System.Drawing.Color.White;
            this.TBcontrasena.Location = new System.Drawing.Point(463, 317);
            this.TBcontrasena.Name = "TBcontrasena";
            this.TBcontrasena.Size = new System.Drawing.Size(185, 20);
            this.TBcontrasena.TabIndex = 8;
            this.TBcontrasena.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBcontrasena_KeyPress);
            // 
            // LContrasena
            // 
            this.LContrasena.AutoSize = true;
            this.LContrasena.BackColor = System.Drawing.Color.Black;
            this.LContrasena.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LContrasena.ForeColor = System.Drawing.Color.White;
            this.LContrasena.Location = new System.Drawing.Point(324, 316);
            this.LContrasena.Name = "LContrasena";
            this.LContrasena.Size = new System.Drawing.Size(77, 17);
            this.LContrasena.TabIndex = 40;
            this.LContrasena.Text = "Contraseña:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.BackColor = System.Drawing.Color.Black;
            this.lblid.Location = new System.Drawing.Point(460, 58);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(19, 13);
            this.lblid.TabIndex = 60;
            this.lblid.Text = "----";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(124, 498);
            this.panel1.TabIndex = 79;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(124, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(588, 31);
            this.panel3.TabIndex = 80;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.picCerrar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(552, 0);
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
            // EditarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(712, 498);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.LTitulo);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditarUsuario";
            this.Load += new System.EventHandler(this.EditarUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LTitulo;
        private System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblDomicilio;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label LDni;
        private System.Windows.Forms.Label LNombree;
        private System.Windows.Forms.Label Lestado;
        private System.Windows.Forms.Label LApellido;
        private System.Windows.Forms.Label LRol;
        private System.Windows.Forms.Label LUsuario;
        private System.Windows.Forms.Label LContrasena;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        public System.Windows.Forms.TextBox textCorreo;
        public System.Windows.Forms.TextBox txtDomicilio;
        public System.Windows.Forms.TextBox txtTelefono;
        public System.Windows.Forms.TextBox TBdni;
        public System.Windows.Forms.TextBox TBNombree;
        public System.Windows.Forms.TextBox TBapellido;
        public System.Windows.Forms.TextBox TBusuario;
        public System.Windows.Forms.TextBox TBcontrasena;
        public System.Windows.Forms.ComboBox comboBox1;
        public System.Windows.Forms.ComboBox CBRol;
        public System.Windows.Forms.Label lblid;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox picCerrar;
    }
}
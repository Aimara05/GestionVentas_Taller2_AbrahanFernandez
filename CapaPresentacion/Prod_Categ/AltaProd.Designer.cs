namespace CapaPresentacion.Prod_Categ
{
    partial class AltaProd
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
            this.LTitulo = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.CBEstado = new System.Windows.Forms.ComboBox();
            this.lblDomicilio = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.lblTel = new System.Windows.Forms.Label();
            this.LNombree = new System.Windows.Forms.Label();
            this.Lestado = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.CBcateg = new System.Windows.Forms.ComboBox();
            this.LApellido = new System.Windows.Forms.Label();
            this.LRol = new System.Windows.Forms.Label();
            this.txtDescr = new System.Windows.Forms.TextBox();
            this.Marca = new System.Windows.Forms.Label();
            this.CBMarca = new System.Windows.Forms.ComboBox();
            this.txtImagen = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.picCerrar = new System.Windows.Forms.PictureBox();
            this.picImgProd = new System.Windows.Forms.PictureBox();
            this.btnImgProd = new System.Windows.Forms.Button();
            this.lblTalle = new System.Windows.Forms.Label();
            this.txtTalle = new System.Windows.Forms.TextBox();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImgProd)).BeginInit();
            this.SuspendLayout();
            // 
            // LTitulo
            // 
            this.LTitulo.BackColor = System.Drawing.Color.Transparent;
            this.LTitulo.Font = new System.Drawing.Font("Leelawadee UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTitulo.ForeColor = System.Drawing.Color.Transparent;
            this.LTitulo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LTitulo.Location = new System.Drawing.Point(313, 63);
            this.LTitulo.Name = "LTitulo";
            this.LTitulo.Size = new System.Drawing.Size(223, 31);
            this.LTitulo.TabIndex = 0;
            this.LTitulo.Text = "Agregar   Producto";
            this.LTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LTitulo.Click += new System.EventHandler(this.LTitulo_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.LightGray;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(202)))), ((int)(((byte)(210)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = global::CapaPresentacion.Properties.Resources.cruz_pequena1;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(408, 423);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(108, 31);
            this.btnCancelar.TabIndex = 11;
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
            this.BtnGuardar.Location = new System.Drawing.Point(262, 424);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.BtnGuardar.Size = new System.Drawing.Size(108, 31);
            this.BtnGuardar.TabIndex = 10;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // CBEstado
            // 
            this.CBEstado.BackColor = System.Drawing.Color.White;
            this.CBEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBEstado.FormattingEnabled = true;
            this.CBEstado.Location = new System.Drawing.Point(318, 363);
            this.CBEstado.Name = "CBEstado";
            this.CBEstado.Size = new System.Drawing.Size(185, 21);
            this.CBEstado.TabIndex = 8;
            // 
            // lblDomicilio
            // 
            this.lblDomicilio.AutoSize = true;
            this.lblDomicilio.BackColor = System.Drawing.Color.Black;
            this.lblDomicilio.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDomicilio.ForeColor = System.Drawing.Color.White;
            this.lblDomicilio.Location = new System.Drawing.Point(179, 250);
            this.lblDomicilio.Name = "lblDomicilio";
            this.lblDomicilio.Size = new System.Drawing.Size(47, 17);
            this.lblDomicilio.TabIndex = 52;
            this.lblDomicilio.Text = "Precio:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.BackColor = System.Drawing.Color.White;
            this.txtPrecio.Location = new System.Drawing.Point(318, 247);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(185, 20);
            this.txtPrecio.TabIndex = 5;
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // txtStock
            // 
            this.txtStock.BackColor = System.Drawing.Color.White;
            this.txtStock.Location = new System.Drawing.Point(318, 210);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(185, 20);
            this.txtStock.TabIndex = 4;
            this.txtStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStock_KeyPress);
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.BackColor = System.Drawing.Color.Black;
            this.lblTel.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTel.ForeColor = System.Drawing.Color.White;
            this.lblTel.Location = new System.Drawing.Point(179, 212);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(42, 17);
            this.lblTel.TabIndex = 49;
            this.lblTel.Text = "Stock:";
            // 
            // LNombree
            // 
            this.LNombree.AutoSize = true;
            this.LNombree.BackColor = System.Drawing.Color.Black;
            this.LNombree.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNombree.ForeColor = System.Drawing.Color.White;
            this.LNombree.Location = new System.Drawing.Point(179, 121);
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
            this.Lestado.Location = new System.Drawing.Point(179, 367);
            this.Lestado.Name = "Lestado";
            this.Lestado.Size = new System.Drawing.Size(51, 17);
            this.Lestado.TabIndex = 48;
            this.Lestado.Text = "Estado:";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.White;
            this.txtNombre.Location = new System.Drawing.Point(318, 121);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(185, 20);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // CBcateg
            // 
            this.CBcateg.BackColor = System.Drawing.Color.White;
            this.CBcateg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBcateg.FormattingEnabled = true;
            this.CBcateg.Location = new System.Drawing.Point(318, 282);
            this.CBcateg.Name = "CBcateg";
            this.CBcateg.Size = new System.Drawing.Size(185, 21);
            this.CBcateg.TabIndex = 6;
            // 
            // LApellido
            // 
            this.LApellido.AutoSize = true;
            this.LApellido.BackColor = System.Drawing.Color.Black;
            this.LApellido.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LApellido.ForeColor = System.Drawing.Color.White;
            this.LApellido.Location = new System.Drawing.Point(179, 158);
            this.LApellido.Name = "LApellido";
            this.LApellido.Size = new System.Drawing.Size(79, 17);
            this.LApellido.TabIndex = 38;
            this.LApellido.Text = "Descripción:";
            // 
            // LRol
            // 
            this.LRol.AutoSize = true;
            this.LRol.BackColor = System.Drawing.Color.Black;
            this.LRol.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LRol.ForeColor = System.Drawing.Color.White;
            this.LRol.Location = new System.Drawing.Point(179, 286);
            this.LRol.Name = "LRol";
            this.LRol.Size = new System.Drawing.Size(65, 17);
            this.LRol.TabIndex = 47;
            this.LRol.Text = "Categoría";
            // 
            // txtDescr
            // 
            this.txtDescr.BackColor = System.Drawing.Color.White;
            this.txtDescr.Location = new System.Drawing.Point(318, 157);
            this.txtDescr.Name = "txtDescr";
            this.txtDescr.Size = new System.Drawing.Size(185, 20);
            this.txtDescr.TabIndex = 2;
            // 
            // Marca
            // 
            this.Marca.AutoSize = true;
            this.Marca.BackColor = System.Drawing.Color.Black;
            this.Marca.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Marca.ForeColor = System.Drawing.Color.White;
            this.Marca.Location = new System.Drawing.Point(179, 324);
            this.Marca.Name = "Marca";
            this.Marca.Size = new System.Drawing.Size(45, 17);
            this.Marca.TabIndex = 58;
            this.Marca.Text = "Marca";
            // 
            // CBMarca
            // 
            this.CBMarca.BackColor = System.Drawing.Color.White;
            this.CBMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBMarca.FormattingEnabled = true;
            this.CBMarca.Location = new System.Drawing.Point(318, 320);
            this.CBMarca.Name = "CBMarca";
            this.CBMarca.Size = new System.Drawing.Size(185, 21);
            this.CBMarca.TabIndex = 7;
            this.CBMarca.SelectedIndexChanged += new System.EventHandler(this.CBMarca_SelectedIndexChanged);
            // 
            // txtImagen
            // 
            this.txtImagen.BackColor = System.Drawing.Color.Black;
            this.txtImagen.Location = new System.Drawing.Point(561, 354);
            this.txtImagen.Name = "txtImagen";
            this.txtImagen.Size = new System.Drawing.Size(131, 20);
            this.txtImagen.TabIndex = 0;
            this.txtImagen.TabStop = false;
            this.txtImagen.Visible = false;
            this.txtImagen.TextChanged += new System.EventHandler(this.txtImagen_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(124, 498);
            this.panel1.TabIndex = 75;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(124, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(588, 31);
            this.panel3.TabIndex = 76;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
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
            this.picCerrar.Location = new System.Drawing.Point(6, 5);
            this.picCerrar.Name = "picCerrar";
            this.picCerrar.Size = new System.Drawing.Size(23, 23);
            this.picCerrar.TabIndex = 75;
            this.picCerrar.TabStop = false;
            this.picCerrar.Click += new System.EventHandler(this.picCerrar_Click);
            // 
            // picImgProd
            // 
            this.picImgProd.Location = new System.Drawing.Point(541, 140);
            this.picImgProd.Name = "picImgProd";
            this.picImgProd.Size = new System.Drawing.Size(164, 127);
            this.picImgProd.TabIndex = 77;
            this.picImgProd.TabStop = false;
            // 
            // btnImgProd
            // 
            this.btnImgProd.Location = new System.Drawing.Point(561, 311);
            this.btnImgProd.Name = "btnImgProd";
            this.btnImgProd.Size = new System.Drawing.Size(131, 37);
            this.btnImgProd.TabIndex = 9;
            this.btnImgProd.Text = "Imagen";
            this.btnImgProd.UseVisualStyleBackColor = true;
            this.btnImgProd.Click += new System.EventHandler(this.btnImgProd_Click);
            // 
            // lblTalle
            // 
            this.lblTalle.AutoSize = true;
            this.lblTalle.BackColor = System.Drawing.Color.Black;
            this.lblTalle.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTalle.ForeColor = System.Drawing.Color.White;
            this.lblTalle.Location = new System.Drawing.Point(179, 184);
            this.lblTalle.Name = "lblTalle";
            this.lblTalle.Size = new System.Drawing.Size(38, 17);
            this.lblTalle.TabIndex = 79;
            this.lblTalle.Text = "Talle:";
            this.lblTalle.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtTalle
            // 
            this.txtTalle.BackColor = System.Drawing.Color.White;
            this.txtTalle.Location = new System.Drawing.Point(318, 183);
            this.txtTalle.Name = "txtTalle";
            this.txtTalle.Size = new System.Drawing.Size(185, 20);
            this.txtTalle.TabIndex = 3;
            this.txtTalle.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // AltaProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(712, 498);
            this.Controls.Add(this.lblTalle);
            this.Controls.Add(this.txtTalle);
            this.Controls.Add(this.btnImgProd);
            this.Controls.Add(this.picImgProd);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtImagen);
            this.Controls.Add(this.LTitulo);
            this.Controls.Add(this.CBMarca);
            this.Controls.Add(this.Marca);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.CBEstado);
            this.Controls.Add(this.lblDomicilio);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.LNombree);
            this.Controls.Add(this.Lestado);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.CBcateg);
            this.Controls.Add(this.LApellido);
            this.Controls.Add(this.LRol);
            this.Controls.Add(this.txtDescr);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AltaProd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AltaProd";
            this.Load += new System.EventHandler(this.AltaProd_Load);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImgProd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LTitulo;
        private System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.ComboBox CBEstado;
        private System.Windows.Forms.Label lblDomicilio;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label LNombree;
        private System.Windows.Forms.Label Lestado;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox CBcateg;
        private System.Windows.Forms.Label LApellido;
        private System.Windows.Forms.Label LRol;
        private System.Windows.Forms.TextBox txtDescr;
        private System.Windows.Forms.Label Marca;
        private System.Windows.Forms.TextBox txtImagen;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox picCerrar;
        private System.Windows.Forms.PictureBox picImgProd;
        private System.Windows.Forms.Button btnImgProd;
        public System.Windows.Forms.ComboBox CBMarca;
        private System.Windows.Forms.Label lblTalle;
        private System.Windows.Forms.TextBox txtTalle;
    }
}
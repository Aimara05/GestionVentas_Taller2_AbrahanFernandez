﻿namespace CapaPresentacion.Prod_Categ
{
    partial class EditarProd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarProd));
            this.LTitulo = new System.Windows.Forms.Label();
            this.CBEstado = new System.Windows.Forms.ComboBox();
            this.lblDomicilio = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.lblTel = new System.Windows.Forms.Label();
            this.LNombree = new System.Windows.Forms.Label();
            this.Lestado = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.CBRol = new System.Windows.Forms.ComboBox();
            this.LApellido = new System.Windows.Forms.Label();
            this.LRol = new System.Windows.Forms.Label();
            this.TBdescr = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.lblidprod = new System.Windows.Forms.Label();
            this.CbMarca = new System.Windows.Forms.ComboBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.txtTalle = new System.Windows.Forms.TextBox();
            this.lbltalle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.picCerrar = new System.Windows.Forms.PictureBox();
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
            this.LTitulo.Image = global::CapaPresentacion.Properties.Resources.editar;
            this.LTitulo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LTitulo.Location = new System.Drawing.Point(392, 61);
            this.LTitulo.Name = "LTitulo";
            this.LTitulo.Size = new System.Drawing.Size(197, 31);
            this.LTitulo.TabIndex = 22;
            this.LTitulo.Text = "Editar  Producto";
            this.LTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CBEstado
            // 
            this.CBEstado.BackColor = System.Drawing.Color.White;
            this.CBEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBEstado.FormattingEnabled = true;
            this.CBEstado.Location = new System.Drawing.Point(463, 382);
            this.CBEstado.Name = "CBEstado";
            this.CBEstado.Size = new System.Drawing.Size(185, 21);
            this.CBEstado.TabIndex = 71;
            // 
            // lblDomicilio
            // 
            this.lblDomicilio.AutoSize = true;
            this.lblDomicilio.BackColor = System.Drawing.Color.Black;
            this.lblDomicilio.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDomicilio.ForeColor = System.Drawing.Color.White;
            this.lblDomicilio.Location = new System.Drawing.Point(336, 268);
            this.lblDomicilio.Name = "lblDomicilio";
            this.lblDomicilio.Size = new System.Drawing.Size(47, 17);
            this.lblDomicilio.TabIndex = 70;
            this.lblDomicilio.Text = "Precio:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.BackColor = System.Drawing.Color.White;
            this.txtPrecio.Location = new System.Drawing.Point(463, 268);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(185, 20);
            this.txtPrecio.TabIndex = 69;
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // txtStock
            // 
            this.txtStock.BackColor = System.Drawing.Color.White;
            this.txtStock.Location = new System.Drawing.Point(463, 232);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(185, 20);
            this.txtStock.TabIndex = 68;
            this.txtStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStock_KeyPress);
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.BackColor = System.Drawing.Color.Black;
            this.lblTel.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTel.ForeColor = System.Drawing.Color.White;
            this.lblTel.Location = new System.Drawing.Point(336, 232);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(42, 17);
            this.lblTel.TabIndex = 67;
            this.lblTel.Text = "Stock:";
            // 
            // LNombree
            // 
            this.LNombree.AutoSize = true;
            this.LNombree.BackColor = System.Drawing.Color.Black;
            this.LNombree.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNombree.ForeColor = System.Drawing.Color.White;
            this.LNombree.Location = new System.Drawing.Point(336, 128);
            this.LNombree.Name = "LNombree";
            this.LNombree.Size = new System.Drawing.Size(60, 17);
            this.LNombree.TabIndex = 59;
            this.LNombree.Text = "Nombre:";
            // 
            // Lestado
            // 
            this.Lestado.AutoSize = true;
            this.Lestado.BackColor = System.Drawing.Color.Black;
            this.Lestado.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lestado.ForeColor = System.Drawing.Color.White;
            this.Lestado.Location = new System.Drawing.Point(336, 386);
            this.Lestado.Name = "Lestado";
            this.Lestado.Size = new System.Drawing.Size(51, 17);
            this.Lestado.TabIndex = 66;
            this.Lestado.Text = "Estado:";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.White;
            this.txtNombre.Location = new System.Drawing.Point(463, 125);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(185, 20);
            this.txtNombre.TabIndex = 62;
            // 
            // CBRol
            // 
            this.CBRol.BackColor = System.Drawing.Color.White;
            this.CBRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBRol.FormattingEnabled = true;
            this.CBRol.Location = new System.Drawing.Point(463, 342);
            this.CBRol.Name = "CBRol";
            this.CBRol.Size = new System.Drawing.Size(185, 21);
            this.CBRol.TabIndex = 64;
            // 
            // LApellido
            // 
            this.LApellido.AutoSize = true;
            this.LApellido.BackColor = System.Drawing.Color.Black;
            this.LApellido.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LApellido.ForeColor = System.Drawing.Color.White;
            this.LApellido.Location = new System.Drawing.Point(336, 160);
            this.LApellido.Name = "LApellido";
            this.LApellido.Size = new System.Drawing.Size(79, 17);
            this.LApellido.TabIndex = 60;
            this.LApellido.Text = "Descripción:";
            // 
            // LRol
            // 
            this.LRol.AutoSize = true;
            this.LRol.BackColor = System.Drawing.Color.Black;
            this.LRol.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LRol.ForeColor = System.Drawing.Color.White;
            this.LRol.Location = new System.Drawing.Point(331, 346);
            this.LRol.Name = "LRol";
            this.LRol.Size = new System.Drawing.Size(65, 17);
            this.LRol.TabIndex = 65;
            this.LRol.Text = "Categoría";
            // 
            // TBdescr
            // 
            this.TBdescr.BackColor = System.Drawing.Color.White;
            this.TBdescr.Location = new System.Drawing.Point(463, 160);
            this.TBdescr.Name = "TBdescr";
            this.TBdescr.Size = new System.Drawing.Size(185, 20);
            this.TBdescr.TabIndex = 63;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.LightGray;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(202)))), ((int)(((byte)(210)))));
            this.btnCancelar.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(518, 427);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(113, 31);
            this.btnCancelar.TabIndex = 73;
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
            this.BtnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("BtnGuardar.Image")));
            this.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGuardar.Location = new System.Drawing.Point(383, 428);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.BtnGuardar.Size = new System.Drawing.Size(113, 31);
            this.BtnGuardar.TabIndex = 72;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // lblidprod
            // 
            this.lblidprod.AutoSize = true;
            this.lblidprod.Location = new System.Drawing.Point(310, 78);
            this.lblidprod.Name = "lblidprod";
            this.lblidprod.Size = new System.Drawing.Size(35, 13);
            this.lblidprod.TabIndex = 87;
            this.lblidprod.Text = "label1";
            this.lblidprod.Visible = false;
            // 
            // CbMarca
            // 
            this.CbMarca.BackColor = System.Drawing.Color.White;
            this.CbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbMarca.FormattingEnabled = true;
            this.CbMarca.Location = new System.Drawing.Point(463, 305);
            this.CbMarca.Name = "CbMarca";
            this.CbMarca.Size = new System.Drawing.Size(185, 21);
            this.CbMarca.TabIndex = 88;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.BackColor = System.Drawing.Color.Black;
            this.lblMarca.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.ForeColor = System.Drawing.Color.White;
            this.lblMarca.Location = new System.Drawing.Point(336, 309);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(45, 17);
            this.lblMarca.TabIndex = 89;
            this.lblMarca.Text = "Marca";
            // 
            // txtTalle
            // 
            this.txtTalle.BackColor = System.Drawing.Color.White;
            this.txtTalle.Location = new System.Drawing.Point(463, 197);
            this.txtTalle.Name = "txtTalle";
            this.txtTalle.Size = new System.Drawing.Size(185, 20);
            this.txtTalle.TabIndex = 91;
            // 
            // lbltalle
            // 
            this.lbltalle.AutoSize = true;
            this.lbltalle.BackColor = System.Drawing.Color.Black;
            this.lbltalle.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltalle.ForeColor = System.Drawing.Color.White;
            this.lbltalle.Location = new System.Drawing.Point(336, 197);
            this.lbltalle.Name = "lbltalle";
            this.lbltalle.Size = new System.Drawing.Size(38, 17);
            this.lbltalle.TabIndex = 90;
            this.lbltalle.Text = "Talle:";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(171, 498);
            this.panel1.TabIndex = 85;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(171, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(541, 31);
            this.panel3.TabIndex = 86;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.picCerrar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(501, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(40, 31);
            this.panel2.TabIndex = 0;
            // 
            // picCerrar
            // 
            this.picCerrar.BackColor = System.Drawing.Color.LightGray;
            this.picCerrar.Image = global::CapaPresentacion.Properties.Resources.cruz_pequena;
            this.picCerrar.Location = new System.Drawing.Point(12, 5);
            this.picCerrar.Name = "picCerrar";
            this.picCerrar.Size = new System.Drawing.Size(23, 23);
            this.picCerrar.TabIndex = 76;
            this.picCerrar.TabStop = false;
            this.picCerrar.Click += new System.EventHandler(this.picCerrar_Click);
            // 
            // EditarProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(712, 498);
            this.Controls.Add(this.txtTalle);
            this.Controls.Add(this.lbltalle);
            this.Controls.Add(this.CbMarca);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblidprod);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.LTitulo);
            this.Controls.Add(this.CBEstado);
            this.Controls.Add(this.lblDomicilio);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.LNombree);
            this.Controls.Add(this.Lestado);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.CBRol);
            this.Controls.Add(this.LApellido);
            this.Controls.Add(this.LRol);
            this.Controls.Add(this.TBdescr);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditarProd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditarProd";
            this.Load += new System.EventHandler(this.EditarProd_Load);
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
        private System.Windows.Forms.Label lblDomicilio;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label LNombree;
        private System.Windows.Forms.Label Lestado;
        private System.Windows.Forms.Label LApellido;
        private System.Windows.Forms.Label LRol;
        public System.Windows.Forms.Label lblidprod;
        public System.Windows.Forms.ComboBox CBEstado;
        public System.Windows.Forms.TextBox txtPrecio;
        public System.Windows.Forms.TextBox txtStock;
        public System.Windows.Forms.TextBox txtNombre;
        public System.Windows.Forms.ComboBox CBRol;
        public System.Windows.Forms.TextBox TBdescr;
        public System.Windows.Forms.ComboBox CbMarca;
        private System.Windows.Forms.Label lblMarca;
        public System.Windows.Forms.TextBox txtTalle;
        private System.Windows.Forms.Label lbltalle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox picCerrar;
        private System.Windows.Forms.Panel panel2;
    }
}
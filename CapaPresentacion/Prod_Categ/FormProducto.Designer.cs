namespace CapaPresentacion
{
    partial class FormProducto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTopProd = new System.Windows.Forms.Panel();
            this.panelLogoTit = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblTituloProd = new System.Windows.Forms.Label();
            this.picUsuario = new System.Windows.Forms.PictureBox();
            this.panelBuscador = new System.Windows.Forms.Panel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.cboBusqueda = new System.Windows.Forms.ComboBox();
            this.panelRigtUsuario = new System.Windows.Forms.Panel();
            this.btnAltaProd = new System.Windows.Forms.Button();
            this.btnBajaUsuario = new System.Windows.Forms.Button();
            this.btnEditarProd = new System.Windows.Forms.Button();
            this.btnAgregarProd = new System.Windows.Forms.Button();
            this.dataGridUsuario = new System.Windows.Forms.DataGridView();
            this.btnSeleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.idProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCateg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelTopProd.SuspendLayout();
            this.panelLogoTit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUsuario)).BeginInit();
            this.panelBuscador.SuspendLayout();
            this.panelRigtUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTopProd
            // 
            this.panelTopProd.BackColor = System.Drawing.Color.LightGray;
            this.panelTopProd.Controls.Add(this.panelLogoTit);
            this.panelTopProd.Controls.Add(this.panelBuscador);
            this.panelTopProd.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopProd.Font = new System.Drawing.Font("Leelawadee UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelTopProd.Location = new System.Drawing.Point(0, 0);
            this.panelTopProd.Name = "panelTopProd";
            this.panelTopProd.Size = new System.Drawing.Size(1124, 107);
            this.panelTopProd.TabIndex = 1;
            // 
            // panelLogoTit
            // 
            this.panelLogoTit.Controls.Add(this.btnRefresh);
            this.panelLogoTit.Controls.Add(this.lblTituloProd);
            this.panelLogoTit.Controls.Add(this.picUsuario);
            this.panelLogoTit.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelLogoTit.Location = new System.Drawing.Point(847, 0);
            this.panelLogoTit.Name = "panelLogoTit";
            this.panelLogoTit.Size = new System.Drawing.Size(277, 107);
            this.panelLogoTit.TabIndex = 27;
            // 
            // btnRefresh
            // 
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Image = global::CapaPresentacion.Properties.Resources.recargar;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.Location = new System.Drawing.Point(96, 35);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(34, 38);
            this.btnRefresh.TabIndex = 7;
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // lblTituloProd
            // 
            this.lblTituloProd.AutoSize = true;
            this.lblTituloProd.Location = new System.Drawing.Point(3, 41);
            this.lblTituloProd.Name = "lblTituloProd";
            this.lblTituloProd.Size = new System.Drawing.Size(97, 25);
            this.lblTituloProd.TabIndex = 1;
            this.lblTituloProd.Text = "Productos";
            // 
            // picUsuario
            // 
            this.picUsuario.BackColor = System.Drawing.Color.LightGray;
            this.picUsuario.Image = global::CapaPresentacion.Properties.Resources.wishlist_product_list_order_cart_icon_225172;
            this.picUsuario.Location = new System.Drawing.Point(170, 12);
            this.picUsuario.Name = "picUsuario";
            this.picUsuario.Padding = new System.Windows.Forms.Padding(0, 0, 40, 0);
            this.picUsuario.Size = new System.Drawing.Size(89, 89);
            this.picUsuario.TabIndex = 0;
            this.picUsuario.TabStop = false;
            // 
            // panelBuscador
            // 
            this.panelBuscador.BackColor = System.Drawing.Color.Transparent;
            this.panelBuscador.Controls.Add(this.btnBuscar);
            this.panelBuscador.Controls.Add(this.textBox1);
            this.panelBuscador.Controls.Add(this.txtBusqueda);
            this.panelBuscador.Controls.Add(this.cboBusqueda);
            this.panelBuscador.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelBuscador.Location = new System.Drawing.Point(0, 0);
            this.panelBuscador.Name = "panelBuscador";
            this.panelBuscador.Size = new System.Drawing.Size(425, 107);
            this.panelBuscador.TabIndex = 26;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Silver;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(202)))), ((int)(((byte)(210)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.Black;
            this.btnBuscar.Image = global::CapaPresentacion.Properties.Resources.busqueda;
            this.btnBuscar.Location = new System.Drawing.Point(397, 48);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(25, 22);
            this.btnBuscar.TabIndex = 25;
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.LightGray;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(11, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(106, 26);
            this.textBox1.TabIndex = 25;
            this.textBox1.Text = "Buscar por :";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusqueda.Location = new System.Drawing.Point(247, 45);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(144, 25);
            this.txtBusqueda.TabIndex = 28;
            // 
            // cboBusqueda
            // 
            this.cboBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBusqueda.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBusqueda.FormattingEnabled = true;
            this.cboBusqueda.Location = new System.Drawing.Point(123, 45);
            this.cboBusqueda.Name = "cboBusqueda";
            this.cboBusqueda.Size = new System.Drawing.Size(118, 25);
            this.cboBusqueda.TabIndex = 27;
            // 
            // panelRigtUsuario
            // 
            this.panelRigtUsuario.BackColor = System.Drawing.Color.LightGray;
            this.panelRigtUsuario.Controls.Add(this.btnAltaProd);
            this.panelRigtUsuario.Controls.Add(this.btnBajaUsuario);
            this.panelRigtUsuario.Controls.Add(this.btnEditarProd);
            this.panelRigtUsuario.Controls.Add(this.btnAgregarProd);
            this.panelRigtUsuario.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRigtUsuario.Location = new System.Drawing.Point(921, 107);
            this.panelRigtUsuario.Name = "panelRigtUsuario";
            this.panelRigtUsuario.Size = new System.Drawing.Size(203, 404);
            this.panelRigtUsuario.TabIndex = 2;
            // 
            // btnAltaProd
            // 
            this.btnAltaProd.BackColor = System.Drawing.Color.LightGray;
            this.btnAltaProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAltaProd.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnAltaProd.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnAltaProd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(202)))), ((int)(((byte)(210)))));
            this.btnAltaProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAltaProd.Font = new System.Drawing.Font("Leelawadee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAltaProd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAltaProd.Image = global::CapaPresentacion.Properties.Resources.checkbox_ckeck_icon_143039;
            this.btnAltaProd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAltaProd.Location = new System.Drawing.Point(19, 239);
            this.btnAltaProd.Name = "btnAltaProd";
            this.btnAltaProd.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnAltaProd.Size = new System.Drawing.Size(166, 49);
            this.btnAltaProd.TabIndex = 7;
            this.btnAltaProd.Text = "Alta Producto";
            this.btnAltaProd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAltaProd.UseVisualStyleBackColor = false;
            // 
            // btnBajaUsuario
            // 
            this.btnBajaUsuario.BackColor = System.Drawing.Color.LightGray;
            this.btnBajaUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBajaUsuario.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnBajaUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnBajaUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(202)))), ((int)(((byte)(210)))));
            this.btnBajaUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBajaUsuario.Font = new System.Drawing.Font("Leelawadee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBajaUsuario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBajaUsuario.Image = global::CapaPresentacion.Properties.Resources.papelera_xmark;
            this.btnBajaUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBajaUsuario.Location = new System.Drawing.Point(19, 173);
            this.btnBajaUsuario.Name = "btnBajaUsuario";
            this.btnBajaUsuario.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnBajaUsuario.Size = new System.Drawing.Size(166, 49);
            this.btnBajaUsuario.TabIndex = 5;
            this.btnBajaUsuario.Text = "Baja Producto";
            this.btnBajaUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBajaUsuario.UseVisualStyleBackColor = false;
            // 
            // btnEditarProd
            // 
            this.btnEditarProd.BackColor = System.Drawing.Color.LightGray;
            this.btnEditarProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarProd.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnEditarProd.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnEditarProd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(202)))), ((int)(((byte)(210)))));
            this.btnEditarProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarProd.Font = new System.Drawing.Font("Leelawadee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarProd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEditarProd.Image = global::CapaPresentacion.Properties.Resources.editar;
            this.btnEditarProd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarProd.Location = new System.Drawing.Point(19, 102);
            this.btnEditarProd.Name = "btnEditarProd";
            this.btnEditarProd.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnEditarProd.Size = new System.Drawing.Size(167, 49);
            this.btnEditarProd.TabIndex = 6;
            this.btnEditarProd.Text = "Editar Producto";
            this.btnEditarProd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditarProd.UseVisualStyleBackColor = false;
            this.btnEditarProd.Click += new System.EventHandler(this.btnEditarProd_Click);
            // 
            // btnAgregarProd
            // 
            this.btnAgregarProd.BackColor = System.Drawing.Color.LightGray;
            this.btnAgregarProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarProd.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnAgregarProd.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnAgregarProd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(202)))), ((int)(((byte)(210)))));
            this.btnAgregarProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarProd.Font = new System.Drawing.Font("Leelawadee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAgregarProd.Image = global::CapaPresentacion.Properties.Resources.anadir;
            this.btnAgregarProd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarProd.Location = new System.Drawing.Point(19, 36);
            this.btnAgregarProd.Name = "btnAgregarProd";
            this.btnAgregarProd.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnAgregarProd.Size = new System.Drawing.Size(167, 49);
            this.btnAgregarProd.TabIndex = 4;
            this.btnAgregarProd.Text = "Añadir Producto";
            this.btnAgregarProd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarProd.UseVisualStyleBackColor = false;
            this.btnAgregarProd.Click += new System.EventHandler(this.btnAgregarProd_Click);
            // 
            // dataGridUsuario
            // 
            this.dataGridUsuario.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Leelawadee UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridUsuario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnSeleccionar,
            this.idProd,
            this.codProd,
            this.nombre,
            this.descripcion,
            this.idCateg,
            this.Stock,
            this.Precio,
            this.Estado});
            this.dataGridUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridUsuario.Location = new System.Drawing.Point(0, 107);
            this.dataGridUsuario.MultiSelect = false;
            this.dataGridUsuario.Name = "dataGridUsuario";
            this.dataGridUsuario.ReadOnly = true;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridUsuario.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridUsuario.RowTemplate.Height = 28;
            this.dataGridUsuario.Size = new System.Drawing.Size(921, 404);
            this.dataGridUsuario.TabIndex = 26;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.HeaderText = "";
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.ReadOnly = true;
            this.btnSeleccionar.Width = 88;
            // 
            // idProd
            // 
            this.idProd.HeaderText = "idProd";
            this.idProd.Name = "idProd";
            this.idProd.ReadOnly = true;
            this.idProd.Visible = false;
            // 
            // codProd
            // 
            this.codProd.HeaderText = "Codigo Producto";
            this.codProd.Name = "codProd";
            this.codProd.ReadOnly = true;
            this.codProd.Width = 88;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 87;
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Descripcion";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            this.descripcion.Width = 88;
            // 
            // idCateg
            // 
            this.idCateg.HeaderText = "idCateg";
            this.idCateg.Name = "idCateg";
            this.idCateg.ReadOnly = true;
            this.idCateg.Visible = false;
            // 
            // Stock
            // 
            this.Stock.HeaderText = "Stock";
            this.Stock.Name = "Stock";
            this.Stock.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "precioVenta";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Width = 88;
            // 
            // FormProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 511);
            this.Controls.Add(this.dataGridUsuario);
            this.Controls.Add(this.panelRigtUsuario);
            this.Controls.Add(this.panelTopProd);
            this.Name = "FormProducto";
            this.Text = "FormProducto";
            this.panelTopProd.ResumeLayout(false);
            this.panelLogoTit.ResumeLayout(false);
            this.panelLogoTit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUsuario)).EndInit();
            this.panelBuscador.ResumeLayout(false);
            this.panelBuscador.PerformLayout();
            this.panelRigtUsuario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTopProd;
        private System.Windows.Forms.Panel panelLogoTit;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblTituloProd;
        private System.Windows.Forms.PictureBox picUsuario;
        private System.Windows.Forms.Panel panelBuscador;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.ComboBox cboBusqueda;
        private System.Windows.Forms.Panel panelRigtUsuario;
        public System.Windows.Forms.Button btnAltaProd;
        public System.Windows.Forms.Button btnBajaUsuario;
        public System.Windows.Forms.Button btnEditarProd;
        public System.Windows.Forms.Button btnAgregarProd;
        public System.Windows.Forms.DataGridView dataGridUsuario;
        private System.Windows.Forms.DataGridViewButtonColumn btnSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn codProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCateg;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}
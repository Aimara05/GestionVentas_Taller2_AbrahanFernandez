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
            this.panelBuscador = new System.Windows.Forms.Panel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.cboBusqueda = new System.Windows.Forms.ComboBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.picUsuario = new System.Windows.Forms.PictureBox();
            this.panelRigtUsuario = new System.Windows.Forms.Panel();
            this.lblTituloCli = new System.Windows.Forms.Label();
            this.btnEditarProd = new System.Windows.Forms.Button();
            this.btnAgregarProd = new System.Windows.Forms.Button();
            this.dataGridProd = new System.Windows.Forms.DataGridView();
            this.btnSeleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.idProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.talle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioUni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCateg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelFormu = new System.Windows.Forms.Panel();
            this.panelTopProd.SuspendLayout();
            this.panelBuscador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUsuario)).BeginInit();
            this.panelRigtUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProd)).BeginInit();
            this.panelFormu.SuspendLayout();
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
            this.panelLogoTit.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelLogoTit.Location = new System.Drawing.Point(847, 0);
            this.panelLogoTit.Name = "panelLogoTit";
            this.panelLogoTit.Size = new System.Drawing.Size(277, 107);
            this.panelLogoTit.TabIndex = 27;
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
            this.btnBuscar.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.Black;
            this.btnBuscar.Image = global::CapaPresentacion.Properties.Resources.busqueda;
            this.btnBuscar.Location = new System.Drawing.Point(397, 40);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(25, 30);
            this.btnBuscar.TabIndex = 2;
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
            this.textBox1.TabStop = false;
            this.textBox1.Text = "Buscar por :";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusqueda.Location = new System.Drawing.Point(247, 45);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(144, 25);
            this.txtBusqueda.TabIndex = 1;
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
            this.cboBusqueda.TabStop = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Image = global::CapaPresentacion.Properties.Resources.recargar;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.Location = new System.Drawing.Point(6, 143);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(34, 38);
            this.btnRefresh.TabIndex = 7;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // picUsuario
            // 
            this.picUsuario.BackColor = System.Drawing.Color.LightGray;
            this.picUsuario.Image = global::CapaPresentacion.Properties.Resources.wishlist_product_list_order_cart_icon_225172;
            this.picUsuario.Location = new System.Drawing.Point(58, 31);
            this.picUsuario.Name = "picUsuario";
            this.picUsuario.Padding = new System.Windows.Forms.Padding(0, 0, 40, 0);
            this.picUsuario.Size = new System.Drawing.Size(89, 89);
            this.picUsuario.TabIndex = 0;
            this.picUsuario.TabStop = false;
            // 
            // panelRigtUsuario
            // 
            this.panelRigtUsuario.BackColor = System.Drawing.Color.LightGray;
            this.panelRigtUsuario.Controls.Add(this.lblTituloCli);
            this.panelRigtUsuario.Controls.Add(this.btnRefresh);
            this.panelRigtUsuario.Controls.Add(this.picUsuario);
            this.panelRigtUsuario.Controls.Add(this.btnEditarProd);
            this.panelRigtUsuario.Controls.Add(this.btnAgregarProd);
            this.panelRigtUsuario.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRigtUsuario.Location = new System.Drawing.Point(921, 107);
            this.panelRigtUsuario.Name = "panelRigtUsuario";
            this.panelRigtUsuario.Size = new System.Drawing.Size(203, 404);
            this.panelRigtUsuario.TabIndex = 2;
            // 
            // lblTituloCli
            // 
            this.lblTituloCli.AutoSize = true;
            this.lblTituloCli.Font = new System.Drawing.Font("Leelawadee UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloCli.Location = new System.Drawing.Point(43, 143);
            this.lblTituloCli.Name = "lblTituloCli";
            this.lblTituloCli.Size = new System.Drawing.Size(148, 37);
            this.lblTituloCli.TabIndex = 8;
            this.lblTituloCli.Text = "Productos";
            // 
            // btnEditarProd
            // 
            this.btnEditarProd.BackColor = System.Drawing.Color.LightGray;
            this.btnEditarProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarProd.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnEditarProd.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnEditarProd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(202)))), ((int)(((byte)(210)))));
            this.btnEditarProd.Font = new System.Drawing.Font("Leelawadee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarProd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEditarProd.Image = global::CapaPresentacion.Properties.Resources.editar;
            this.btnEditarProd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarProd.Location = new System.Drawing.Point(58, 228);
            this.btnEditarProd.Name = "btnEditarProd";
            this.btnEditarProd.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnEditarProd.Size = new System.Drawing.Size(48, 49);
            this.btnEditarProd.TabIndex = 6;
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
            this.btnAgregarProd.Font = new System.Drawing.Font("Leelawadee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAgregarProd.Image = global::CapaPresentacion.Properties.Resources.anadir;
            this.btnAgregarProd.Location = new System.Drawing.Point(112, 228);
            this.btnAgregarProd.Name = "btnAgregarProd";
            this.btnAgregarProd.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnAgregarProd.Size = new System.Drawing.Size(48, 49);
            this.btnAgregarProd.TabIndex = 4;
            this.btnAgregarProd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarProd.UseVisualStyleBackColor = false;
            this.btnAgregarProd.Click += new System.EventHandler(this.btnAgregarProd_Click);
            // 
            // dataGridProd
            // 
            this.dataGridProd.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridProd.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnSeleccionar,
            this.idProd,
            this.nombreProd,
            this.descripcionProd,
            this.talle,
            this.stock,
            this.estado,
            this.PrecioUni,
            this.idMarca,
            this.descripcionMarca,
            this.idCateg,
            this.descripcion});
            this.dataGridProd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridProd.Location = new System.Drawing.Point(0, 0);
            this.dataGridProd.MultiSelect = false;
            this.dataGridProd.Name = "dataGridProd";
            this.dataGridProd.ReadOnly = true;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridProd.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridProd.RowTemplate.Height = 28;
            this.dataGridProd.Size = new System.Drawing.Size(921, 404);
            this.dataGridProd.TabIndex = 26;
            this.dataGridProd.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridProd_CellClick);
            this.dataGridProd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridProd_CellContentClick);
            this.dataGridProd.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridProd_CellFormatting_1);
            this.dataGridProd.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridProd_CellPainting);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.HeaderText = "";
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.ReadOnly = true;
            this.btnSeleccionar.Width = 30;
            // 
            // idProd
            // 
            this.idProd.HeaderText = "idProd";
            this.idProd.Name = "idProd";
            this.idProd.ReadOnly = true;
            this.idProd.Visible = false;
            // 
            // nombreProd
            // 
            this.nombreProd.HeaderText = "Nombre";
            this.nombreProd.Name = "nombreProd";
            this.nombreProd.ReadOnly = true;
            this.nombreProd.Width = 87;
            // 
            // descripcionProd
            // 
            this.descripcionProd.HeaderText = "Descripcion";
            this.descripcionProd.Name = "descripcionProd";
            this.descripcionProd.ReadOnly = true;
            this.descripcionProd.Width = 88;
            // 
            // talle
            // 
            this.talle.HeaderText = "Talle";
            this.talle.Name = "talle";
            this.talle.ReadOnly = true;
            // 
            // stock
            // 
            this.stock.HeaderText = "stock";
            this.stock.Name = "stock";
            this.stock.ReadOnly = true;
            // 
            // estado
            // 
            this.estado.HeaderText = "estado";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            // 
            // PrecioUni
            // 
            this.PrecioUni.HeaderText = "Precio";
            this.PrecioUni.Name = "PrecioUni";
            this.PrecioUni.ReadOnly = true;
            // 
            // idMarca
            // 
            this.idMarca.HeaderText = "idMarca";
            this.idMarca.Name = "idMarca";
            this.idMarca.ReadOnly = true;
            this.idMarca.Visible = false;
            // 
            // descripcionMarca
            // 
            this.descripcionMarca.HeaderText = "Marca";
            this.descripcionMarca.Name = "descripcionMarca";
            this.descripcionMarca.ReadOnly = true;
            // 
            // idCateg
            // 
            this.idCateg.HeaderText = "idCateg";
            this.idCateg.Name = "idCateg";
            this.idCateg.ReadOnly = true;
            this.idCateg.Visible = false;
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Categoria";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            // 
            // panelFormu
            // 
            this.panelFormu.Controls.Add(this.dataGridProd);
            this.panelFormu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFormu.Location = new System.Drawing.Point(0, 107);
            this.panelFormu.Name = "panelFormu";
            this.panelFormu.Size = new System.Drawing.Size(921, 404);
            this.panelFormu.TabIndex = 27;
            // 
            // FormProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1124, 511);
            this.Controls.Add(this.panelFormu);
            this.Controls.Add(this.panelRigtUsuario);
            this.Controls.Add(this.panelTopProd);
            this.Name = "FormProducto";
            this.Text = "FormProducto";
            this.Load += new System.EventHandler(this.FormProducto_Load);
            this.panelTopProd.ResumeLayout(false);
            this.panelBuscador.ResumeLayout(false);
            this.panelBuscador.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUsuario)).EndInit();
            this.panelRigtUsuario.ResumeLayout(false);
            this.panelRigtUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProd)).EndInit();
            this.panelFormu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTopProd;
        private System.Windows.Forms.Panel panelLogoTit;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.PictureBox picUsuario;
        private System.Windows.Forms.Panel panelBuscador;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.ComboBox cboBusqueda;
        private System.Windows.Forms.Panel panelRigtUsuario;
        public System.Windows.Forms.Button btnEditarProd;
        public System.Windows.Forms.Button btnAgregarProd;
        public System.Windows.Forms.DataGridView dataGridProd;
        private System.Windows.Forms.Panel panelFormu;
        private System.Windows.Forms.DataGridViewButtonColumn btnSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn talle;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioUni;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCateg;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.Label lblTituloCli;
    }
}
namespace CapaPresentacion
{
    partial class FormRegistrarVentas
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
            this.GbxInfoVent = new System.Windows.Forms.GroupBox();
            this.picVendedor = new System.Windows.Forms.PictureBox();
            this.lblIDvende = new System.Windows.Forms.TextBox();
            this.txtVendedor = new System.Windows.Forms.TextBox();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.lblVendedor = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cboBusquedaProd = new System.Windows.Forms.Button();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtProd = new System.Windows.Forms.TextBox();
            this.txtCodProd = new System.Windows.Forms.TextBox();
            this.lblCantid = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblProd = new System.Windows.Forms.Label();
            this.GbxCliente = new System.Windows.Forms.GroupBox();
            this.picCliente = new System.Windows.Forms.PictureBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.LTelefono = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.cboBusqueda = new System.Windows.Forms.Button();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.lblNombreyApe = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtCambio = new System.Windows.Forms.TextBox();
            this.lblCambio = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblTipoPag = new System.Windows.Forms.Label();
            this.panelTopUsuario = new System.Windows.Forms.Panel();
            this.panelLogoTit = new System.Windows.Forms.Panel();
            this.lblTituloCli = new System.Windows.Forms.Label();
            this.lblTituloVenta = new System.Windows.Forms.Label();
            this.picUsuario = new System.Windows.Forms.PictureBox();
            this.panelRigtUsuario = new System.Windows.Forms.Panel();
            this.btnRealizarVent = new System.Windows.Forms.Button();
            this.CbTipopago = new System.Windows.Forms.ComboBox();
            this.txtPagaCon = new System.Windows.Forms.TextBox();
            this.lblPagaCon = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btneliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.GbxInfoVent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picVendedor)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.GbxCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCliente)).BeginInit();
            this.panelTopUsuario.SuspendLayout();
            this.panelLogoTit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUsuario)).BeginInit();
            this.panelRigtUsuario.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // GbxInfoVent
            // 
            this.GbxInfoVent.BackColor = System.Drawing.Color.Silver;
            this.GbxInfoVent.Controls.Add(this.picVendedor);
            this.GbxInfoVent.Controls.Add(this.lblIDvende);
            this.GbxInfoVent.Controls.Add(this.txtVendedor);
            this.GbxInfoVent.Controls.Add(this.txtHora);
            this.GbxInfoVent.Controls.Add(this.lblVendedor);
            this.GbxInfoVent.Controls.Add(this.lblHora);
            this.GbxInfoVent.Controls.Add(this.txtFecha);
            this.GbxInfoVent.Controls.Add(this.lblFecha);
            this.GbxInfoVent.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.GbxInfoVent.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbxInfoVent.Location = new System.Drawing.Point(45, 68);
            this.GbxInfoVent.Name = "GbxInfoVent";
            this.GbxInfoVent.Size = new System.Drawing.Size(383, 177);
            this.GbxInfoVent.TabIndex = 27;
            this.GbxInfoVent.TabStop = false;
            // 
            // picVendedor
            // 
            this.picVendedor.Image = global::CapaPresentacion.Properties.Resources.avatarUsuario;
            this.picVendedor.Location = new System.Drawing.Point(6, 39);
            this.picVendedor.Name = "picVendedor";
            this.picVendedor.Size = new System.Drawing.Size(95, 102);
            this.picVendedor.TabIndex = 28;
            this.picVendedor.TabStop = false;
            // 
            // lblIDvende
            // 
            this.lblIDvende.Location = new System.Drawing.Point(310, 8);
            this.lblIDvende.Name = "lblIDvende";
            this.lblIDvende.Size = new System.Drawing.Size(34, 25);
            this.lblIDvende.TabIndex = 27;
            this.lblIDvende.Visible = false;
            // 
            // txtVendedor
            // 
            this.txtVendedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVendedor.Location = new System.Drawing.Point(194, 39);
            this.txtVendedor.Name = "txtVendedor";
            this.txtVendedor.ReadOnly = true;
            this.txtVendedor.Size = new System.Drawing.Size(154, 25);
            this.txtVendedor.TabIndex = 7;
            // 
            // txtHora
            // 
            this.txtHora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHora.Location = new System.Drawing.Point(194, 107);
            this.txtHora.Name = "txtHora";
            this.txtHora.ReadOnly = true;
            this.txtHora.Size = new System.Drawing.Size(154, 25);
            this.txtHora.TabIndex = 6;
            // 
            // lblVendedor
            // 
            this.lblVendedor.AutoSize = true;
            this.lblVendedor.Font = new System.Drawing.Font("Leelawadee UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendedor.Location = new System.Drawing.Point(112, 51);
            this.lblVendedor.Name = "lblVendedor";
            this.lblVendedor.Size = new System.Drawing.Size(61, 13);
            this.lblVendedor.TabIndex = 5;
            this.lblVendedor.Text = "Vendedor:";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Leelawadee UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(112, 119);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(35, 13);
            this.lblHora.TabIndex = 4;
            this.lblHora.Text = "Hora:";
            // 
            // txtFecha
            // 
            this.txtFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFecha.Location = new System.Drawing.Point(194, 73);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.ReadOnly = true;
            this.txtFecha.Size = new System.Drawing.Size(154, 25);
            this.txtFecha.TabIndex = 3;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Leelawadee UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(112, 85);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(40, 13);
            this.lblFecha.TabIndex = 0;
            this.lblFecha.Text = "Fecha:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.cboBusquedaProd);
            this.groupBox1.Controls.Add(this.txtStock);
            this.groupBox1.Controls.Add(this.lblStock);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.txtPrecio);
            this.groupBox1.Controls.Add(this.txtProd);
            this.groupBox1.Controls.Add(this.txtCodProd);
            this.groupBox1.Controls.Add(this.lblCantid);
            this.groupBox1.Controls.Add(this.lblPrecio);
            this.groupBox1.Controls.Add(this.lblCodigo);
            this.groupBox1.Controls.Add(this.lblProd);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(45, 251);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(810, 125);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 11);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(194, 17);
            this.label11.TabIndex = 32;
            this.label11.Text = "Informacion de los productos:";
            // 
            // cboBusquedaProd
            // 
            this.cboBusquedaProd.BackColor = System.Drawing.Color.Silver;
            this.cboBusquedaProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboBusquedaProd.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cboBusquedaProd.FlatAppearance.BorderSize = 0;
            this.cboBusquedaProd.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.cboBusquedaProd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(202)))), ((int)(((byte)(210)))));
            this.cboBusquedaProd.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBusquedaProd.ForeColor = System.Drawing.Color.Black;
            this.cboBusquedaProd.Image = global::CapaPresentacion.Properties.Resources.busqueda;
            this.cboBusquedaProd.Location = new System.Drawing.Point(318, 61);
            this.cboBusquedaProd.Name = "cboBusquedaProd";
            this.cboBusquedaProd.Size = new System.Drawing.Size(42, 33);
            this.cboBusquedaProd.TabIndex = 31;
            this.cboBusquedaProd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cboBusquedaProd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cboBusquedaProd.UseVisualStyleBackColor = false;
            this.cboBusquedaProd.Click += new System.EventHandler(this.cboBusquedaProd_Click);
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(483, 69);
            this.txtStock.Name = "txtStock";
            this.txtStock.ReadOnly = true;
            this.txtStock.Size = new System.Drawing.Size(51, 25);
            this.txtStock.TabIndex = 30;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Leelawadee UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.Location = new System.Drawing.Point(480, 43);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(35, 13);
            this.lblStock.TabIndex = 29;
            this.lblStock.Text = "Stock";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Leelawadee UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(566, 72);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 12;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Silver;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(202)))), ((int)(((byte)(210)))));
            this.btnAgregar.Font = new System.Drawing.Font("Leelawadee UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Image = global::CapaPresentacion.Properties.Resources.anadir;
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAgregar.Location = new System.Drawing.Point(719, 49);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(61, 45);
            this.btnAgregar.TabIndex = 28;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(379, 69);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.ReadOnly = true;
            this.txtPrecio.Size = new System.Drawing.Size(79, 25);
            this.txtPrecio.TabIndex = 10;
            // 
            // txtProd
            // 
            this.txtProd.Location = new System.Drawing.Point(121, 69);
            this.txtProd.Name = "txtProd";
            this.txtProd.ReadOnly = true;
            this.txtProd.Size = new System.Drawing.Size(175, 25);
            this.txtProd.TabIndex = 9;
            // 
            // txtCodProd
            // 
            this.txtCodProd.Location = new System.Drawing.Point(22, 69);
            this.txtCodProd.Name = "txtCodProd";
            this.txtCodProd.ReadOnly = true;
            this.txtCodProd.Size = new System.Drawing.Size(68, 25);
            this.txtCodProd.TabIndex = 7;
            // 
            // lblCantid
            // 
            this.lblCantid.AutoSize = true;
            this.lblCantid.Font = new System.Drawing.Font("Leelawadee UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantid.Location = new System.Drawing.Point(563, 43);
            this.lblCantid.Name = "lblCantid";
            this.lblCantid.Size = new System.Drawing.Size(54, 13);
            this.lblCantid.TabIndex = 6;
            this.lblCantid.Text = "Cantidad";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Leelawadee UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(376, 43);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(38, 13);
            this.lblPrecio.TabIndex = 5;
            this.lblPrecio.Text = "Precio";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Leelawadee UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(19, 43);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(45, 13);
            this.lblCodigo.TabIndex = 3;
            this.lblCodigo.Text = "Codigo";
            // 
            // lblProd
            // 
            this.lblProd.AutoSize = true;
            this.lblProd.Font = new System.Drawing.Font("Leelawadee UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProd.Location = new System.Drawing.Point(118, 43);
            this.lblProd.Name = "lblProd";
            this.lblProd.Size = new System.Drawing.Size(54, 13);
            this.lblProd.TabIndex = 4;
            this.lblProd.Text = "Producto";
            // 
            // GbxCliente
            // 
            this.GbxCliente.BackColor = System.Drawing.Color.Silver;
            this.GbxCliente.Controls.Add(this.picCliente);
            this.GbxCliente.Controls.Add(this.lblCorreo);
            this.GbxCliente.Controls.Add(this.LTelefono);
            this.GbxCliente.Controls.Add(this.txtCorreo);
            this.GbxCliente.Controls.Add(this.txtIdCliente);
            this.GbxCliente.Controls.Add(this.txtTel);
            this.GbxCliente.Controls.Add(this.txtCliente);
            this.GbxCliente.Controls.Add(this.cboBusqueda);
            this.GbxCliente.Controls.Add(this.txtDni);
            this.GbxCliente.Controls.Add(this.lblNombreyApe);
            this.GbxCliente.Controls.Add(this.lblDni);
            this.GbxCliente.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.GbxCliente.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbxCliente.Location = new System.Drawing.Point(472, 68);
            this.GbxCliente.Name = "GbxCliente";
            this.GbxCliente.Size = new System.Drawing.Size(383, 177);
            this.GbxCliente.TabIndex = 28;
            this.GbxCliente.TabStop = false;
            // 
            // picCliente
            // 
            this.picCliente.Image = global::CapaPresentacion.Properties.Resources._456212;
            this.picCliente.Location = new System.Drawing.Point(2, 39);
            this.picCliente.Name = "picCliente";
            this.picCliente.Size = new System.Drawing.Size(95, 102);
            this.picCliente.TabIndex = 31;
            this.picCliente.TabStop = false;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Leelawadee UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.Location = new System.Drawing.Point(103, 131);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(45, 13);
            this.lblCorreo.TabIndex = 30;
            this.lblCorreo.Text = "Correo:";
            // 
            // LTelefono
            // 
            this.LTelefono.AutoSize = true;
            this.LTelefono.Font = new System.Drawing.Font("Leelawadee UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTelefono.Location = new System.Drawing.Point(103, 99);
            this.LTelefono.Name = "LTelefono";
            this.LTelefono.Size = new System.Drawing.Size(55, 13);
            this.LTelefono.TabIndex = 29;
            this.LTelefono.Text = "Teléfono:";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(164, 119);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.ReadOnly = true;
            this.txtCorreo.Size = new System.Drawing.Size(166, 25);
            this.txtCorreo.TabIndex = 28;
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Location = new System.Drawing.Point(341, 81);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(34, 25);
            this.txtIdCliente.TabIndex = 26;
            this.txtIdCliente.Visible = false;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(164, 88);
            this.txtTel.Name = "txtTel";
            this.txtTel.ReadOnly = true;
            this.txtTel.Size = new System.Drawing.Size(166, 25);
            this.txtTel.TabIndex = 27;
            // 
            // txtCliente
            // 
            this.txtCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCliente.Location = new System.Drawing.Point(164, 57);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.ReadOnly = true;
            this.txtCliente.Size = new System.Drawing.Size(166, 25);
            this.txtCliente.TabIndex = 4;
            // 
            // cboBusqueda
            // 
            this.cboBusqueda.BackColor = System.Drawing.Color.Silver;
            this.cboBusqueda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboBusqueda.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cboBusqueda.FlatAppearance.BorderSize = 0;
            this.cboBusqueda.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.cboBusqueda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(202)))), ((int)(((byte)(210)))));
            this.cboBusqueda.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBusqueda.ForeColor = System.Drawing.Color.Black;
            this.cboBusqueda.Image = global::CapaPresentacion.Properties.Resources.busqueda;
            this.cboBusqueda.Location = new System.Drawing.Point(336, 20);
            this.cboBusqueda.Name = "cboBusqueda";
            this.cboBusqueda.Size = new System.Drawing.Size(42, 33);
            this.cboBusqueda.TabIndex = 25;
            this.cboBusqueda.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cboBusqueda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cboBusqueda.UseVisualStyleBackColor = false;
            this.cboBusqueda.Click += new System.EventHandler(this.cboBusqueda_Click);
            // 
            // txtDni
            // 
            this.txtDni.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDni.Location = new System.Drawing.Point(164, 24);
            this.txtDni.Name = "txtDni";
            this.txtDni.ReadOnly = true;
            this.txtDni.Size = new System.Drawing.Size(166, 25);
            this.txtDni.TabIndex = 2;
            // 
            // lblNombreyApe
            // 
            this.lblNombreyApe.AutoSize = true;
            this.lblNombreyApe.Font = new System.Drawing.Font("Leelawadee UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreyApe.Location = new System.Drawing.Point(103, 69);
            this.lblNombreyApe.Name = "lblNombreyApe";
            this.lblNombreyApe.Size = new System.Drawing.Size(46, 13);
            this.lblNombreyApe.TabIndex = 3;
            this.lblNombreyApe.Text = "Cliente:";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Font = new System.Drawing.Font("Leelawadee UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDni.Location = new System.Drawing.Point(103, 36);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(29, 13);
            this.lblDni.TabIndex = 0;
            this.lblDni.Text = "DNI:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(46, 31);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(37, 15);
            this.lblTotal.TabIndex = 36;
            this.lblTotal.Text = "Total:";
            // 
            // txtCambio
            // 
            this.txtCambio.Location = new System.Drawing.Point(142, 124);
            this.txtCambio.Name = "txtCambio";
            this.txtCambio.ReadOnly = true;
            this.txtCambio.Size = new System.Drawing.Size(100, 25);
            this.txtCambio.TabIndex = 39;
            this.txtCambio.Click += new System.EventHandler(this.txtCambio_Click);
            // 
            // lblCambio
            // 
            this.lblCambio.AutoSize = true;
            this.lblCambio.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCambio.Location = new System.Drawing.Point(46, 134);
            this.lblCambio.Name = "lblCambio";
            this.lblCambio.Size = new System.Drawing.Size(52, 15);
            this.lblCambio.TabIndex = 38;
            this.lblCambio.Text = "Cambio:";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(143, 21);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 25);
            this.txtTotal.TabIndex = 41;
            // 
            // lblTipoPag
            // 
            this.lblTipoPag.AutoSize = true;
            this.lblTipoPag.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoPag.Location = new System.Drawing.Point(46, 65);
            this.lblTipoPag.Name = "lblTipoPag";
            this.lblTipoPag.Size = new System.Drawing.Size(80, 15);
            this.lblTipoPag.TabIndex = 40;
            this.lblTipoPag.Text = "Tipo de Pago:";
            // 
            // panelTopUsuario
            // 
            this.panelTopUsuario.BackColor = System.Drawing.Color.DarkGray;
            this.panelTopUsuario.Controls.Add(this.panelLogoTit);
            this.panelTopUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopUsuario.Font = new System.Drawing.Font("Leelawadee UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelTopUsuario.Location = new System.Drawing.Point(0, 0);
            this.panelTopUsuario.Name = "panelTopUsuario";
            this.panelTopUsuario.Size = new System.Drawing.Size(1153, 53);
            this.panelTopUsuario.TabIndex = 42;
            // 
            // panelLogoTit
            // 
            this.panelLogoTit.Controls.Add(this.lblTituloCli);
            this.panelLogoTit.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelLogoTit.Location = new System.Drawing.Point(775, 0);
            this.panelLogoTit.Name = "panelLogoTit";
            this.panelLogoTit.Size = new System.Drawing.Size(378, 53);
            this.panelLogoTit.TabIndex = 27;
            // 
            // lblTituloCli
            // 
            this.lblTituloCli.AutoSize = true;
            this.lblTituloCli.Font = new System.Drawing.Font("Leelawadee UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloCli.Location = new System.Drawing.Point(170, 58);
            this.lblTituloCli.Name = "lblTituloCli";
            this.lblTituloCli.Size = new System.Drawing.Size(175, 30);
            this.lblTituloCli.TabIndex = 1;
            this.lblTituloCli.Text = "Registrar Venta";
            // 
            // lblTituloVenta
            // 
            this.lblTituloVenta.AutoSize = true;
            this.lblTituloVenta.Font = new System.Drawing.Font("Leelawadee UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloVenta.Location = new System.Drawing.Point(86, 117);
            this.lblTituloVenta.Name = "lblTituloVenta";
            this.lblTituloVenta.Size = new System.Drawing.Size(79, 30);
            this.lblTituloVenta.TabIndex = 37;
            this.lblTituloVenta.Text = "Ventas";
            // 
            // picUsuario
            // 
            this.picUsuario.BackColor = System.Drawing.Color.DarkGray;
            this.picUsuario.Image = global::CapaPresentacion.Properties.Resources.sales_store_ecommerce_shopping_and_commerce_shop_online_icon_255549;
            this.picUsuario.Location = new System.Drawing.Point(96, 219);
            this.picUsuario.Name = "picUsuario";
            this.picUsuario.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.picUsuario.Size = new System.Drawing.Size(69, 73);
            this.picUsuario.TabIndex = 2;
            this.picUsuario.TabStop = false;
            // 
            // panelRigtUsuario
            // 
            this.panelRigtUsuario.BackColor = System.Drawing.Color.DarkGray;
            this.panelRigtUsuario.Controls.Add(this.lblTituloVenta);
            this.panelRigtUsuario.Controls.Add(this.picUsuario);
            this.panelRigtUsuario.Controls.Add(this.btnRealizarVent);
            this.panelRigtUsuario.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRigtUsuario.Location = new System.Drawing.Point(900, 53);
            this.panelRigtUsuario.Name = "panelRigtUsuario";
            this.panelRigtUsuario.Size = new System.Drawing.Size(253, 495);
            this.panelRigtUsuario.TabIndex = 43;
            // 
            // btnRealizarVent
            // 
            this.btnRealizarVent.BackColor = System.Drawing.Color.LightGray;
            this.btnRealizarVent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRealizarVent.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnRealizarVent.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnRealizarVent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(202)))), ((int)(((byte)(210)))));
            this.btnRealizarVent.Font = new System.Drawing.Font("Leelawadee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRealizarVent.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRealizarVent.Image = global::CapaPresentacion.Properties.Resources.checkbox_ckeck_icon_143039;
            this.btnRealizarVent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRealizarVent.Location = new System.Drawing.Point(50, 347);
            this.btnRealizarVent.Name = "btnRealizarVent";
            this.btnRealizarVent.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnRealizarVent.Size = new System.Drawing.Size(169, 39);
            this.btnRealizarVent.TabIndex = 5;
            this.btnRealizarVent.Text = "Realizar Venta";
            this.btnRealizarVent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRealizarVent.UseVisualStyleBackColor = false;
            this.btnRealizarVent.Click += new System.EventHandler(this.btnRealizarVent_Click);
            // 
            // CbTipopago
            // 
            this.CbTipopago.FormattingEnabled = true;
            this.CbTipopago.Location = new System.Drawing.Point(142, 55);
            this.CbTipopago.Name = "CbTipopago";
            this.CbTipopago.Size = new System.Drawing.Size(101, 25);
            this.CbTipopago.TabIndex = 45;
            // 
            // txtPagaCon
            // 
            this.txtPagaCon.Location = new System.Drawing.Point(142, 89);
            this.txtPagaCon.Name = "txtPagaCon";
            this.txtPagaCon.Size = new System.Drawing.Size(100, 25);
            this.txtPagaCon.TabIndex = 44;
            this.txtPagaCon.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPagaCon_KeyDown);
            this.txtPagaCon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPagaCon_KeyPress);
            // 
            // lblPagaCon
            // 
            this.lblPagaCon.AutoSize = true;
            this.lblPagaCon.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPagaCon.Location = new System.Drawing.Point(46, 99);
            this.lblPagaCon.Name = "lblPagaCon";
            this.lblPagaCon.Size = new System.Drawing.Size(59, 15);
            this.lblPagaCon.TabIndex = 43;
            this.lblPagaCon.Text = "Paga con:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Silver;
            this.groupBox2.Controls.Add(this.lblTipoPag);
            this.groupBox2.Controls.Add(this.txtPagaCon);
            this.groupBox2.Controls.Add(this.txtCambio);
            this.groupBox2.Controls.Add(this.CbTipopago);
            this.groupBox2.Controls.Add(this.lblPagaCon);
            this.groupBox2.Controls.Add(this.lblCambio);
            this.groupBox2.Controls.Add(this.lblTotal);
            this.groupBox2.Controls.Add(this.txtTotal);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(560, 382);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(295, 163);
            this.groupBox2.TabIndex = 44;
            this.groupBox2.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProducto,
            this.nombre,
            this.stock,
            this.precio,
            this.cantidad,
            this.subtotal,
            this.btneliminar,
            this.btnEditar});
            this.dataGridView1.Location = new System.Drawing.Point(45, 385);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(509, 163);
            this.dataGridView1.TabIndex = 45;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridView1_CellPainting_1);
            // 
            // idProducto
            // 
            this.idProducto.HeaderText = "idProd";
            this.idProducto.Name = "idProducto";
            this.idProducto.Visible = false;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            // 
            // stock
            // 
            this.stock.HeaderText = "stock";
            this.stock.Name = "stock";
            // 
            // precio
            // 
            this.precio.HeaderText = "Precio";
            this.precio.Name = "precio";
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            // 
            // subtotal
            // 
            this.subtotal.HeaderText = "Subtotal";
            this.subtotal.Name = "subtotal";
            // 
            // btneliminar
            // 
            this.btneliminar.HeaderText = "";
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Width = 30;
            // 
            // btnEditar
            // 
            this.btnEditar.HeaderText = "";
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnEditar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnEditar.Width = 30;
            // 
            // FormRegistrarVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1153, 548);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panelRigtUsuario);
            this.Controls.Add(this.GbxCliente);
            this.Controls.Add(this.panelTopUsuario);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GbxInfoVent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormRegistrarVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.FormRegistrarVentas_Load);
            this.GbxInfoVent.ResumeLayout(false);
            this.GbxInfoVent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picVendedor)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.GbxCliente.ResumeLayout(false);
            this.GbxCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCliente)).EndInit();
            this.panelTopUsuario.ResumeLayout(false);
            this.panelLogoTit.ResumeLayout(false);
            this.panelLogoTit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUsuario)).EndInit();
            this.panelRigtUsuario.ResumeLayout(false);
            this.panelRigtUsuario.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox GbxInfoVent;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtProd;
        private System.Windows.Forms.TextBox txtCodProd;
        private System.Windows.Forms.Label lblCantid;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblProd;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label lblNombreyApe;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtCambio;
        private System.Windows.Forms.Label lblCambio;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblTipoPag;
        public System.Windows.Forms.GroupBox GbxCliente;
        private System.Windows.Forms.Button cboBusqueda;
        private System.Windows.Forms.Panel panelTopUsuario;
        private System.Windows.Forms.Panel panelLogoTit;
        private System.Windows.Forms.PictureBox picUsuario;
        private System.Windows.Forms.Label lblTituloCli;
        private System.Windows.Forms.Panel panelRigtUsuario;
        public System.Windows.Forms.Button btnRealizarVent;
        private System.Windows.Forms.Button cboBusquedaProd;
        private System.Windows.Forms.Label lblPagaCon;
        private System.Windows.Forms.TextBox txtPagaCon;
        private System.Windows.Forms.Label LTelefono;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.ComboBox CbTipopago;
        private System.Windows.Forms.Label lblTituloVenta;
        private System.Windows.Forms.TextBox lblIDvende;
        private System.Windows.Forms.TextBox txtVendedor;
        private System.Windows.Forms.TextBox txtHora;
        private System.Windows.Forms.Label lblVendedor;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.PictureBox picVendedor;
        private System.Windows.Forms.PictureBox picCliente;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal;
        private System.Windows.Forms.DataGridViewButtonColumn btneliminar;
        private System.Windows.Forms.DataGridViewButtonColumn btnEditar;
    }
}
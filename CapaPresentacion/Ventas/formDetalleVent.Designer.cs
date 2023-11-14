namespace CapaPresentacion.Ventas
{
    partial class formDetalleVent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formDetalleVent));
            this.GbxInfoVent = new System.Windows.Forms.GroupBox();
            this.dataGridVenta = new System.Windows.Forms.DataGridView();
            this.producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GbxCliente = new System.Windows.Forms.GroupBox();
            this.Bbuscarventas = new System.Windows.Forms.Button();
            this.btnLimpiardetalle = new System.Windows.Forms.Button();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtfechaventa = new System.Windows.Forms.TextBox();
            this.lblNombreyApe = new System.Windows.Forms.Label();
            this.txtcodigoFactura = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GbxUsuario = new System.Windows.Forms.GroupBox();
            this.txtnomyapeusuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDniUsu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panelTopUsuario = new System.Windows.Forms.Panel();
            this.panelLogoTit = new System.Windows.Forms.Panel();
            this.picUsuario = new System.Windows.Forms.PictureBox();
            this.lblTituloCli = new System.Windows.Forms.Label();
            this.panelRigtUsuario = new System.Windows.Forms.Panel();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtidcliente = new System.Windows.Forms.TextBox();
            this.txtcorreocliente = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txttelcliente = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtnomyapecliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtdnicliente = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.GbxInfoVent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVenta)).BeginInit();
            this.GbxCliente.SuspendLayout();
            this.GbxUsuario.SuspendLayout();
            this.panelTopUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUsuario)).BeginInit();
            this.panelRigtUsuario.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GbxInfoVent
            // 
            this.GbxInfoVent.Controls.Add(this.dataGridVenta);
            this.GbxInfoVent.Controls.Add(this.GbxCliente);
            this.GbxInfoVent.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbxInfoVent.Location = new System.Drawing.Point(12, 225);
            this.GbxInfoVent.Name = "GbxInfoVent";
            this.GbxInfoVent.Size = new System.Drawing.Size(1027, 348);
            this.GbxInfoVent.TabIndex = 28;
            this.GbxInfoVent.TabStop = false;
            // 
            // dataGridVenta
            // 
            this.dataGridVenta.AllowUserToAddRows = false;
            this.dataGridVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.producto,
            this.precio,
            this.Cantidad,
            this.Subtotal});
            this.dataGridVenta.Location = new System.Drawing.Point(27, 71);
            this.dataGridVenta.Name = "dataGridVenta";
            this.dataGridVenta.Size = new System.Drawing.Size(470, 249);
            this.dataGridVenta.TabIndex = 40;
            // 
            // producto
            // 
            this.producto.HeaderText = "Producto";
            this.producto.Name = "producto";
            // 
            // precio
            // 
            this.precio.HeaderText = "Precio";
            this.precio.Name = "precio";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // Subtotal
            // 
            this.Subtotal.HeaderText = "Subtotal";
            this.Subtotal.Name = "Subtotal";
            // 
            // GbxCliente
            // 
            this.GbxCliente.Controls.Add(this.Bbuscarventas);
            this.GbxCliente.Controls.Add(this.btnLimpiardetalle);
            this.GbxCliente.Controls.Add(this.txttotal);
            this.GbxCliente.Controls.Add(this.label9);
            this.GbxCliente.Controls.Add(this.txtfechaventa);
            this.GbxCliente.Controls.Add(this.lblNombreyApe);
            this.GbxCliente.Controls.Add(this.txtcodigoFactura);
            this.GbxCliente.Controls.Add(this.label1);
            this.GbxCliente.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbxCliente.Location = new System.Drawing.Point(530, 71);
            this.GbxCliente.Name = "GbxCliente";
            this.GbxCliente.Size = new System.Drawing.Size(471, 271);
            this.GbxCliente.TabIndex = 29;
            this.GbxCliente.TabStop = false;
            this.GbxCliente.Text = "Información de la Venta";
            // 
            // Bbuscarventas
            // 
            this.Bbuscarventas.BackColor = System.Drawing.Color.Silver;
            this.Bbuscarventas.Image = ((System.Drawing.Image)(resources.GetObject("Bbuscarventas.Image")));
            this.Bbuscarventas.Location = new System.Drawing.Point(199, 77);
            this.Bbuscarventas.Name = "Bbuscarventas";
            this.Bbuscarventas.Size = new System.Drawing.Size(203, 97);
            this.Bbuscarventas.TabIndex = 36;
            this.Bbuscarventas.Text = "Buscar Ventas";
            this.Bbuscarventas.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Bbuscarventas.UseVisualStyleBackColor = false;
            this.Bbuscarventas.Click += new System.EventHandler(this.Bbuscarventas_Click);
            // 
            // btnLimpiardetalle
            // 
            this.btnLimpiardetalle.BackColor = System.Drawing.Color.Silver;
            this.btnLimpiardetalle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiardetalle.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLimpiardetalle.FlatAppearance.BorderSize = 0;
            this.btnLimpiardetalle.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnLimpiardetalle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(202)))), ((int)(((byte)(210)))));
            this.btnLimpiardetalle.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiardetalle.ForeColor = System.Drawing.Color.Black;
            this.btnLimpiardetalle.Image = global::CapaPresentacion.Properties.Resources.limpieza_de_datos;
            this.btnLimpiardetalle.Location = new System.Drawing.Point(273, 190);
            this.btnLimpiardetalle.Name = "btnLimpiardetalle";
            this.btnLimpiardetalle.Size = new System.Drawing.Size(54, 43);
            this.btnLimpiardetalle.TabIndex = 34;
            this.btnLimpiardetalle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiardetalle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpiardetalle.UseVisualStyleBackColor = false;
            this.btnLimpiardetalle.Click += new System.EventHandler(this.btnLimpiardetalle_Click);
            // 
            // txttotal
            // 
            this.txttotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txttotal.Location = new System.Drawing.Point(26, 208);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(95, 25);
            this.txttotal.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(23, 173);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 20);
            this.label9.TabIndex = 27;
            this.label9.Text = "TOTAL";
            // 
            // txtfechaventa
            // 
            this.txtfechaventa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtfechaventa.Location = new System.Drawing.Point(15, 115);
            this.txtfechaventa.Name = "txtfechaventa";
            this.txtfechaventa.Size = new System.Drawing.Size(125, 25);
            this.txtfechaventa.TabIndex = 4;
            // 
            // lblNombreyApe
            // 
            this.lblNombreyApe.AutoSize = true;
            this.lblNombreyApe.Font = new System.Drawing.Font("Leelawadee UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreyApe.Location = new System.Drawing.Point(22, 99);
            this.lblNombreyApe.Name = "lblNombreyApe";
            this.lblNombreyApe.Size = new System.Drawing.Size(37, 13);
            this.lblNombreyApe.TabIndex = 3;
            this.lblNombreyApe.Text = "Fecha";
            // 
            // txtcodigoFactura
            // 
            this.txtcodigoFactura.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtcodigoFactura.Location = new System.Drawing.Point(15, 51);
            this.txtcodigoFactura.Name = "txtcodigoFactura";
            this.txtcodigoFactura.Size = new System.Drawing.Size(125, 25);
            this.txtcodigoFactura.TabIndex = 2;
            this.txtcodigoFactura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDni_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Leelawadee UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo de Factura";
            // 
            // GbxUsuario
            // 
            this.GbxUsuario.Controls.Add(this.txtnomyapeusuario);
            this.GbxUsuario.Controls.Add(this.label2);
            this.GbxUsuario.Controls.Add(this.txtDniUsu);
            this.GbxUsuario.Controls.Add(this.label3);
            this.GbxUsuario.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbxUsuario.Location = new System.Drawing.Point(504, 127);
            this.GbxUsuario.Name = "GbxUsuario";
            this.GbxUsuario.Size = new System.Drawing.Size(471, 101);
            this.GbxUsuario.TabIndex = 37;
            this.GbxUsuario.TabStop = false;
            this.GbxUsuario.Text = "Información de Usuario";
            // 
            // txtnomyapeusuario
            // 
            this.txtnomyapeusuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtnomyapeusuario.Location = new System.Drawing.Point(257, 49);
            this.txtnomyapeusuario.Name = "txtnomyapeusuario";
            this.txtnomyapeusuario.Size = new System.Drawing.Size(173, 25);
            this.txtnomyapeusuario.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Leelawadee UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(263, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre y Apellido";
            // 
            // txtDniUsu
            // 
            this.txtDniUsu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDniUsu.Location = new System.Drawing.Point(38, 49);
            this.txtDniUsu.Name = "txtDniUsu";
            this.txtDniUsu.Size = new System.Drawing.Size(151, 25);
            this.txtDniUsu.TabIndex = 2;
            this.txtDniUsu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDniUsu_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Leelawadee UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "DNI";
            // 
            // panelTopUsuario
            // 
            this.panelTopUsuario.BackColor = System.Drawing.Color.DarkGray;
            this.panelTopUsuario.Controls.Add(this.panelLogoTit);
            this.panelTopUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopUsuario.Font = new System.Drawing.Font("Leelawadee UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelTopUsuario.Location = new System.Drawing.Point(0, 0);
            this.panelTopUsuario.Name = "panelTopUsuario";
            this.panelTopUsuario.Size = new System.Drawing.Size(1233, 103);
            this.panelTopUsuario.TabIndex = 43;
            // 
            // panelLogoTit
            // 
            this.panelLogoTit.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelLogoTit.Location = new System.Drawing.Point(380, 0);
            this.panelLogoTit.Name = "panelLogoTit";
            this.panelLogoTit.Size = new System.Drawing.Size(853, 103);
            this.panelLogoTit.TabIndex = 27;
            // 
            // picUsuario
            // 
            this.picUsuario.BackColor = System.Drawing.Color.DarkGray;
            this.picUsuario.Image = global::CapaPresentacion.Properties.Resources.sales_store_ecommerce_shopping_and_commerce_shop_online_icon_255549;
            this.picUsuario.Location = new System.Drawing.Point(67, 123);
            this.picUsuario.Name = "picUsuario";
            this.picUsuario.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.picUsuario.Size = new System.Drawing.Size(69, 73);
            this.picUsuario.TabIndex = 2;
            this.picUsuario.TabStop = false;
            // 
            // lblTituloCli
            // 
            this.lblTituloCli.AutoSize = true;
            this.lblTituloCli.Font = new System.Drawing.Font("Leelawadee UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloCli.Location = new System.Drawing.Point(27, 49);
            this.lblTituloCli.Name = "lblTituloCli";
            this.lblTituloCli.Size = new System.Drawing.Size(142, 30);
            this.lblTituloCli.TabIndex = 1;
            this.lblTituloCli.Text = "Detalle Venta";
            // 
            // panelRigtUsuario
            // 
            this.panelRigtUsuario.BackColor = System.Drawing.Color.DarkGray;
            this.panelRigtUsuario.Controls.Add(this.lblTituloCli);
            this.panelRigtUsuario.Controls.Add(this.picUsuario);
            this.panelRigtUsuario.Controls.Add(this.btnImprimir);
            this.panelRigtUsuario.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRigtUsuario.Location = new System.Drawing.Point(1045, 103);
            this.panelRigtUsuario.Name = "panelRigtUsuario";
            this.panelRigtUsuario.Size = new System.Drawing.Size(188, 503);
            this.panelRigtUsuario.TabIndex = 44;
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.Color.LightGray;
            this.btnImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImprimir.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnImprimir.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnImprimir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(202)))), ((int)(((byte)(210)))));
            this.btnImprimir.Font = new System.Drawing.Font("Leelawadee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnImprimir.Image = global::CapaPresentacion.Properties.Resources.print_black_printer_tool_symbol_icon_icons_com_54467;
            this.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimir.Location = new System.Drawing.Point(39, 440);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnImprimir.Size = new System.Drawing.Size(130, 39);
            this.btnImprimir.TabIndex = 42;
            this.btnImprimir.Text = "Imprimir ";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtidcliente);
            this.groupBox1.Controls.Add(this.txtcorreocliente);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txttelcliente);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtnomyapecliente);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtdnicliente);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(18, 127);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(466, 145);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información de Cliente";
            // 
            // txtidcliente
            // 
            this.txtidcliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtidcliente.Location = new System.Drawing.Point(376, 45);
            this.txtidcliente.Name = "txtidcliente";
            this.txtidcliente.Size = new System.Drawing.Size(25, 25);
            this.txtidcliente.TabIndex = 32;
            this.txtidcliente.TextChanged += new System.EventHandler(this.txtidcliente_TextChanged);
            // 
            // txtcorreocliente
            // 
            this.txtcorreocliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtcorreocliente.Location = new System.Drawing.Point(209, 114);
            this.txtcorreocliente.Name = "txtcorreocliente";
            this.txtcorreocliente.Size = new System.Drawing.Size(108, 25);
            this.txtcorreocliente.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Leelawadee UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(206, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Correo";
            // 
            // txttelcliente
            // 
            this.txttelcliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txttelcliente.Location = new System.Drawing.Point(38, 112);
            this.txttelcliente.Name = "txttelcliente";
            this.txttelcliente.Size = new System.Drawing.Size(108, 25);
            this.txttelcliente.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Leelawadee UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(46, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Telefono";
            // 
            // txtnomyapecliente
            // 
            this.txtnomyapecliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtnomyapecliente.Location = new System.Drawing.Point(183, 46);
            this.txtnomyapecliente.Name = "txtnomyapecliente";
            this.txtnomyapecliente.Size = new System.Drawing.Size(168, 25);
            this.txtnomyapecliente.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Leelawadee UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(206, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nombre y Apellido";
            // 
            // txtdnicliente
            // 
            this.txtdnicliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtdnicliente.Location = new System.Drawing.Point(38, 46);
            this.txtdnicliente.Name = "txtdnicliente";
            this.txtdnicliente.Size = new System.Drawing.Size(108, 25);
            this.txtdnicliente.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Leelawadee UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(46, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "DNI";
            // 
            // formDetalleVent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1233, 606);
            this.Controls.Add(this.panelRigtUsuario);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panelTopUsuario);
            this.Controls.Add(this.GbxUsuario);
            this.Controls.Add(this.GbxInfoVent);
            this.Name = "formDetalleVent";
            this.Text = "formDetalleVent";
            this.Load += new System.EventHandler(this.formDetalleVent_Load);
            this.GbxInfoVent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVenta)).EndInit();
            this.GbxCliente.ResumeLayout(false);
            this.GbxCliente.PerformLayout();
            this.GbxUsuario.ResumeLayout(false);
            this.GbxUsuario.PerformLayout();
            this.panelTopUsuario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picUsuario)).EndInit();
            this.panelRigtUsuario.ResumeLayout(false);
            this.panelRigtUsuario.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox GbxInfoVent;
        private System.Windows.Forms.GroupBox GbxCliente;
        private System.Windows.Forms.TextBox txtfechaventa;
        private System.Windows.Forms.Label lblNombreyApe;
        private System.Windows.Forms.TextBox txtcodigoFactura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridVenta;
        private System.Windows.Forms.TextBox txtnomyapeusuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDniUsu;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.GroupBox GbxUsuario;
        private System.Windows.Forms.Panel panelTopUsuario;
        private System.Windows.Forms.Panel panelLogoTit;
        private System.Windows.Forms.PictureBox picUsuario;
        private System.Windows.Forms.Label lblTituloCli;
        private System.Windows.Forms.Panel panelRigtUsuario;
        public System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtnomyapecliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtdnicliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtidcliente;
        private System.Windows.Forms.TextBox txtcorreocliente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txttelcliente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnLimpiardetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
        private System.Windows.Forms.Button Bbuscarventas;
    }
}
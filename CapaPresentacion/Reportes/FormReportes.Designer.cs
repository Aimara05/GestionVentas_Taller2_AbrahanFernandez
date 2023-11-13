namespace CapaPresentacion
{
    partial class FormReportes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReportes));
            this.dataGridReportes = new System.Windows.Forms.DataGridView();
            this.fechaRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dniUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionCateg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboBusqueda = new System.Windows.Forms.ComboBox();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblTituloUsu = new System.Windows.Forms.Label();
            this.panetop = new System.Windows.Forms.Panel();
            this.btnExcel = new System.Windows.Forms.Button();
            this.Btnbuscarfecha = new System.Windows.Forms.Button();
            this.Btnlimp = new System.Windows.Forms.Button();
            this.Dfechafin = new System.Windows.Forms.DateTimePicker();
            this.Dfechainicio = new System.Windows.Forms.DateTimePicker();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.BtnGraficos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReportes)).BeginInit();
            this.panetop.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridReportes
            // 
            this.dataGridReportes.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Leelawadee UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridReportes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridReportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridReportes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fechaRegistro,
            this.codigoFactura,
            this.montoTotal,
            this.tipoPago,
            this.nombreUsuario,
            this.apellidoUsuario,
            this.dniUsuario,
            this.nombreCliente,
            this.apellidoCliente,
            this.documentoCliente,
            this.idProducto,
            this.nombreProd,
            this.descripcionCateg,
            this.descripcionMarca,
            this.precioVenta,
            this.cantidad,
            this.subtotal});
            this.dataGridReportes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridReportes.Location = new System.Drawing.Point(0, 107);
            this.dataGridReportes.MultiSelect = false;
            this.dataGridReportes.Name = "dataGridReportes";
            this.dataGridReportes.ReadOnly = true;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridReportes.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridReportes.RowTemplate.Height = 28;
            this.dataGridReportes.Size = new System.Drawing.Size(1740, 343);
            this.dataGridReportes.TabIndex = 27;
            // 
            // fechaRegistro
            // 
            this.fechaRegistro.HeaderText = "FechaRegistro";
            this.fechaRegistro.Name = "fechaRegistro";
            this.fechaRegistro.ReadOnly = true;
            // 
            // codigoFactura
            // 
            this.codigoFactura.HeaderText = "CodigoFactura";
            this.codigoFactura.Name = "codigoFactura";
            this.codigoFactura.ReadOnly = true;
            // 
            // montoTotal
            // 
            this.montoTotal.HeaderText = "MontoTotal";
            this.montoTotal.Name = "montoTotal";
            this.montoTotal.ReadOnly = true;
            // 
            // tipoPago
            // 
            this.tipoPago.HeaderText = "TipoPago";
            this.tipoPago.Name = "tipoPago";
            this.tipoPago.ReadOnly = true;
            // 
            // nombreUsuario
            // 
            this.nombreUsuario.HeaderText = "NombreUsuario";
            this.nombreUsuario.Name = "nombreUsuario";
            this.nombreUsuario.ReadOnly = true;
            // 
            // apellidoUsuario
            // 
            this.apellidoUsuario.HeaderText = "ApellidoUsuario";
            this.apellidoUsuario.Name = "apellidoUsuario";
            this.apellidoUsuario.ReadOnly = true;
            // 
            // dniUsuario
            // 
            this.dniUsuario.HeaderText = "DniUsuario";
            this.dniUsuario.Name = "dniUsuario";
            this.dniUsuario.ReadOnly = true;
            // 
            // nombreCliente
            // 
            this.nombreCliente.HeaderText = "NombreCliente";
            this.nombreCliente.Name = "nombreCliente";
            this.nombreCliente.ReadOnly = true;
            // 
            // apellidoCliente
            // 
            this.apellidoCliente.HeaderText = "ApellidoCliente";
            this.apellidoCliente.Name = "apellidoCliente";
            this.apellidoCliente.ReadOnly = true;
            // 
            // documentoCliente
            // 
            this.documentoCliente.HeaderText = "DocumentoCliente";
            this.documentoCliente.Name = "documentoCliente";
            this.documentoCliente.ReadOnly = true;
            // 
            // idProducto
            // 
            this.idProducto.HeaderText = "IdProducto";
            this.idProducto.Name = "idProducto";
            this.idProducto.ReadOnly = true;
            // 
            // nombreProd
            // 
            this.nombreProd.HeaderText = "NombreProducto";
            this.nombreProd.Name = "nombreProd";
            this.nombreProd.ReadOnly = true;
            // 
            // descripcionCateg
            // 
            this.descripcionCateg.HeaderText = "Categoria";
            this.descripcionCateg.Name = "descripcionCateg";
            this.descripcionCateg.ReadOnly = true;
            // 
            // descripcionMarca
            // 
            this.descripcionMarca.HeaderText = "Marca";
            this.descripcionMarca.Name = "descripcionMarca";
            this.descripcionMarca.ReadOnly = true;
            // 
            // precioVenta
            // 
            this.precioVenta.HeaderText = "PrecioVenta";
            this.precioVenta.Name = "precioVenta";
            this.precioVenta.ReadOnly = true;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            // 
            // subtotal
            // 
            this.subtotal.HeaderText = "Subtotal";
            this.subtotal.Name = "subtotal";
            this.subtotal.ReadOnly = true;
            // 
            // cboBusqueda
            // 
            this.cboBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBusqueda.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBusqueda.FormattingEnabled = true;
            this.cboBusqueda.Location = new System.Drawing.Point(787, 76);
            this.cboBusqueda.Name = "cboBusqueda";
            this.cboBusqueda.Size = new System.Drawing.Size(118, 25);
            this.cboBusqueda.TabIndex = 27;
            this.cboBusqueda.SelectedIndexChanged += new System.EventHandler(this.cboBusqueda_SelectedIndexChanged);
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusqueda.Location = new System.Drawing.Point(911, 76);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(119, 25);
            this.txtBusqueda.TabIndex = 28;
            this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.LightGray;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(787, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(89, 22);
            this.textBox1.TabIndex = 25;
            this.textBox1.Text = "Buscar por :";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
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
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(973, 46);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(25, 22);
            this.btnBuscar.TabIndex = 25;
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblTituloUsu
            // 
            this.lblTituloUsu.AutoSize = true;
            this.lblTituloUsu.Font = new System.Drawing.Font("Leelawadee UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloUsu.Location = new System.Drawing.Point(3, 1);
            this.lblTituloUsu.Name = "lblTituloUsu";
            this.lblTituloUsu.Size = new System.Drawing.Size(235, 37);
            this.lblTituloUsu.TabIndex = 1;
            this.lblTituloUsu.Text = "Reporte de Ventas";
            // 
            // panetop
            // 
            this.panetop.BackColor = System.Drawing.Color.LightGray;
            this.panetop.Controls.Add(this.BtnGraficos);
            this.panetop.Controls.Add(this.btnExcel);
            this.panetop.Controls.Add(this.Btnbuscarfecha);
            this.panetop.Controls.Add(this.Btnlimp);
            this.panetop.Controls.Add(this.Dfechafin);
            this.panetop.Controls.Add(this.Dfechainicio);
            this.panetop.Controls.Add(this.textBox3);
            this.panetop.Controls.Add(this.textBox2);
            this.panetop.Controls.Add(this.lblTituloUsu);
            this.panetop.Controls.Add(this.textBox1);
            this.panetop.Controls.Add(this.btnBuscar);
            this.panetop.Controls.Add(this.cboBusqueda);
            this.panetop.Controls.Add(this.txtBusqueda);
            this.panetop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panetop.Font = new System.Drawing.Font("Leelawadee UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panetop.Location = new System.Drawing.Point(0, 0);
            this.panetop.Name = "panetop";
            this.panetop.Size = new System.Drawing.Size(1740, 107);
            this.panetop.TabIndex = 26;
            // 
            // btnExcel
            // 
            this.btnExcel.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcel.Location = new System.Drawing.Point(387, 9);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(133, 29);
            this.btnExcel.TabIndex = 36;
            this.btnExcel.Text = "Descargar Excel";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // Btnbuscarfecha
            // 
            this.Btnbuscarfecha.BackColor = System.Drawing.Color.Silver;
            this.Btnbuscarfecha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btnbuscarfecha.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Btnbuscarfecha.FlatAppearance.BorderSize = 0;
            this.Btnbuscarfecha.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btnbuscarfecha.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(202)))), ((int)(((byte)(210)))));
            this.Btnbuscarfecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btnbuscarfecha.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnbuscarfecha.ForeColor = System.Drawing.Color.Black;
            this.Btnbuscarfecha.Image = ((System.Drawing.Image)(resources.GetObject("Btnbuscarfecha.Image")));
            this.Btnbuscarfecha.Location = new System.Drawing.Point(290, 73);
            this.Btnbuscarfecha.Name = "Btnbuscarfecha";
            this.Btnbuscarfecha.Size = new System.Drawing.Size(53, 28);
            this.Btnbuscarfecha.TabIndex = 35;
            this.Btnbuscarfecha.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btnbuscarfecha.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btnbuscarfecha.UseVisualStyleBackColor = false;
            this.Btnbuscarfecha.Click += new System.EventHandler(this.Btnbuscarfecha_Click);
            // 
            // Btnlimp
            // 
            this.Btnlimp.BackColor = System.Drawing.Color.Silver;
            this.Btnlimp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btnlimp.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Btnlimp.FlatAppearance.BorderSize = 0;
            this.Btnlimp.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btnlimp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(202)))), ((int)(((byte)(210)))));
            this.Btnlimp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btnlimp.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnlimp.ForeColor = System.Drawing.Color.Black;
            this.Btnlimp.Image = global::CapaPresentacion.Properties.Resources.limpieza_de_datos;
            this.Btnlimp.Location = new System.Drawing.Point(1004, 46);
            this.Btnlimp.Name = "Btnlimp";
            this.Btnlimp.Size = new System.Drawing.Size(25, 22);
            this.Btnlimp.TabIndex = 34;
            this.Btnlimp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btnlimp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btnlimp.UseVisualStyleBackColor = false;
            this.Btnlimp.Click += new System.EventHandler(this.Btnlimp_Click);
            // 
            // Dfechafin
            // 
            this.Dfechafin.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dfechafin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dfechafin.Location = new System.Drawing.Point(152, 74);
            this.Dfechafin.Name = "Dfechafin";
            this.Dfechafin.Size = new System.Drawing.Size(119, 27);
            this.Dfechafin.TabIndex = 33;
            // 
            // Dfechainicio
            // 
            this.Dfechainicio.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dfechainicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dfechainicio.Location = new System.Drawing.Point(17, 73);
            this.Dfechainicio.Name = "Dfechainicio";
            this.Dfechainicio.Size = new System.Drawing.Size(119, 27);
            this.Dfechainicio.TabIndex = 32;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.LightGray;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(152, 53);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(73, 16);
            this.textBox3.TabIndex = 31;
            this.textBox3.Text = "Fecha Fin:";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.LightGray;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(17, 52);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(89, 16);
            this.textBox2.TabIndex = 30;
            this.textBox2.Text = "Fecha Inicio:";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // BtnGraficos
            // 
            this.BtnGraficos.Location = new System.Drawing.Point(444, 53);
            this.BtnGraficos.Name = "BtnGraficos";
            this.BtnGraficos.Size = new System.Drawing.Size(150, 43);
            this.BtnGraficos.TabIndex = 37;
            this.BtnGraficos.Text = "Graficos";
            this.BtnGraficos.UseVisualStyleBackColor = true;
            this.BtnGraficos.Click += new System.EventHandler(this.BtnGraficos_Click);
            // 
            // FormReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1740, 450);
            this.Controls.Add(this.dataGridReportes);
            this.Controls.Add(this.panetop);
            this.Name = "FormReportes";
            this.Text = "FormReportes";
            this.Load += new System.EventHandler(this.FormReportes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReportes)).EndInit();
            this.panetop.ResumeLayout(false);
            this.panetop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridReportes;
        private System.Windows.Forms.ComboBox cboBusqueda;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblTituloUsu;
        private System.Windows.Forms.Panel panetop;
        private System.Windows.Forms.DateTimePicker Dfechainicio;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DateTimePicker Dfechafin;
        private System.Windows.Forms.Button Btnlimp;
        private System.Windows.Forms.Button Btnbuscarfecha;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn dniUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionCateg;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal;
        private System.Windows.Forms.Button BtnGraficos;
    }
}
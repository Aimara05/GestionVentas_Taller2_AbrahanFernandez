namespace CapaPresentacion.Modales
{
    partial class mdListarVentas
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
            this.panelBuscador = new System.Windows.Forms.Panel();
            this.btnLimpiar2 = new System.Windows.Forms.Button();
            this.btnBuscar2 = new System.Windows.Forms.Button();
            this.lblTituloProd = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.cboBusqueda = new System.Windows.Forms.ComboBox();
            this.panelTopProd = new System.Windows.Forms.Panel();
            this.dataGridVenta = new System.Windows.Forms.DataGridView();
            this.idVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTipoPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaReg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelBuscador.SuspendLayout();
            this.panelTopProd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBuscador
            // 
            this.panelBuscador.BackColor = System.Drawing.Color.Transparent;
            this.panelBuscador.Controls.Add(this.btnLimpiar2);
            this.panelBuscador.Controls.Add(this.btnBuscar2);
            this.panelBuscador.Controls.Add(this.lblTituloProd);
            this.panelBuscador.Controls.Add(this.textBox1);
            this.panelBuscador.Controls.Add(this.txtBusqueda);
            this.panelBuscador.Controls.Add(this.cboBusqueda);
            this.panelBuscador.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelBuscador.Location = new System.Drawing.Point(0, 0);
            this.panelBuscador.Name = "panelBuscador";
            this.panelBuscador.Size = new System.Drawing.Size(738, 107);
            this.panelBuscador.TabIndex = 26;
            // 
            // btnLimpiar2
            // 
            this.btnLimpiar2.BackColor = System.Drawing.Color.Silver;
            this.btnLimpiar2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLimpiar2.FlatAppearance.BorderSize = 0;
            this.btnLimpiar2.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnLimpiar2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(202)))), ((int)(((byte)(210)))));
            this.btnLimpiar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar2.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar2.ForeColor = System.Drawing.Color.Black;
            this.btnLimpiar2.Image = global::CapaPresentacion.Properties.Resources.limpieza_de_datos;
            this.btnLimpiar2.Location = new System.Drawing.Point(399, 74);
            this.btnLimpiar2.Name = "btnLimpiar2";
            this.btnLimpiar2.Size = new System.Drawing.Size(25, 22);
            this.btnLimpiar2.TabIndex = 31;
            this.btnLimpiar2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiar2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpiar2.UseVisualStyleBackColor = false;
            this.btnLimpiar2.Click += new System.EventHandler(this.btnLimpiar2_Click);
            // 
            // btnBuscar2
            // 
            this.btnBuscar2.BackColor = System.Drawing.Color.Silver;
            this.btnBuscar2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBuscar2.FlatAppearance.BorderSize = 0;
            this.btnBuscar2.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnBuscar2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(202)))), ((int)(((byte)(210)))));
            this.btnBuscar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar2.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar2.ForeColor = System.Drawing.Color.Black;
            this.btnBuscar2.Image = global::CapaPresentacion.Properties.Resources.busqueda;
            this.btnBuscar2.Location = new System.Drawing.Point(368, 74);
            this.btnBuscar2.Name = "btnBuscar2";
            this.btnBuscar2.Size = new System.Drawing.Size(25, 22);
            this.btnBuscar2.TabIndex = 25;
            this.btnBuscar2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar2.UseVisualStyleBackColor = false;
            this.btnBuscar2.Click += new System.EventHandler(this.btnBuscar2_Click);
            // 
            // lblTituloProd
            // 
            this.lblTituloProd.AutoSize = true;
            this.lblTituloProd.Location = new System.Drawing.Point(153, 9);
            this.lblTituloProd.Name = "lblTituloProd";
            this.lblTituloProd.Size = new System.Drawing.Size(138, 25);
            this.lblTituloProd.TabIndex = 1;
            this.lblTituloProd.Text = "Lista de Ventas";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.LightGray;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 74);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(76, 18);
            this.textBox1.TabIndex = 25;
            this.textBox1.Text = "Buscar por :";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusqueda.Location = new System.Drawing.Point(218, 71);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(144, 25);
            this.txtBusqueda.TabIndex = 28;
            // 
            // cboBusqueda
            // 
            this.cboBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBusqueda.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBusqueda.FormattingEnabled = true;
            this.cboBusqueda.Location = new System.Drawing.Point(94, 71);
            this.cboBusqueda.Name = "cboBusqueda";
            this.cboBusqueda.Size = new System.Drawing.Size(118, 25);
            this.cboBusqueda.TabIndex = 27;
            // 
            // panelTopProd
            // 
            this.panelTopProd.BackColor = System.Drawing.Color.LightGray;
            this.panelTopProd.Controls.Add(this.panelBuscador);
            this.panelTopProd.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopProd.Font = new System.Drawing.Font("Leelawadee UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelTopProd.Location = new System.Drawing.Point(0, 0);
            this.panelTopProd.Name = "panelTopProd";
            this.panelTopProd.Size = new System.Drawing.Size(737, 107);
            this.panelTopProd.TabIndex = 29;
            // 
            // dataGridVenta
            // 
            this.dataGridVenta.AllowUserToAddRows = false;
            this.dataGridVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idVenta,
            this.idUsuario,
            this.idCliente,
            this.nombreCliente,
            this.apellidoCliente,
            this.idTipoPago,
            this.descripcion,
            this.codigoFactura,
            this.fechaReg,
            this.montoTotal});
            this.dataGridVenta.Location = new System.Drawing.Point(0, 102);
            this.dataGridVenta.Name = "dataGridVenta";
            this.dataGridVenta.Size = new System.Drawing.Size(738, 357);
            this.dataGridVenta.TabIndex = 30;
            this.dataGridVenta.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridVenta_CellDoubleClick);
            // 
            // idVenta
            // 
            this.idVenta.HeaderText = "idVenta";
            this.idVenta.Name = "idVenta";
            // 
            // idUsuario
            // 
            this.idUsuario.HeaderText = "idUsuario";
            this.idUsuario.Name = "idUsuario";
            this.idUsuario.Visible = false;
            // 
            // idCliente
            // 
            this.idCliente.HeaderText = "idCliente";
            this.idCliente.Name = "idCliente";
            this.idCliente.Visible = false;
            // 
            // nombreCliente
            // 
            this.nombreCliente.HeaderText = "nombreCliente";
            this.nombreCliente.Name = "nombreCliente";
            // 
            // apellidoCliente
            // 
            this.apellidoCliente.HeaderText = "apellidoCliente";
            this.apellidoCliente.Name = "apellidoCliente";
            // 
            // idTipoPago
            // 
            this.idTipoPago.HeaderText = "idTipoPago";
            this.idTipoPago.Name = "idTipoPago";
            this.idTipoPago.Visible = false;
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "TipoPago";
            this.descripcion.Name = "descripcion";
            // 
            // codigoFactura
            // 
            this.codigoFactura.HeaderText = "codigoFactura";
            this.codigoFactura.Name = "codigoFactura";
            // 
            // fechaReg
            // 
            this.fechaReg.HeaderText = "fechaReg";
            this.fechaReg.Name = "fechaReg";
            // 
            // montoTotal
            // 
            this.montoTotal.HeaderText = "montoTotal";
            this.montoTotal.Name = "montoTotal";
            // 
            // mdListarVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 450);
            this.Controls.Add(this.dataGridVenta);
            this.Controls.Add(this.panelTopProd);
            this.Name = "mdListarVentas";
            this.Text = "mdListarVentas";
            this.Load += new System.EventHandler(this.mdListarVentas_Load);
            this.panelBuscador.ResumeLayout(false);
            this.panelBuscador.PerformLayout();
            this.panelTopProd.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVenta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelBuscador;
        private System.Windows.Forms.Button btnLimpiar2;
        private System.Windows.Forms.Button btnBuscar2;
        private System.Windows.Forms.Label lblTituloProd;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.ComboBox cboBusqueda;
        private System.Windows.Forms.Panel panelTopProd;
        private System.Windows.Forms.DataGridView dataGridVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTipoPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaReg;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoTotal;
    }
}
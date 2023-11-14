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
            this.btnLimpiar2 = new System.Windows.Forms.Button();
            this.btnBuscar2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.cboBusqueda = new System.Windows.Forms.ComboBox();
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
            this.panelBotonesCerrar = new System.Windows.Forms.Panel();
            this.picTitulo = new System.Windows.Forms.PictureBox();
            this.lblTituloPr = new System.Windows.Forms.Label();
            this.panelBotonesForm = new System.Windows.Forms.Panel();
            this.picCerrar = new System.Windows.Forms.PictureBox();
            this.panelTopUsuario = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVenta)).BeginInit();
            this.panelBotonesCerrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTitulo)).BeginInit();
            this.panelBotonesForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCerrar)).BeginInit();
            this.panelTopUsuario.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLimpiar2
            // 
            this.btnLimpiar2.BackColor = System.Drawing.Color.Silver;
            this.btnLimpiar2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLimpiar2.FlatAppearance.BorderSize = 0;
            this.btnLimpiar2.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnLimpiar2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(202)))), ((int)(((byte)(210)))));
            this.btnLimpiar2.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar2.ForeColor = System.Drawing.Color.Black;
            this.btnLimpiar2.Image = global::CapaPresentacion.Properties.Resources.limpieza_de_datos;
            this.btnLimpiar2.Location = new System.Drawing.Point(427, 66);
            this.btnLimpiar2.Name = "btnLimpiar2";
            this.btnLimpiar2.Size = new System.Drawing.Size(25, 25);
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
            this.btnBuscar2.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar2.ForeColor = System.Drawing.Color.Black;
            this.btnBuscar2.Image = global::CapaPresentacion.Properties.Resources.busqueda;
            this.btnBuscar2.Location = new System.Drawing.Point(396, 66);
            this.btnBuscar2.Name = "btnBuscar2";
            this.btnBuscar2.Size = new System.Drawing.Size(25, 25);
            this.btnBuscar2.TabIndex = 25;
            this.btnBuscar2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar2.UseVisualStyleBackColor = false;
            this.btnBuscar2.Click += new System.EventHandler(this.btnBuscar2_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Black;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(40, 69);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(76, 18);
            this.textBox1.TabIndex = 25;
            this.textBox1.Text = "Buscar por :";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusqueda.Location = new System.Drawing.Point(246, 66);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(144, 25);
            this.txtBusqueda.TabIndex = 28;
            // 
            // cboBusqueda
            // 
            this.cboBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBusqueda.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBusqueda.FormattingEnabled = true;
            this.cboBusqueda.Location = new System.Drawing.Point(122, 66);
            this.cboBusqueda.Name = "cboBusqueda";
            this.cboBusqueda.Size = new System.Drawing.Size(118, 25);
            this.cboBusqueda.TabIndex = 27;
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
            this.dataGridVenta.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridVenta.Location = new System.Drawing.Point(0, 206);
            this.dataGridVenta.Name = "dataGridVenta";
            this.dataGridVenta.Size = new System.Drawing.Size(753, 244);
            this.dataGridVenta.TabIndex = 31;
            this.dataGridVenta.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridVenta_CellDoubleClick_1);
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
            // panelBotonesCerrar
            // 
            this.panelBotonesCerrar.BackColor = System.Drawing.Color.LightGray;
            this.panelBotonesCerrar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelBotonesCerrar.Controls.Add(this.picTitulo);
            this.panelBotonesCerrar.Controls.Add(this.lblTituloPr);
            this.panelBotonesCerrar.Controls.Add(this.panelBotonesForm);
            this.panelBotonesCerrar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBotonesCerrar.Location = new System.Drawing.Point(0, 0);
            this.panelBotonesCerrar.Name = "panelBotonesCerrar";
            this.panelBotonesCerrar.Size = new System.Drawing.Size(753, 35);
            this.panelBotonesCerrar.TabIndex = 32;
            // 
            // picTitulo
            // 
            this.picTitulo.Image = global::CapaPresentacion.Properties.Resources.paraArticulos;
            this.picTitulo.Location = new System.Drawing.Point(160, 3);
            this.picTitulo.Name = "picTitulo";
            this.picTitulo.Size = new System.Drawing.Size(46, 29);
            this.picTitulo.TabIndex = 2;
            this.picTitulo.TabStop = false;
            // 
            // lblTituloPr
            // 
            this.lblTituloPr.AutoSize = true;
            this.lblTituloPr.Font = new System.Drawing.Font("Leelawadee UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloPr.Location = new System.Drawing.Point(10, 3);
            this.lblTituloPr.Name = "lblTituloPr";
            this.lblTituloPr.Size = new System.Drawing.Size(144, 25);
            this.lblTituloPr.TabIndex = 0;
            this.lblTituloPr.Text = "Lista de Ventas";
            // 
            // panelBotonesForm
            // 
            this.panelBotonesForm.BackColor = System.Drawing.Color.LightGray;
            this.panelBotonesForm.Controls.Add(this.picCerrar);
            this.panelBotonesForm.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelBotonesForm.Location = new System.Drawing.Point(637, 0);
            this.panelBotonesForm.Name = "panelBotonesForm";
            this.panelBotonesForm.Size = new System.Drawing.Size(112, 31);
            this.panelBotonesForm.TabIndex = 0;
            // 
            // picCerrar
            // 
            this.picCerrar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picCerrar.Image = global::CapaPresentacion.Properties.Resources.cruz_pequena;
            this.picCerrar.Location = new System.Drawing.Point(73, 2);
            this.picCerrar.Name = "picCerrar";
            this.picCerrar.Size = new System.Drawing.Size(29, 26);
            this.picCerrar.TabIndex = 2;
            this.picCerrar.TabStop = false;
            this.picCerrar.Click += new System.EventHandler(this.picCerrar_Click);
            // 
            // panelTopUsuario
            // 
            this.panelTopUsuario.BackColor = System.Drawing.Color.Black;
            this.panelTopUsuario.Controls.Add(this.panel1);
            this.panelTopUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopUsuario.Font = new System.Drawing.Font("Leelawadee UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelTopUsuario.Location = new System.Drawing.Point(0, 35);
            this.panelTopUsuario.Name = "panelTopUsuario";
            this.panelTopUsuario.Size = new System.Drawing.Size(753, 107);
            this.panelTopUsuario.TabIndex = 33;
            this.panelTopUsuario.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTopUsuario_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnLimpiar2);
            this.panel1.Controls.Add(this.txtBusqueda);
            this.panel1.Controls.Add(this.btnBuscar2);
            this.panel1.Controls.Add(this.cboBusqueda);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(503, 107);
            this.panel1.TabIndex = 26;
            // 
            // mdListarVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(753, 450);
            this.Controls.Add(this.panelTopUsuario);
            this.Controls.Add(this.panelBotonesCerrar);
            this.Controls.Add(this.dataGridVenta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "mdListarVentas";
            this.Text = "mdListarVentas";
            this.Load += new System.EventHandler(this.mdListarVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVenta)).EndInit();
            this.panelBotonesCerrar.ResumeLayout(false);
            this.panelBotonesCerrar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTitulo)).EndInit();
            this.panelBotonesForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCerrar)).EndInit();
            this.panelTopUsuario.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnLimpiar2;
        private System.Windows.Forms.Button btnBuscar2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.ComboBox cboBusqueda;
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
        private System.Windows.Forms.Panel panelBotonesCerrar;
        private System.Windows.Forms.PictureBox picTitulo;
        private System.Windows.Forms.Label lblTituloPr;
        private System.Windows.Forms.Panel panelBotonesForm;
        private System.Windows.Forms.PictureBox picCerrar;
        private System.Windows.Forms.Panel panelTopUsuario;
        private System.Windows.Forms.Panel panel1;
    }
}
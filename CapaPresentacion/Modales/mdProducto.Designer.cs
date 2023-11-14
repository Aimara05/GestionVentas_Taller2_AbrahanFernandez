namespace CapaPresentacion.Modales
{
    partial class mdProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mdProducto));
            this.dataGridProd = new System.Windows.Forms.DataGridView();
            this.idProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioUni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelBotonesCerrar = new System.Windows.Forms.Panel();
            this.picTitulo = new System.Windows.Forms.PictureBox();
            this.lblTituloPr = new System.Windows.Forms.Label();
            this.panelBotonesForm = new System.Windows.Forms.Panel();
            this.picCerrar = new System.Windows.Forms.PictureBox();
            this.panelTopUsuario = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtTitBuscar = new System.Windows.Forms.TextBox();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.cboBusqueda = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProd)).BeginInit();
            this.panelBotonesCerrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTitulo)).BeginInit();
            this.panelBotonesForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCerrar)).BeginInit();
            this.panelTopUsuario.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.idProducto,
            this.nombreProd,
            this.descripcionProd,
            this.stock,
            this.PrecioUni});
            this.dataGridProd.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridProd.Location = new System.Drawing.Point(0, 152);
            this.dataGridProd.MultiSelect = false;
            this.dataGridProd.Name = "dataGridProd";
            this.dataGridProd.ReadOnly = true;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridProd.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridProd.RowTemplate.Height = 28;
            this.dataGridProd.Size = new System.Drawing.Size(534, 175);
            this.dataGridProd.TabIndex = 0;
            this.dataGridProd.TabStop = false;
            this.dataGridProd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridProd_CellContentClick);
            this.dataGridProd.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridProd_CellDoubleClick);
            // 
            // idProducto
            // 
            this.idProducto.HeaderText = "idProd";
            this.idProducto.Name = "idProducto";
            this.idProducto.ReadOnly = true;
            this.idProducto.Visible = false;
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
            // stock
            // 
            this.stock.HeaderText = "stock";
            this.stock.Name = "stock";
            this.stock.ReadOnly = true;
            // 
            // PrecioUni
            // 
            this.PrecioUni.HeaderText = "Precio";
            this.PrecioUni.Name = "PrecioUni";
            this.PrecioUni.ReadOnly = true;
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
            this.panelBotonesCerrar.Size = new System.Drawing.Size(534, 35);
            this.panelBotonesCerrar.TabIndex = 30;
            // 
            // picTitulo
            // 
            this.picTitulo.Image = global::CapaPresentacion.Properties.Resources.cliente;
            this.picTitulo.Location = new System.Drawing.Point(120, 0);
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
            this.lblTituloPr.Size = new System.Drawing.Size(104, 25);
            this.lblTituloPr.TabIndex = 0;
            this.lblTituloPr.Text = "Productos";
            // 
            // panelBotonesForm
            // 
            this.panelBotonesForm.BackColor = System.Drawing.Color.LightGray;
            this.panelBotonesForm.Controls.Add(this.picCerrar);
            this.panelBotonesForm.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelBotonesForm.Location = new System.Drawing.Point(418, 0);
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
            this.panelTopUsuario.Font = new System.Drawing.Font("Leelawadee UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelTopUsuario.Location = new System.Drawing.Point(0, 37);
            this.panelTopUsuario.Name = "panelTopUsuario";
            this.panelTopUsuario.Size = new System.Drawing.Size(534, 107);
            this.panelTopUsuario.TabIndex = 31;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnLimpiar);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.txtTitBuscar);
            this.panel1.Controls.Add(this.txtBusqueda);
            this.panel1.Controls.Add(this.cboBusqueda);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(503, 107);
            this.panel1.TabIndex = 26;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Silver;
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(202)))), ((int)(((byte)(210)))));
            this.btnLimpiar.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.Black;
            this.btnLimpiar.Image = global::CapaPresentacion.Properties.Resources.limpieza_de_datos;
            this.btnLimpiar.Location = new System.Drawing.Point(442, 50);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(38, 26);
            this.btnLimpiar.TabIndex = 3;
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpiar.UseVisualStyleBackColor = false;
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
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(398, 50);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(38, 26);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = ".";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtTitBuscar
            // 
            this.txtTitBuscar.BackColor = System.Drawing.Color.Black;
            this.txtTitBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTitBuscar.ForeColor = System.Drawing.Color.Transparent;
            this.txtTitBuscar.Location = new System.Drawing.Point(12, 50);
            this.txtTitBuscar.Name = "txtTitBuscar";
            this.txtTitBuscar.Size = new System.Drawing.Size(106, 26);
            this.txtTitBuscar.TabIndex = 0;
            this.txtTitBuscar.TabStop = false;
            this.txtTitBuscar.Text = "Buscar por :";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusqueda.Location = new System.Drawing.Point(248, 51);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(144, 25);
            this.txtBusqueda.TabIndex = 1;
            // 
            // cboBusqueda
            // 
            this.cboBusqueda.BackColor = System.Drawing.Color.White;
            this.cboBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBusqueda.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBusqueda.FormattingEnabled = true;
            this.cboBusqueda.Location = new System.Drawing.Point(124, 50);
            this.cboBusqueda.Name = "cboBusqueda";
            this.cboBusqueda.Size = new System.Drawing.Size(118, 25);
            this.cboBusqueda.TabIndex = 0;
            this.cboBusqueda.TabStop = false;
            // 
            // mdProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(534, 327);
            this.Controls.Add(this.panelTopUsuario);
            this.Controls.Add(this.panelBotonesCerrar);
            this.Controls.Add(this.dataGridProd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "mdProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mdProducto";
            this.Load += new System.EventHandler(this.mdProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProd)).EndInit();
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

        public System.Windows.Forms.DataGridView dataGridProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioUni;
        private System.Windows.Forms.Panel panelBotonesCerrar;
        private System.Windows.Forms.PictureBox picTitulo;
        private System.Windows.Forms.Label lblTituloPr;
        private System.Windows.Forms.Panel panelBotonesForm;
        private System.Windows.Forms.PictureBox picCerrar;
        private System.Windows.Forms.Panel panelTopUsuario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtTitBuscar;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.ComboBox cboBusqueda;
    }
}
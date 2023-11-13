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
            this.dataGridProd = new System.Windows.Forms.DataGridView();
            this.idProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioUni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelTopProd = new System.Windows.Forms.Panel();
            this.btnLimpiar2 = new System.Windows.Forms.Button();
            this.panelBuscador = new System.Windows.Forms.Panel();
            this.btnBuscar2 = new System.Windows.Forms.Button();
            this.lblTituloProd = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.cboBusqueda = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProd)).BeginInit();
            this.panelTopProd.SuspendLayout();
            this.panelBuscador.SuspendLayout();
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
            this.dataGridProd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridProd.Location = new System.Drawing.Point(0, 107);
            this.dataGridProd.MultiSelect = false;
            this.dataGridProd.Name = "dataGridProd";
            this.dataGridProd.ReadOnly = true;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridProd.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridProd.RowTemplate.Height = 28;
            this.dataGridProd.Size = new System.Drawing.Size(1072, 113);
            this.dataGridProd.TabIndex = 28;
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
            // panelTopProd
            // 
            this.panelTopProd.BackColor = System.Drawing.Color.LightGray;
            this.panelTopProd.Controls.Add(this.btnLimpiar2);
            this.panelTopProd.Controls.Add(this.panelBuscador);
            this.panelTopProd.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopProd.Font = new System.Drawing.Font("Leelawadee UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelTopProd.Location = new System.Drawing.Point(0, 0);
            this.panelTopProd.Name = "panelTopProd";
            this.panelTopProd.Size = new System.Drawing.Size(1072, 107);
            this.panelTopProd.TabIndex = 27;
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
            this.btnLimpiar2.Location = new System.Drawing.Point(428, 46);
            this.btnLimpiar2.Name = "btnLimpiar2";
            this.btnLimpiar2.Size = new System.Drawing.Size(25, 22);
            this.btnLimpiar2.TabIndex = 31;
            this.btnLimpiar2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiar2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpiar2.UseVisualStyleBackColor = false;
            this.btnLimpiar2.Click += new System.EventHandler(this.btnLimpiar2_Click);
            // 
            // panelBuscador
            // 
            this.panelBuscador.BackColor = System.Drawing.Color.Transparent;
            this.panelBuscador.Controls.Add(this.btnBuscar2);
            this.panelBuscador.Controls.Add(this.lblTituloProd);
            this.panelBuscador.Controls.Add(this.textBox1);
            this.panelBuscador.Controls.Add(this.txtBusqueda);
            this.panelBuscador.Controls.Add(this.cboBusqueda);
            this.panelBuscador.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelBuscador.Location = new System.Drawing.Point(0, 0);
            this.panelBuscador.Name = "panelBuscador";
            this.panelBuscador.Size = new System.Drawing.Size(464, 107);
            this.panelBuscador.TabIndex = 26;
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
            this.btnBuscar2.Location = new System.Drawing.Point(397, 48);
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
            this.lblTituloProd.Location = new System.Drawing.Point(6, 9);
            this.lblTituloProd.Name = "lblTituloProd";
            this.lblTituloProd.Size = new System.Drawing.Size(166, 25);
            this.lblTituloProd.TabIndex = 1;
            this.lblTituloProd.Text = "Lista de Productos";
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
            // mdProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 220);
            this.Controls.Add(this.dataGridProd);
            this.Controls.Add(this.panelTopProd);
            this.Name = "mdProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mdProducto";
            this.Load += new System.EventHandler(this.mdProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProd)).EndInit();
            this.panelTopProd.ResumeLayout(false);
            this.panelBuscador.ResumeLayout(false);
            this.panelBuscador.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridProd;
        private System.Windows.Forms.Panel panelTopProd;
        private System.Windows.Forms.Panel panelBuscador;
        private System.Windows.Forms.Button btnBuscar2;
        private System.Windows.Forms.Label lblTituloProd;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.ComboBox cboBusqueda;
        private System.Windows.Forms.Button btnLimpiar2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioUni;
    }
}
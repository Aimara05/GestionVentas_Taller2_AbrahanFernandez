namespace CapaPresentacion
{
    partial class FormCategorias
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTopCateg = new System.Windows.Forms.Panel();
            this.panelLogoTit = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.picUsuario = new System.Windows.Forms.PictureBox();
            this.panelBuscador = new System.Windows.Forms.Panel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtbuscarPor = new System.Windows.Forms.TextBox();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.cboBusqueda = new System.Windows.Forms.ComboBox();
            this.panelRigtUsuario = new System.Windows.Forms.Panel();
            this.btnEditarCateg = new System.Windows.Forms.Button();
            this.btnRegistrarCateg = new System.Windows.Forms.Button();
            this.dataGridCateg = new System.Windows.Forms.DataGridView();
            this.btnSeleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.idCateg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelFormu = new System.Windows.Forms.Panel();
            this.lblTituloCli = new System.Windows.Forms.Label();
            this.panelTopCateg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUsuario)).BeginInit();
            this.panelBuscador.SuspendLayout();
            this.panelRigtUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCateg)).BeginInit();
            this.panelFormu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTopCateg
            // 
            this.panelTopCateg.BackColor = System.Drawing.Color.LightGray;
            this.panelTopCateg.Controls.Add(this.panelLogoTit);
            this.panelTopCateg.Controls.Add(this.panelBuscador);
            this.panelTopCateg.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopCateg.Font = new System.Drawing.Font("Leelawadee UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelTopCateg.Location = new System.Drawing.Point(0, 0);
            this.panelTopCateg.Name = "panelTopCateg";
            this.panelTopCateg.Size = new System.Drawing.Size(799, 107);
            this.panelTopCateg.TabIndex = 1;
            this.panelTopCateg.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTopCateg_Paint_1);
            // 
            // panelLogoTit
            // 
            this.panelLogoTit.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelLogoTit.Location = new System.Drawing.Point(522, 0);
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
            this.btnRefresh.Location = new System.Drawing.Point(29, 137);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(34, 38);
            this.btnRefresh.TabIndex = 7;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // picUsuario
            // 
            this.picUsuario.BackColor = System.Drawing.Color.LightGray;
            this.picUsuario.Image = global::CapaPresentacion.Properties.Resources.lista;
            this.picUsuario.Location = new System.Drawing.Point(108, 48);
            this.picUsuario.Name = "picUsuario";
            this.picUsuario.Padding = new System.Windows.Forms.Padding(0, 0, 40, 0);
            this.picUsuario.Size = new System.Drawing.Size(70, 71);
            this.picUsuario.TabIndex = 0;
            this.picUsuario.TabStop = false;
            // 
            // panelBuscador
            // 
            this.panelBuscador.BackColor = System.Drawing.Color.Transparent;
            this.panelBuscador.Controls.Add(this.btnBuscar);
            this.panelBuscador.Controls.Add(this.txtbuscarPor);
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
            // txtbuscarPor
            // 
            this.txtbuscarPor.BackColor = System.Drawing.Color.LightGray;
            this.txtbuscarPor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbuscarPor.Location = new System.Drawing.Point(11, 40);
            this.txtbuscarPor.Name = "txtbuscarPor";
            this.txtbuscarPor.Size = new System.Drawing.Size(106, 26);
            this.txtbuscarPor.TabIndex = 25;
            this.txtbuscarPor.Text = "Buscar por :";
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
            this.panelRigtUsuario.Controls.Add(this.btnRefresh);
            this.panelRigtUsuario.Controls.Add(this.lblTituloCli);
            this.panelRigtUsuario.Controls.Add(this.picUsuario);
            this.panelRigtUsuario.Controls.Add(this.btnEditarCateg);
            this.panelRigtUsuario.Controls.Add(this.btnRegistrarCateg);
            this.panelRigtUsuario.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRigtUsuario.Location = new System.Drawing.Point(525, 107);
            this.panelRigtUsuario.Name = "panelRigtUsuario";
            this.panelRigtUsuario.Size = new System.Drawing.Size(274, 403);
            this.panelRigtUsuario.TabIndex = 3;
            // 
            // btnEditarCateg
            // 
            this.btnEditarCateg.BackColor = System.Drawing.Color.LightGray;
            this.btnEditarCateg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarCateg.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnEditarCateg.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnEditarCateg.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(202)))), ((int)(((byte)(210)))));
            this.btnEditarCateg.Font = new System.Drawing.Font("Leelawadee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarCateg.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEditarCateg.Image = global::CapaPresentacion.Properties.Resources.editar;
            this.btnEditarCateg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarCateg.Location = new System.Drawing.Point(154, 201);
            this.btnEditarCateg.Name = "btnEditarCateg";
            this.btnEditarCateg.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnEditarCateg.Size = new System.Drawing.Size(49, 49);
            this.btnEditarCateg.TabIndex = 0;
            this.btnEditarCateg.TabStop = false;
            this.btnEditarCateg.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditarCateg.UseVisualStyleBackColor = false;
            this.btnEditarCateg.Click += new System.EventHandler(this.btnEditarCateg_Click);
            // 
            // btnRegistrarCateg
            // 
            this.btnRegistrarCateg.BackColor = System.Drawing.Color.LightGray;
            this.btnRegistrarCateg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrarCateg.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnRegistrarCateg.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnRegistrarCateg.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(202)))), ((int)(((byte)(210)))));
            this.btnRegistrarCateg.Font = new System.Drawing.Font("Leelawadee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarCateg.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRegistrarCateg.Image = global::CapaPresentacion.Properties.Resources.paraArticulos;
            this.btnRegistrarCateg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrarCateg.Location = new System.Drawing.Point(93, 201);
            this.btnRegistrarCateg.Name = "btnRegistrarCateg";
            this.btnRegistrarCateg.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnRegistrarCateg.Size = new System.Drawing.Size(49, 49);
            this.btnRegistrarCateg.TabIndex = 0;
            this.btnRegistrarCateg.TabStop = false;
            this.btnRegistrarCateg.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegistrarCateg.UseVisualStyleBackColor = false;
            this.btnRegistrarCateg.Click += new System.EventHandler(this.btnRegistrarCateg_Click);
            // 
            // dataGridCateg
            // 
            this.dataGridCateg.AllowUserToAddRows = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Leelawadee UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridCateg.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridCateg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCateg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnSeleccionar,
            this.idCateg,
            this.descripcion,
            this.Estado});
            this.dataGridCateg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridCateg.Location = new System.Drawing.Point(0, 0);
            this.dataGridCateg.MultiSelect = false;
            this.dataGridCateg.Name = "dataGridCateg";
            this.dataGridCateg.ReadOnly = true;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridCateg.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridCateg.RowTemplate.Height = 28;
            this.dataGridCateg.Size = new System.Drawing.Size(525, 403);
            this.dataGridCateg.TabIndex = 27;
            this.dataGridCateg.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCateg_CellClick);
            this.dataGridCateg.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCateg_CellContentClick);
            this.dataGridCateg.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridCateg_CellFormatting);
            this.dataGridCateg.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridCateg_CellPainting);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.HeaderText = "";
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.ReadOnly = true;
            this.btnSeleccionar.Width = 88;
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
            this.descripcion.HeaderText = "Descripcion";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            this.descripcion.Width = 88;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Width = 88;
            // 
            // panelFormu
            // 
            this.panelFormu.Controls.Add(this.dataGridCateg);
            this.panelFormu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFormu.Location = new System.Drawing.Point(0, 107);
            this.panelFormu.Name = "panelFormu";
            this.panelFormu.Size = new System.Drawing.Size(525, 403);
            this.panelFormu.TabIndex = 28;
            // 
            // lblTituloCli
            // 
            this.lblTituloCli.AutoSize = true;
            this.lblTituloCli.Font = new System.Drawing.Font("Leelawadee UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloCli.Location = new System.Drawing.Point(69, 137);
            this.lblTituloCli.Name = "lblTituloCli";
            this.lblTituloCli.Size = new System.Drawing.Size(156, 37);
            this.lblTituloCli.TabIndex = 9;
            this.lblTituloCli.Text = "Categorías";
            // 
            // FormCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 510);
            this.Controls.Add(this.panelFormu);
            this.Controls.Add(this.panelRigtUsuario);
            this.Controls.Add(this.panelTopCateg);
            this.Name = "FormCategorias";
            this.Text = "FormCategorias";
            this.Load += new System.EventHandler(this.FormCategorias_Load);
            this.panelTopCateg.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picUsuario)).EndInit();
            this.panelBuscador.ResumeLayout(false);
            this.panelBuscador.PerformLayout();
            this.panelRigtUsuario.ResumeLayout(false);
            this.panelRigtUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCateg)).EndInit();
            this.panelFormu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTopCateg;
        private System.Windows.Forms.Panel panelLogoTit;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.PictureBox picUsuario;
        private System.Windows.Forms.Panel panelBuscador;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtbuscarPor;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.ComboBox cboBusqueda;
        private System.Windows.Forms.Panel panelRigtUsuario;
        public System.Windows.Forms.Button btnEditarCateg;
        public System.Windows.Forms.Button btnRegistrarCateg;
        public System.Windows.Forms.DataGridView dataGridCateg;
        private System.Windows.Forms.DataGridViewButtonColumn btnSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCateg;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.Panel panelFormu;
        private System.Windows.Forms.Label lblTituloCli;
    }
}
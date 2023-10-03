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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTopCateg = new System.Windows.Forms.Panel();
            this.panelLogoTit = new System.Windows.Forms.Panel();
            this.lblTituloCateg = new System.Windows.Forms.Label();
            this.panelBuscador = new System.Windows.Forms.Panel();
            this.txtbuscarPor = new System.Windows.Forms.TextBox();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.cboBusqueda = new System.Windows.Forms.ComboBox();
            this.panelRigtUsuario = new System.Windows.Forms.Panel();
            this.dataGridUsuario = new System.Windows.Forms.DataGridView();
            this.btnSeleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.idCateg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAltaUsu = new System.Windows.Forms.Button();
            this.btnBajaCateg = new System.Windows.Forms.Button();
            this.btnEditarCateg = new System.Windows.Forms.Button();
            this.btnAltaCateg = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.picUsuario = new System.Windows.Forms.PictureBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.panelTopCateg.SuspendLayout();
            this.panelLogoTit.SuspendLayout();
            this.panelBuscador.SuspendLayout();
            this.panelRigtUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUsuario)).BeginInit();
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
            // 
            // panelLogoTit
            // 
            this.panelLogoTit.Controls.Add(this.btnRefresh);
            this.panelLogoTit.Controls.Add(this.lblTituloCateg);
            this.panelLogoTit.Controls.Add(this.picUsuario);
            this.panelLogoTit.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelLogoTit.Location = new System.Drawing.Point(522, 0);
            this.panelLogoTit.Name = "panelLogoTit";
            this.panelLogoTit.Size = new System.Drawing.Size(277, 107);
            this.panelLogoTit.TabIndex = 27;
            // 
            // lblTituloCateg
            // 
            this.lblTituloCateg.AutoSize = true;
            this.lblTituloCateg.Location = new System.Drawing.Point(3, 41);
            this.lblTituloCateg.Name = "lblTituloCateg";
            this.lblTituloCateg.Size = new System.Drawing.Size(102, 25);
            this.lblTituloCateg.TabIndex = 1;
            this.lblTituloCateg.Text = "Categorías";
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
            this.panelRigtUsuario.Controls.Add(this.btnAltaUsu);
            this.panelRigtUsuario.Controls.Add(this.btnBajaCateg);
            this.panelRigtUsuario.Controls.Add(this.btnEditarCateg);
            this.panelRigtUsuario.Controls.Add(this.btnAltaCateg);
            this.panelRigtUsuario.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRigtUsuario.Location = new System.Drawing.Point(596, 107);
            this.panelRigtUsuario.Name = "panelRigtUsuario";
            this.panelRigtUsuario.Size = new System.Drawing.Size(203, 403);
            this.panelRigtUsuario.TabIndex = 3;
            // 
            // dataGridUsuario
            // 
            this.dataGridUsuario.AllowUserToAddRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Leelawadee UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridUsuario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnSeleccionar,
            this.idCateg,
            this.nombre,
            this.descripcion,
            this.Estado});
            this.dataGridUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridUsuario.Location = new System.Drawing.Point(0, 107);
            this.dataGridUsuario.MultiSelect = false;
            this.dataGridUsuario.Name = "dataGridUsuario";
            this.dataGridUsuario.ReadOnly = true;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridUsuario.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridUsuario.RowTemplate.Height = 28;
            this.dataGridUsuario.Size = new System.Drawing.Size(596, 403);
            this.dataGridUsuario.TabIndex = 27;
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
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Width = 88;
            // 
            // btnAltaUsu
            // 
            this.btnAltaUsu.BackColor = System.Drawing.Color.LightGray;
            this.btnAltaUsu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAltaUsu.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnAltaUsu.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnAltaUsu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(202)))), ((int)(((byte)(210)))));
            this.btnAltaUsu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAltaUsu.Font = new System.Drawing.Font("Leelawadee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAltaUsu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAltaUsu.Image = global::CapaPresentacion.Properties.Resources.usuarios_alt1;
            this.btnAltaUsu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAltaUsu.Location = new System.Drawing.Point(19, 239);
            this.btnAltaUsu.Name = "btnAltaUsu";
            this.btnAltaUsu.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnAltaUsu.Size = new System.Drawing.Size(166, 49);
            this.btnAltaUsu.TabIndex = 7;
            this.btnAltaUsu.Text = "Alta Usuario";
            this.btnAltaUsu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAltaUsu.UseVisualStyleBackColor = false;
            // 
            // btnBajaCateg
            // 
            this.btnBajaCateg.BackColor = System.Drawing.Color.LightGray;
            this.btnBajaCateg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBajaCateg.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnBajaCateg.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnBajaCateg.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(202)))), ((int)(((byte)(210)))));
            this.btnBajaCateg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBajaCateg.Font = new System.Drawing.Font("Leelawadee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBajaCateg.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBajaCateg.Image = global::CapaPresentacion.Properties.Resources.papelera_xmark;
            this.btnBajaCateg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBajaCateg.Location = new System.Drawing.Point(19, 173);
            this.btnBajaCateg.Name = "btnBajaCateg";
            this.btnBajaCateg.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnBajaCateg.Size = new System.Drawing.Size(166, 49);
            this.btnBajaCateg.TabIndex = 5;
            this.btnBajaCateg.Text = "Baja Categoría";
            this.btnBajaCateg.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBajaCateg.UseVisualStyleBackColor = false;
            // 
            // btnEditarCateg
            // 
            this.btnEditarCateg.BackColor = System.Drawing.Color.LightGray;
            this.btnEditarCateg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarCateg.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnEditarCateg.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnEditarCateg.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(202)))), ((int)(((byte)(210)))));
            this.btnEditarCateg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarCateg.Font = new System.Drawing.Font("Leelawadee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarCateg.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEditarCateg.Image = global::CapaPresentacion.Properties.Resources.editar;
            this.btnEditarCateg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarCateg.Location = new System.Drawing.Point(19, 102);
            this.btnEditarCateg.Name = "btnEditarCateg";
            this.btnEditarCateg.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnEditarCateg.Size = new System.Drawing.Size(167, 49);
            this.btnEditarCateg.TabIndex = 6;
            this.btnEditarCateg.Text = "Editar Categoría";
            this.btnEditarCateg.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditarCateg.UseVisualStyleBackColor = false;
            // 
            // btnAltaCateg
            // 
            this.btnAltaCateg.BackColor = System.Drawing.Color.LightGray;
            this.btnAltaCateg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAltaCateg.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnAltaCateg.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnAltaCateg.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(202)))), ((int)(((byte)(210)))));
            this.btnAltaCateg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAltaCateg.Font = new System.Drawing.Font("Leelawadee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAltaCateg.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAltaCateg.Image = global::CapaPresentacion.Properties.Resources.paraArticulos;
            this.btnAltaCateg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAltaCateg.Location = new System.Drawing.Point(19, 36);
            this.btnAltaCateg.Name = "btnAltaCateg";
            this.btnAltaCateg.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnAltaCateg.Size = new System.Drawing.Size(166, 49);
            this.btnAltaCateg.TabIndex = 4;
            this.btnAltaCateg.Text = "Añadir Categoría";
            this.btnAltaCateg.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAltaCateg.UseVisualStyleBackColor = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Image = global::CapaPresentacion.Properties.Resources.recargar;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.Location = new System.Drawing.Point(111, 35);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(34, 38);
            this.btnRefresh.TabIndex = 7;
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // picUsuario
            // 
            this.picUsuario.BackColor = System.Drawing.Color.LightGray;
            this.picUsuario.Image = global::CapaPresentacion.Properties.Resources.lista;
            this.picUsuario.Location = new System.Drawing.Point(176, 21);
            this.picUsuario.Name = "picUsuario";
            this.picUsuario.Padding = new System.Windows.Forms.Padding(0, 0, 40, 0);
            this.picUsuario.Size = new System.Drawing.Size(70, 71);
            this.picUsuario.TabIndex = 0;
            this.picUsuario.TabStop = false;
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
            // FormCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 510);
            this.Controls.Add(this.dataGridUsuario);
            this.Controls.Add(this.panelRigtUsuario);
            this.Controls.Add(this.panelTopCateg);
            this.Name = "FormCategorias";
            this.Text = "FormCategorias";
            this.panelTopCateg.ResumeLayout(false);
            this.panelLogoTit.ResumeLayout(false);
            this.panelLogoTit.PerformLayout();
            this.panelBuscador.ResumeLayout(false);
            this.panelBuscador.PerformLayout();
            this.panelRigtUsuario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUsuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTopCateg;
        private System.Windows.Forms.Panel panelLogoTit;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblTituloCateg;
        private System.Windows.Forms.PictureBox picUsuario;
        private System.Windows.Forms.Panel panelBuscador;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtbuscarPor;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.ComboBox cboBusqueda;
        private System.Windows.Forms.Panel panelRigtUsuario;
        public System.Windows.Forms.Button btnAltaUsu;
        public System.Windows.Forms.Button btnBajaCateg;
        public System.Windows.Forms.Button btnEditarCateg;
        public System.Windows.Forms.Button btnAltaCateg;
        public System.Windows.Forms.DataGridView dataGridUsuario;
        private System.Windows.Forms.DataGridViewButtonColumn btnSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCateg;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}
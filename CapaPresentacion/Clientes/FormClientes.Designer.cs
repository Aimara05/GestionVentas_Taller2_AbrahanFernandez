namespace CapaPresentacion
{
    partial class FormClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClientes));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTopUsuario = new System.Windows.Forms.Panel();
            this.panelBuscador = new System.Windows.Forms.Panel();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.cboBusqueda = new System.Windows.Forms.ComboBox();
            this.picUsuario = new System.Windows.Forms.PictureBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblTituloCli = new System.Windows.Forms.Label();
            this.panelRigtUsuario = new System.Windows.Forms.Panel();
            this.btnEditarCliente = new System.Windows.Forms.Button();
            this.btnAltaCliente = new System.Windows.Forms.Button();
            this.dataGridClientes = new System.Windows.Forms.DataGridView();
            this.btnSeleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.idCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod_estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelCliente = new System.Windows.Forms.Panel();
            this.panelTopUsuario.SuspendLayout();
            this.panelBuscador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUsuario)).BeginInit();
            this.panelRigtUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClientes)).BeginInit();
            this.panelCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTopUsuario
            // 
            this.panelTopUsuario.BackColor = System.Drawing.Color.LightGray;
            this.panelTopUsuario.Controls.Add(this.panelBuscador);
            this.panelTopUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopUsuario.Font = new System.Drawing.Font("Leelawadee UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelTopUsuario.Location = new System.Drawing.Point(0, 0);
            this.panelTopUsuario.Name = "panelTopUsuario";
            this.panelTopUsuario.Size = new System.Drawing.Size(800, 107);
            this.panelTopUsuario.TabIndex = 1;
            // 
            // panelBuscador
            // 
            this.panelBuscador.BackColor = System.Drawing.Color.Transparent;
            this.panelBuscador.Controls.Add(this.btnLimpiar);
            this.panelBuscador.Controls.Add(this.btnBuscar);
            this.panelBuscador.Controls.Add(this.textBox1);
            this.panelBuscador.Controls.Add(this.txtBusqueda);
            this.panelBuscador.Controls.Add(this.cboBusqueda);
            this.panelBuscador.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelBuscador.Location = new System.Drawing.Point(0, 0);
            this.panelBuscador.Name = "panelBuscador";
            this.panelBuscador.Size = new System.Drawing.Size(485, 107);
            this.panelBuscador.TabIndex = 26;
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
            this.btnLimpiar.Location = new System.Drawing.Point(436, 42);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(33, 26);
            this.btnLimpiar.TabIndex = 30;
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click_1);
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
            this.btnBuscar.Location = new System.Drawing.Point(397, 42);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(33, 26);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.LightGray;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(11, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(106, 26);
            this.textBox1.TabIndex = 25;
            this.textBox1.Text = "Buscar por :";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusqueda.Location = new System.Drawing.Point(247, 42);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(144, 25);
            this.txtBusqueda.TabIndex = 1;
            // 
            // cboBusqueda
            // 
            this.cboBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBusqueda.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBusqueda.FormattingEnabled = true;
            this.cboBusqueda.Location = new System.Drawing.Point(123, 43);
            this.cboBusqueda.Name = "cboBusqueda";
            this.cboBusqueda.Size = new System.Drawing.Size(118, 25);
            this.cboBusqueda.TabIndex = 27;
            // 
            // picUsuario
            // 
            this.picUsuario.BackColor = System.Drawing.Color.LightGray;
            this.picUsuario.Image = ((System.Drawing.Image)(resources.GetObject("picUsuario.Image")));
            this.picUsuario.Location = new System.Drawing.Point(70, 34);
            this.picUsuario.Name = "picUsuario";
            this.picUsuario.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.picUsuario.Size = new System.Drawing.Size(89, 89);
            this.picUsuario.TabIndex = 2;
            this.picUsuario.TabStop = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.Location = new System.Drawing.Point(23, 161);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(34, 38);
            this.btnRefresh.TabIndex = 8;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click_1);
            // 
            // lblTituloCli
            // 
            this.lblTituloCli.AutoSize = true;
            this.lblTituloCli.Font = new System.Drawing.Font("Leelawadee UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloCli.Location = new System.Drawing.Point(63, 155);
            this.lblTituloCli.Name = "lblTituloCli";
            this.lblTituloCli.Size = new System.Drawing.Size(119, 37);
            this.lblTituloCli.TabIndex = 1;
            this.lblTituloCli.Text = "Clientes";
            // 
            // panelRigtUsuario
            // 
            this.panelRigtUsuario.BackColor = System.Drawing.Color.LightGray;
            this.panelRigtUsuario.Controls.Add(this.picUsuario);
            this.panelRigtUsuario.Controls.Add(this.btnRefresh);
            this.panelRigtUsuario.Controls.Add(this.btnEditarCliente);
            this.panelRigtUsuario.Controls.Add(this.lblTituloCli);
            this.panelRigtUsuario.Controls.Add(this.btnAltaCliente);
            this.panelRigtUsuario.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRigtUsuario.Location = new System.Drawing.Point(604, 107);
            this.panelRigtUsuario.Name = "panelRigtUsuario";
            this.panelRigtUsuario.Size = new System.Drawing.Size(196, 343);
            this.panelRigtUsuario.TabIndex = 2;
            // 
            // btnEditarCliente
            // 
            this.btnEditarCliente.BackColor = System.Drawing.Color.LightGray;
            this.btnEditarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarCliente.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnEditarCliente.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnEditarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(202)))), ((int)(((byte)(210)))));
            this.btnEditarCliente.Font = new System.Drawing.Font("Leelawadee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarCliente.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEditarCliente.Image = global::CapaPresentacion.Properties.Resources.edit_user_icon_195392;
            this.btnEditarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarCliente.Location = new System.Drawing.Point(53, 229);
            this.btnEditarCliente.Name = "btnEditarCliente";
            this.btnEditarCliente.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnEditarCliente.Size = new System.Drawing.Size(48, 49);
            this.btnEditarCliente.TabIndex = 6;
            this.btnEditarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditarCliente.UseVisualStyleBackColor = false;
            this.btnEditarCliente.Click += new System.EventHandler(this.btnEditarCliente_Click);
            // 
            // btnAltaCliente
            // 
            this.btnAltaCliente.BackColor = System.Drawing.Color.LightGray;
            this.btnAltaCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAltaCliente.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnAltaCliente.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnAltaCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(202)))), ((int)(((byte)(210)))));
            this.btnAltaCliente.Font = new System.Drawing.Font("Leelawadee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAltaCliente.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAltaCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnAltaCliente.Image")));
            this.btnAltaCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAltaCliente.Location = new System.Drawing.Point(121, 229);
            this.btnAltaCliente.Name = "btnAltaCliente";
            this.btnAltaCliente.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnAltaCliente.Size = new System.Drawing.Size(48, 49);
            this.btnAltaCliente.TabIndex = 4;
            this.btnAltaCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAltaCliente.UseVisualStyleBackColor = false;
            this.btnAltaCliente.Click += new System.EventHandler(this.btnAltaCliente_Click_1);
            // 
            // dataGridClientes
            // 
            this.dataGridClientes.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnSeleccionar,
            this.idCliente,
            this.dni,
            this.nombre,
            this.apellido,
            this.telefono,
            this.Correo,
            this.Estado,
            this.cod_estado});
            this.dataGridClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridClientes.Location = new System.Drawing.Point(0, 0);
            this.dataGridClientes.MultiSelect = false;
            this.dataGridClientes.Name = "dataGridClientes";
            this.dataGridClientes.ReadOnly = true;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridClientes.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridClientes.RowTemplate.Height = 28;
            this.dataGridClientes.Size = new System.Drawing.Size(604, 343);
            this.dataGridClientes.TabIndex = 26;
            this.dataGridClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridClientes_CellClick);
            this.dataGridClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridClientes_CellContentClick);
            this.dataGridClientes.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridClientes_CellFormatting);
            this.dataGridClientes.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridClientes_CellPainting);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.FillWeight = 41.01563F;
            this.btnSeleccionar.HeaderText = "";
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.ReadOnly = true;
            this.btnSeleccionar.Width = 30;
            // 
            // idCliente
            // 
            this.idCliente.HeaderText = "id_Cliente";
            this.idCliente.Name = "idCliente";
            this.idCliente.ReadOnly = true;
            this.idCliente.Visible = false;
            this.idCliente.Width = 87;
            // 
            // dni
            // 
            this.dni.FillWeight = 137.354F;
            this.dni.HeaderText = "Dni";
            this.dni.Name = "dni";
            this.dni.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.FillWeight = 118.5488F;
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 150;
            // 
            // apellido
            // 
            this.apellido.FillWeight = 103.4164F;
            this.apellido.HeaderText = "Apellido";
            this.apellido.Name = "apellido";
            this.apellido.ReadOnly = true;
            this.apellido.Width = 150;
            // 
            // telefono
            // 
            this.telefono.FillWeight = 91.23962F;
            this.telefono.HeaderText = "Telefono";
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            // 
            // Correo
            // 
            this.Correo.FillWeight = 162.8822F;
            this.Correo.HeaderText = "Correo";
            this.Correo.Name = "Correo";
            this.Correo.ReadOnly = true;
            this.Correo.Width = 200;
            // 
            // Estado
            // 
            this.Estado.FillWeight = 45.5434F;
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // cod_estado
            // 
            this.cod_estado.HeaderText = "cod_estado";
            this.cod_estado.Name = "cod_estado";
            this.cod_estado.ReadOnly = true;
            this.cod_estado.Visible = false;
            this.cod_estado.Width = 95;
            // 
            // panelCliente
            // 
            this.panelCliente.Controls.Add(this.dataGridClientes);
            this.panelCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCliente.Location = new System.Drawing.Point(0, 107);
            this.panelCliente.Name = "panelCliente";
            this.panelCliente.Size = new System.Drawing.Size(604, 343);
            this.panelCliente.TabIndex = 3;
            // 
            // FormClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelCliente);
            this.Controls.Add(this.panelRigtUsuario);
            this.Controls.Add(this.panelTopUsuario);
            this.Name = "FormClientes";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormClientes_Load);
            this.panelTopUsuario.ResumeLayout(false);
            this.panelBuscador.ResumeLayout(false);
            this.panelBuscador.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUsuario)).EndInit();
            this.panelRigtUsuario.ResumeLayout(false);
            this.panelRigtUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClientes)).EndInit();
            this.panelCliente.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTopUsuario;
        private System.Windows.Forms.Label lblTituloCli;
        private System.Windows.Forms.Panel panelBuscador;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.ComboBox cboBusqueda;
        private System.Windows.Forms.Panel panelRigtUsuario;
        public System.Windows.Forms.Button btnEditarCliente;
        public System.Windows.Forms.Button btnAltaCliente;
        private System.Windows.Forms.PictureBox picUsuario;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.DataGridViewButtonColumn btnSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_estado;
        private System.Windows.Forms.Panel panelCliente;
        public System.Windows.Forms.DataGridView dataGridClientes;
    }
}
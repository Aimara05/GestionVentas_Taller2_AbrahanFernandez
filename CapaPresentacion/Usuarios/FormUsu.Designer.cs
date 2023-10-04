namespace CapaPresentacion.Usuarios
{
    partial class FormUsu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUsu));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTopUsuario = new System.Windows.Forms.Panel();
            this.panelLogoTit = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblTituloUsu = new System.Windows.Forms.Label();
            this.picUsuario = new System.Windows.Forms.PictureBox();
            this.panelBuscador = new System.Windows.Forms.Panel();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.cboBusqueda = new System.Windows.Forms.ComboBox();
            this.panelRigtUsuario = new System.Windows.Forms.Panel();
            this.btnAltaUsu = new System.Windows.Forms.Button();
            this.btnBajaUsuario = new System.Windows.Forms.Button();
            this.btnEditarUsuario = new System.Windows.Forms.Button();
            this.btnAltausuario = new System.Windows.Forms.Button();
            this.panelContenedorUsu = new System.Windows.Forms.Panel();
            this.dataGridUsuario = new System.Windows.Forms.DataGridView();
            this.btnSeleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.idUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Domicilio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idRol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelTopUsuario.SuspendLayout();
            this.panelLogoTit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUsuario)).BeginInit();
            this.panelBuscador.SuspendLayout();
            this.panelRigtUsuario.SuspendLayout();
            this.panelContenedorUsu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTopUsuario
            // 
            this.panelTopUsuario.BackColor = System.Drawing.Color.LightGray;
            this.panelTopUsuario.Controls.Add(this.panelLogoTit);
            this.panelTopUsuario.Controls.Add(this.panelBuscador);
            this.panelTopUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopUsuario.Font = new System.Drawing.Font("Leelawadee UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelTopUsuario.Location = new System.Drawing.Point(0, 0);
            this.panelTopUsuario.Name = "panelTopUsuario";
            this.panelTopUsuario.Size = new System.Drawing.Size(1124, 107);
            this.panelTopUsuario.TabIndex = 0;
            // 
            // panelLogoTit
            // 
            this.panelLogoTit.Controls.Add(this.btnRefresh);
            this.panelLogoTit.Controls.Add(this.lblTituloUsu);
            this.panelLogoTit.Controls.Add(this.picUsuario);
            this.panelLogoTit.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelLogoTit.Location = new System.Drawing.Point(847, 0);
            this.panelLogoTit.Name = "panelLogoTit";
            this.panelLogoTit.Size = new System.Drawing.Size(277, 107);
            this.panelLogoTit.TabIndex = 27;
            // 
            // btnRefresh
            // 
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.Location = new System.Drawing.Point(96, 35);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(34, 38);
            this.btnRefresh.TabIndex = 7;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblTituloUsu
            // 
            this.lblTituloUsu.AutoSize = true;
            this.lblTituloUsu.Location = new System.Drawing.Point(3, 41);
            this.lblTituloUsu.Name = "lblTituloUsu";
            this.lblTituloUsu.Size = new System.Drawing.Size(85, 25);
            this.lblTituloUsu.TabIndex = 1;
            this.lblTituloUsu.Text = "Usuarios";
            // 
            // picUsuario
            // 
            this.picUsuario.BackColor = System.Drawing.Color.LightGray;
            this.picUsuario.Image = ((System.Drawing.Image)(resources.GetObject("picUsuario.Image")));
            this.picUsuario.Location = new System.Drawing.Point(170, 12);
            this.picUsuario.Name = "picUsuario";
            this.picUsuario.Padding = new System.Windows.Forms.Padding(0, 0, 40, 0);
            this.picUsuario.Size = new System.Drawing.Size(89, 89);
            this.picUsuario.TabIndex = 0;
            this.picUsuario.TabStop = false;
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
            this.panelBuscador.Size = new System.Drawing.Size(476, 107);
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
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.Black;
            this.btnLimpiar.Image = global::CapaPresentacion.Properties.Resources.limpieza_de_datos;
            this.btnLimpiar.Location = new System.Drawing.Point(428, 48);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(25, 22);
            this.btnLimpiar.TabIndex = 29;
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
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
            this.btnBuscar.Location = new System.Drawing.Point(397, 48);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(25, 22);
            this.btnBuscar.TabIndex = 25;
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
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
            // panelRigtUsuario
            // 
            this.panelRigtUsuario.BackColor = System.Drawing.Color.LightGray;
            this.panelRigtUsuario.Controls.Add(this.btnAltaUsu);
            this.panelRigtUsuario.Controls.Add(this.btnBajaUsuario);
            this.panelRigtUsuario.Controls.Add(this.btnEditarUsuario);
            this.panelRigtUsuario.Controls.Add(this.btnAltausuario);
            this.panelRigtUsuario.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRigtUsuario.Location = new System.Drawing.Point(921, 107);
            this.panelRigtUsuario.Name = "panelRigtUsuario";
            this.panelRigtUsuario.Size = new System.Drawing.Size(203, 404);
            this.panelRigtUsuario.TabIndex = 1;
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
            this.btnAltaUsu.Image = ((System.Drawing.Image)(resources.GetObject("btnAltaUsu.Image")));
            this.btnAltaUsu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAltaUsu.Location = new System.Drawing.Point(19, 239);
            this.btnAltaUsu.Name = "btnAltaUsu";
            this.btnAltaUsu.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnAltaUsu.Size = new System.Drawing.Size(166, 49);
            this.btnAltaUsu.TabIndex = 7;
            this.btnAltaUsu.Text = "Alta Usuario";
            this.btnAltaUsu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAltaUsu.UseVisualStyleBackColor = false;
            this.btnAltaUsu.Click += new System.EventHandler(this.btnAltaUsu_Click);
            // 
            // btnBajaUsuario
            // 
            this.btnBajaUsuario.BackColor = System.Drawing.Color.LightGray;
            this.btnBajaUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBajaUsuario.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnBajaUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnBajaUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(202)))), ((int)(((byte)(210)))));
            this.btnBajaUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBajaUsuario.Font = new System.Drawing.Font("Leelawadee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBajaUsuario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBajaUsuario.Image = ((System.Drawing.Image)(resources.GetObject("btnBajaUsuario.Image")));
            this.btnBajaUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBajaUsuario.Location = new System.Drawing.Point(19, 173);
            this.btnBajaUsuario.Name = "btnBajaUsuario";
            this.btnBajaUsuario.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnBajaUsuario.Size = new System.Drawing.Size(166, 49);
            this.btnBajaUsuario.TabIndex = 5;
            this.btnBajaUsuario.Text = "Baja Usuario";
            this.btnBajaUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBajaUsuario.UseVisualStyleBackColor = false;
            this.btnBajaUsuario.Click += new System.EventHandler(this.btnBajaUsuario_Click);
            // 
            // btnEditarUsuario
            // 
            this.btnEditarUsuario.BackColor = System.Drawing.Color.LightGray;
            this.btnEditarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarUsuario.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnEditarUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnEditarUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(202)))), ((int)(((byte)(210)))));
            this.btnEditarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarUsuario.Font = new System.Drawing.Font("Leelawadee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarUsuario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEditarUsuario.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarUsuario.Image")));
            this.btnEditarUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarUsuario.Location = new System.Drawing.Point(19, 102);
            this.btnEditarUsuario.Name = "btnEditarUsuario";
            this.btnEditarUsuario.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnEditarUsuario.Size = new System.Drawing.Size(167, 49);
            this.btnEditarUsuario.TabIndex = 6;
            this.btnEditarUsuario.Text = "Editar Usuario";
            this.btnEditarUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditarUsuario.UseVisualStyleBackColor = false;
            this.btnEditarUsuario.Click += new System.EventHandler(this.btnEditarUsuario_Click);
            // 
            // btnAltausuario
            // 
            this.btnAltausuario.BackColor = System.Drawing.Color.LightGray;
            this.btnAltausuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAltausuario.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnAltausuario.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnAltausuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(202)))), ((int)(((byte)(210)))));
            this.btnAltausuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAltausuario.Font = new System.Drawing.Font("Leelawadee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAltausuario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAltausuario.Image = ((System.Drawing.Image)(resources.GetObject("btnAltausuario.Image")));
            this.btnAltausuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAltausuario.Location = new System.Drawing.Point(19, 36);
            this.btnAltausuario.Name = "btnAltausuario";
            this.btnAltausuario.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnAltausuario.Size = new System.Drawing.Size(167, 49);
            this.btnAltausuario.TabIndex = 4;
            this.btnAltausuario.Text = "Agregar Usuario";
            this.btnAltausuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAltausuario.UseVisualStyleBackColor = false;
            this.btnAltausuario.Click += new System.EventHandler(this.btnAltausuario_Click);
            // 
            // panelContenedorUsu
            // 
            this.panelContenedorUsu.Controls.Add(this.dataGridUsuario);
            this.panelContenedorUsu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedorUsu.Location = new System.Drawing.Point(0, 107);
            this.panelContenedorUsu.Name = "panelContenedorUsu";
            this.panelContenedorUsu.Size = new System.Drawing.Size(921, 404);
            this.panelContenedorUsu.TabIndex = 2;
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
            this.idUsuario,
            this.dni,
            this.nombre,
            this.apellido,
            this.Correo,
            this.usuario,
            this.clave,
            this.telefono,
            this.Domicilio,
            this.Estado,
            this.idRol,
            this.descripcion});
            this.dataGridUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridUsuario.Location = new System.Drawing.Point(0, 0);
            this.dataGridUsuario.MultiSelect = false;
            this.dataGridUsuario.Name = "dataGridUsuario";
            this.dataGridUsuario.ReadOnly = true;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridUsuario.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridUsuario.RowTemplate.Height = 28;
            this.dataGridUsuario.Size = new System.Drawing.Size(921, 404);
            this.dataGridUsuario.TabIndex = 25;
            this.dataGridUsuario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridUsuario_CellContentClick);
            this.dataGridUsuario.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridUsuario_CellFormatting);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.HeaderText = "";
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.ReadOnly = true;
            this.btnSeleccionar.Width = 88;
            // 
            // idUsuario
            // 
            this.idUsuario.HeaderText = "id_Usuarios";
            this.idUsuario.Name = "idUsuario";
            this.idUsuario.ReadOnly = true;
            this.idUsuario.Visible = false;
            // 
            // dni
            // 
            this.dni.HeaderText = "Dni";
            this.dni.Name = "dni";
            this.dni.ReadOnly = true;
            this.dni.Width = 88;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 87;
            // 
            // apellido
            // 
            this.apellido.HeaderText = "Apellido";
            this.apellido.Name = "apellido";
            this.apellido.ReadOnly = true;
            this.apellido.Width = 88;
            // 
            // Correo
            // 
            this.Correo.HeaderText = "Correo";
            this.Correo.Name = "Correo";
            this.Correo.ReadOnly = true;
            this.Correo.Width = 88;
            // 
            // usuario
            // 
            this.usuario.HeaderText = "Usuario";
            this.usuario.Name = "usuario";
            this.usuario.ReadOnly = true;
            this.usuario.Width = 88;
            // 
            // clave
            // 
            this.clave.HeaderText = "Clave";
            this.clave.Name = "clave";
            this.clave.ReadOnly = true;
            this.clave.Visible = false;
            // 
            // telefono
            // 
            this.telefono.HeaderText = "Telefono";
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            this.telefono.Width = 88;
            // 
            // Domicilio
            // 
            this.Domicilio.HeaderText = "Domicilio";
            this.Domicilio.Name = "Domicilio";
            this.Domicilio.ReadOnly = true;
            this.Domicilio.Width = 87;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Width = 88;
            // 
            // idRol
            // 
            this.idRol.HeaderText = "idRol";
            this.idRol.Name = "idRol";
            this.idRol.ReadOnly = true;
            this.idRol.Visible = false;
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Rol";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            this.descripcion.Width = 88;
            // 
            // FormUsu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 511);
            this.Controls.Add(this.panelContenedorUsu);
            this.Controls.Add(this.panelRigtUsuario);
            this.Controls.Add(this.panelTopUsuario);
            this.Name = "FormUsu";
            this.Text = "FormUsu";
            this.Load += new System.EventHandler(this.FormUsu_Load);
            this.panelTopUsuario.ResumeLayout(false);
            this.panelLogoTit.ResumeLayout(false);
            this.panelLogoTit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUsuario)).EndInit();
            this.panelBuscador.ResumeLayout(false);
            this.panelBuscador.PerformLayout();
            this.panelRigtUsuario.ResumeLayout(false);
            this.panelContenedorUsu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTopUsuario;
        private System.Windows.Forms.PictureBox picUsuario;
        private System.Windows.Forms.Label lblTituloUsu;
        private System.Windows.Forms.Panel panelRigtUsuario;
        private System.Windows.Forms.Panel panelContenedorUsu;
        private System.Windows.Forms.Panel panelBuscador;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.ComboBox cboBusqueda;
        private System.Windows.Forms.Panel panelLogoTit;
        public System.Windows.Forms.Button btnEditarUsuario;
        public System.Windows.Forms.Button btnBajaUsuario;
        public System.Windows.Forms.Button btnAltausuario;
        public System.Windows.Forms.DataGridView dataGridUsuario;
        private System.Windows.Forms.Button btnRefresh;
        public System.Windows.Forms.Button btnAltaUsu;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.DataGridViewButtonColumn btnSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn clave;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Domicilio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRol;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
    }
}
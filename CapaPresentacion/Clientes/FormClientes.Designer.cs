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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTopUsuario = new System.Windows.Forms.Panel();
            this.panelLogoTit = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.picUsuario = new System.Windows.Forms.PictureBox();
            this.lblTituloCli = new System.Windows.Forms.Label();
            this.panelBuscador = new System.Windows.Forms.Panel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.cboBusqueda = new System.Windows.Forms.ComboBox();
            this.panelRigtUsuario = new System.Windows.Forms.Panel();
            this.btnEditarCliente = new System.Windows.Forms.Button();
            this.btnBajaUsuario = new System.Windows.Forms.Button();
            this.btnAltaCliente = new System.Windows.Forms.Button();
            this.dataGridUsuario = new System.Windows.Forms.DataGridView();
            this.btnSeleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.id_Usuarios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Domicilio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod_estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.panelTopUsuario.SuspendLayout();
            this.panelLogoTit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUsuario)).BeginInit();
            this.panelBuscador.SuspendLayout();
            this.panelRigtUsuario.SuspendLayout();
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
            this.panelTopUsuario.Size = new System.Drawing.Size(800, 107);
            this.panelTopUsuario.TabIndex = 1;
            // 
            // panelLogoTit
            // 
            this.panelLogoTit.Controls.Add(this.btnRefresh);
            this.panelLogoTit.Controls.Add(this.picUsuario);
            this.panelLogoTit.Controls.Add(this.lblTituloCli);
            this.panelLogoTit.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelLogoTit.Location = new System.Drawing.Point(523, 0);
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
            this.btnRefresh.Location = new System.Drawing.Point(109, 33);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(34, 38);
            this.btnRefresh.TabIndex = 8;
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // picUsuario
            // 
            this.picUsuario.BackColor = System.Drawing.Color.LightGray;
            this.picUsuario.Image = ((System.Drawing.Image)(resources.GetObject("picUsuario.Image")));
            this.picUsuario.Location = new System.Drawing.Point(157, 12);
            this.picUsuario.Name = "picUsuario";
            this.picUsuario.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.picUsuario.Size = new System.Drawing.Size(89, 89);
            this.picUsuario.TabIndex = 2;
            this.picUsuario.TabStop = false;
            // 
            // lblTituloCli
            // 
            this.lblTituloCli.AutoSize = true;
            this.lblTituloCli.Location = new System.Drawing.Point(16, 41);
            this.lblTituloCli.Name = "lblTituloCli";
            this.lblTituloCli.Size = new System.Drawing.Size(79, 25);
            this.lblTituloCli.TabIndex = 1;
            this.lblTituloCli.Text = "Clientes";
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
            this.btnBuscar.Location = new System.Drawing.Point(397, 45);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(25, 22);
            this.btnBuscar.TabIndex = 25;
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar.UseVisualStyleBackColor = false;
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
            this.txtBusqueda.TabIndex = 28;
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
            // panelRigtUsuario
            // 
            this.panelRigtUsuario.BackColor = System.Drawing.Color.LightGray;
            this.panelRigtUsuario.Controls.Add(this.btnEditarCliente);
            this.panelRigtUsuario.Controls.Add(this.btnBajaUsuario);
            this.panelRigtUsuario.Controls.Add(this.btnAltaCliente);
            this.panelRigtUsuario.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRigtUsuario.Location = new System.Drawing.Point(600, 107);
            this.panelRigtUsuario.Name = "panelRigtUsuario";
            this.panelRigtUsuario.Size = new System.Drawing.Size(200, 343);
            this.panelRigtUsuario.TabIndex = 2;
            // 
            // btnEditarCliente
            // 
            this.btnEditarCliente.BackColor = System.Drawing.Color.LightGray;
            this.btnEditarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarCliente.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnEditarCliente.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnEditarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(202)))), ((int)(((byte)(210)))));
            this.btnEditarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarCliente.Font = new System.Drawing.Font("Leelawadee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarCliente.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEditarCliente.Image = global::CapaPresentacion.Properties.Resources.editar;
            this.btnEditarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarCliente.Location = new System.Drawing.Point(32, 170);
            this.btnEditarCliente.Name = "btnEditarCliente";
            this.btnEditarCliente.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnEditarCliente.Size = new System.Drawing.Size(144, 49);
            this.btnEditarCliente.TabIndex = 6;
            this.btnEditarCliente.Text = "Editar Cliente";
            this.btnEditarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditarCliente.UseVisualStyleBackColor = false;
            this.btnEditarCliente.Click += new System.EventHandler(this.btnEditarCliente_Click);
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
            this.btnBajaUsuario.Location = new System.Drawing.Point(32, 236);
            this.btnBajaUsuario.Name = "btnBajaUsuario";
            this.btnBajaUsuario.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnBajaUsuario.Size = new System.Drawing.Size(144, 49);
            this.btnBajaUsuario.TabIndex = 5;
            this.btnBajaUsuario.Text = "Baja Cliente";
            this.btnBajaUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBajaUsuario.UseVisualStyleBackColor = false;
            // 
            // btnAltaCliente
            // 
            this.btnAltaCliente.BackColor = System.Drawing.Color.LightGray;
            this.btnAltaCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAltaCliente.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnAltaCliente.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnAltaCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(202)))), ((int)(((byte)(210)))));
            this.btnAltaCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAltaCliente.Font = new System.Drawing.Font("Leelawadee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAltaCliente.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAltaCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnAltaCliente.Image")));
            this.btnAltaCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAltaCliente.Location = new System.Drawing.Point(32, 105);
            this.btnAltaCliente.Name = "btnAltaCliente";
            this.btnAltaCliente.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnAltaCliente.Size = new System.Drawing.Size(144, 49);
            this.btnAltaCliente.TabIndex = 4;
            this.btnAltaCliente.Text = "Alta clientes";
            this.btnAltaCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAltaCliente.UseVisualStyleBackColor = false;
            this.btnAltaCliente.Click += new System.EventHandler(this.btnAltaCliente_Click);
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
            this.id_Usuarios,
            this.dni,
            this.nombre,
            this.apellido,
            this.telefono,
            this.Domicilio,
            this.Correo,
            this.cod_estado,
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
            this.dataGridUsuario.Size = new System.Drawing.Size(600, 343);
            this.dataGridUsuario.TabIndex = 26;
          
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.HeaderText = "";
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.ReadOnly = true;
            this.btnSeleccionar.Width = 30;
            // 
            // id_Usuarios
            // 
            this.id_Usuarios.HeaderText = "id_Usuarios";
            this.id_Usuarios.Name = "id_Usuarios";
            this.id_Usuarios.ReadOnly = true;
            this.id_Usuarios.Visible = false;
            // 
            // dni
            // 
            this.dni.HeaderText = "Dni";
            this.dni.Name = "dni";
            this.dni.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // apellido
            // 
            this.apellido.HeaderText = "Apellido";
            this.apellido.Name = "apellido";
            this.apellido.ReadOnly = true;
            // 
            // telefono
            // 
            this.telefono.HeaderText = "Telefono";
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            // 
            // Domicilio
            // 
            this.Domicilio.HeaderText = "Domicilio";
            this.Domicilio.Name = "Domicilio";
            this.Domicilio.ReadOnly = true;
            // 
            // Correo
            // 
            this.Correo.HeaderText = "Correo";
            this.Correo.Name = "Correo";
            this.Correo.ReadOnly = true;
            // 
            // cod_estado
            // 
            this.cod_estado.HeaderText = "cod_estado";
            this.cod_estado.Name = "cod_estado";
            this.cod_estado.ReadOnly = true;
            this.cod_estado.Visible = false;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Width = 50;
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
            this.btnLimpiar.Location = new System.Drawing.Point(428, 46);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(25, 22);
            this.btnLimpiar.TabIndex = 30;
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // FormClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridUsuario);
            this.Controls.Add(this.panelRigtUsuario);
            this.Controls.Add(this.panelTopUsuario);
            this.Name = "FormClientes";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormClientes_Load);
            this.panelTopUsuario.ResumeLayout(false);
            this.panelLogoTit.ResumeLayout(false);
            this.panelLogoTit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUsuario)).EndInit();
            this.panelBuscador.ResumeLayout(false);
            this.panelBuscador.PerformLayout();
            this.panelRigtUsuario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTopUsuario;
        private System.Windows.Forms.Panel panelLogoTit;
        private System.Windows.Forms.Label lblTituloCli;
        private System.Windows.Forms.Panel panelBuscador;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.ComboBox cboBusqueda;
        private System.Windows.Forms.Panel panelRigtUsuario;
        public System.Windows.Forms.Button btnEditarCliente;
        public System.Windows.Forms.Button btnBajaUsuario;
        public System.Windows.Forms.Button btnAltaCliente;
        private System.Windows.Forms.DataGridView dataGridUsuario;
        private System.Windows.Forms.DataGridViewButtonColumn btnSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Usuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Domicilio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.PictureBox picUsuario;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnLimpiar;
    }
}
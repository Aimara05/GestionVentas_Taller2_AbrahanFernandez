namespace CapaPresentacion.Modales
{
    partial class mdCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mdCliente));
            this.dataGridUsuario = new System.Windows.Forms.DataGridView();
            this.idCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelBuscador = new System.Windows.Forms.Panel();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtTitBuscar = new System.Windows.Forms.TextBox();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.cboBusqueda = new System.Windows.Forms.ComboBox();
            this.panelTopUsuario = new System.Windows.Forms.Panel();
            this.lblTituloCli = new System.Windows.Forms.Label();
            this.panelBotonesCerrar = new System.Windows.Forms.Panel();
            this.picTitulo = new System.Windows.Forms.PictureBox();
            this.panelBotonesForm = new System.Windows.Forms.Panel();
            this.picCerrar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsuario)).BeginInit();
            this.panelBuscador.SuspendLayout();
            this.panelTopUsuario.SuspendLayout();
            this.panelBotonesCerrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTitulo)).BeginInit();
            this.panelBotonesForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridUsuario
            // 
            this.dataGridUsuario.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Leelawadee UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridUsuario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCliente,
            this.documento,
            this.nombre,
            this.apellido,
            this.correo,
            this.telefono,
            this.estado});
            this.dataGridUsuario.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridUsuario.Location = new System.Drawing.Point(0, 148);
            this.dataGridUsuario.MultiSelect = false;
            this.dataGridUsuario.Name = "dataGridUsuario";
            this.dataGridUsuario.ReadOnly = true;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridUsuario.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridUsuario.RowTemplate.Height = 28;
            this.dataGridUsuario.Size = new System.Drawing.Size(550, 218);
            this.dataGridUsuario.TabIndex = 0;
            this.dataGridUsuario.TabStop = false;
            this.dataGridUsuario.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridUsuario_CellDoubleClick);
            // 
            // idCliente
            // 
            this.idCliente.HeaderText = "idCliente";
            this.idCliente.Name = "idCliente";
            this.idCliente.ReadOnly = true;
            this.idCliente.Visible = false;
            // 
            // documento
            // 
            this.documento.FillWeight = 98.90017F;
            this.documento.HeaderText = "Dni";
            this.documento.Name = "documento";
            this.documento.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.FillWeight = 98.90017F;
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // apellido
            // 
            this.apellido.FillWeight = 98.90017F;
            this.apellido.HeaderText = "Apellido";
            this.apellido.Name = "apellido";
            this.apellido.ReadOnly = true;
            // 
            // correo
            // 
            this.correo.HeaderText = "Correo";
            this.correo.Name = "correo";
            this.correo.ReadOnly = true;
            // 
            // telefono
            // 
            this.telefono.HeaderText = "Telefono";
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            // 
            // estado
            // 
            this.estado.HeaderText = "Estado";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            this.estado.Visible = false;
            // 
            // panelBuscador
            // 
            this.panelBuscador.BackColor = System.Drawing.Color.Transparent;
            this.panelBuscador.Controls.Add(this.btnLimpiar);
            this.panelBuscador.Controls.Add(this.btnBuscar);
            this.panelBuscador.Controls.Add(this.txtTitBuscar);
            this.panelBuscador.Controls.Add(this.txtBusqueda);
            this.panelBuscador.Controls.Add(this.cboBusqueda);
            this.panelBuscador.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelBuscador.Location = new System.Drawing.Point(0, 0);
            this.panelBuscador.Name = "panelBuscador";
            this.panelBuscador.Size = new System.Drawing.Size(503, 107);
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
            this.btnLimpiar.Location = new System.Drawing.Point(442, 50);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(38, 26);
            this.btnLimpiar.TabIndex = 3;
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
            this.txtTitBuscar.TabIndex = 25;
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
            this.cboBusqueda.TabIndex = 27;
            this.cboBusqueda.TabStop = false;
            // 
            // panelTopUsuario
            // 
            this.panelTopUsuario.BackColor = System.Drawing.Color.Black;
            this.panelTopUsuario.Controls.Add(this.panelBuscador);
            this.panelTopUsuario.Font = new System.Drawing.Font("Leelawadee UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelTopUsuario.Location = new System.Drawing.Point(0, 35);
            this.panelTopUsuario.Name = "panelTopUsuario";
            this.panelTopUsuario.Size = new System.Drawing.Size(547, 107);
            this.panelTopUsuario.TabIndex = 27;
            // 
            // lblTituloCli
            // 
            this.lblTituloCli.AutoSize = true;
            this.lblTituloCli.Font = new System.Drawing.Font("Leelawadee UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloCli.Location = new System.Drawing.Point(10, 3);
            this.lblTituloCli.Name = "lblTituloCli";
            this.lblTituloCli.Size = new System.Drawing.Size(81, 25);
            this.lblTituloCli.TabIndex = 0;
            this.lblTituloCli.Text = "Clientes";
            // 
            // panelBotonesCerrar
            // 
            this.panelBotonesCerrar.BackColor = System.Drawing.Color.LightGray;
            this.panelBotonesCerrar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelBotonesCerrar.Controls.Add(this.picTitulo);
            this.panelBotonesCerrar.Controls.Add(this.lblTituloCli);
            this.panelBotonesCerrar.Controls.Add(this.panelBotonesForm);
            this.panelBotonesCerrar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBotonesCerrar.Location = new System.Drawing.Point(0, 0);
            this.panelBotonesCerrar.Name = "panelBotonesCerrar";
            this.panelBotonesCerrar.Size = new System.Drawing.Size(550, 35);
            this.panelBotonesCerrar.TabIndex = 29;
            // 
            // picTitulo
            // 
            this.picTitulo.Image = global::CapaPresentacion.Properties.Resources.cliente;
            this.picTitulo.Location = new System.Drawing.Point(97, 0);
            this.picTitulo.Name = "picTitulo";
            this.picTitulo.Size = new System.Drawing.Size(46, 29);
            this.picTitulo.TabIndex = 2;
            this.picTitulo.TabStop = false;
            // 
            // panelBotonesForm
            // 
            this.panelBotonesForm.BackColor = System.Drawing.Color.LightGray;
            this.panelBotonesForm.Controls.Add(this.picCerrar);
            this.panelBotonesForm.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelBotonesForm.Location = new System.Drawing.Point(434, 0);
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
            // mdCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(550, 366);
            this.Controls.Add(this.panelBotonesCerrar);
            this.Controls.Add(this.dataGridUsuario);
            this.Controls.Add(this.panelTopUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "mdCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mdCliente";
            this.Load += new System.EventHandler(this.mdCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsuario)).EndInit();
            this.panelBuscador.ResumeLayout(false);
            this.panelBuscador.PerformLayout();
            this.panelTopUsuario.ResumeLayout(false);
            this.panelBotonesCerrar.ResumeLayout(false);
            this.panelBotonesCerrar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTitulo)).EndInit();
            this.panelBotonesForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridUsuario;
        private System.Windows.Forms.Panel panelBuscador;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtTitBuscar;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.ComboBox cboBusqueda;
        private System.Windows.Forms.Panel panelTopUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.Label lblTituloCli;
        private System.Windows.Forms.Panel panelBotonesCerrar;
        private System.Windows.Forms.Panel panelBotonesForm;
        private System.Windows.Forms.PictureBox picCerrar;
        private System.Windows.Forms.PictureBox picTitulo;
    }
}
namespace CapaPresentacion
{
    partial class FormUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUsuarios));
            this.LDni = new System.Windows.Forms.Label();
            this.LApellido = new System.Windows.Forms.Label();
            this.LUsuario = new System.Windows.Forms.Label();
            this.LContrasena = new System.Windows.Forms.Label();
            this.LConfContrasena = new System.Windows.Forms.Label();
            this.TBdni = new System.Windows.Forms.TextBox();
            this.TBapellido = new System.Windows.Forms.TextBox();
            this.TBusuario = new System.Windows.Forms.TextBox();
            this.TBcontrasena = new System.Windows.Forms.TextBox();
            this.TBConfContra = new System.Windows.Forms.TextBox();
            this.CBRol = new System.Windows.Forms.ComboBox();
            this.LRol = new System.Windows.Forms.Label();
            this.Lestado = new System.Windows.Forms.Label();
            this.CBestado = new System.Windows.Forms.ComboBox();
            this.LTitulo = new System.Windows.Forms.Label();
            this.PFormUsuario = new System.Windows.Forms.Panel();
            this.TIdUsuario = new System.Windows.Forms.TextBox();
            this.BCancelar = new System.Windows.Forms.Button();
            this.BLimpiar = new System.Windows.Forms.Button();
            this.BGuardar = new System.Windows.Forms.Button();
            this.LNombree = new System.Windows.Forms.Label();
            this.TBNombree = new System.Windows.Forms.TextBox();
            this.dataGridUsuario = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cboBusqueda = new System.Windows.Forms.ComboBox();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.panelBuscador = new System.Windows.Forms.Panel();
            this.btnSeleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.id_Usuarios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contrasena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PFormUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsuario)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelBuscador.SuspendLayout();
            this.SuspendLayout();
            // 
            // LDni
            // 
            this.LDni.AutoSize = true;
            this.LDni.BackColor = System.Drawing.Color.White;
            this.LDni.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDni.Location = new System.Drawing.Point(17, 47);
            this.LDni.Name = "LDni";
            this.LDni.Size = new System.Drawing.Size(112, 17);
            this.LDni.TabIndex = 1;
            this.LDni.Text = "N° de documento";
            // 
            // LApellido
            // 
            this.LApellido.AutoSize = true;
            this.LApellido.BackColor = System.Drawing.Color.White;
            this.LApellido.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LApellido.Location = new System.Drawing.Point(17, 148);
            this.LApellido.Name = "LApellido";
            this.LApellido.Size = new System.Drawing.Size(56, 17);
            this.LApellido.TabIndex = 3;
            this.LApellido.Text = "Apellido";
            // 
            // LUsuario
            // 
            this.LUsuario.AutoSize = true;
            this.LUsuario.BackColor = System.Drawing.Color.White;
            this.LUsuario.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LUsuario.Location = new System.Drawing.Point(20, 199);
            this.LUsuario.Name = "LUsuario";
            this.LUsuario.Size = new System.Drawing.Size(53, 17);
            this.LUsuario.TabIndex = 4;
            this.LUsuario.Text = "Usuario";
            // 
            // LContrasena
            // 
            this.LContrasena.AutoSize = true;
            this.LContrasena.BackColor = System.Drawing.Color.White;
            this.LContrasena.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LContrasena.Location = new System.Drawing.Point(17, 250);
            this.LContrasena.Name = "LContrasena";
            this.LContrasena.Size = new System.Drawing.Size(74, 17);
            this.LContrasena.TabIndex = 5;
            this.LContrasena.Text = "Contraseña";
            // 
            // LConfContrasena
            // 
            this.LConfContrasena.AutoSize = true;
            this.LConfContrasena.BackColor = System.Drawing.Color.White;
            this.LConfContrasena.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LConfContrasena.Location = new System.Drawing.Point(17, 302);
            this.LConfContrasena.Name = "LConfContrasena";
            this.LConfContrasena.Size = new System.Drawing.Size(134, 17);
            this.LConfContrasena.TabIndex = 6;
            this.LConfContrasena.Text = "Confirmar contraseña";
            // 
            // TBdni
            // 
            this.TBdni.Location = new System.Drawing.Point(31, 67);
            this.TBdni.Name = "TBdni";
            this.TBdni.Size = new System.Drawing.Size(208, 22);
            this.TBdni.TabIndex = 7;
            this.TBdni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBdni_KeyPress);
            // 
            // TBapellido
            // 
            this.TBapellido.Location = new System.Drawing.Point(31, 168);
            this.TBapellido.Name = "TBapellido";
            this.TBapellido.Size = new System.Drawing.Size(208, 22);
            this.TBapellido.TabIndex = 9;
            this.TBapellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBapellido_KeyPress);
            // 
            // TBusuario
            // 
            this.TBusuario.Location = new System.Drawing.Point(31, 219);
            this.TBusuario.Name = "TBusuario";
            this.TBusuario.Size = new System.Drawing.Size(208, 22);
            this.TBusuario.TabIndex = 10;
            // 
            // TBcontrasena
            // 
            this.TBcontrasena.Location = new System.Drawing.Point(31, 270);
            this.TBcontrasena.Name = "TBcontrasena";
            this.TBcontrasena.Size = new System.Drawing.Size(208, 22);
            this.TBcontrasena.TabIndex = 11;
            // 
            // TBConfContra
            // 
            this.TBConfContra.Location = new System.Drawing.Point(31, 322);
            this.TBConfContra.Name = "TBConfContra";
            this.TBConfContra.Size = new System.Drawing.Size(208, 22);
            this.TBConfContra.TabIndex = 12;
            // 
            // CBRol
            // 
            this.CBRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBRol.FormattingEnabled = true;
            this.CBRol.Location = new System.Drawing.Point(28, 367);
            this.CBRol.Name = "CBRol";
            this.CBRol.Size = new System.Drawing.Size(208, 21);
            this.CBRol.TabIndex = 15;
            // 
            // LRol
            // 
            this.LRol.AutoSize = true;
            this.LRol.BackColor = System.Drawing.Color.White;
            this.LRol.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LRol.Location = new System.Drawing.Point(17, 347);
            this.LRol.Name = "LRol";
            this.LRol.Size = new System.Drawing.Size(27, 17);
            this.LRol.TabIndex = 16;
            this.LRol.Text = "Rol";
            // 
            // Lestado
            // 
            this.Lestado.AutoSize = true;
            this.Lestado.BackColor = System.Drawing.Color.White;
            this.Lestado.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lestado.Location = new System.Drawing.Point(14, 397);
            this.Lestado.Name = "Lestado";
            this.Lestado.Size = new System.Drawing.Size(48, 17);
            this.Lestado.TabIndex = 17;
            this.Lestado.Text = "Estado";
            // 
            // CBestado
            // 
            this.CBestado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBestado.FormattingEnabled = true;
            this.CBestado.Location = new System.Drawing.Point(28, 417);
            this.CBestado.Name = "CBestado";
            this.CBestado.Size = new System.Drawing.Size(208, 21);
            this.CBestado.TabIndex = 18;
            // 
            // LTitulo
            // 
            this.LTitulo.AutoSize = true;
            this.LTitulo.BackColor = System.Drawing.Color.White;
            this.LTitulo.Font = new System.Drawing.Font("Leelawadee UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTitulo.Location = new System.Drawing.Point(58, 9);
            this.LTitulo.Name = "LTitulo";
            this.LTitulo.Size = new System.Drawing.Size(174, 25);
            this.LTitulo.TabIndex = 22;
            this.LTitulo.Text = "Detalle de Usuario";
            // 
            // PFormUsuario
            // 
            this.PFormUsuario.AutoScroll = true;
            this.PFormUsuario.BackColor = System.Drawing.Color.White;
            this.PFormUsuario.Controls.Add(this.TIdUsuario);
            this.PFormUsuario.Controls.Add(this.LTitulo);
            this.PFormUsuario.Controls.Add(this.BCancelar);
            this.PFormUsuario.Controls.Add(this.LDni);
            this.PFormUsuario.Controls.Add(this.BLimpiar);
            this.PFormUsuario.Controls.Add(this.TBdni);
            this.PFormUsuario.Controls.Add(this.BGuardar);
            this.PFormUsuario.Controls.Add(this.LNombree);
            this.PFormUsuario.Controls.Add(this.CBestado);
            this.PFormUsuario.Controls.Add(this.TBNombree);
            this.PFormUsuario.Controls.Add(this.Lestado);
            this.PFormUsuario.Controls.Add(this.LApellido);
            this.PFormUsuario.Controls.Add(this.CBRol);
            this.PFormUsuario.Controls.Add(this.LRol);
            this.PFormUsuario.Controls.Add(this.TBapellido);
            this.PFormUsuario.Controls.Add(this.LUsuario);
            this.PFormUsuario.Controls.Add(this.TBConfContra);
            this.PFormUsuario.Controls.Add(this.TBusuario);
            this.PFormUsuario.Controls.Add(this.LConfContrasena);
            this.PFormUsuario.Controls.Add(this.TBcontrasena);
            this.PFormUsuario.Controls.Add(this.LContrasena);
            this.PFormUsuario.Dock = System.Windows.Forms.DockStyle.Right;
            this.PFormUsuario.Location = new System.Drawing.Point(691, 0);
            this.PFormUsuario.Name = "PFormUsuario";
            this.PFormUsuario.Size = new System.Drawing.Size(276, 591);
            this.PFormUsuario.TabIndex = 23;
            // 
            // TIdUsuario
            // 
            this.TIdUsuario.Location = new System.Drawing.Point(215, 39);
            this.TIdUsuario.Name = "TIdUsuario";
            this.TIdUsuario.Size = new System.Drawing.Size(31, 22);
            this.TIdUsuario.TabIndex = 23;
            this.TIdUsuario.Text = "0";
            this.TIdUsuario.Visible = false;
            // 
            // BCancelar
            // 
            this.BCancelar.BackColor = System.Drawing.Color.Silver;
            this.BCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BCancelar.FlatAppearance.BorderSize = 0;
            this.BCancelar.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(202)))), ((int)(((byte)(210)))));
            this.BCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BCancelar.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BCancelar.Image = global::CapaPresentacion.Properties.Resources.papelera_xmark;
            this.BCancelar.Location = new System.Drawing.Point(23, 529);
            this.BCancelar.Name = "BCancelar";
            this.BCancelar.Size = new System.Drawing.Size(216, 39);
            this.BCancelar.TabIndex = 21;
            this.BCancelar.Text = "Eliminar";
            this.BCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BCancelar.UseVisualStyleBackColor = false;
            // 
            // BLimpiar
            // 
            this.BLimpiar.BackColor = System.Drawing.Color.Silver;
            this.BLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BLimpiar.FlatAppearance.BorderSize = 0;
            this.BLimpiar.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BLimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(202)))), ((int)(((byte)(210)))));
            this.BLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BLimpiar.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BLimpiar.Image = global::CapaPresentacion.Properties.Resources.archivo_de_edicion;
            this.BLimpiar.Location = new System.Drawing.Point(23, 486);
            this.BLimpiar.Name = "BLimpiar";
            this.BLimpiar.Size = new System.Drawing.Size(216, 37);
            this.BLimpiar.TabIndex = 20;
            this.BLimpiar.Text = "Limpiar";
            this.BLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BLimpiar.UseVisualStyleBackColor = false;
            // 
            // BGuardar
            // 
            this.BGuardar.BackColor = System.Drawing.Color.Silver;
            this.BGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BGuardar.FlatAppearance.BorderSize = 0;
            this.BGuardar.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(202)))), ((int)(((byte)(210)))));
            this.BGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BGuardar.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BGuardar.ForeColor = System.Drawing.Color.Black;
            this.BGuardar.Image = global::CapaPresentacion.Properties.Resources.flecha_de_circulo_de_disquete_a_la_derecha;
            this.BGuardar.Location = new System.Drawing.Point(23, 444);
            this.BGuardar.Name = "BGuardar";
            this.BGuardar.Size = new System.Drawing.Size(216, 36);
            this.BGuardar.TabIndex = 19;
            this.BGuardar.Text = "Guardar";
            this.BGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BGuardar.UseVisualStyleBackColor = false;
            this.BGuardar.Click += new System.EventHandler(this.BGuardar_Click);
            // 
            // LNombree
            // 
            this.LNombree.AutoSize = true;
            this.LNombree.BackColor = System.Drawing.Color.White;
            this.LNombree.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNombree.Location = new System.Drawing.Point(18, 98);
            this.LNombree.Name = "LNombree";
            this.LNombree.Size = new System.Drawing.Size(57, 17);
            this.LNombree.TabIndex = 2;
            this.LNombree.Text = "Nombre";
            // 
            // TBNombree
            // 
            this.TBNombree.Location = new System.Drawing.Point(31, 118);
            this.TBNombree.Name = "TBNombree";
            this.TBNombree.Size = new System.Drawing.Size(208, 22);
            this.TBNombree.TabIndex = 8;
            this.TBNombree.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBNombree_KeyPress);
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
            this.btnSeleccionar,
            this.id_Usuarios,
            this.dni,
            this.nombre,
            this.apellido,
            this.usuario,
            this.Contrasena,
            this.Id_Rol,
            this.Rol,
            this.Estado});
            this.dataGridUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridUsuario.Location = new System.Drawing.Point(0, 0);
            this.dataGridUsuario.MultiSelect = false;
            this.dataGridUsuario.Name = "dataGridUsuario";
            this.dataGridUsuario.ReadOnly = true;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridUsuario.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridUsuario.RowTemplate.Height = 28;
            this.dataGridUsuario.Size = new System.Drawing.Size(691, 591);
            this.dataGridUsuario.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Leelawadee UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(967, 47);
            this.label2.TabIndex = 25;
            this.label2.Text = "Lista de Usuarios:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridUsuario);
            this.panel1.Controls.Add(this.PFormUsuario);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(967, 591);
            this.panel1.TabIndex = 26;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(3, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(106, 15);
            this.textBox1.TabIndex = 25;
            this.textBox1.Text = "Buscar por :";
            // 
            // cboBusqueda
            // 
            this.cboBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBusqueda.FormattingEnabled = true;
            this.cboBusqueda.Location = new System.Drawing.Point(115, 17);
            this.cboBusqueda.Name = "cboBusqueda";
            this.cboBusqueda.Size = new System.Drawing.Size(118, 21);
            this.cboBusqueda.TabIndex = 27;
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(239, 16);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(144, 22);
            this.txtBusqueda.TabIndex = 28;
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
            this.btnBuscar.Location = new System.Drawing.Point(389, 16);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(25, 22);
            this.btnBuscar.TabIndex = 25;
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // panelBuscador
            // 
            this.panelBuscador.BackColor = System.Drawing.Color.White;
            this.panelBuscador.Controls.Add(this.btnBuscar);
            this.panelBuscador.Controls.Add(this.textBox1);
            this.panelBuscador.Controls.Add(this.txtBusqueda);
            this.panelBuscador.Controls.Add(this.cboBusqueda);
            this.panelBuscador.Location = new System.Drawing.Point(236, 0);
            this.panelBuscador.Name = "panelBuscador";
            this.panelBuscador.Size = new System.Drawing.Size(437, 47);
            this.panelBuscador.TabIndex = 25;
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
            // usuario
            // 
            this.usuario.HeaderText = "Usuario";
            this.usuario.Name = "usuario";
            this.usuario.ReadOnly = true;
            // 
            // Contrasena
            // 
            this.Contrasena.HeaderText = "Contraseña";
            this.Contrasena.Name = "Contrasena";
            this.Contrasena.ReadOnly = true;
            this.Contrasena.Visible = false;
            // 
            // Id_Rol
            // 
            this.Id_Rol.HeaderText = "Id_Rol";
            this.Id_Rol.Name = "Id_Rol";
            this.Id_Rol.ReadOnly = true;
            this.Id_Rol.Visible = false;
            // 
            // Rol
            // 
            this.Rol.HeaderText = "Rol";
            this.Rol.Name = "Rol";
            this.Rol.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Width = 50;
            // 
            // FormUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(967, 638);
            this.Controls.Add(this.panelBuscador);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Leelawadee UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormUsuarios";
            this.Text = "Infinite Tienda";
            this.Load += new System.EventHandler(this.FormUsuarios_Load);
            this.PFormUsuario.ResumeLayout(false);
            this.PFormUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsuario)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panelBuscador.ResumeLayout(false);
            this.panelBuscador.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label LDni;
        private System.Windows.Forms.Label LApellido;
        private System.Windows.Forms.Label LUsuario;
        private System.Windows.Forms.Label LContrasena;
        private System.Windows.Forms.Label LConfContrasena;
        private System.Windows.Forms.TextBox TBdni;
        private System.Windows.Forms.TextBox TBapellido;
        private System.Windows.Forms.TextBox TBusuario;
        private System.Windows.Forms.TextBox TBcontrasena;
        private System.Windows.Forms.TextBox TBConfContra;
        private System.Windows.Forms.ComboBox CBRol;
        private System.Windows.Forms.Label LRol;
        private System.Windows.Forms.Label Lestado;
        private System.Windows.Forms.ComboBox CBestado;
        private System.Windows.Forms.Button BGuardar;
        private System.Windows.Forms.Label LTitulo;
        private System.Windows.Forms.Panel PFormUsuario;
        private System.Windows.Forms.Label LNombree;
        private System.Windows.Forms.TextBox TBNombree;
        private System.Windows.Forms.DataGridView dataGridUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TIdUsuario;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cboBusqueda;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Button BCancelar;
        private System.Windows.Forms.Button BLimpiar;
        private System.Windows.Forms.Panel panelBuscador;
        private System.Windows.Forms.DataGridViewButtonColumn btnSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Usuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contrasena;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Rol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}
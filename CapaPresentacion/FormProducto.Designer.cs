namespace CapaPresentacion
{
    partial class FormProducto
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
            this.LProducto = new System.Windows.Forms.Label();
            this.PFormUsuario = new System.Windows.Forms.Panel();
            this.TIdProducto = new System.Windows.Forms.TextBox();
            this.LTitulo = new System.Windows.Forms.Label();
            this.LCodProduct = new System.Windows.Forms.Label();
            this.TBdni = new System.Windows.Forms.TextBox();
            this.LNombree = new System.Windows.Forms.Label();
            this.CBestado = new System.Windows.Forms.ComboBox();
            this.TBNombree = new System.Windows.Forms.TextBox();
            this.Lestado = new System.Windows.Forms.Label();
            this.LDescripcion = new System.Windows.Forms.Label();
            this.CBRol = new System.Windows.Forms.ComboBox();
            this.LCategoria = new System.Windows.Forms.Label();
            this.TBapellido = new System.Windows.Forms.TextBox();
            this.LStock = new System.Windows.Forms.Label();
            this.TBusuario = new System.Windows.Forms.TextBox();
            this.TBcontrasena = new System.Windows.Forms.TextBox();
            this.LPrecio = new System.Windows.Forms.Label();
            this.dataGridProducto = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cboBusqueda = new System.Windows.Forms.ComboBox();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.btnSeleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.id_Prod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Categ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.BEliminar = new System.Windows.Forms.Button();
            this.BEditar = new System.Windows.Forms.Button();
            this.BGuardar = new System.Windows.Forms.Button();
            this.PFormUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // LProducto
            // 
            this.LProducto.BackColor = System.Drawing.Color.White;
            this.LProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LProducto.Dock = System.Windows.Forms.DockStyle.Top;
            this.LProducto.Font = new System.Drawing.Font("Leelawadee UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LProducto.Location = new System.Drawing.Point(0, 0);
            this.LProducto.Name = "LProducto";
            this.LProducto.Size = new System.Drawing.Size(1017, 47);
            this.LProducto.TabIndex = 26;
            this.LProducto.Text = "Lista de Productos:";
            this.LProducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PFormUsuario
            // 
            this.PFormUsuario.AutoScroll = true;
            this.PFormUsuario.BackColor = System.Drawing.Color.White;
            this.PFormUsuario.Controls.Add(this.TIdProducto);
            this.PFormUsuario.Controls.Add(this.LTitulo);
            this.PFormUsuario.Controls.Add(this.BEliminar);
            this.PFormUsuario.Controls.Add(this.LCodProduct);
            this.PFormUsuario.Controls.Add(this.BEditar);
            this.PFormUsuario.Controls.Add(this.TBdni);
            this.PFormUsuario.Controls.Add(this.BGuardar);
            this.PFormUsuario.Controls.Add(this.LNombree);
            this.PFormUsuario.Controls.Add(this.CBestado);
            this.PFormUsuario.Controls.Add(this.TBNombree);
            this.PFormUsuario.Controls.Add(this.Lestado);
            this.PFormUsuario.Controls.Add(this.LDescripcion);
            this.PFormUsuario.Controls.Add(this.CBRol);
            this.PFormUsuario.Controls.Add(this.LCategoria);
            this.PFormUsuario.Controls.Add(this.TBapellido);
            this.PFormUsuario.Controls.Add(this.LStock);
            this.PFormUsuario.Controls.Add(this.TBusuario);
            this.PFormUsuario.Controls.Add(this.TBcontrasena);
            this.PFormUsuario.Controls.Add(this.LPrecio);
            this.PFormUsuario.Dock = System.Windows.Forms.DockStyle.Right;
            this.PFormUsuario.Location = new System.Drawing.Point(759, 47);
            this.PFormUsuario.Name = "PFormUsuario";
            this.PFormUsuario.Size = new System.Drawing.Size(258, 545);
            this.PFormUsuario.TabIndex = 27;
            // 
            // TIdProducto
            // 
            this.TIdProducto.Location = new System.Drawing.Point(205, 39);
            this.TIdProducto.Name = "TIdProducto";
            this.TIdProducto.Size = new System.Drawing.Size(31, 20);
            this.TIdProducto.TabIndex = 23;
            this.TIdProducto.Text = "0";
            this.TIdProducto.Visible = false;
            // 
            // LTitulo
            // 
            this.LTitulo.AutoSize = true;
            this.LTitulo.BackColor = System.Drawing.Color.White;
            this.LTitulo.Font = new System.Drawing.Font("Leelawadee UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTitulo.Location = new System.Drawing.Point(36, 11);
            this.LTitulo.Name = "LTitulo";
            this.LTitulo.Size = new System.Drawing.Size(189, 25);
            this.LTitulo.TabIndex = 22;
            this.LTitulo.Text = "Detalle de Producto";
            // 
            // LCodProduct
            // 
            this.LCodProduct.AutoSize = true;
            this.LCodProduct.BackColor = System.Drawing.Color.White;
            this.LCodProduct.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCodProduct.Location = new System.Drawing.Point(17, 47);
            this.LCodProduct.Name = "LCodProduct";
            this.LCodProduct.Size = new System.Drawing.Size(115, 17);
            this.LCodProduct.TabIndex = 1;
            this.LCodProduct.Text = "Cod. del producto";
            // 
            // TBdni
            // 
            this.TBdni.Location = new System.Drawing.Point(31, 67);
            this.TBdni.Name = "TBdni";
            this.TBdni.Size = new System.Drawing.Size(208, 20);
            this.TBdni.TabIndex = 7;
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
            // CBestado
            // 
            this.CBestado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBestado.FormattingEnabled = true;
            this.CBestado.Location = new System.Drawing.Point(32, 372);
            this.CBestado.Name = "CBestado";
            this.CBestado.Size = new System.Drawing.Size(208, 21);
            this.CBestado.TabIndex = 18;
            // 
            // TBNombree
            // 
            this.TBNombree.Location = new System.Drawing.Point(31, 118);
            this.TBNombree.Name = "TBNombree";
            this.TBNombree.Size = new System.Drawing.Size(208, 20);
            this.TBNombree.TabIndex = 8;
            // 
            // Lestado
            // 
            this.Lestado.AutoSize = true;
            this.Lestado.BackColor = System.Drawing.Color.White;
            this.Lestado.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lestado.Location = new System.Drawing.Point(18, 352);
            this.Lestado.Name = "Lestado";
            this.Lestado.Size = new System.Drawing.Size(48, 17);
            this.Lestado.TabIndex = 17;
            this.Lestado.Text = "Estado";
            // 
            // LDescripcion
            // 
            this.LDescripcion.AutoSize = true;
            this.LDescripcion.BackColor = System.Drawing.Color.White;
            this.LDescripcion.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDescripcion.Location = new System.Drawing.Point(17, 148);
            this.LDescripcion.Name = "LDescripcion";
            this.LDescripcion.Size = new System.Drawing.Size(76, 17);
            this.LDescripcion.TabIndex = 3;
            this.LDescripcion.Text = "Descripción";
            // 
            // CBRol
            // 
            this.CBRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBRol.FormattingEnabled = true;
            this.CBRol.Location = new System.Drawing.Point(32, 322);
            this.CBRol.Name = "CBRol";
            this.CBRol.Size = new System.Drawing.Size(208, 21);
            this.CBRol.TabIndex = 15;
            // 
            // LCategoria
            // 
            this.LCategoria.AutoSize = true;
            this.LCategoria.BackColor = System.Drawing.Color.White;
            this.LCategoria.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCategoria.Location = new System.Drawing.Point(21, 302);
            this.LCategoria.Name = "LCategoria";
            this.LCategoria.Size = new System.Drawing.Size(65, 17);
            this.LCategoria.TabIndex = 16;
            this.LCategoria.Text = "Categoría";
            // 
            // TBapellido
            // 
            this.TBapellido.Location = new System.Drawing.Point(31, 168);
            this.TBapellido.Name = "TBapellido";
            this.TBapellido.Size = new System.Drawing.Size(208, 20);
            this.TBapellido.TabIndex = 9;
            // 
            // LStock
            // 
            this.LStock.AutoSize = true;
            this.LStock.BackColor = System.Drawing.Color.White;
            this.LStock.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LStock.Location = new System.Drawing.Point(20, 199);
            this.LStock.Name = "LStock";
            this.LStock.Size = new System.Drawing.Size(39, 17);
            this.LStock.TabIndex = 4;
            this.LStock.Text = "Stock";
            // 
            // TBusuario
            // 
            this.TBusuario.Location = new System.Drawing.Point(31, 219);
            this.TBusuario.Name = "TBusuario";
            this.TBusuario.Size = new System.Drawing.Size(208, 20);
            this.TBusuario.TabIndex = 10;
            // 
            // TBcontrasena
            // 
            this.TBcontrasena.Location = new System.Drawing.Point(31, 270);
            this.TBcontrasena.Name = "TBcontrasena";
            this.TBcontrasena.Size = new System.Drawing.Size(208, 20);
            this.TBcontrasena.TabIndex = 11;
            // 
            // LPrecio
            // 
            this.LPrecio.AutoSize = true;
            this.LPrecio.BackColor = System.Drawing.Color.White;
            this.LPrecio.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LPrecio.Location = new System.Drawing.Point(17, 250);
            this.LPrecio.Name = "LPrecio";
            this.LPrecio.Size = new System.Drawing.Size(44, 17);
            this.LPrecio.TabIndex = 5;
            this.LPrecio.Text = "Precio";
            // 
            // dataGridProducto
            // 
            this.dataGridProducto.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Leelawadee UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridProducto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProducto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnSeleccionar,
            this.id_Prod,
            this.cod,
            this.nombre,
            this.descripcion,
            this.stock,
            this.Precio,
            this.Id_Categ,
            this.categoria,
            this.Estado});
            this.dataGridProducto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridProducto.Location = new System.Drawing.Point(0, 47);
            this.dataGridProducto.MultiSelect = false;
            this.dataGridProducto.Name = "dataGridProducto";
            this.dataGridProducto.ReadOnly = true;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridProducto.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridProducto.RowTemplate.Height = 28;
            this.dataGridProducto.Size = new System.Drawing.Size(759, 545);
            this.dataGridProducto.TabIndex = 28;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(193, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(106, 13);
            this.textBox1.TabIndex = 29;
            this.textBox1.Text = "Buscar por :";
            // 
            // cboBusqueda
            // 
            this.cboBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBusqueda.FormattingEnabled = true;
            this.cboBusqueda.Location = new System.Drawing.Point(260, 17);
            this.cboBusqueda.Name = "cboBusqueda";
            this.cboBusqueda.Size = new System.Drawing.Size(118, 21);
            this.cboBusqueda.TabIndex = 30;
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(388, 18);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(144, 20);
            this.txtBusqueda.TabIndex = 31;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.HeaderText = "";
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.ReadOnly = true;
            this.btnSeleccionar.Width = 30;
            // 
            // id_Prod
            // 
            this.id_Prod.HeaderText = "id_Prod";
            this.id_Prod.Name = "id_Prod";
            this.id_Prod.ReadOnly = true;
            this.id_Prod.Visible = false;
            // 
            // cod
            // 
            this.cod.HeaderText = "Codigo ";
            this.cod.Name = "cod";
            this.cod.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Descripción";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            // 
            // stock
            // 
            this.stock.HeaderText = "Stock";
            this.stock.Name = "stock";
            this.stock.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.Visible = false;
            // 
            // Id_Categ
            // 
            this.Id_Categ.HeaderText = "Id_categ";
            this.Id_Categ.Name = "Id_Categ";
            this.Id_Categ.ReadOnly = true;
            this.Id_Categ.Visible = false;
            // 
            // categoria
            // 
            this.categoria.HeaderText = "Categoría";
            this.categoria.Name = "categoria";
            this.categoria.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
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
            this.btnBuscar.Location = new System.Drawing.Point(542, 17);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(25, 22);
            this.btnBuscar.TabIndex = 32;
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // BEliminar
            // 
            this.BEliminar.BackColor = System.Drawing.Color.Silver;
            this.BEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BEliminar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BEliminar.FlatAppearance.BorderSize = 0;
            this.BEliminar.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(202)))), ((int)(((byte)(210)))));
            this.BEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BEliminar.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BEliminar.Image = global::CapaPresentacion.Properties.Resources.papelera_xmark;
            this.BEliminar.Location = new System.Drawing.Point(20, 495);
            this.BEliminar.Name = "BEliminar";
            this.BEliminar.Size = new System.Drawing.Size(216, 39);
            this.BEliminar.TabIndex = 21;
            this.BEliminar.Text = "Eliminar";
            this.BEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BEliminar.UseVisualStyleBackColor = false;
            // 
            // BEditar
            // 
            this.BEditar.BackColor = System.Drawing.Color.Silver;
            this.BEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BEditar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BEditar.FlatAppearance.BorderSize = 0;
            this.BEditar.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BEditar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(202)))), ((int)(((byte)(210)))));
            this.BEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BEditar.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BEditar.Image = global::CapaPresentacion.Properties.Resources.archivo_de_edicion;
            this.BEditar.Location = new System.Drawing.Point(20, 452);
            this.BEditar.Name = "BEditar";
            this.BEditar.Size = new System.Drawing.Size(216, 37);
            this.BEditar.TabIndex = 20;
            this.BEditar.Text = "Editar";
            this.BEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BEditar.UseVisualStyleBackColor = false;
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
            this.BGuardar.Location = new System.Drawing.Point(21, 410);
            this.BGuardar.Name = "BGuardar";
            this.BGuardar.Size = new System.Drawing.Size(216, 36);
            this.BGuardar.TabIndex = 19;
            this.BGuardar.Text = "Guardar";
            this.BGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BGuardar.UseVisualStyleBackColor = false;
            // 
            // FormProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 592);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.cboBusqueda);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridProducto);
            this.Controls.Add(this.PFormUsuario);
            this.Controls.Add(this.LProducto);
            this.Name = "FormProducto";
            this.Text = "FormProducto";
            this.PFormUsuario.ResumeLayout(false);
            this.PFormUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LProducto;
        private System.Windows.Forms.Panel PFormUsuario;
        private System.Windows.Forms.TextBox TIdProducto;
        private System.Windows.Forms.Label LTitulo;
        private System.Windows.Forms.Button BEliminar;
        private System.Windows.Forms.Label LCodProduct;
        private System.Windows.Forms.Button BEditar;
        private System.Windows.Forms.TextBox TBdni;
        private System.Windows.Forms.Button BGuardar;
        private System.Windows.Forms.Label LNombree;
        private System.Windows.Forms.ComboBox CBestado;
        private System.Windows.Forms.TextBox TBNombree;
        private System.Windows.Forms.Label Lestado;
        private System.Windows.Forms.Label LDescripcion;
        private System.Windows.Forms.ComboBox CBRol;
        private System.Windows.Forms.Label LCategoria;
        private System.Windows.Forms.TextBox TBapellido;
        private System.Windows.Forms.Label LStock;
        private System.Windows.Forms.TextBox TBusuario;
        private System.Windows.Forms.TextBox TBcontrasena;
        private System.Windows.Forms.Label LPrecio;
        private System.Windows.Forms.DataGridView dataGridProducto;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cboBusqueda;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridViewButtonColumn btnSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Prod;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Categ;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}
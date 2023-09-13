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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LCategoriaa = new System.Windows.Forms.Label();
            this.PFormUsuario = new System.Windows.Forms.Panel();
            this.TIdCategoria = new System.Windows.Forms.TextBox();
            this.LTitulo = new System.Windows.Forms.Label();
            this.BEliminar = new System.Windows.Forms.Button();
            this.LCodCategoria = new System.Windows.Forms.Label();
            this.BEditar = new System.Windows.Forms.Button();
            this.TBdni = new System.Windows.Forms.TextBox();
            this.BGuardar = new System.Windows.Forms.Button();
            this.LNombree = new System.Windows.Forms.Label();
            this.CBestado = new System.Windows.Forms.ComboBox();
            this.TBNombree = new System.Windows.Forms.TextBox();
            this.Lestado = new System.Windows.Forms.Label();
            this.LDescripcion = new System.Windows.Forms.Label();
            this.TBapellido = new System.Windows.Forms.TextBox();
            this.dataGridProducto = new System.Windows.Forms.DataGridView();
            this.btnSeleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.id_categ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PFormUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // LCategoriaa
            // 
            this.LCategoriaa.BackColor = System.Drawing.Color.White;
            this.LCategoriaa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LCategoriaa.Dock = System.Windows.Forms.DockStyle.Top;
            this.LCategoriaa.Font = new System.Drawing.Font("Leelawadee UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCategoriaa.Location = new System.Drawing.Point(0, 0);
            this.LCategoriaa.Name = "LCategoriaa";
            this.LCategoriaa.Size = new System.Drawing.Size(630, 47);
            this.LCategoriaa.TabIndex = 27;
            this.LCategoriaa.Text = "Lista de Categorías:";
            this.LCategoriaa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PFormUsuario
            // 
            this.PFormUsuario.AutoScroll = true;
            this.PFormUsuario.BackColor = System.Drawing.Color.White;
            this.PFormUsuario.Controls.Add(this.TIdCategoria);
            this.PFormUsuario.Controls.Add(this.LTitulo);
            this.PFormUsuario.Controls.Add(this.BEliminar);
            this.PFormUsuario.Controls.Add(this.LCodCategoria);
            this.PFormUsuario.Controls.Add(this.BEditar);
            this.PFormUsuario.Controls.Add(this.TBdni);
            this.PFormUsuario.Controls.Add(this.BGuardar);
            this.PFormUsuario.Controls.Add(this.LNombree);
            this.PFormUsuario.Controls.Add(this.CBestado);
            this.PFormUsuario.Controls.Add(this.TBNombree);
            this.PFormUsuario.Controls.Add(this.Lestado);
            this.PFormUsuario.Controls.Add(this.LDescripcion);
            this.PFormUsuario.Controls.Add(this.TBapellido);
            this.PFormUsuario.Dock = System.Windows.Forms.DockStyle.Right;
            this.PFormUsuario.Location = new System.Drawing.Point(372, 47);
            this.PFormUsuario.Name = "PFormUsuario";
            this.PFormUsuario.Size = new System.Drawing.Size(258, 463);
            this.PFormUsuario.TabIndex = 28;
            // 
            // TIdCategoria
            // 
            this.TIdCategoria.Location = new System.Drawing.Point(215, 39);
            this.TIdCategoria.Name = "TIdCategoria";
            this.TIdCategoria.Size = new System.Drawing.Size(31, 20);
            this.TIdCategoria.TabIndex = 23;
            this.TIdCategoria.Text = "0";
            this.TIdCategoria.Visible = false;
            // 
            // LTitulo
            // 
            this.LTitulo.AutoSize = true;
            this.LTitulo.BackColor = System.Drawing.Color.White;
            this.LTitulo.Font = new System.Drawing.Font("Leelawadee UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTitulo.Location = new System.Drawing.Point(36, 11);
            this.LTitulo.Name = "LTitulo";
            this.LTitulo.Size = new System.Drawing.Size(192, 25);
            this.LTitulo.TabIndex = 22;
            this.LTitulo.Text = "Detalle de Categoría";
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
            this.BEliminar.Location = new System.Drawing.Point(20, 354);
            this.BEliminar.Name = "BEliminar";
            this.BEliminar.Size = new System.Drawing.Size(216, 39);
            this.BEliminar.TabIndex = 21;
            this.BEliminar.Text = "Eliminar";
            this.BEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BEliminar.UseVisualStyleBackColor = false;
            // 
            // LCodCategoria
            // 
            this.LCodCategoria.AutoSize = true;
            this.LCodCategoria.BackColor = System.Drawing.Color.White;
            this.LCodCategoria.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCodCategoria.Location = new System.Drawing.Point(17, 47);
            this.LCodCategoria.Name = "LCodCategoria";
            this.LCodCategoria.Size = new System.Drawing.Size(94, 17);
            this.LCodCategoria.TabIndex = 1;
            this.LCodCategoria.Text = "Cod. categoría";
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
            this.BEditar.Location = new System.Drawing.Point(20, 311);
            this.BEditar.Name = "BEditar";
            this.BEditar.Size = new System.Drawing.Size(216, 37);
            this.BEditar.TabIndex = 20;
            this.BEditar.Text = "Editar";
            this.BEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BEditar.UseVisualStyleBackColor = false;
            // 
            // TBdni
            // 
            this.TBdni.Location = new System.Drawing.Point(31, 67);
            this.TBdni.Name = "TBdni";
            this.TBdni.Size = new System.Drawing.Size(208, 20);
            this.TBdni.TabIndex = 7;
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
            this.BGuardar.Location = new System.Drawing.Point(21, 269);
            this.BGuardar.Name = "BGuardar";
            this.BGuardar.Size = new System.Drawing.Size(216, 36);
            this.BGuardar.TabIndex = 19;
            this.BGuardar.Text = "Guardar";
            this.BGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BGuardar.UseVisualStyleBackColor = false;
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
            this.CBestado.Location = new System.Drawing.Point(32, 231);
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
            this.Lestado.Location = new System.Drawing.Point(18, 211);
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
            // TBapellido
            // 
            this.TBapellido.Location = new System.Drawing.Point(31, 168);
            this.TBapellido.Name = "TBapellido";
            this.TBapellido.Size = new System.Drawing.Size(208, 20);
            this.TBapellido.TabIndex = 9;
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
            this.id_categ,
            this.cod,
            this.nombre,
            this.descripcion});
            this.dataGridProducto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridProducto.Location = new System.Drawing.Point(0, 47);
            this.dataGridProducto.MultiSelect = false;
            this.dataGridProducto.Name = "dataGridProducto";
            this.dataGridProducto.ReadOnly = true;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridProducto.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridProducto.RowTemplate.Height = 28;
            this.dataGridProducto.Size = new System.Drawing.Size(372, 463);
            this.dataGridProducto.TabIndex = 29;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.HeaderText = "";
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.ReadOnly = true;
            this.btnSeleccionar.Width = 30;
            // 
            // id_categ
            // 
            this.id_categ.HeaderText = "id_Categoria";
            this.id_categ.Name = "id_categ";
            this.id_categ.ReadOnly = true;
            this.id_categ.Visible = false;
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
            // FormCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 510);
            this.Controls.Add(this.dataGridProducto);
            this.Controls.Add(this.PFormUsuario);
            this.Controls.Add(this.LCategoriaa);
            this.Name = "FormCategorias";
            this.Text = "FormCategorias";
            this.PFormUsuario.ResumeLayout(false);
            this.PFormUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProducto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LCategoriaa;
        private System.Windows.Forms.Panel PFormUsuario;
        private System.Windows.Forms.TextBox TIdCategoria;
        private System.Windows.Forms.Label LTitulo;
        private System.Windows.Forms.Button BEliminar;
        private System.Windows.Forms.Label LCodCategoria;
        private System.Windows.Forms.Button BEditar;
        private System.Windows.Forms.TextBox TBdni;
        private System.Windows.Forms.Button BGuardar;
        private System.Windows.Forms.Label LNombree;
        private System.Windows.Forms.ComboBox CBestado;
        private System.Windows.Forms.TextBox TBNombree;
        private System.Windows.Forms.Label Lestado;
        private System.Windows.Forms.Label LDescripcion;
        private System.Windows.Forms.TextBox TBapellido;
        private System.Windows.Forms.DataGridView dataGridProducto;
        private System.Windows.Forms.DataGridViewButtonColumn btnSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_categ;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
    }
}
namespace CapaPresentacion.Prod_Categ
{
    partial class AltaCateg
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
            this.panelBotonCerrar = new System.Windows.Forms.Panel();
            this.CBestado = new System.Windows.Forms.ComboBox();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.LDni = new System.Windows.Forms.Label();
            this.Lestado = new System.Windows.Forms.Label();
            this.LApellido = new System.Windows.Forms.Label();
            this.txtDescrip = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picCerrar = new System.Windows.Forms.PictureBox();
            this.LTitulo = new System.Windows.Forms.Label();
            this.panelBotonCerrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBotonCerrar
            // 
            this.panelBotonCerrar.BackColor = System.Drawing.Color.DarkGray;
            this.panelBotonCerrar.Controls.Add(this.pictureBox1);
            this.panelBotonCerrar.Controls.Add(this.picCerrar);
            this.panelBotonCerrar.Controls.Add(this.LTitulo);
            this.panelBotonCerrar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBotonCerrar.Location = new System.Drawing.Point(0, 0);
            this.panelBotonCerrar.Name = "panelBotonCerrar";
            this.panelBotonCerrar.Size = new System.Drawing.Size(560, 35);
            this.panelBotonCerrar.TabIndex = 36;
            // 
            // CBestado
            // 
            this.CBestado.BackColor = System.Drawing.Color.White;
            this.CBestado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBestado.FormattingEnabled = true;
            this.CBestado.Location = new System.Drawing.Point(224, 212);
            this.CBestado.Name = "CBestado";
            this.CBestado.Size = new System.Drawing.Size(185, 21);
            this.CBestado.TabIndex = 71;
            // 
            // txtCod
            // 
            this.txtCod.BackColor = System.Drawing.Color.White;
            this.txtCod.Location = new System.Drawing.Point(224, 136);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(185, 20);
            this.txtCod.TabIndex = 61;
            this.txtCod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCod_KeyPress);
            // 
            // LDni
            // 
            this.LDni.AutoSize = true;
            this.LDni.BackColor = System.Drawing.Color.Black;
            this.LDni.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDni.ForeColor = System.Drawing.Color.White;
            this.LDni.Location = new System.Drawing.Point(138, 136);
            this.LDni.Name = "LDni";
            this.LDni.Size = new System.Drawing.Size(55, 17);
            this.LDni.TabIndex = 58;
            this.LDni.Text = "Codigo ";
            // 
            // Lestado
            // 
            this.Lestado.AutoSize = true;
            this.Lestado.BackColor = System.Drawing.Color.Black;
            this.Lestado.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lestado.ForeColor = System.Drawing.Color.White;
            this.Lestado.Location = new System.Drawing.Point(142, 216);
            this.Lestado.Name = "Lestado";
            this.Lestado.Size = new System.Drawing.Size(51, 17);
            this.Lestado.TabIndex = 66;
            this.Lestado.Text = "Estado:";
            // 
            // LApellido
            // 
            this.LApellido.AutoSize = true;
            this.LApellido.BackColor = System.Drawing.Color.Black;
            this.LApellido.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LApellido.ForeColor = System.Drawing.Color.White;
            this.LApellido.Location = new System.Drawing.Point(138, 174);
            this.LApellido.Name = "LApellido";
            this.LApellido.Size = new System.Drawing.Size(79, 17);
            this.LApellido.TabIndex = 60;
            this.LApellido.Text = "Descripción:";
            // 
            // txtDescrip
            // 
            this.txtDescrip.BackColor = System.Drawing.Color.White;
            this.txtDescrip.Location = new System.Drawing.Point(224, 174);
            this.txtDescrip.Name = "txtDescrip";
            this.txtDescrip.Size = new System.Drawing.Size(185, 20);
            this.txtDescrip.TabIndex = 63;
            this.txtDescrip.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescrip_KeyPress);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.LightGray;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(202)))), ((int)(((byte)(210)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = global::CapaPresentacion.Properties.Resources.cruz_pequena1;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(301, 281);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(108, 31);
            this.btnCancelar.TabIndex = 73;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.LightGray;
            this.BtnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.BtnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BtnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(202)))), ((int)(((byte)(210)))));
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardar.Font = new System.Drawing.Font("Leelawadee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnGuardar.Image = global::CapaPresentacion.Properties.Resources.flecha_de_circulo_de_disquete_a_la_derecha;
            this.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGuardar.Location = new System.Drawing.Point(141, 281);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.BtnGuardar.Size = new System.Drawing.Size(108, 31);
            this.BtnGuardar.TabIndex = 72;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightGray;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.cruz_pequena1;
            this.pictureBox1.Location = new System.Drawing.Point(523, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // picCerrar
            // 
            this.picCerrar.BackColor = System.Drawing.Color.LightGray;
            this.picCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCerrar.Image = global::CapaPresentacion.Properties.Resources.cruz_pequena1;
            this.picCerrar.Location = new System.Drawing.Point(767, 3);
            this.picCerrar.Name = "picCerrar";
            this.picCerrar.Size = new System.Drawing.Size(33, 22);
            this.picCerrar.TabIndex = 35;
            this.picCerrar.TabStop = false;
            // 
            // LTitulo
            // 
            this.LTitulo.BackColor = System.Drawing.Color.Transparent;
            this.LTitulo.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTitulo.ForeColor = System.Drawing.Color.Black;
            this.LTitulo.Image = global::CapaPresentacion.Properties.Resources.anadir___Copia;
            this.LTitulo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LTitulo.Location = new System.Drawing.Point(3, 0);
            this.LTitulo.Name = "LTitulo";
            this.LTitulo.Size = new System.Drawing.Size(204, 31);
            this.LTitulo.TabIndex = 22;
            this.LTitulo.Text = "Agregar  de Categoría";
            this.LTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AltaCateg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(560, 418);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.CBestado);
            this.Controls.Add(this.txtCod);
            this.Controls.Add(this.LDni);
            this.Controls.Add(this.Lestado);
            this.Controls.Add(this.LApellido);
            this.Controls.Add(this.txtDescrip);
            this.Controls.Add(this.panelBotonCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AltaCateg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AltaCateg";
            this.panelBotonCerrar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelBotonCerrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picCerrar;
        private System.Windows.Forms.Label LTitulo;
        private System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.ComboBox CBestado;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.Label LDni;
        private System.Windows.Forms.Label Lestado;
        private System.Windows.Forms.Label LApellido;
        private System.Windows.Forms.TextBox txtDescrip;
    }
}
namespace CapaPresentacion.Modales
{
    partial class modalCantModificar
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
            this.lblTituloPr = new System.Windows.Forms.Label();
            this.panelBotonesCerrar = new System.Windows.Forms.Panel();
            this.panelBotonesForm = new System.Windows.Forms.Panel();
            this.picCerrar = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCantid = new System.Windows.Forms.Label();
            this.numericUpDownModif = new System.Windows.Forms.NumericUpDown();
            this.btnModificar = new System.Windows.Forms.Button();
            this.panelBotonesCerrar.SuspendLayout();
            this.panelBotonesForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCerrar)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownModif)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloPr
            // 
            this.lblTituloPr.AutoSize = true;
            this.lblTituloPr.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloPr.Location = new System.Drawing.Point(10, 7);
            this.lblTituloPr.Name = "lblTituloPr";
            this.lblTituloPr.Size = new System.Drawing.Size(124, 17);
            this.lblTituloPr.TabIndex = 0;
            this.lblTituloPr.Text = "Modificar cantidad";
            // 
            // panelBotonesCerrar
            // 
            this.panelBotonesCerrar.BackColor = System.Drawing.Color.LightGray;
            this.panelBotonesCerrar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelBotonesCerrar.Controls.Add(this.lblTituloPr);
            this.panelBotonesCerrar.Controls.Add(this.panelBotonesForm);
            this.panelBotonesCerrar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBotonesCerrar.Location = new System.Drawing.Point(0, 0);
            this.panelBotonesCerrar.Name = "panelBotonesCerrar";
            this.panelBotonesCerrar.Size = new System.Drawing.Size(327, 35);
            this.panelBotonesCerrar.TabIndex = 32;
            // 
            // panelBotonesForm
            // 
            this.panelBotonesForm.BackColor = System.Drawing.Color.LightGray;
            this.panelBotonesForm.Controls.Add(this.picCerrar);
            this.panelBotonesForm.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelBotonesForm.Location = new System.Drawing.Point(211, 0);
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
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.lblCantid);
            this.groupBox1.Controls.Add(this.numericUpDownModif);
            this.groupBox1.Controls.Add(this.btnModificar);
            this.groupBox1.Location = new System.Drawing.Point(27, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(266, 143);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            // 
            // lblCantid
            // 
            this.lblCantid.AutoSize = true;
            this.lblCantid.Font = new System.Drawing.Font("Leelawadee UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantid.Location = new System.Drawing.Point(17, 28);
            this.lblCantid.Name = "lblCantid";
            this.lblCantid.Size = new System.Drawing.Size(57, 13);
            this.lblCantid.TabIndex = 14;
            this.lblCantid.Text = "Cantidad:";
            // 
            // numericUpDownModif
            // 
            this.numericUpDownModif.Font = new System.Drawing.Font("Leelawadee UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownModif.Location = new System.Drawing.Point(67, 63);
            this.numericUpDownModif.Name = "numericUpDownModif";
            this.numericUpDownModif.Size = new System.Drawing.Size(131, 22);
            this.numericUpDownModif.TabIndex = 13;
            this.numericUpDownModif.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.Silver;
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(202)))), ((int)(((byte)(210)))));
            this.btnModificar.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.Black;
            this.btnModificar.Location = new System.Drawing.Point(67, 102);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(131, 26);
            this.btnModificar.TabIndex = 4;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // modalCantModificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(327, 181);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panelBotonesCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "modalCantModificar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "modalCantModificar";
            this.panelBotonesCerrar.ResumeLayout(false);
            this.panelBotonesCerrar.PerformLayout();
            this.panelBotonesForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCerrar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownModif)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTituloPr;
        private System.Windows.Forms.Panel panelBotonesCerrar;
        private System.Windows.Forms.Panel panelBotonesForm;
        private System.Windows.Forms.PictureBox picCerrar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCantid;
        public System.Windows.Forms.NumericUpDown numericUpDownModif;
        public System.Windows.Forms.Button btnModificar;
    }
}
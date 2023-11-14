namespace CapaPresentacion.Seguridad
{
    partial class FormSeguridad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSeguridad));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtBackup = new System.Windows.Forms.TextBox();
            this.lblBackup = new System.Windows.Forms.Label();
            this.btnRestaurar = new System.Windows.Forms.Button();
            this.txtRestore = new System.Windows.Forms.TextBox();
            this.lblRestore = new System.Windows.Forms.Label();
            this.panelTopUsuario = new System.Windows.Forms.Panel();
            this.panelBuscador = new System.Windows.Forms.Panel();
            this.panelRigtUsuario = new System.Windows.Forms.Panel();
            this.picUsuario = new System.Windows.Forms.PictureBox();
            this.lblTituloCli = new System.Windows.Forms.Label();
            this.panelSeguri = new System.Windows.Forms.Panel();
            this.gbxRestore = new System.Windows.Forms.GroupBox();
            this.picRestore = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gBxBackup = new System.Windows.Forms.GroupBox();
            this.picBackup = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTopUsuario.SuspendLayout();
            this.panelRigtUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUsuario)).BeginInit();
            this.panelSeguri.SuspendLayout();
            this.gbxRestore.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRestore)).BeginInit();
            this.gBxBackup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBackup)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Silver;
            this.btnGuardar.Font = new System.Drawing.Font("Leelawadee UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(21, 200);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtBackup
            // 
            this.txtBackup.Location = new System.Drawing.Point(100, 201);
            this.txtBackup.Name = "txtBackup";
            this.txtBackup.Size = new System.Drawing.Size(163, 20);
            this.txtBackup.TabIndex = 1;
            // 
            // lblBackup
            // 
            this.lblBackup.AutoSize = true;
            this.lblBackup.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBackup.Location = new System.Drawing.Point(60, 51);
            this.lblBackup.Name = "lblBackup";
            this.lblBackup.Size = new System.Drawing.Size(52, 17);
            this.lblBackup.TabIndex = 0;
            this.lblBackup.Text = "Backup";
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.BackColor = System.Drawing.Color.Silver;
            this.btnRestaurar.Font = new System.Drawing.Font("Leelawadee UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestaurar.Location = new System.Drawing.Point(24, 201);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(75, 23);
            this.btnRestaurar.TabIndex = 3;
            this.btnRestaurar.Text = "Restaurar";
            this.btnRestaurar.UseVisualStyleBackColor = false;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // txtRestore
            // 
            this.txtRestore.Location = new System.Drawing.Point(105, 201);
            this.txtRestore.Name = "txtRestore";
            this.txtRestore.Size = new System.Drawing.Size(148, 20);
            this.txtRestore.TabIndex = 2;
            // 
            // lblRestore
            // 
            this.lblRestore.AutoSize = true;
            this.lblRestore.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRestore.Location = new System.Drawing.Point(60, 51);
            this.lblRestore.Name = "lblRestore";
            this.lblRestore.Size = new System.Drawing.Size(54, 17);
            this.lblRestore.TabIndex = 1;
            this.lblRestore.Text = "Restore";
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
            this.panelTopUsuario.TabIndex = 4;
            // 
            // panelBuscador
            // 
            this.panelBuscador.BackColor = System.Drawing.Color.Transparent;
            this.panelBuscador.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelBuscador.Location = new System.Drawing.Point(0, 0);
            this.panelBuscador.Name = "panelBuscador";
            this.panelBuscador.Size = new System.Drawing.Size(485, 107);
            this.panelBuscador.TabIndex = 26;
            // 
            // panelRigtUsuario
            // 
            this.panelRigtUsuario.BackColor = System.Drawing.Color.LightGray;
            this.panelRigtUsuario.Controls.Add(this.picUsuario);
            this.panelRigtUsuario.Controls.Add(this.lblTituloCli);
            this.panelRigtUsuario.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRigtUsuario.Location = new System.Drawing.Point(604, 107);
            this.panelRigtUsuario.Name = "panelRigtUsuario";
            this.panelRigtUsuario.Size = new System.Drawing.Size(196, 343);
            this.panelRigtUsuario.TabIndex = 5;
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
            // lblTituloCli
            // 
            this.lblTituloCli.AutoSize = true;
            this.lblTituloCli.Font = new System.Drawing.Font("Leelawadee UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloCli.Location = new System.Drawing.Point(36, 147);
            this.lblTituloCli.Name = "lblTituloCli";
            this.lblTituloCli.Size = new System.Drawing.Size(148, 37);
            this.lblTituloCli.TabIndex = 1;
            this.lblTituloCli.Text = "Seguridad";
            // 
            // panelSeguri
            // 
            this.panelSeguri.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSeguri.BackColor = System.Drawing.Color.DarkGray;
            this.panelSeguri.Controls.Add(this.gbxRestore);
            this.panelSeguri.Controls.Add(this.gBxBackup);
            this.panelSeguri.Location = new System.Drawing.Point(0, 107);
            this.panelSeguri.Name = "panelSeguri";
            this.panelSeguri.Size = new System.Drawing.Size(634, 343);
            this.panelSeguri.TabIndex = 6;
            // 
            // gbxRestore
            // 
            this.gbxRestore.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbxRestore.BackColor = System.Drawing.Color.Silver;
            this.gbxRestore.Controls.Add(this.picRestore);
            this.gbxRestore.Controls.Add(this.label2);
            this.gbxRestore.Controls.Add(this.lblRestore);
            this.gbxRestore.Controls.Add(this.txtRestore);
            this.gbxRestore.Controls.Add(this.btnRestaurar);
            this.gbxRestore.Location = new System.Drawing.Point(329, 55);
            this.gbxRestore.Name = "gbxRestore";
            this.gbxRestore.Size = new System.Drawing.Size(269, 276);
            this.gbxRestore.TabIndex = 7;
            this.gbxRestore.TabStop = false;
            // 
            // picRestore
            // 
            this.picRestore.Image = ((System.Drawing.Image)(resources.GetObject("picRestore.Image")));
            this.picRestore.Location = new System.Drawing.Point(140, 39);
            this.picRestore.Name = "picRestore";
            this.picRestore.Size = new System.Drawing.Size(56, 58);
            this.picRestore.TabIndex = 6;
            this.picRestore.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Restaurar una copia de seguridad";
            // 
            // gBxBackup
            // 
            this.gBxBackup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gBxBackup.BackColor = System.Drawing.Color.Silver;
            this.gBxBackup.Controls.Add(this.picBackup);
            this.gBxBackup.Controls.Add(this.label1);
            this.gBxBackup.Controls.Add(this.txtBackup);
            this.gBxBackup.Controls.Add(this.btnGuardar);
            this.gBxBackup.Controls.Add(this.lblBackup);
            this.gBxBackup.Location = new System.Drawing.Point(54, 55);
            this.gBxBackup.Name = "gBxBackup";
            this.gBxBackup.Size = new System.Drawing.Size(269, 276);
            this.gBxBackup.TabIndex = 6;
            this.gBxBackup.TabStop = false;
            // 
            // picBackup
            // 
            this.picBackup.Image = ((System.Drawing.Image)(resources.GetObject("picBackup.Image")));
            this.picBackup.Location = new System.Drawing.Point(150, 39);
            this.picBackup.Name = "picBackup";
            this.picBackup.Size = new System.Drawing.Size(68, 63);
            this.picBackup.TabIndex = 4;
            this.picBackup.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Realizar copia de seguridad";
            // 
            // FormSeguridad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelSeguri);
            this.Controls.Add(this.panelRigtUsuario);
            this.Controls.Add(this.panelTopUsuario);
            this.Name = "FormSeguridad";
            this.Text = "Seguridad";
            this.Load += new System.EventHandler(this.Seguridad_Load);
            this.panelTopUsuario.ResumeLayout(false);
            this.panelRigtUsuario.ResumeLayout(false);
            this.panelRigtUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUsuario)).EndInit();
            this.panelSeguri.ResumeLayout(false);
            this.gbxRestore.ResumeLayout(false);
            this.gbxRestore.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRestore)).EndInit();
            this.gBxBackup.ResumeLayout(false);
            this.gBxBackup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBackup)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtBackup;
        private System.Windows.Forms.Label lblBackup;
        private System.Windows.Forms.Button btnRestaurar;
        private System.Windows.Forms.TextBox txtRestore;
        private System.Windows.Forms.Label lblRestore;
        private System.Windows.Forms.Panel panelTopUsuario;
        private System.Windows.Forms.Panel panelBuscador;
        private System.Windows.Forms.Panel panelRigtUsuario;
        private System.Windows.Forms.PictureBox picUsuario;
        private System.Windows.Forms.Label lblTituloCli;
        private System.Windows.Forms.Panel panelSeguri;
        private System.Windows.Forms.GroupBox gBxBackup;
        private System.Windows.Forms.GroupBox gbxRestore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picRestore;
        private System.Windows.Forms.PictureBox picBackup;
    }
}
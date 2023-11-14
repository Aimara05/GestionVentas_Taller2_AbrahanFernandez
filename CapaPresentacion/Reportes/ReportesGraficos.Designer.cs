namespace CapaPresentacion.Reportes
{
    partial class ReportesGraficos
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.grafico1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Dfechafin2 = new System.Windows.Forms.DateTimePicker();
            this.Dfechainicio2 = new System.Windows.Forms.DateTimePicker();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnGenerarGraficos = new System.Windows.Forms.Button();
            this.btnprodmontos = new System.Windows.Forms.Button();
            this.btnvendventas = new System.Windows.Forms.Button();
            this.btnvendmontos = new System.Windows.Forms.Button();
            this.grafico2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.picCerrar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.grafico1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grafico2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // grafico1
            // 
            chartArea1.Name = "ChartArea1";
            this.grafico1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.grafico1.Legends.Add(legend1);
            this.grafico1.Location = new System.Drawing.Point(416, 50);
            this.grafico1.Name = "grafico1";
            this.grafico1.Size = new System.Drawing.Size(339, 215);
            this.grafico1.TabIndex = 0;
            this.grafico1.Tag = "";
            // 
            // Dfechafin2
            // 
            this.Dfechafin2.Font = new System.Drawing.Font("Leelawadee UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dfechafin2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dfechafin2.Location = new System.Drawing.Point(221, 75);
            this.Dfechafin2.Name = "Dfechafin2";
            this.Dfechafin2.Size = new System.Drawing.Size(119, 22);
            this.Dfechafin2.TabIndex = 39;
            // 
            // Dfechainicio2
            // 
            this.Dfechainicio2.Font = new System.Drawing.Font("Leelawadee UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dfechainicio2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dfechainicio2.Location = new System.Drawing.Point(34, 75);
            this.Dfechainicio2.Name = "Dfechainicio2";
            this.Dfechainicio2.Size = new System.Drawing.Size(119, 22);
            this.Dfechainicio2.TabIndex = 38;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.Black;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Leelawadee UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.White;
            this.textBox3.Location = new System.Drawing.Point(243, 54);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(73, 15);
            this.textBox3.TabIndex = 37;
            this.textBox3.Text = "Fecha Fin:";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Black;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Leelawadee UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(54, 54);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(89, 15);
            this.textBox2.TabIndex = 36;
            this.textBox2.Text = "Fecha Inicio:";
            // 
            // btnGenerarGraficos
            // 
            this.btnGenerarGraficos.Location = new System.Drawing.Point(176, 75);
            this.btnGenerarGraficos.Name = "btnGenerarGraficos";
            this.btnGenerarGraficos.Size = new System.Drawing.Size(130, 51);
            this.btnGenerarGraficos.TabIndex = 41;
            this.btnGenerarGraficos.Text = "Productos mas vendidos";
            this.btnGenerarGraficos.UseVisualStyleBackColor = true;
            this.btnGenerarGraficos.Click += new System.EventHandler(this.btnGenerarGraficos_Click);
            // 
            // btnprodmontos
            // 
            this.btnprodmontos.Location = new System.Drawing.Point(20, 77);
            this.btnprodmontos.Name = "btnprodmontos";
            this.btnprodmontos.Size = new System.Drawing.Size(133, 49);
            this.btnprodmontos.TabIndex = 42;
            this.btnprodmontos.Text = "Montos Recaudados por productos";
            this.btnprodmontos.UseVisualStyleBackColor = true;
            this.btnprodmontos.Click += new System.EventHandler(this.btnprodmontos_Click);
            // 
            // btnvendventas
            // 
            this.btnvendventas.BackColor = System.Drawing.Color.LightGray;
            this.btnvendventas.Font = new System.Drawing.Font("Leelawadee UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvendventas.ForeColor = System.Drawing.Color.Black;
            this.btnvendventas.Location = new System.Drawing.Point(20, 79);
            this.btnvendventas.Name = "btnvendventas";
            this.btnvendventas.Size = new System.Drawing.Size(133, 51);
            this.btnvendventas.TabIndex = 43;
            this.btnvendventas.Text = "Cantidad de ventas (Por Vendedor)";
            this.btnvendventas.UseVisualStyleBackColor = false;
            this.btnvendventas.Click += new System.EventHandler(this.btnvendventas_Click);
            // 
            // btnvendmontos
            // 
            this.btnvendmontos.Font = new System.Drawing.Font("Leelawadee UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvendmontos.Location = new System.Drawing.Point(176, 79);
            this.btnvendmontos.Name = "btnvendmontos";
            this.btnvendmontos.Size = new System.Drawing.Size(133, 51);
            this.btnvendmontos.TabIndex = 44;
            this.btnvendmontos.Text = "Montos totales recaudados (Por Vendedor)";
            this.btnvendmontos.UseVisualStyleBackColor = true;
            this.btnvendmontos.Click += new System.EventHandler(this.btnvendmontos_Click);
            // 
            // grafico2
            // 
            chartArea2.Name = "ChartArea1";
            this.grafico2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.grafico2.Legends.Add(legend2);
            this.grafico2.Location = new System.Drawing.Point(416, 283);
            this.grafico2.Name = "grafico2";
            this.grafico2.Size = new System.Drawing.Size(339, 197);
            this.grafico2.TabIndex = 45;
            this.grafico2.Tag = "";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnvendventas);
            this.panel1.Controls.Add(this.btnvendmontos);
            this.panel1.Font = new System.Drawing.Font("Leelawadee UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(34, 130);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(324, 172);
            this.panel1.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Leelawadee UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 30);
            this.label1.TabIndex = 45;
            this.label1.Text = "Reportes de Vendedores";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnprodmontos);
            this.panel2.Controls.Add(this.btnGenerarGraficos);
            this.panel2.Font = new System.Drawing.Font("Leelawadee UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(34, 308);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(324, 172);
            this.panel2.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Leelawadee UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 30);
            this.label2.TabIndex = 46;
            this.label2.Text = "Reportes de Productos";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 31);
            this.panel3.TabIndex = 77;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.picCerrar);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(764, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(36, 31);
            this.panel4.TabIndex = 75;
            // 
            // picCerrar
            // 
            this.picCerrar.BackColor = System.Drawing.Color.LightGray;
            this.picCerrar.Image = global::CapaPresentacion.Properties.Resources.cruz_pequena;
            this.picCerrar.Location = new System.Drawing.Point(6, 5);
            this.picCerrar.Name = "picCerrar";
            this.picCerrar.Size = new System.Drawing.Size(23, 23);
            this.picCerrar.TabIndex = 75;
            this.picCerrar.TabStop = false;
            this.picCerrar.Click += new System.EventHandler(this.picCerrar_Click);
            // 
            // ReportesGraficos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grafico2);
            this.Controls.Add(this.Dfechafin2);
            this.Controls.Add(this.Dfechainicio2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.grafico1);
            this.Name = "ReportesGraficos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ReportesGraficos";
            ((System.ComponentModel.ISupportInitialize)(this.grafico1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grafico2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart grafico1;
        private System.Windows.Forms.DateTimePicker Dfechafin2;
        private System.Windows.Forms.DateTimePicker Dfechainicio2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnGenerarGraficos;
        private System.Windows.Forms.Button btnprodmontos;
        private System.Windows.Forms.Button btnvendventas;
        private System.Windows.Forms.Button btnvendmontos;
        private System.Windows.Forms.DataVisualization.Charting.Chart grafico2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox picCerrar;
    }
}
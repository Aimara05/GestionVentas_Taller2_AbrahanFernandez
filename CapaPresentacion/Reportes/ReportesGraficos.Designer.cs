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
            this.grafico1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Dfechafin2 = new System.Windows.Forms.DateTimePicker();
            this.Dfechainicio2 = new System.Windows.Forms.DateTimePicker();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnGenerarGraficos = new System.Windows.Forms.Button();
            this.btnprodmontos = new System.Windows.Forms.Button();
            this.btnvendventas = new System.Windows.Forms.Button();
            this.btnvendmontos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grafico1)).BeginInit();
            this.SuspendLayout();
            // 
            // grafico1
            // 
            chartArea1.Name = "ChartArea1";
            this.grafico1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.grafico1.Legends.Add(legend1);
            this.grafico1.Location = new System.Drawing.Point(387, 28);
            this.grafico1.Name = "grafico1";
            this.grafico1.Size = new System.Drawing.Size(357, 275);
            this.grafico1.TabIndex = 0;
            this.grafico1.Tag = "";
            // 
            // Dfechafin2
            // 
            this.Dfechafin2.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dfechafin2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dfechafin2.Location = new System.Drawing.Point(183, 49);
            this.Dfechafin2.Name = "Dfechafin2";
            this.Dfechafin2.Size = new System.Drawing.Size(119, 27);
            this.Dfechafin2.TabIndex = 39;
            // 
            // Dfechainicio2
            // 
            this.Dfechainicio2.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dfechainicio2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dfechainicio2.Location = new System.Drawing.Point(48, 48);
            this.Dfechainicio2.Name = "Dfechainicio2";
            this.Dfechainicio2.Size = new System.Drawing.Size(119, 27);
            this.Dfechainicio2.TabIndex = 38;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.LightGray;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(183, 28);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(73, 16);
            this.textBox3.TabIndex = 37;
            this.textBox3.Text = "Fecha Fin:";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.LightGray;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(48, 28);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(89, 16);
            this.textBox2.TabIndex = 36;
            this.textBox2.Text = "Fecha Inicio:";
            // 
            // btnGenerarGraficos
            // 
            this.btnGenerarGraficos.Location = new System.Drawing.Point(21, 107);
            this.btnGenerarGraficos.Name = "btnGenerarGraficos";
            this.btnGenerarGraficos.Size = new System.Drawing.Size(157, 54);
            this.btnGenerarGraficos.TabIndex = 41;
            this.btnGenerarGraficos.Text = "Productos mas vendidos";
            this.btnGenerarGraficos.UseVisualStyleBackColor = true;
            this.btnGenerarGraficos.Click += new System.EventHandler(this.btnGenerarGraficos_Click);
            // 
            // btnprodmontos
            // 
            this.btnprodmontos.Location = new System.Drawing.Point(21, 167);
            this.btnprodmontos.Name = "btnprodmontos";
            this.btnprodmontos.Size = new System.Drawing.Size(157, 61);
            this.btnprodmontos.TabIndex = 42;
            this.btnprodmontos.Text = "Montos Recaudados por productos";
            this.btnprodmontos.UseVisualStyleBackColor = true;
            this.btnprodmontos.Click += new System.EventHandler(this.btnprodmontos_Click);
            // 
            // btnvendventas
            // 
            this.btnvendventas.Location = new System.Drawing.Point(184, 107);
            this.btnvendventas.Name = "btnvendventas";
            this.btnvendventas.Size = new System.Drawing.Size(147, 54);
            this.btnvendventas.TabIndex = 43;
            this.btnvendventas.Text = "Cantidad de ventas (Por Vendedor)";
            this.btnvendventas.UseVisualStyleBackColor = true;
            this.btnvendventas.Click += new System.EventHandler(this.btnvendventas_Click);
            // 
            // btnvendmontos
            // 
            this.btnvendmontos.Location = new System.Drawing.Point(184, 167);
            this.btnvendmontos.Name = "btnvendmontos";
            this.btnvendmontos.Size = new System.Drawing.Size(147, 61);
            this.btnvendmontos.TabIndex = 44;
            this.btnvendmontos.Text = "Montos totales recaudados (Por Vendedor)";
            this.btnvendmontos.UseVisualStyleBackColor = true;
            this.btnvendmontos.Click += new System.EventHandler(this.btnvendmontos_Click);
            // 
            // ReportesGraficos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnvendmontos);
            this.Controls.Add(this.btnvendventas);
            this.Controls.Add(this.btnprodmontos);
            this.Controls.Add(this.btnGenerarGraficos);
            this.Controls.Add(this.Dfechafin2);
            this.Controls.Add(this.Dfechainicio2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.grafico1);
            this.Name = "ReportesGraficos";
            this.Text = "ReportesGraficos";
            ((System.ComponentModel.ISupportInitialize)(this.grafico1)).EndInit();
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
    }
}
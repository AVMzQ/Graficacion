namespace Grafic
{
    partial class GraficTrigono
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
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.cmbFuncion = new System.Windows.Forms.ComboBox();
            this.btnInicio = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnReg = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFuncion = new System.Windows.Forms.TextBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.btnGraficar = new System.Windows.Forms.Button();
            this.Plano = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Plano)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnAyuda);
            this.panel1.Controls.Add(this.cmbFuncion);
            this.panel1.Controls.Add(this.btnInicio);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnReg);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtFuncion);
            this.panel1.Controls.Add(this.cmbTipo);
            this.panel1.Controls.Add(this.btnGraficar);
            this.panel1.Controls.Add(this.Plano);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(579, 426);
            this.panel1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 78);
            this.label3.TabIndex = 15;
            this.label3.Text = "Las potencias se marcaran\r\nsin este simbolo ^ y al terminar\r\nuse un espacio\r\n\r\nej" +
    "emplo: 2x2 +2\r\nLo sentimos";
            // 
            // btnAyuda
            // 
            this.btnAyuda.Location = new System.Drawing.Point(0, 367);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(195, 23);
            this.btnAyuda.TabIndex = 14;
            this.btnAyuda.Text = "Ayuda";
            this.btnAyuda.UseVisualStyleBackColor = true;
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
            // 
            // cmbFuncion
            // 
            this.cmbFuncion.FormattingEnabled = true;
            this.cmbFuncion.Items.AddRange(new object[] {
            "Algebraica",
            "Trigonométricas",
            "Ecuaciones cónicas"});
            this.cmbFuncion.Location = new System.Drawing.Point(2, 311);
            this.cmbFuncion.Name = "cmbFuncion";
            this.cmbFuncion.Size = new System.Drawing.Size(195, 21);
            this.cmbFuncion.TabIndex = 10;
            // 
            // btnInicio
            // 
            this.btnInicio.Location = new System.Drawing.Point(0, 338);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(197, 23);
            this.btnInicio.TabIndex = 8;
            this.btnInicio.Text = "ir";
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Quires graficar otra cosa?";
            // 
            // btnReg
            // 
            this.btnReg.Location = new System.Drawing.Point(2, 396);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(193, 23);
            this.btnReg.TabIndex = 7;
            this.btnReg.Text = "Regresar";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Que tipos es?";
            // 
            // txtFuncion
            // 
            this.txtFuncion.Location = new System.Drawing.Point(2, 152);
            this.txtFuncion.Name = "txtFuncion";
            this.txtFuncion.Size = new System.Drawing.Size(192, 20);
            this.txtFuncion.TabIndex = 4;
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "Cos",
            "Sin",
            "Tan"});
            this.cmbTipo.Location = new System.Drawing.Point(2, 125);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(195, 21);
            this.cmbTipo.TabIndex = 3;
            // 
            // btnGraficar
            // 
            this.btnGraficar.Location = new System.Drawing.Point(2, 189);
            this.btnGraficar.Name = "btnGraficar";
            this.btnGraficar.Size = new System.Drawing.Size(192, 26);
            this.btnGraficar.TabIndex = 2;
            this.btnGraficar.Text = "Graficar";
            this.btnGraficar.UseVisualStyleBackColor = true;
            this.btnGraficar.Click += new System.EventHandler(this.btnGraficar_Click);
            // 
            // Plano
            // 
            chartArea1.Name = "ChartArea1";
            this.Plano.ChartAreas.Add(chartArea1);
            this.Plano.Dock = System.Windows.Forms.DockStyle.Right;
            legend1.Name = "Legend1";
            this.Plano.Legends.Add(legend1);
            this.Plano.Location = new System.Drawing.Point(204, 0);
            this.Plano.Name = "Plano";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.Legend = "Legend1";
            series1.Name = "p";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "l";
            this.Plano.Series.Add(series1);
            this.Plano.Series.Add(series2);
            this.Plano.Size = new System.Drawing.Size(375, 426);
            this.Plano.TabIndex = 1;
            this.Plano.Text = "plano";
            // 
            // GraficTrigono
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 426);
            this.Controls.Add(this.panel1);
            this.Name = "GraficTrigono";
            this.Text = "GraficTrigono";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Plano)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFuncion;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Button btnGraficar;
        private System.Windows.Forms.DataVisualization.Charting.Chart Plano;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.ComboBox cmbFuncion;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.Label label3;

    }
}
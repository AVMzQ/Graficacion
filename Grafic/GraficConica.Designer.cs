namespace Grafic
{
    partial class GraficConica
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.cmbFuncion = new System.Windows.Forms.ComboBox();
            this.btnInicio = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Plano = new System.Windows.Forms.PictureBox();
            this.btnReg = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFuncion = new System.Windows.Forms.TextBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.btnGraficar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Plano)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.btnAyuda);
            this.panel1.Controls.Add(this.cmbFuncion);
            this.panel1.Controls.Add(this.btnInicio);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Plano);
            this.panel1.Controls.Add(this.btnReg);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtFuncion);
            this.panel1.Controls.Add(this.cmbTipo);
            this.panel1.Controls.Add(this.btnGraficar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(660, 418);
            this.panel1.TabIndex = 2;
            // 
            // btnAyuda
            // 
            this.btnAyuda.Location = new System.Drawing.Point(0, 364);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(198, 23);
            this.btnAyuda.TabIndex = 13;
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
            this.cmbFuncion.Location = new System.Drawing.Point(0, 308);
            this.cmbFuncion.Name = "cmbFuncion";
            this.cmbFuncion.Size = new System.Drawing.Size(195, 21);
            this.cmbFuncion.TabIndex = 12;
            // 
            // btnInicio
            // 
            this.btnInicio.Location = new System.Drawing.Point(0, 335);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(197, 23);
            this.btnInicio.TabIndex = 10;
            this.btnInicio.Text = "ir";
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Quires graficar otra cosa?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 52);
            this.label2.TabIndex = 9;
            this.label2.Text = "Al terminar el \r\ncontenido del parentesis\r\nsepara el exponente de el\r\nEjemplo: (x" +
    "-2) 2+(y-3) 2=4  ";
            // 
            // Plano
            // 
            this.Plano.BackColor = System.Drawing.Color.White;
            this.Plano.Location = new System.Drawing.Point(201, 3);
            this.Plano.Name = "Plano";
            this.Plano.Size = new System.Drawing.Size(457, 413);
            this.Plano.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Plano.TabIndex = 8;
            this.Plano.TabStop = false;
            this.Plano.Paint += new System.Windows.Forms.PaintEventHandler(this.Plano_Paint);
            // 
            // btnReg
            // 
            this.btnReg.Location = new System.Drawing.Point(0, 393);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(197, 23);
            this.btnReg.TabIndex = 7;
            this.btnReg.Text = "Regresar";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Que tipos es?";
            // 
            // txtFuncion
            // 
            this.txtFuncion.Location = new System.Drawing.Point(3, 117);
            this.txtFuncion.Name = "txtFuncion";
            this.txtFuncion.Size = new System.Drawing.Size(195, 20);
            this.txtFuncion.TabIndex = 4;
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "Circunferencia",
            "Elipse",
            "Hiperbola"});
            this.cmbTipo.Location = new System.Drawing.Point(3, 90);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(195, 21);
            this.cmbTipo.TabIndex = 3;
            // 
            // btnGraficar
            // 
            this.btnGraficar.Location = new System.Drawing.Point(3, 143);
            this.btnGraficar.Name = "btnGraficar";
            this.btnGraficar.Size = new System.Drawing.Size(195, 26);
            this.btnGraficar.TabIndex = 2;
            this.btnGraficar.Text = "Graficar";
            this.btnGraficar.UseVisualStyleBackColor = true;
            this.btnGraficar.Click += new System.EventHandler(this.btnGraficar_Click);
            // 
            // GraficConica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 418);
            this.Controls.Add(this.panel1);
            this.Name = "GraficConica";
            this.Text = "GraficConica";
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
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.PictureBox Plano;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbFuncion;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAyuda;
    }
}
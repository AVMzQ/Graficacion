using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grafic
{
    public partial class GraficTrigono : Form
    {
        public GraficTrigono()
        {
            InitializeComponent();
        }

        private void btnGraficar_Click(object sender, EventArgs e)
        {
            //Falta agrregar detalles esteticos.
            Plano.Series["p"].Points.Clear();
            Plano.Series["l"].Points.Clear();

            int count = 0;
            string fun = txtFuncion.Text;

            string[] SeparacionX = fun.Split('x',' ','c','o','s','i','n','t','a','n');
            string[] SX = fun.Split('1', '2', '3', '4', '5', '6', '7', '8', '9','0', '+', '-', ' ', 'c', 'o', 's', 's', 'i', 'n', 't', 'a', 'n');

            for (int i = 0; i < SX.Length; i++)
            {
                if (SX[i] == "x")
                {
                    count++;
                }
            }

            if (cmbTipo.SelectedItem=="Cos")
            {
                if (count==1)
                {
                    //poner como defal la contante a como 1
                    //poner un condicion de los separadores de dos
                    //si es igual a 1 o dos para hacer la debida operacion
                   //cosx
                    double a, b,c;
                    

                    if (SeparacionX[0]=="")
                    {
                        a = 1;
                    }
                    else
                    a = Convert.ToDouble(SeparacionX[0]);
                    if (SeparacionX[1] == "")
                    {
                        b = 1;
                    }
                    else
                        b = Convert.ToDouble(SeparacionX[1]);
                    if (SeparacionX[2] == "")
                    {
                        c = 1;
                    }
                    else
                        c = Convert.ToDouble(SeparacionX[2]);
                    

                    for (int i = 0; i <= 360; i++)
                    {
                        double r = i * (Math.PI / 180);
                        double y = a * Math.Cos(b * Math.Pow(r,c));
                        Plano.Series["p"].Points.AddXY(i, y);
                        double y2 = a * Math.Cos(b * Math.Pow(r, c));
                        Plano.Series["l"].Points.AddXY(i, y2);
                        i = i + 29;
                    }
                }
                else
                    MessageBox.Show("son demasiadas x, no?");
            }
            if (cmbTipo.SelectedItem == "Sin")
            {
                if (count == 1)
                {
                    //poner como defal la contante a como 1
                    //poner un condicion de los separadores de dos
                    //si es igual a 1 o dos para hacer la debida operacion
                    //cosx
                    double a, b, c;
                    
                    if (SeparacionX[0] == "")
                    {
                        a = 1;
                    }
                    else
                        a = Convert.ToDouble(SeparacionX[0]);
                    if (SeparacionX[1] == "")
                    {
                        b = 1;
                    }
                    else
                        b = Convert.ToDouble(SeparacionX[1]);
                    if (SeparacionX[2] == "")
                    {
                        c = 1;
                    }
                    else
                        c = Convert.ToDouble(SeparacionX[2]);


                    for (int i = 0; i <= 360; i++)
                    {
                        double r = i * (Math.PI / 180);
                        double y = a * Math.Sin(b * Math.Pow(r, c));
                        Plano.Series["p"].Points.AddXY(i, y);
                        double y2 = a * Math.Sin(b * Math.Pow(r, c));
                        Plano.Series["l"].Points.AddXY(i, y2);
                        i = i + 29;
                    }
                }
                else
                    MessageBox.Show("son demasiadas x, no?");
            }
            if (cmbTipo.SelectedItem == "Tan")
            {
                if (count == 1)
                {
                    //poner como defal la contante a como 1
                    //poner un condicion de los separadores de dos
                    //si es igual a 1 o dos para hacer la debida operacion
                    //cosx
                    double a, b, c;
                    
                    if (SeparacionX[0] == "")
                    {
                        a = 1;
                    }
                    else
                        a = Convert.ToDouble(SeparacionX[0]);
                    if (SeparacionX[1] == "")
                    {
                        b = 1;
                    }
                    else
                        b = Convert.ToDouble(SeparacionX[1]);
                    if (SeparacionX[2] == "")
                    {
                        c = 1;
                    }
                    else
                        c = Convert.ToDouble(SeparacionX[2]);


                    for (int i = 0; i <= 270; i++)
                    {
                        double y, y2;
                        if (i == 120 || i == 150 || i == 210 || i == 240)
                        {
                            double radians = i * (Math.PI / 180);

                            //double r = i * (Math.PI / 180);
                            //double y = a * Math.Sin(b * Math.Pow(r, c));
                            //Plano.Series["p"].Points.AddXY(i, y);
                            //double y2 = a * Math.Sin(b * Math.Pow(r, c));
                            //Plano.Series["l"].Points.AddXY(i, y2);
                            //i = i + 29;

                            y = a * Math.Tan(b * Math.Pow(radians, c));
                            Plano.Series["p"].Points.AddXY(i, y);
                            y2 = a * Math.Tan(b * Math.Pow(radians, c));
                            Plano.Series["l"].Points.AddXY(i, y);
                            i = i + 29;
                        }

                    }
                }
                else
                    MessageBox.Show("son demasiadas x, no?");

        }
            
           
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show(); this.Close();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            if (cmbFuncion.SelectedItem == "Algebraica")
            {
                GraficAlgebraica g = new GraficAlgebraica();
                g.Show();
                this.Hide();

            }
            if (cmbFuncion.SelectedItem == "Trigonométricas")
            {
                GraficTrigono gt = new GraficTrigono();
                gt.Show();
                this.Hide();
            }
            if (cmbFuncion.SelectedItem == "Ecuaciones cónicas")
            {
                GraficConica gc = new GraficConica();
                gc.Show();
                this.Hide();
            }
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            Ayuda a = new Ayuda();
            a.Show();
        }
    }
}

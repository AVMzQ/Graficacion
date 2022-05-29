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
    using info.lundin.math;
    public partial class GraficAlgebraica : Form
    {

        public GraficAlgebraica()
        {
            InitializeComponent();
        }

        private void btnGraficar_Click(object sender, EventArgs e)
        {
            //LIneal
            //Parabola
            //Cubica

            if (cmbTipo.SelectedItem == "LIneal")
            {
                int count = 0;
                //poner otro if con condicion de lineal de dos constantes
                string fun = txtFuncion.Text;

                string[] SeparacionX = fun.Split('x');
                string[] SX = fun.Split('1', '2', '3', '4', '5', '6', '7', '8', '9', '+', '-', ' ','0');

                for (int i = 0; i < SX.Length; i++)
                {
                    if (SX[i] == "x")
                    {
                        count++;
                    }
                }
                if (count == 1)
                {
                    for (int x = 0; x < 1; x++)
                    {
                        if (fun.Length == 2 || fun.Length == 3 || fun.Length == 4 && SeparacionX.Length == 2 && count == 1)
                        {
                            Plano.Series["p"].Points.Clear();
                            Plano.Series["L"].Points.Clear();
                            //solo dos constantes y una x 2x+3
                            double a, b;
                            a = Convert.ToDouble(SeparacionX[0]);

                            for (int i = -3; i <= 3; i++)
                            {
                                double y = a * i;
                                Plano.Series["p"].Points.AddXY(i, y);
                                double y2 = a * i;
                                Plano.Series["L"].Points.AddXY(i, y2);
                            }
                            break;
                        }
                        else if (fun.Length == 4 || fun.Length == 6 || fun.Length == 5 || fun.Length == 7 && SeparacionX.Length == 2 && count == 1)
                        {
                            Plano.Series["p"].Points.Clear();
                            Plano.Series["L"].Points.Clear();
                            //solo dos constantes y una x 2x+3
                            double a, b;
                            a = Convert.ToDouble(SeparacionX[0]);
                            if (SeparacionX[1] == " ")
                            {
                                b = 0;
                            }
                            else
                                b = Convert.ToDouble(SeparacionX[1]);
                            for (int i = -3; i <= 3; i++)
                            {
                                double y = a * i + b;
                                Plano.Series["p"].Points.AddXY(i, y);
                                double y2 = a * i + b;
                                Plano.Series["L"].Points.AddXY(i, y2);
                            }
                            break;
                        }
                    }
                }
                if (count == 2)
                {

                    Plano.Series["p"].Points.Clear();
                    Plano.Series["L"].Points.Clear();

                    for (int x = 0; x < 1; x++)
                    {
                        if (fun.Length == 5 || fun.Length == 6 || fun.Length == 7 || fun.Length == 8 && SeparacionX.Length == 3 && count == 2)
                    {
                        //solo dos constantes y una x 2x+3x
                        double a, b;
                        a = Convert.ToDouble(SeparacionX[0]);
                        b = Convert.ToDouble(SeparacionX[1]);
                        for (int i = -3; i <= 3; i++)
                        {
                            double y = (a * i) + (b * i);
                            Plano.Series["p"].Points.AddXY(i, y);
                            double y2 = a * i + (b * i);
                            Plano.Series["L"].Points.AddXY(i, y2);
                        }
                        break;
                    }
                    if (fun.Length == 7 || fun.Length == 8|| fun.Length == 9
                        || fun.Length == 10 || fun.Length == 11 && SeparacionX.Length == 3 && count == 2)
                    {
                        //solo dos constantes y una x 2x+3x+1
                        double a, b,c;
                        a = Convert.ToDouble(SeparacionX[0]);
                        b = Convert.ToDouble(SeparacionX[1]);
                        c = Convert.ToDouble(SeparacionX[2]);
                        for (int i = -3; i <= 3; i++)
                        {
                            double y = (a * i) + (b * i)+c;
                            Plano.Series["p"].Points.AddXY(i, y);
                            double y2 = a * i + (b * i)+c;
                            Plano.Series["L"].Points.AddXY(i, y2);
                        }
                    }
                    }
                }
                else if (count > 3)
                    MessageBox.Show("Son demasiadas x, no?");

            }
            if (cmbTipo.SelectedItem == "Parabola")
            {
                
                Plano.Series["p"].Points.Clear();
                Plano.Series["L"].Points.Clear();

                int count = 0;
                //poner otro if con condicion de lineal de dos constantes
                string fun = txtFuncion.Text;

                string[] SeparacionX = fun.Split('x',' ');
                string[] SX = fun.Split('1','2','3','4','5','6','7','8','9','0', '+', '-',' ');

               
                for (int i = 0; i < SX.Length; i++)
                {
                    if (SX[i]=="x")
                    {
                        count++;
                    }
                }

                
                //2x2 +2
                if (count==1)
                {
                    for (int x = 0; x < 1; x++)
                    {
                        //agregar un if y que diga que entre aqui si son mas de 3 en separacion, que pase por ahi

                        //parabola 1 parte 2
                        if (fun.Length == 3 || fun.Length == 4 || fun.Length == 5 && SeparacionX.Length == 2 && count == 1)
                        {
                            double a, expo;
                            a = Convert.ToDouble(SeparacionX[0]);
                            expo = Convert.ToDouble(SeparacionX[1]);
                            for (int i = -3; i <= 3; i++)
                            {
                                double y = a * Math.Pow(i, expo);
                                Plano.Series["p"].Points.AddXY(i, y);
                                double y2 = a * Math.Pow(i, expo);
                                Plano.Series["L"].Points.AddXY(i, y);
                            }
                            break;
                        }
                        if (fun.Length == 6 || fun.Length == 7 || fun.Length == 6 || fun.Length == 9 && SeparacionX.Length == 2 && count == 1)
                        {
                            double a, expo, c;
                            a = Convert.ToDouble(SeparacionX[0]);
                            expo = Convert.ToDouble(SeparacionX[1]);
                            c = Convert.ToDouble(SeparacionX[2]);
                            for (int i = -3; i <= 3; i++)
                            {
                                double y = a * Math.Pow(i, expo) + c;
                                Plano.Series["p"].Points.AddXY(i, y);
                                double y2 = a * Math.Pow(i, expo) + c;
                                Plano.Series["L"].Points.AddXY(i, y);

                            }
                            break;
                        }

                    }
                    
                }
                if (count==2)
                {
                    for (int x = 0; x < 1; x++)
                    {
                        //parabola 2
                        //parte 1********************************************************************************************
                        if (fun.Length == 7 || fun.Length == 8
                            || fun.Length == 9 || fun.Length == 10 && SeparacionX.Length == 4 && count == 2)
                        {
                            //2x^2+2x
                            double a, expo, b;
                            a = Convert.ToDouble(SeparacionX[0]);
                            expo = Convert.ToDouble(SeparacionX[1]);
                            b = Convert.ToDouble(SeparacionX[2]);
                            for (int i = -3; i <= 3; i++)
                            {
                                double y = a * Math.Pow(i, expo) + (b *i);
                                Plano.Series["p"].Points.AddXY(i, y);
                                double y2 = a * Math.Pow(i, expo) + (b * i);
                                Plano.Series["L"].Points.AddXY(i, y);

                            }
                            break;
                        }
                        //parte 2********************************************************************************************

                        if (fun.Length == 8 || fun.Length == 9 || fun.Length == 10 ||
                        fun.Length == 11 && SeparacionX.Length == 4 && count == 2)
                        {
                            MessageBox.Show("");
                            double a, expo, b, expo2;
                            a = Convert.ToDouble(SeparacionX[0]);
                            expo = Convert.ToDouble(SeparacionX[1]);
                            b = Convert.ToDouble(SeparacionX[2]);
                            expo2 = Convert.ToDouble(SeparacionX[3]);
                            for (int i = 3; i < 5; i++)
                            {
                                double y = a * Math.Pow(i, expo) + (b * Math.Pow(i, expo2));
                                Plano.Series["p"].Points.AddXY(i, y);
                                double y2 = a * Math.Pow(i, expo) + (b * Math.Pow(i, expo2));
                                Plano.Series["L"].Points.AddXY(i, y);

                            }
                            break;
                        }
                        //parte tres*****************************************************************************************
                        if (fun.Length == 9 || fun.Length == 10 ||
                            fun.Length == 11 || fun.Length == 12 || fun.Length == 13 | fun.Length == 14
                            && SeparacionX.Length == 4 && count == 2)
                        {
                            double a, expo, b, expo2, c;
                            a = Convert.ToDouble(SeparacionX[0]);
                            expo = Convert.ToDouble(SeparacionX[1]);
                            b = Convert.ToDouble(SeparacionX[2]);
                            expo2 = Convert.ToDouble(SeparacionX[3]);
                            c = Convert.ToDouble(SeparacionX[4]);

                            for (int i = -3; i < 4; i++)
                            {
                                double y = a * Math.Pow(i, expo) + (b * i) + c;
                                Plano.Series["p"].Points.AddXY(i, y);
                                double y2 = a * Math.Pow(i, expo) + (b * i) + c;
                                Plano.Series["L"].Points.AddXY(i, y);
                            }
                            break;
                        }
                        //parte 4******************************************************************************************
                        if (fun.Length == 11 || fun.Length == 12 || fun.Length == 13 || fun.Length == 14
                                || fun.Length == 15 && SeparacionX.Length == 5 && count == 2)
                        {
                            double a, expo, b, expo2, c;
                            a = Convert.ToDouble(SeparacionX[0]);
                            expo = Convert.ToDouble(SeparacionX[1]);
                            b = Convert.ToDouble(SeparacionX[2]);
                            expo2 = Convert.ToDouble(SeparacionX[3]);
                            c = Convert.ToDouble(SeparacionX[4]);
                            for (int i = -3; i <= 3; i++)
                            {
                                double y = a * Math.Pow(i, expo) + (b * Math.Pow(i, expo2)) + c;
                                Plano.Series["p"].Points.AddXY(i, y);
                                double y2 = a * Math.Pow(i, expo) + (b * Math.Pow(i, expo2)) + c;
                                Plano.Series["L"].Points.AddXY(i, y);
                            }
                            break;
                        }
                    }          
                }
               else if (count > 2)
                    MessageBox.Show("son demacias x, no?");
                
            }

            if (cmbTipo.SelectedItem == "Cubica")
            {
                //lo mismo que la parabola
                //poner dos if con SeparacionX 1 y 2

                Plano.Series["p"].Points.Clear();
                Plano.Series["L"].Points.Clear();

                int count = 0;
                string fun = txtFuncion.Text;

                string[] SeparacionX = fun.Split('x', ' ');
                string[] SX = fun.Split('1', '2', '3', '4', '5', '6', '7', '8', '9', '+', '-', ' ');

                for (int i = 0; i < SX.Length; i++)
                {
                    if (SX[i] == "x")
                    {
                        count++;
                    }
                }
//*********************************************************************************************************************
                for (int x = 0; x < 1; x++)
                {
                    if (count == 1)
                    {
                        //cubica
                        //parte 1****************************************************************************************
                        if (fun.Length == 3 || fun.Length == 4
                            || fun.Length == 5 || fun.Length == 10 && SeparacionX.Length == 2 && count == 1)
                        {
                            double a, expo, c;
                            a = Convert.ToDouble(SeparacionX[0]);
                            expo = Convert.ToDouble(SeparacionX[1]);

                            for (int i = -3; i <= 3; i++)
                            {
                                double y = a * Math.Pow(i, expo);
                                Plano.Series["p"].Points.AddXY(i, y);
                                double y2 = a * Math.Pow(i, expo);
                                Plano.Series["L"].Points.AddXY(i, y);

                            }
                            break;
                        }
                        //parte 2******************************************************************************************
                        if (fun.Length == 6 || fun.Length == 7
                            || fun.Length == 8 || fun.Length == 9 && SeparacionX.Length == 2 && count == 1)
                        {
                            double a, expo, b;
                            a = Convert.ToDouble(SeparacionX[0]);
                            expo = Convert.ToDouble(SeparacionX[1]);
                            b = Convert.ToDouble(SeparacionX[2]);

                            for (int i = -3; i <= 3; i++)
                            {
                                double y = a * Math.Pow(i, expo) + b;
                                Plano.Series["p"].Points.AddXY(i, y);
                                double y2 = a * Math.Pow(i, expo) + b;
                                Plano.Series["L"].Points.AddXY(i, y);

                            }
                            break;
                        }
                    }
                        //contador =2**************************************************************************************
                    else if (count == 2)
                    {
                        for (int j = 0; j < 1; j++)
                        {
                            //parte 1**************************************************************************************
                            if (fun.Length==7||fun.Length==8||fun.Length==9||fun.Length==10 
                                && SeparacionX.Length==4 && count==2)
                            {
                                double a, expo, b,expo2;
                                a = Convert.ToDouble(SeparacionX[0]);
                                expo = Convert.ToDouble(SeparacionX[1]);
                                b = Convert.ToDouble(SeparacionX[2]);
                                expo2 = Convert.ToDouble(SeparacionX[3]);
                                for (int i = -3; i <= 3; i++)
                                {
                                    double y = a * Math.Pow(i, expo) + b*Math.Pow(i,expo2);
                                    Plano.Series["p"].Points.AddXY(i, y);
                                    double y2 = a * Math.Pow(i, expo) + b*Math.Pow(i,expo2);
                                    Plano.Series["L"].Points.AddXY(i, y);

                                }
                                break;
                            }
                            //parte 2****************************************************************************************
                            if (fun.Length == 8 || fun.Length == 9 || fun.Length == 10 || fun.Length == 11 
                                && SeparacionX.Length==4 && count==2)
                            {
                                double a, expo, b, expo2;
                                a = Convert.ToDouble(SeparacionX[0]);
                                expo = Convert.ToDouble(SeparacionX[1]);
                                b = Convert.ToDouble(SeparacionX[2]);
                                expo2 = Convert.ToDouble(SeparacionX[3]);
                                for (int i = -3; i <= 3; i++)
                                {
                                    double y = a * Math.Pow(i, expo) + b * Math.Pow(i, expo2);
                                    Plano.Series["p"].Points.AddXY(i, y);
                                    double y2 = a * Math.Pow(i, expo) + b * Math.Pow(i, expo2);
                                    Plano.Series["L"].Points.AddXY(i, y);

                                }
                                break;
                            }
                            //parte 3*****************************************************************************************
                            if (fun.Length == 9 || fun.Length == 10 || fun.Length == 11 || fun.Length == 12
                                || fun.Length == 13 || fun.Length == 14
                                && SeparacionX.Length == 4 && count == 2)
                            {
                                double a, expo, b, expo2,c;
                                a = Convert.ToDouble(SeparacionX[0]);
                                expo = Convert.ToDouble(SeparacionX[1]);
                                b = Convert.ToDouble(SeparacionX[2]);
                                expo2 = Convert.ToDouble(SeparacionX[3]);
                                c = Convert.ToDouble(SeparacionX[4]);
                                for (int i = -3; i <= 3; i++)
                                {
                                    double y = a * Math.Pow(i, expo) + (b * Math.Pow(i, expo2)) + c;
                                    Plano.Series["p"].Points.AddXY(i, y);
                                    double y2 = a * Math.Pow(i, expo) + (b * Math.Pow(i, expo2)) + c;
                                    Plano.Series["L"].Points.AddXY(i, y);
                                }
                                break;
                            }
                            //parte 4***************************************************************************************
                            if (fun.Length == 11 || fun.Length == 12 || fun.Length == 13 || fun.Length == 14
                                || fun.Length == 15 && SeparacionX.Length == 5 && count == 2)
                            {
                                double a, expo, b, expo2, c;
                                a = Convert.ToDouble(SeparacionX[0]);
                                expo = Convert.ToDouble(SeparacionX[1]);
                                b = Convert.ToDouble(SeparacionX[2]);
                                expo2 = Convert.ToDouble(SeparacionX[3]);
                                c = Convert.ToDouble(SeparacionX[4]);
                                for (int i = -3; i <= 3; i++)
                                {
                                    double y = a * Math.Pow(i, expo) + (b * Math.Pow(i, expo2)) + c;
                                    Plano.Series["p"].Points.AddXY(i, y);
                                    double y2 = a * Math.Pow(i, expo) + (b * Math.Pow(i, expo2)) + c;
                                    Plano.Series["L"].Points.AddXY(i, y);
                                }
                                break;
                            }
                        }
                        
                    }
                    else
                        MessageBox.Show("son demacias x, no?");
                }

            }
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Close();
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

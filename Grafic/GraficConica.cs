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
    public partial class GraficConica : Form
    {
        public GraficConica()
        {
            InitializeComponent();
        }

        private void btnGraficar_Click(object sender, EventArgs e)
        {
            int Height = 40;
            int Width = 30;
            Bitmap Plano0 = new Bitmap(Width, Height);
            Graphics plano = Graphics.FromImage(Plano0);
            plano = Plano.CreateGraphics();

            

            double Xc = Plano.Width / 2;
            double Yc = Plano.Height / 2;

            string fun = txtFuncion.Text;
            double count=0;
            string[] SeparacionX = fun.Split('x', ' ','(',')','y','=','/');
            string[] SX = fun.Split('1', '2', '3', '4', '5', '6', '7', '8', '9', '+', '-', ' ');

            for (int i = 0; i < SX.Length; i++)
            {
                if (SX[i] == "x")
                {
                    count++;
                }
            }

            double a, b, h, k, c,r ;

            
            if (cmbTipo.SelectedItem == "Circunferencia")
            {
                //Esta mal, se tiene que ver la graficacion.

                Plano.Refresh();
                
                h = Convert.ToDouble(SeparacionX[2]);
                k = Convert.ToDouble(SeparacionX[6]);
                r = Convert.ToDouble(SeparacionX[9]);
                
                

                h = -(h);
                k = -(k);

                h = h + Xc;
                k = k + Yc;
                double RAP = r + h, RAN = r + k;
                plano.FillEllipse(Brushes.Black, new Rectangle(Convert.ToInt32(h), Convert.ToInt32(k), 3, 3));
                Pen lapiz = new Pen(Color.Black, 1);
                plano.DrawArc(lapiz, new Rectangle(Convert.ToInt32(h / 2), Convert.ToInt32(k / 2), Convert.ToInt32(RAP), Convert.ToInt32(RAN)), 0, 360);
            }

            if (cmbTipo.SelectedItem == "Elipse")
            {
                Plano.Refresh();
                
                h = Convert.ToDouble(SeparacionX[3]);
                a = Convert.ToDouble(SeparacionX[6]);
                k = Convert.ToDouble(SeparacionX[10]);
                b = Convert.ToDouble(SeparacionX[12]);

                double nh = h + Xc;
                double nk = k + Yc;


                if (a > b)
                {
                    a = a * 5;
                    b = b * 5;
                    h = h * 5;
                    k = k * 5;

                    Pen lapiz = new Pen(Color.Blue, 2);
                    //puntos clave
                    //centro
                    plano.FillEllipse(Brushes.Black, new Rectangle(Convert.ToInt32(nh), Convert.ToInt32(nk), 2, 2));
                    //vetice +
                    plano.FillEllipse(Brushes.Black, new Rectangle(Convert.ToInt32(nh + a), Convert.ToInt32(nk), 2, 2));
                    //vertice -
                    plano.FillEllipse(Brushes.Black, new Rectangle(Convert.ToInt32(nh - a), Convert.ToInt32(nk), 2, 2));
                    // y+
                    plano.FillEllipse(Brushes.Black, new Rectangle(Convert.ToInt32(nh), Convert.ToInt32(nk + b), 2, 2));
                    //y-
                    plano.FillEllipse(Brushes.Black, new Rectangle(Convert.ToInt32(nh), Convert.ToInt32(nk - b), 2, 2));

                    //Dibujo
                    //Plano.DrawEllipse(lapiz, new Rectangle(Convert.ToInt32(nh/2), Convert.ToInt32(nk/2), Convert.ToInt32(nh + Math.Sqrt(a)), Convert.ToInt32(nk + Math.Sqrt(b))));

                    double Xap, Ybp, Xan, Ybn;
                    Xap = nh + a;
                    Ybp = nk + b;
                    Xan = nh - a;
                    Ybn = nk - b;

                    Point[] p = { new Point(Convert.ToInt32(Xap), Convert.ToInt32(nk)), new Point(Convert.ToInt32(nh), Convert.ToInt32(Ybp)),
                                    new Point(Convert.ToInt32(Xan), Convert.ToInt32(nk)),new Point(Convert.ToInt32(nh),Convert.ToInt32(Ybn)) };
                    plano.DrawClosedCurve(lapiz, p);
                }
                else if(a<b)
                {
                    //((x+4) 2/9)+((y-2)2/25)=1

                    a = Convert.ToDouble(SeparacionX[6]);
                    b = Convert.ToDouble(SeparacionX[12]);

                    a = a * 5;
                    b = b * 5;
                    h = h * 5;
                    k = k * 5;

                    Pen lapiz = new Pen(Color.Blue, 2);

                    double Xbp, Yap, Xbn, Yan;
                    Xbp = nh + b;
                    Xbn = nh - b;
                    Yap = nk + a;
                    Yan = nk - a;
                    double Lr = (2 * b) / a;
                    double lr2 = Lr / 2;

                    //puntos clave
                    //centro
                    plano.FillEllipse(Brushes.Black, new Rectangle(Convert.ToInt32(nh), Convert.ToInt32(nk), 4, 4));
                    //vertice x+
                    plano.FillEllipse(Brushes.Black, new Rectangle(Convert.ToInt32(Xbp), Convert.ToInt32(nk),4, 4));
                    //vertice x-
                    plano.FillEllipse(Brushes.Black, new Rectangle(Convert.ToInt32(Xbn), Convert.ToInt32(nk), 4, 4));
                    //vertice y+
                    plano.FillEllipse(Brushes.Black, new Rectangle(Convert.ToInt32(nh), Convert.ToInt32(Yap), 4, 4));
                    //y-
                    plano.FillEllipse(Brushes.Black, new Rectangle(Convert.ToInt32(nh), Convert.ToInt32(Yan), 4, 4));

                    //Dibujo
                    //Plano.DrawEllipse(lapiz, new Rectangle(Convert.ToInt32(nh/2), Convert.ToInt32(nk/2), Convert.ToInt32(nh + Math.Sqrt(a)), Convert.ToInt32(nk + Math.Sqrt(b))));

                   



                    Point[] p = { new Point(Convert.ToInt32(Xbp), Convert.ToInt32(nk)), new Point(Convert.ToInt32(nh), Convert.ToInt32(Yap)),
                                    new Point(Convert.ToInt32(Xbn), Convert.ToInt32(nk)),new Point(Convert.ToInt32(nh),Convert.ToInt32(Yan)) };
                    plano.DrawClosedCurve(lapiz, p);

                }
            }

            if (cmbTipo.SelectedItem == "Hiperbola")
            {
                Plano.Refresh();
                double nh, nk, nh1, a1, b1;

                h = Convert.ToDouble(SeparacionX[3]);
                a = Convert.ToDouble(SeparacionX[6]);
                k = Convert.ToDouble(SeparacionX[10]);
                b = Convert.ToDouble(SeparacionX[12]);
                a = a * 10;
                b = b * 10;
                h = h * 5;
                k = k * 5;
                a1 = Math.Sqrt(a);
                b1 = Math.Sqrt(b);

                //calculo de focos
                c = Math.Sqrt(a + b)*2;


                h = -(h);
                k = -(k);

                nh = h + Xc;
                nk = k + Yc;

                double Lr = (2 * b) / a1;
                double Lr2 = Lr / 2;

                //puntos
                //Coordenada centro
                plano.FillEllipse(Brushes.Black, new Rectangle(Convert.ToInt32(nh), Convert.ToInt32(nk), 2, 2));
                //vertices x+
                plano.FillEllipse(Brushes.Blue, new Rectangle(Convert.ToInt32(nh + a1), Convert.ToInt32(nk), 2, 2));
                // vertice x-
                plano.FillEllipse(Brushes.Blue, new Rectangle(Convert.ToInt32(nh - a1), Convert.ToInt32(nk), 2, 2));
                //vertices y+
                plano.FillEllipse(Brushes.Blue, new Rectangle(Convert.ToInt32(nh), Convert.ToInt32(nk + b1), 2, 2));
                //vertice y-
                plano.FillEllipse(Brushes.Blue, new Rectangle(Convert.ToInt32(nh), Convert.ToInt32(nk - b1), 2, 2));

                //inicio del cuadrado imaginario
                nh1 = nh + a1;
                double nh2 = nh - a1;
                //Lr
                //Plano.FillEllipse(Brushes.Blue, new Rectangle(Convert.ToInt32(nh1), Convert.ToInt32(nk + Lr), 2, 2));
                //Plano.FillEllipse(Brushes.Blue, new Rectangle(Convert.ToInt32(nh1), Convert.ToInt32(nk - Lr), 2, 2));

                //Plano.FillEllipse(Brushes.Blue, new Rectangle(Convert.ToInt32(nh2), Convert.ToInt32(nk + Lr), 2, 2));
                //Plano.FillEllipse(Brushes.Blue, new Rectangle(Convert.ToInt32(nh2), Convert.ToInt32(nk - Lr), 2, 2));

                double xP = nk + b1, xN = nk - b1, Yp = nk + b1, Yn = nk - b1;
                //trazo del cuadro
                Pen lapiz = new Pen(Color.Black, 1);
                plano.DrawLine(lapiz, Convert.ToInt32(nh1), Convert.ToInt32(xP), Convert.ToInt32(nh2), Convert.ToInt32(Yp));
                plano.DrawLine(lapiz, Convert.ToInt32(nh1), Convert.ToInt32(xN), Convert.ToInt32(nh2), Convert.ToInt32(Yn));
                plano.DrawLine(lapiz, Convert.ToInt32(nh2), Convert.ToInt32(Yp), Convert.ToInt32(nh2), Convert.ToInt32(Yn));
                plano.DrawLine(lapiz, Convert.ToInt32(nh1), Convert.ToInt32(xP), Convert.ToInt32(nh1), Convert.ToInt32(xN));

                //trazo de x
                Pen lapiz1 = new Pen(Color.Black, 3);
                plano.DrawLine(lapiz1, Convert.ToInt32(nh2), Convert.ToInt32(Yp), Convert.ToInt32(nh1), Convert.ToInt32(xN));
                plano.DrawLine(lapiz1, Convert.ToInt32(nh1), Convert.ToInt32(xP), Convert.ToInt32(nh2), Convert.ToInt32(Yn));

                //trazo de hiperbola
                double f = nh + c;
                double f2 = nh - c;
                Pen lapiz3 = new Pen(Color.BlueViolet, 2);
                Point[] p = { new Point(Convert.ToInt32(nh1), Convert.ToInt32(nk)), 
                                new Point(Convert.ToInt32(f), Convert.ToInt32(nk + Lr2)),new Point (Convert.ToInt32(nh1), Convert.ToInt32(nk)), 
                new Point(Convert.ToInt32(f), Convert.ToInt32(nk - Lr2)) };
                //Point[] p1 = { new Point(Convert.ToInt32(nh1), Convert.ToInt32(nk)), new Point(Convert.ToInt32(f), Convert.ToInt32(nk - Lr2)) };
                plano.DrawCurve(lapiz3, p);
                //Plano.DrawCurve(lapiz3, p1);
            }
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show(); this.Close();
        }

        private void Plano_Paint(object sender, PaintEventArgs e)
        {
            int xCentro = Plano.Width / 2;
            int yCentro = Plano.Height / 2;
            Pen lapiz = new Pen(Color.Black, 2);
            e.Graphics.TranslateTransform(xCentro, yCentro);
            e.Graphics.ScaleTransform(1, -1);//Con esto se convierte a coordenadas normales
            //dibujo de ejes x-y
            //x
            e.Graphics.DrawLine(lapiz, xCentro * -1, 0, xCentro * 2, 0);
            //y
            e.Graphics.DrawLine(lapiz, 0, yCentro, 0, yCentro * -1);
            
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

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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Algebraica
//Trigonométricas
//Ecuaciones cónicas
        private void btnInicio_Click(object sender, EventArgs e)
        {
            if (cmbFuncion.SelectedItem=="Algebraica")
            {
                GraficAlgebraica g = new GraficAlgebraica();
                g.Show();
                this.Hide();

            }
            if(cmbFuncion.SelectedItem=="Trigonométricas")
            {
                GraficTrigono gt=new GraficTrigono();
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
    }
}

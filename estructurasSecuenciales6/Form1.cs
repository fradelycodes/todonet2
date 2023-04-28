using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.MonthCalendar;

namespace estructurasSecuenciales6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double ladoa, ladob;
            double area, perimetro;

            //entrada de datos
            ladoa = Convert.ToDouble(txtladoa.Text);
            ladob = Convert.ToDouble(txtladob.Text);

            //evalacion
            if(ladoa == ladob)
            {
                pxcuadrado.Visible = true;
                pxrectangulo.Visible = false;
            }
            else
            {
                pxcuadrado.Visible = false;
                pxrectangulo.Visible = true;
            }

            //calculo

            area = ladoa * ladob;
            perimetro = 2 * (ladoa + ladob);
            //Salida de la Información
            txtarea.Text = Convert.ToString(area);

            txtperimetro.Text = Convert.ToString(perimetro);
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            txtladoa.Clear();
            txtladob.Clear();
            txtarea.Clear();
            txtperimetro.Clear();
            pxcuadrado.Visible = false;
            pxrectangulo.Visible = false;
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

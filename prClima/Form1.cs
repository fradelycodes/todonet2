using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prClima
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            byte temperatura;
            string  clima;
            temperatura = Convert.ToByte(txttemperatura.Text);

            if(temperatura < 10)
            {
                clima = "Frio";
            }else if(temperatura >= 10 && temperatura <= 20)
            {
                clima = "Nublado";
            }
            else if (temperatura > 20 && temperatura <= 30)
            {
                clima = "Calor";
            }
            else
            {
                clima = "Tropical";
            }
            txtclima.Text = clima;
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            txtclima.Clear();
            txttemperatura.Clear();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

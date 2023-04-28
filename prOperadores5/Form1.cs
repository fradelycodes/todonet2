using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prOperadores5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double num1, num2;
            double suma, resta, mult, div, potencia, raiz;

            //entreada de datos

            num1 = Convert.ToDouble(txtnumero1.Text);
            num2 = Convert.ToDouble(txtnumero2.Text);

            //operaciones aritmetica

            suma = num1 + num2;
            resta = num1 - num2;
            mult = num1 * num2;
            div = num1 / num2;
            potencia = Math.Pow(num1, num2);
            raiz = Math.Pow(num1, (1 / num2));

            //salida

            txtsuma.Text = Convert.ToString(suma);
            txtresta.Text = Convert.ToString(resta);
            txtmultiplicacion.Text = Convert.ToString(mult);
            txtdivision.Text = Convert.ToString(div);
            txtpotencia.Text = Convert.ToString(potencia);
            txtraiz.Text = Convert.ToString(raiz);

        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtnumero1.Clear();
            txtnumero2.Clear();
            txtsuma.Clear();
            txtresta.Clear();
            txtmultiplicacion.Clear();
            txtdivision.Clear();
            txtpotencia.Clear();
            txtraiz.Clear();
        }
    }
}

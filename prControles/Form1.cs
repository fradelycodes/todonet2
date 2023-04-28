using System.Security.Cryptography;
using static System.Net.Mime.MediaTypeNames;

namespace prControles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            //declaracion de variables
            double num1, num2;
            double suma, resta, mult, div, potencia, raiz;

            num1 = Convert.ToDouble(txtnumero1.Text);
            num2 = Convert.ToDouble(txtnumero2.Text);

            //proceso
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
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace estructurasMultiples8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            byte numero;
            string dia;

            numero = Convert.ToByte(txtnumero.Text);

            switch (numero)
            {
                case 2:
                    dia = "Martes";
                    break;
                case 3:
                    dia = "Miercoles";
                    break;
                case 4:
                    dia = "Jueves";
                    break;
                case 5:
                    dia = "Viernes";
                    break;
                case 6:
                    dia = "Sabado";
                    break;
                case 7:
                    dia = "Domingo";
                    break;
                default:
                    dia = "Ingrese un nuevo numero";
                    break;

            }
            //salida
            txtdia.Text = dia;
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            txtnumero.Clear();
            txtdia.Clear();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

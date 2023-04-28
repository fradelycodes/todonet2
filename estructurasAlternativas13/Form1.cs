namespace estructurasAlternativas13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            //delclaracion
            int numero;
            double suma, resta, mult, div;
            numero = Convert.ToInt32(txtnumero.Text);

            //proceso

            cbosuma.Items.Clear();
            cboresta.Items.Clear();
            cbomult.Items.Clear();
            cbodiv.Items.Clear();

            for (int i = 1; i <= 12; i++)
            {
                suma = numero + i;
                resta = numero - i;
                mult = numero * i;
                div = numero / i;

                //agregar los resultados
                cbosuma.Items.Add(numero + " + " + i + " = " + suma);
                cboresta.Items.Add(numero + " - " + i + " = " + resta);
                cbomult.Items.Add(numero + " * " + i + " = " + mult);
                cbodiv.Items.Add(numero + " / " + i + " = " + div);
            }
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            cbosuma.Items.Clear();
            cboresta.Items.Clear();
            cbomult.Items.Clear();
            cbodiv.Items.Clear();
            txtnumero.Clear();

         
        }
    }
}
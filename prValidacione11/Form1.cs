namespace prValidacione11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.ttmensaje.SetToolTip(this.txtnombres, "Ingrese su nombre");
            this.ttmensaje.SetToolTip(this.txtsalario, "Ingrese su salario");
            this.ttmensaje.SetToolTip(this.txtedad, "Ingrese su edad");
            this.ttmensaje.SetToolTip(this.txtdescripcion, "Ingrese su descripcion");

        }

        private void btnenviar_Click(object sender, EventArgs e)
        {
            if (is_validate())
            {
                erroricono.Clear();
                // Mostramos un mensaje si todo está correcto
                MessageBox.Show("Datos Agregados Correctamente", "Validaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private bool is_validate()
        {
            bool no_error = true;
            if (txtnombres.Text == string.Empty)
            {
                erroricono.SetError(txtnombres, "Ingrese Nombre");
                no_error = false;
            }
            else
            {
                //limpiar
                try
                {
                    int i = Convert.ToInt32(txtedad.Text);
                }
                catch
                {
                    erroricono.Clear(); // Limpiar todos los mensajes de error
                    erroricono.SetError(txtedad, "Ingrese una Edad Válida");
                    return false;
                }

                try
                {
                    double j = Convert.ToDouble(txtsalario.Text);
                }
                catch
                {
                    erroricono.Clear(); // Limpiar todos los mensajes de error
                    erroricono.SetError(txtsalario, "Ingrese un Salario Válido");
                    return false;
                }
            }
            return no_error;
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            txtnombres.Clear();
            txtedad.Clear();
            txtsalario.Clear();
            txtdescripcion.Clear();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
        }
    }
}
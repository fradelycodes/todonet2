namespace messageBox09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            // declarar variables
            string nombre;
            nombre = Microsoft.VisualBasic.Interaction.InputBox("Ingrese Nombre ", "Registro de Datos Personales", "Nombre", 100, 0);
            MessageBox.Show("Bienvenido Usuario: " + nombre, "Registro de Datos Personales", MessageBoxButtons.OK, MessageBoxIcon.Information)

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            DialogResult opcion;
            opcion = MessageBox.Show("Realmente desea Salir", "Salir del Programa", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
      if(opcion == DialogResult.Yes)
            {
                Close();
            }
                
                }
    }
}
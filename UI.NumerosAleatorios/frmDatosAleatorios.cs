namespace UI.NumerosAleatorios
{
    public partial class frmDatosAleatorios : Form
    {
        public frmDatosAleatorios()
        {
            InitializeComponent();
        }

        String[] nombresHombre = { "Carlos", "Teco", "Luis", "Victor", "Fernando" };
        String[] nombresMujer = { "Ana", "Selina", "Angelica", "Carmen", "Belem" };

        private Random random = new Random();

        private void GenerarDatosAleatorios_Click(object sender, EventArgs e)
        {
            Empleado empleado = GenerarEmpleadoAleatorio();
            MostrarEmpleado(empleado);
        }

        private Empleado GenerarEmpleadoAleatorio()
        {
            int valorSex = random.Next(2);
            int valorSeguro = random.Next(2);

            var empleado = new Empleado
            {
                Numero = random.Next(1, 1000),
                Grupo = (char)random.Next('A', 'Z' + 1),
                Sueldo = Math.Round(random.NextDouble() * 50000, 2),
                FechaDeNacimiento = DateTime.Now.AddDays(-random.Next(18 * 365, 65 * 365))
            };

            if (valorSex == 0)
            {
                empleado.Sexo1 = "Hombre";
                empleado.Nombre = nombresHombre[random.Next(nombresHombre.Length)];
            }

            else
            {
                empleado.Sexo1 = "Mujer";
                empleado.Nombre = nombresMujer[random.Next(nombresMujer.Length)];
            }


            if (valorSeguro == 0)
            {
                empleado.SeguroMedico1 = true;
            }
            else
            {
                empleado.SeguroMedico1 = false;
            }

            return empleado;
        }

        private void MostrarEmpleado(Empleado empleado)
        {
            txtNumero.Text = empleado.Numero.ToString();
            txtNombre.Text = empleado.Nombre.ToString();
            radioMasculino.Checked = empleado.Sexo1 == "Hombre";
            radioFemenino.Checked = empleado.Sexo1 == "Mujer";
            comboGrupo.Text = empleado.Grupo.ToString();
            txtSueldo.Text = empleado.Sueldo.ToString();
            checkSeguroM.Checked = empleado.SeguroMedico1;
            dateFechaNacimiento.Value = empleado.FechaDeNacimiento;

        }

        private void frmDatosAleatorios_Load(object sender, EventArgs e)
        {

        }
    }
}

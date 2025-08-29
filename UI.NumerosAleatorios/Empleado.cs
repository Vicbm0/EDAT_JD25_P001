namespace UI.NumerosAleatorios
{
    internal class Empleado
    {
        private int numero;
        private string nombre;
        private DateTime fechaDeNacimiento;
        private string Sexo;
        private char grupo;
        private double sueldo;
        private bool seguroMedico;

        public int Numero { get => numero; set => numero = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public DateTime FechaDeNacimiento { get => fechaDeNacimiento; set => fechaDeNacimiento = value; }
        public string Sexo1 { get => Sexo; set => Sexo = value; }
        public char Grupo { get => grupo; set => grupo = value; }
        public double Sueldo { get => sueldo; set => sueldo = value; }
        public bool SeguroMedico1 { get => seguroMedico; set => seguroMedico = value; }

        public override string ToString()
        {
            return $"Número: {Numero}, Nombre: {Nombre}, Fecha de Nacimiento: {FechaDeNacimiento.ToShortDateString()}, Sexo: {Sexo1}, Grupo: {Grupo}, Sueldo: {Sueldo:C}, Seguro Médico: {(SeguroMedico1 ? "Sí" : "No")}";
        }
    }
}

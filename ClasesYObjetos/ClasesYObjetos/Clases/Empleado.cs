using ClasesYObjetos.Interfaces;

namespace ClasesYObjetos.Clases
{
    public class Empleado : Persona
    {
        private string? _puesto;
        private decimal _salario;

        public Empleado(string? nombre, int edad, string? direccion, string? puesto, decimal salario) : base(nombre, edad, direccion)
        {
            _puesto = puesto;
            _salario = salario;
        }

        public void MostrarInfo()
        {
            base.MostrarInfo();
            Console.WriteLine($"""
                Puesto:         {_puesto}
                Salario:        {_salario}
             """);
        }
    }
}

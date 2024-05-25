using ClasesYObjetos.Interfaces;

namespace ClasesYObjetos.Clases
{
    public class Persona : IMostrarInformacion
    {
        private string? _nombre;
        private int _edad;
        private string? _direccion;

        public Persona(string? nombre, int edad, string? direccion)
        {
            _nombre = nombre;
            _edad = edad;
            _direccion = direccion;
        }

        public void MostrarInfo()
        {
            Console.WriteLine($"""
                Nombre:         {_nombre}
                Edad:           {_edad}
                Direccion:      {_direccion}
                Año nacimiento: {añoNacimiento()}
             """);
        }
        public int añoNacimiento()
        {
            int añoAcual = DateTime.Now.Year;
            int nacimiento = añoAcual - _edad;

            return nacimiento;
        }
    }
}

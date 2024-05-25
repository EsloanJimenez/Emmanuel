namespace ClasesYObjetos
{
    public interface MostrandoInformacion
    {
        void mostrarInfo();
    }
    public class Persona : MostrandoInformacion
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

        public void mostrarInfo()
        {
            Console.WriteLine($"""
                Nombre:     {_nombre}
                Edad:       {_edad}
                Direccion:  {_direccion}
                """);
        }
    }
}

namespace ClasesYObjetos.Clases
{
    public class CalcularEdad
    {
        private int _edad;

        public CalcularEdad(int edad)
        {
            _edad = edad;
        }

        public int añoNacimiento()
        {
            int añoAcual = DateTime.Now.Year;
            int nacimiento = añoAcual - _edad;

            return nacimiento;
        }
    }
}

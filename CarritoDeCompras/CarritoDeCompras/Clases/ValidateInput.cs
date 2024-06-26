using CarritoDeCompras.Enum;

namespace ListaEstudiantes.Class
{
    public static class ValidateInput
    {
        public static char GetValidateCharInput()
        {
            char input;
            while (!char.TryParse(Console.ReadLine(), out input))
                Console.Write("Entrada inválida. Por favor introduce un carácter válido: ");

            return input;
        }

        public static int GetValidateOption()
        {
            int op;
            while(!int.TryParse(Console.ReadLine(), out op) || !Enum.IsDefined(typeof(Option), op))
                Console.Write("Entrada inválida. Por favor ingresa una opción válida: ");
            return op;
        }
    }
}

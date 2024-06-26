namespace ListaEstudiantes.Class
{
    public static class Repeat
    {
        private static char Select { get; set; }
        public static int Repeating()
        {

            Console.Write("\n¿Quieres salir del programa? S/N: ");
            Select = ValidateInput.GetValidateCharInput();

            if (Select == 's')
                return 2;
            else
                return 6;
        }
    }
}

namespace ListaEstudiantes.Class
{
    public static class Repeat
    {
        private static char Select { get; set; }
        public static int Repeating()
        {

            Console.Write("\nDo you want to exit the program? Y/N: ");
            Select = char.Parse(Console.ReadLine().ToLower());

            if (Select == 'y')
                return 5;
            else
                return 6;
        }
    }
}

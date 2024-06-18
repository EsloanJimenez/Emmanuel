namespace ListaEstudiantes.Class
{
    public class Repeat
    {
        private char Select { get; set; }
        public int Op { get; set; }
        public int Repeating()
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

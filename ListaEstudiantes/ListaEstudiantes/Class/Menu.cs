namespace ListaEstudiantes.Class
{
    public class Menu
    {
        public void Option()
        {
            Console.WriteLine("Select to option");
            Console.WriteLine($"""
                1) Add student
                2) View student
                3) Update student
                4) Delete student
                5) To out
            """);
        }
    }
}

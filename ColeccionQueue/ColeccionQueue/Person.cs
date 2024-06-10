namespace ColeccionList
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public Person(int id, string fn, string ln, int age)
        {
            Id = id;
            FirstName = fn;
            LastName = ln;
            Age = age;
        }

        public void ViewInfo()
        {
            Console.WriteLine($"""
                ID:         {Id},
                Nombre:     {FirstName},
                Apellido:   {LastName},
                Edad:       {Age}
                """);
            Console.WriteLine();
        }
    }

}

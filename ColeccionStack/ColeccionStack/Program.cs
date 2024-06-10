using ColeccionList;

Stack<Person> personas = new Stack<Person>();

//PARA AGREGAR UN ELEMENTO
personas.Push(new Person(4, "Betsy", "Pimentel", 29));
personas.Push(new Person(1, "Enrique", "Pimentel", 30));
personas.Push(new Person(2, "Yhennifer", "Abreu", 29));
personas.Push(new Person(3, "Enyher", "Jimenez", 8));

foreach (Person p in personas)
{
    Console.WriteLine($"""
                ID:         {p.Id},
                Nombre:     {p.FirstName},
                Apellido:   {p.LastName},
                Edad:       {p.Age}
                """);
    Console.WriteLine();
}

//PARA ELIMINAR ELEMENTO
personas.Pop();

Console.WriteLine("Despues de aver eliminando un elemento");

foreach (Person p in personas)
{
    Console.WriteLine($"""
                ID:         {p.Id},
                Nombre:     {p.FirstName},
                Apellido:   {p.LastName},
                Edad:       {p.Age}
                """);
    Console.WriteLine();
}

//https://learn.microsoft.com/es-es/dotnet/api/system.collections.generic.stack-1?view=net-8.0
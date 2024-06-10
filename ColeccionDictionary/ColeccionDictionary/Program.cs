using ColeccionList;
using static System.Console;

Write("Cuantos usuarios desea ingresar: ");
int count = int.Parse(ReadLine());

Dictionary<int, Person> personas = new Dictionary<int, Person>();

string firstName;
string lastName;
int age;

for (int i = 1; i <= count; i++)
{
    Write("Digite su nombre: ");
    firstName = ReadLine();

    Write("Digite su apellido: ");
    lastName = ReadLine();

    Write("Digite su edad: ");
    age = int.Parse(ReadLine());

    personas.Add(i, new Person(i, firstName, lastName, age));
}

foreach (KeyValuePair<int, Person> per in personas)
{
    Console.WriteLine($"""
                ID:         {per.Key},
                Nombre:     {per.Value.FirstName},
                Apellido:   {per.Value.LastName},
                Edad:       {per.Value.Age}
                """);
    Console.WriteLine();
}


//https://learn.microsoft.com/es-es/dotnet/api/system.collections.generic.dictionary-2?view=net-8.0
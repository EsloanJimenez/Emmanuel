using BucleForEach;
using static System.Console;

Write("Cuantas personas va agregar: ");
int amount = int.Parse(ReadLine());

string id, firstName, lastName, address;
int age;


List<Person> people = new List<Person>();
YearOfBirth yearOfBirth = new YearOfBirth();




for (int i = 0; i < amount; i++)
{
    Write("Primer nombre: \t");
    firstName = ReadLine();

    Write("Segundo nombre: ");
    lastName = ReadLine();

    Write("Edad: \t\t");
    age = int.Parse(ReadLine());

    Write("Direccion: \t");
    address = ReadLine();

    Write("Cedula: \t");
    id = ReadLine();



    // break;
    // continue;

    people.Add(new Person
    {
        Id = id,
        FirstName = firstName,
        LastName = lastName,
        Age = age,
        YearBirth = yearOfBirth.Birth(age),
        Address = address
    });

    WriteLine("\n===============================");
}

foreach (Person person in people)
{
    WriteLine($"""
        Nombre:         {person.FirstName}
        Apellido:       {person.LastName}
        Edad:           {person.Age}
        Año Nacimiento: {person.YearBirth}
        Direccion:      {person.Address}
        Cedula:         {person.Id}
        """);

    WriteLine("\n===============================");
}


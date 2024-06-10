using ColeccionList;

List<Person> personas = new List<Person>();

//METODO PARA AGREGAR UN ELEMENTO 
personas.Add(new Person(1, "Enrique", "Jimenez", 30));
personas.Add(new Person(2, "Yhennifer", "Abreu", 29));
personas.Add(new Person(3, "Enyher", "Jimenez", 8));

foreach (var p in personas)
{
    p.ViewInfo();
}


List<Person> newPerson = new List<Person> {
    new Person( 4,  "Betsy",  "Jimenez", 26),
    new Person( 5, "Sofia", "Pimentel", 2)
};

//METODO PARA AGREGAR VARIOS ELEMENTO 
personas.AddRange(newPerson);

Console.WriteLine("\nLista con mas personas agregadas");
foreach (var p in personas)
{
    p.ViewInfo();
}

//METODO PARA ELIMINAR UN ELEMENTO 
personas.RemoveAt(3);

Console.WriteLine("\nLista con el elemento 4 eliminado");
foreach (var p in personas)
{
    p.ViewInfo();
}

//COMO EDITAR ELEMENTOS DE UNA LISTA
Console.WriteLine("""
    Mostrada su lista de usuarios.
    Cual desea editar.
    Estos se editan por su numero de ID
""");
int id = Int32.Parse(Console.ReadLine());

Console.Write("Digite su nombre: ");
personas[id].FirstName = Console.ReadLine();

Console.Write("Digite su apellido: ");
personas[id].LastName = Console.ReadLine();

Console.Write("Digite su edad: ");
personas[id].Age = int.Parse(Console.ReadLine());

Console.WriteLine("\nLista con elemento editado");
foreach (var p in personas)
{
    p.ViewInfo();
}

//ENLACE DONDE SE ENCUENTRAN TODOS LOS METODOS DE LA CLASE List<>
//https://learn.microsoft.com/es-es/dotnet/api/system.collections.generic.list-1?view=net-8.0
using ColeccionList;

LinkedList<Person> personas = new LinkedList<Person>();

/*
LinkedList<Person> addPerson = new LinkedList<Person>()
{
    new Person(1, "Enrique", "Jimenez", 30),
};
*/

Person persona1 = new Person(1, "Enrique", "Jimenez", 30);
Person persona2 = new Person(2, "Yhennifer", "Abreu", 29);
Person persona3 = new Person(3, "Enyher", "Jimenez", 8);
Person persona4 = new Person(4, "Betsy", "Pimentel", 26);
Person persona5 = new Person(5, "Sofia", "OstenGuarde", 2);

//PARA AGREGAR ELEMENTO AL INICIO DE LA LISTA
personas.AddFirst(persona1);
personas.AddFirst(persona3);
personas.AddFirst(persona4);

//PARA AGREGAR ELEMENTO AL FINAL DE LA LISTA
personas.AddLast(persona2);
personas.AddLast(persona5);


foreach (Person person in personas)
{
    person.ViewInfo();
}

//ELIMINAR EL PRIMER ELEMENTO
personas.RemoveFirst();

//ELIMINAR EL ULTIMO ELEMENTO
personas.RemoveLast();

//ELIMINAR UN ELEMENTO EN ESPECIFICO
personas.Remove(persona4);

Console.WriteLine("Despues de avber eliminado los elementos.");
foreach (Person person in personas)
{
    person.ViewInfo();
}

//PARA AGREGAR UN ELEMENTO ANTES DE UNO EN ESPECIFICO
LinkedListNode<Person> nodo = personas.Find(persona3);

if (nodo != null) personas.AddBefore(nodo, persona1);

Console.WriteLine("MOSTRANDO LA LISTA LUEGO DE DECIR QUE LA PERSONA 3 SE PONGA ANTES DE LA PERSONA 2");
foreach (Person person in personas)
{
    person.ViewInfo();
}


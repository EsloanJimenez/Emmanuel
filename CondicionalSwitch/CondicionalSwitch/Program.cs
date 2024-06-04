// SWITCH SIMPLE
Console.Write("En que mes estamos: ");
string mes = Console.ReadLine().ToLower();

switch(mes)
{
    case "enero":
        Console.WriteLine($"Este es el mes de: {mes}");
        break;
    case "febrero":
        Console.WriteLine($"Este es el mes de: {mes}");
        break;
    case "marzo":
        Console.WriteLine($"Este es el mes de: {mes}");
        break;
    case "abril":
        Console.WriteLine($"Este es el mes de: {mes}");
        break;
    case "mayo":
        Console.WriteLine($"Este es el mes de: {mes}");
        break;
    case "junio":
        Console.WriteLine($"Este es el mes de: {mes}");
        break;
    case "julio":
        Console.WriteLine($"Este es el mes de: {mes}");
        break;
    case "agosto":
        Console.WriteLine($"Este es el mes de: {mes}");
        break;
    case "septiembre":
        Console.WriteLine($"Este es el mes de: {mes}");
        break;
    case "octubre":
        Console.WriteLine($"Este es el mes de: {mes}");
        break;
    case "noviembre":
        Console.WriteLine($"Este es el mes de: {mes}");
        break;
    case "diciembre":
        Console.WriteLine($"Este es el mes de: {mes}");
        break;
    default:
        Console.WriteLine($"El mes {mes} no esta contemplado");
        break;
}


// ESTE ES UN SWITCH CON CONDICIONES EN LOS CASE

Console.Write("Que edad tienes: ");
int edad = int.Parse(Console.ReadLine());

Console.Write("Estas estudiando: ");
string op = Console.ReadLine().ToLower();

bool estudiante;

if (op == "si") estudiante = true;
else estudiante = false;


switch (edad)
{
    case int mayorDeEdad when edad >= 18 && estudiante:
        Console.WriteLine(mayorDeEdad);
        Console.WriteLine("Eres un estudiante adulto.");
        break;
    case int mayorDeEdad when edad >= 18 && !estudiante:
        Console.WriteLine("Eres un adulto no estudiante.");
        break;
    default:

        Console.WriteLine("Eres menor de edad.");
        break;
}



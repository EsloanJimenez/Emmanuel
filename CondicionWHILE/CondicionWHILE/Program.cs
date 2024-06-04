using CondicionWHILE;

Console.WriteLine("Introduce un valor numerico");
int numeroRandom = int.Parse(Console.ReadLine());

Condicion condicion = new Condicion();

condicion.CondicionWhile(numeroRandom);
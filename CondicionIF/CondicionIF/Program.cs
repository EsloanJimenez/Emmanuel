using CondicionIF;

Random random = new Random();
int numeroRandon = random.Next(1, 100);

Console.Write("Escribe su nombre: ");
string nombre = Console.ReadLine();

Console.WriteLine(numeroRandon);

Condicion condicion = new Condicion();

condicion.NumeroRandon(numeroRandon, nombre);
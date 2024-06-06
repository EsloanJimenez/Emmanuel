/*

Console.Write("Digite un numero: ");
int numero = int.Parse(Console.ReadLine());





// INICIALIZACION - CONDICION  - INCREMENTO O DECREMENTO
for(int i = 0;      numero >= i;           i++)
{
    Console.WriteLine(i);
}

Console.WriteLine("\nSalio del bucle");

*/


List<string> list = new List<string>();

list.Add("Enrique");
list.Add("Enyher");
list.Add("Yhennifer");

Console.WriteLine(list[1]);

list.RemoveAt(1);

Console.WriteLine(list[1]);
int i = 0;

Console.WriteLine("Introduce un valor numerico");
int num = int.Parse(Console.ReadLine());

do
{
    Console.WriteLine(i);
    i++;
} while (i <= num);

Console.WriteLine("\nSalio del bucle");
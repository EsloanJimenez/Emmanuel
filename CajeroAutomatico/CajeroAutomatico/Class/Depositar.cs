namespace CajeroAutomatico.Class
{
    public class Depositar
    {
        public decimal Deposito(decimal saldo)
        {
            Console.Write("Cantidad a depositar: ");
            saldo += decimal.Parse(Console.ReadLine());

            Console.WriteLine("Su saldo se ha depositado correctamente.");

            return saldo;
        }
    }
}

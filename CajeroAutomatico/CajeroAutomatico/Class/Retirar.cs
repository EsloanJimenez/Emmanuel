namespace CajeroAutomatico.Class
{
    public class Retirar
    {
        public decimal Retirado(decimal saldo)
        {
            Console.Write($"Cantidad a retirar: ");
            saldo -= decimal.Parse( Console.ReadLine() );

            Console.WriteLine("Su retiro ha sido satisfactorio.");
            
            return saldo;
        }
    }
}

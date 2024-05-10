namespace CajeroAutomatico.Class
{

    public class MostrarSaldo
    {
        public void MostrandoSaldo(string nombre, decimal saldo)
        {
            Console.WriteLine("Mostrando Saldo");
            Console.WriteLine($"""
                    Nombre:   {nombre}
                    Saldo:    {saldo}
                """);
        }
    }
}

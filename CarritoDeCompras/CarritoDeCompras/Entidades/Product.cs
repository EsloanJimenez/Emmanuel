namespace CarritoDeCompras.Entidades
{
    public class Product
    {
        public int Id { get; set; }
        public required string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
    }
}

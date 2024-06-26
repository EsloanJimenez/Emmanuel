namespace CarritoDeCompras.Entidades
{
    public class ProductSelection
    {
        public Product Productos {  get; set; }
        public int Quantity { get; set; }
        public decimal SubTotal { get { return Productos.ProductPrice * Quantity; } }
    }
}

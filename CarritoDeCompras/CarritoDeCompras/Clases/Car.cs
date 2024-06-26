using CarritoDeCompras.Entidades;

namespace CarritoDeCompras.Clases
{
    public static class Car
    {
        public static void DisplayProduct(List<ProductSelection> productSelections)
        {
            Console.WriteLine("{0,-5} {1,-40} {2, -10} {3, -10:C} {4, 10:C}", "Id", "Nombre", "Cantidad", "Precio", "SubTotal");
            Console.WriteLine(new string('-', 80));

            decimal total = 0;

            foreach (var pSelect in productSelections)
            {
                total += pSelect.SubTotal;

                Console.WriteLine("{0, -5} {1, -40} {2, -10} {3, -10:C} {4, 10:C}", 
                    pSelect.Productos.Id, 
                    pSelect.Productos.ProductName, 
                    pSelect.Quantity, 
                    pSelect.Productos.ProductPrice, 
                    pSelect.SubTotal
                );
            }

            Console.WriteLine(new string('-', 80));
            Console.WriteLine("{0, -60} {1, 18:C}", "TOTAL", total);
        }
    }
}

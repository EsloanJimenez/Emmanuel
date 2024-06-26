using CarritoDeCompras.Entidades;

namespace CarritoDeCompras.Clases
{
    public static class ProductView
    {
        public static Product[] ProductList()
        {
            return new Product[]
            {
                new Product {Id = 1, ProductName = "Papa selectas", ProductPrice = 230 },
                new Product {Id = 2, ProductName = "Crema de leche 200ML", ProductPrice = 58 },
                new Product {Id = 3, ProductName = "Pan Hot Dog 400G 8/1", ProductPrice = 69 },
                new Product {Id = 4, ProductName = "Platano maduro 1UND", ProductPrice = 17 },
                new Product {Id = 5, ProductName = "Cebolla Roja Criolla 1LB", ProductPrice = 64 },
                new Product {Id = 6, ProductName = "Pan de agua 10/1", ProductPrice = 50 },
                new Product {Id = 7, ProductName = "Leche entera 1LT", ProductPrice = 58 },
                new Product {Id = 8, ProductName = "Huevos grande 30/1", ProductPrice = 195 },
                new Product {Id = 9, ProductName = "Queso mozzarella lonja 1LB", ProductPrice = 198 },
                new Product {Id = 10, ProductName = "Fresa congelada 1LB", ProductPrice = 98 },
                new Product {Id = 11, ProductName = "Jugo petit sabores 200ML 6/1", ProductPrice = 125 },
                new Product {Id = 12, ProductName = "Salami super especial 1.47LB", ProductPrice = 190 },
                new Product {Id = 13, ProductName = "Azucar crema 2LB", ProductPrice = 58 },
                new Product {Id = 14, ProductName = "Malta morena botella plastica 1UND 8oz", ProductPrice = 35 },
                new Product {Id = 15, ProductName = "Jugo frut ponch 64oz", ProductPrice = 133 },
                new Product {Id = 16, ProductName = "Cloro 1GL", ProductPrice = 75 },
                new Product {Id = 17, ProductName = "Chocolate tableta 10/1", ProductPrice = 98 },
                new Product {Id = 18, ProductName = "Leche evaporada", ProductPrice = 58 },
                new Product {Id = 19, ProductName = "refresco clasico", ProductPrice = 85 },
                new Product {Id = 21, ProductName = "Mayonesa 16oz", ProductPrice = 145 },
                new Product {Id = 22, ProductName = "papel higienico 4/1", ProductPrice = 59 },
                new Product {Id = 23, ProductName = "cafe molido 1/2LB", ProductPrice = 144 },
                new Product {Id = 24, ProductName = "Maiz dulce 425GR", ProductPrice = 38 },
                new Product {Id = 25, ProductName = "Qaueso mozzarela barra 8oz", ProductPrice = 115 },
                new Product {Id = 26, ProductName = "tomate bugalu 1LB", ProductPrice = 41 },
                new Product {Id = 27, ProductName = "Aji cubanela", ProductPrice = 49 },
                new Product {Id = 28, ProductName = "queso rebanado chedal 0.75LB", ProductPrice = 220 },
                new Product {Id = 29, ProductName = "Piña 1UND", ProductPrice = 84 },
                new Product {Id = 30, ProductName = "Aceite de soya 1.5LT", ProductPrice = 195 }
            };
        }

        public static void GetProduct(Product[] products)
        {
            Console.WriteLine("");
            Console.WriteLine("{0,-5} {1,-40} {2,10}", "Id", "Product Name", "Price");
            Console.WriteLine(new string('-', 60));

            foreach (var product in products)
            {
                Console.WriteLine("{0,-5} {1,-40} {2,10:C}", product.Id, product.ProductName, product.ProductPrice);
            }
        }
    }
}

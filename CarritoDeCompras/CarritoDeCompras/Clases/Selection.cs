using CarritoDeCompras.Entidades;

namespace CarritoDeCompras.Clases
{
    public static class Selection
    {
        public static List<ProductSelection> SelectProductById(Product[] products, Dictionary<int, int> idQuantity)
        {
            List<ProductSelection> selectsProducts = new List<ProductSelection>();

            foreach (var p in idQuantity)
            {
                int ProductId = p.Key;
                int quantity = p.Value;

                Product product = Array.Find(products, entry => entry.Id == ProductId);

                if(product != null)
                {
                    selectsProducts.Add(
                        new ProductSelection { 
                            Productos = product,
                            Quantity = quantity,
                        }
                    );
                }
            }
            return selectsProducts;
        }
    }
}

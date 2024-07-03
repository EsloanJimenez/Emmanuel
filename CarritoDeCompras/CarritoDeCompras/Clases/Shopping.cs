using CarritoDeCompras.Entidades;
using CarritoDeCompras.Enum;
using CarritoDeCompras.Interfaces;
using ListaEstudiantes.Class;

namespace CarritoDeCompras.Clases
{
    public class Shopping : IShoppingCart
    {
        Dictionary<int, int> item = new Dictionary<int, int>();

        int selectId, selectAmount, currentValue, op;
        char aumentarReducir;
        bool keyId;

        public void AddArticle(Product[] products)
        {
            Console.WriteLine("\nEscriba el -ID- del articulo y que cantidad de dicho articulo va a desear, luego presione -ENTER-");
            Console.WriteLine("Si desea actualizar la cantidad de articulos de un producto, solo digite su -ID-.");
            Console.WriteLine("Cuando desee salir de la compra solo precione el -0-\n");

            do
            {
                Console.Write("ID: \t\t");
                selectId = ValidateInput.GetValidateIntInput();

                if (selectId == 0)
                    break;

                if (item.ContainsKey(selectId))
                {
                    Console.WriteLine($"\nEl articulo con el ID {selectId} ya existe.\n");

                    EditProduct.EditingProduct(op, item, selectId, selectAmount, currentValue);
                    return;
                }

                Console.Write("Cantidad: \t");
                selectAmount = int.Parse(Console.ReadLine());

                if (item.TryGetValue(selectId, out int valor))
                {
                    currentValue = valor + selectAmount;
                    item[selectId] = currentValue;
                }
                else
                    item.Add(selectId, selectAmount);

            } while (selectId > 0 && selectId < 30);

            Selection.SelectProductById(products, item);
        }

        public void DeleteArticle()
        {

            do
            {
                Console.Write("Que articulo desea eliminar: ");
                selectId = int.Parse(Console.ReadLine());

                if (item.ContainsKey(selectId))
                {
                    item.Remove(selectId);
                    Console.WriteLine($"El articulo {selectId} se a eliminado con exito.");
                    keyId = item.ContainsKey(selectId);
                }
                else
                {
                    Console.WriteLine($"El ID {selectId} no existe");
                    keyId = item.ContainsKey(selectId);
                    Console.WriteLine(keyId);
                }

            } while (!keyId);

        }

        public void ViewCar(Product[] products)
        {
            Car.DisplayProduct(Selection.SelectProductById(products, item));

            EditProduct.EditingProduct(op, item, selectId, selectAmount, currentValue);
        }
    }
}

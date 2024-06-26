using CarritoDeCompras.Entidades;
using CarritoDeCompras.Interfaces;

namespace CarritoDeCompras.Clases
{
    public class Shopping : IShoppingCart
    {
        Dictionary<int, int> item = new Dictionary<int, int>();
        int selectId, selectCantidad, valorActual;
        char aumentarReducir;

        public void AddArticle(Product[] products)
        {
            Console.WriteLine("\nCuales y cuantos articulos va agregar al carrito");
            Console.WriteLine("Escriba el -ID- del articulo y que cantidad de dicho articulo va a desear, luego presione -ENTER-");
            Console.WriteLine("Cuando desee salir de la compra solo precione el -0-\n");

            do
            {
                Console.Write("ID: \t\t");
                selectId = int.Parse(Console.ReadLine());

                if (selectId == 0)
                    break;

                if (item.ContainsKey(selectId))
                {
                    do
                    {
                        Console.WriteLine($"\nEl articulo con el ID {selectId} ya existe.");
                        Console.WriteLine("Desea aumentar o reducir la cantidad de dicho articulo");

                        Console.Write("Si desea aumentar escriba una -a- de lo contrario una -r-: ");
                        aumentarReducir = char.Parse(Console.ReadLine().ToLower());

                        if (aumentarReducir == 'a')
                        {
                            if (item.TryGetValue(selectId, out int val))
                            {
                                Console.Write("Cantidad: \t");
                                selectCantidad = int.Parse(Console.ReadLine());

                                valorActual = val + selectCantidad;
                                item[selectId] = valorActual;
                                return;
                            }
                        }
                        else if (aumentarReducir == 'r')
                        {
                            if (item.TryGetValue(selectId, out int val))
                            {
                                Console.Write("Cantidad: \t");
                                selectCantidad = int.Parse(Console.ReadLine());

                                valorActual = val - selectCantidad;
                                item[selectId] = valorActual;
                                return;
                            }
                        }
                        else
                        {
                            Console.WriteLine("La opcion seleccionada no esta contemplada.");
                            Console.WriteLine("Por favor seleccione una opcion del menu.");
                        }
                    } while (aumentarReducir != 'a' && aumentarReducir != 'r');  
                }

                Console.Write("Cantidad: \t");
                selectCantidad = int.Parse(Console.ReadLine());

                if (item.TryGetValue(selectId, out int valor))
                {
                    valorActual = valor + selectCantidad;
                    item[selectId] = valorActual;
                }
                else
                    item.Add(selectId, selectCantidad);

            } while (selectId > 0 && selectId < 30);

            Selection.SelectProductById(products, item);
        }

        public void DeleteArticle()
        {
            Console.Write("Que articulo desea eliminar: ");
            selectId = int.Parse(Console.ReadLine());

            item.Remove(selectId);

            Console.WriteLine("El articulo se a eliminado con exito.");
        }

        public void ViewCar(Product[] products)
        {
            Car.DisplayProduct(Selection.SelectProductById(products, item));
        }
    }
}

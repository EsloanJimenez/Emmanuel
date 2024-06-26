using CarritoDeCompras.Enum;

namespace CarritoDeCompras.Clases
{
    public static class Menu
    {
        public static void OptionMenu()
        {
            Console.WriteLine("\nOpciones del menu");
            Console.WriteLine($"""

            {(int)Option.AddArticle}) Agregar articulo
            {(int)Option.ViewCar}) Ver carrito
            {(int)Option.DeleteArticle}) Eliminar articulos

            """);
        }
    }
}

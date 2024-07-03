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

        public static void OptionMenuEditAmount()
        {
            Console.WriteLine("\nDesea editar las cantidades de sus productos.");
            Console.WriteLine($"""

            {(int)OptionEditAmount.editAmount}) SI
            {(int)OptionEditAmount.noEditAmount}) No

            """);
        }

        public static void OptionMenuARN()
        {
            Console.WriteLine("\nQue desea realizar?.");
            Console.WriteLine($"""

            {(int)OptionARN.raise}) Aumentar
            {(int)OptionARN.reduce}) Reducir
            {(int)OptionARN.neutral}) Neutro

            """);
        }
    }
}

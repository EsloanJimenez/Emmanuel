namespace CajeroAutomatico.Class
{
    public class IniciarSeccion : Campos
    {
        public Datos Autenticando(List<Datos> datos)
        {
            Console.WriteLine("INICIO DE SECION \n");

            Console.Write("Nombre De Usuario: \t");
            nombreUsuario = Console.ReadLine();

            Console.Write("Pin: \t\t\t");
            pin = Console.ReadLine();

            foreach (Datos lista in datos)
            {
                if(lista.NombreUsuario == nombreUsuario && lista.Pin == pin)
                {
                    return lista;
                }
            }
            return null;
        }
    }
}

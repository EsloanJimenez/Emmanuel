using static System.Console;

namespace CajeroAutomatico.Class
{
    public class ObtenerUsuarios
    {
        public void MostrarUsuarios(List<Datos> datos)
        {
            WriteLine("LISTA DE USUARIOS");

            foreach(Datos view in datos)
            {
                WriteLine($"ID: \t\t\t{view.Id}");
                WriteLine($"NOMBRE: \t\t{view.Nombre}");
                WriteLine($"NOMBRE DE USUARIO: \t{view.NombreUsuario}");
                WriteLine($"PIN: \t\t\t{view.Pin}");
                WriteLine($"SALDO: \t\t\t{view.Saldo}\n");
            }
        }
    }
}

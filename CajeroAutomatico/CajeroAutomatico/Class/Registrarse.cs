using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Net.NetworkInformation;
using static System.Console;

namespace CajeroAutomatico.Class
{
    public class Registrarse : Campos
    {
        public void Registro(List<Datos> datos)
        {
            bool soloNumeros = true;

            id = datos.Count + 1;

            Write("Digite su nombre: \t\t");
            nombre = ReadLine();

            Write("Digite su nombre de usuario: \t");
            nombreUsuario = ReadLine().Replace(" ", "");

            do
            {
                Write("Digite su pin: \t\t\t");
                pin = ReadLine();

                soloNumeros = EsSoloNumero(pin);

                if (!soloNumeros)
                    WriteLine("Por favor introdusca valores numericos");

            } while (!soloNumeros);

            saldo = 0;

            Datos newUser = new Datos
            {
                Id = id,
                Nombre = nombre,
                NombreUsuario = nombreUsuario,
                Pin = pin,
                Saldo = saldo
            };

            datos.Add(newUser);

            WriteLine($"Cuenta registrada con exito. \n\n");
        }

        public static bool EsSoloNumero(string texto)
        {
            foreach (char caracter in texto)
            {
                if (!char.IsDigit(caracter)) return false;
            }
            return true;
        }
    }
}

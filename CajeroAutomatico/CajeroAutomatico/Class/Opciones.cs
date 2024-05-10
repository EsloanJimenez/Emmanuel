namespace CajeroAutomatico.Class
{
    public class Opciones
    {
        public void MenuInicio()
        {
            Console.WriteLine(@"
                SELCCIONE UNA OPCION

                1- Iniciar Seccion
                2- Registrarse
                3- Cerrar Aplicacion
            ");
        }

        public void MenuCuenta()
        {
            Console.WriteLine();
            Console.WriteLine(@"
                SELCCIONE UNA OPCION

                1- Depositar
                2- Retirar
                3- Mostrar el saldo
                4- Cerrar Seccion
            ");
        }
    }
}

using CajeroAutomatico.Class;

int op = 0;
bool repetir = false;
bool subRepetir = false;

Opciones option = new Opciones();
IniciarSeccion logIn = new IniciarSeccion();
ObtenerUsuarios viewInfo = new ObtenerUsuarios();

List<Datos> usuarios = new List<Datos>();

do
{
    option.MenuInicio();
    op = int.Parse(Console.ReadLine());

    switch (op)
    {
        case 1:
            Datos usuarioAutenticado = logIn.Autenticando(usuarios);

            if (usuarioAutenticado != null)
            {
                Console.WriteLine($"\n\nBienvenido: {usuarioAutenticado.Nombre}");

                do
                {
                    option.MenuCuenta();
                    op = int.Parse(Console.ReadLine());

                    switch (op)
                    {
                        case 1:
                            Depositar depositar = new Depositar();
                            usuarioAutenticado.Saldo = depositar.Deposito(usuarioAutenticado.Saldo);
                            subRepetir = true;
                            break;
                        case 2:
                            Retirar retirar = new Retirar();
                            usuarioAutenticado.Saldo = retirar.Retirado(usuarioAutenticado.Saldo);
                            subRepetir = true;
                            break;
                        case 3:
                            MostrarSaldo mostrarSaldo = new MostrarSaldo();
                            mostrarSaldo.MostrandoSaldo(usuarioAutenticado.Nombre, usuarioAutenticado.Saldo);
                            subRepetir = true;
                            break;
                        case 4:
                            subRepetir = false;
                            break;
                        default:
                            Console.WriteLine("La opcion seleccionada no esta contemplada.");
                            Console.WriteLine("Por favor seleccione una opcion del menu");
                            repetir = true;
                            break;
                    }
                } while (subRepetir);
            }
            else
            {
                Console.WriteLine("La contrasena o el usuario estan incorrectos");
            }

            repetir = true;
            break;
        case 2:
            Registrarse registro = new Registrarse();
            registro.Registro(usuarios);
            
            repetir = true;
            break;
        case 3:
            Console.WriteLine("\nAPLICACION CERRADA.");
            repetir = false;
            break;
        default:
            Console.WriteLine("La opcion seleccionada no esta contemplada.");
            Console.WriteLine("Por favor seleccione una opcion del menu");
            repetir = true;
            break;
    }
}while (repetir);

Console.WriteLine("\n\nNOS VEMOS LUEGO");


viewInfo.MostrarUsuarios(usuarios);
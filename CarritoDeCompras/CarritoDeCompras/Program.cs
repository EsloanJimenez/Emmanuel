using CarritoDeCompras.Clases;
using CarritoDeCompras.Entidades;
using CarritoDeCompras.Enum;
using ListaEstudiantes.Class;
using static System.Console;

Product[] products = ProductView.ProductList();
Shopping shopping = new Shopping();

WriteLine("Supermercado Sirena\n");
int op;

do
{
    Menu.OptionMenu();
    op = ValidateInput.GetValidateOption();

    switch(op)
    {
        case (int)Option.AddArticle:
            WriteLine("Elija los articulos que va a desear por su -ID-");
            ProductView.GetProduct(products);

            shopping.AddArticle(products);
            op = Repeat.Repeating();
            break;

        case (int)Option.ViewCar:
            shopping.ViewCar(products);
            op = Repeat.Repeating();
            break;

        case (int)Option.DeleteArticle:
            shopping.DeleteArticle();
            op = Repeat.Repeating();
            break;

        default:
            WriteLine("La opcion que a seleccionado no esta contemplada.");
            WriteLine("Porfavor seleccione una opcion del menu.");
            op = 2;
            break;
    }
} while (op <= 0 || op >= 5);

WriteLine("Nos vemos en la proxima compra...");
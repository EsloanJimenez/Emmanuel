using CarritoDeCompras.Enum;
using ListaEstudiantes.Class;

namespace CarritoDeCompras.Clases
{
    public static class EditProduct
    {
        public static void EditingProduct(int op, Dictionary<int, int> item, int selectId, int selectAmount, int currentValue)
        {
            do
            {
                Menu.OptionMenuEditAmount();
                op = ValidateInput.GetValidateOption();

                switch (op)
                {
                    case (int)OptionEditAmount.editAmount:
                        do
                        {
                            Console.Write("\nA cual producto desea editar su cantidad?: ");
                            selectId = ValidateInput.GetValidateIntInput();

                        } while (!item.ContainsKey(selectId));

                        Menu.OptionMenuARN();

                        EditAmount.RAN(op, item, selectId, selectAmount, currentValue);
                        break;
                    case (int)OptionEditAmount.noEditAmount:
                        break;
                    default:
                        Console.WriteLine("Selecciono una opcion no contemplada.");
                        break;
                }
            } while (op <= 0 || op >= 3);
        }
    }
}


/*==============================
ARREGLARLE LA PARTE DE

POR EJEMPLO

CUANDO VIENE DE AGREGAR ARTICULO SI ESCRIBO UN PRODUCTO EXISTENTE 

QUE NO PREGUNTE 

A cual producto desea editar su cantidad?

YA QUE SE SUPONE QUE SE ESCRIBIO UN ID EXISTENTE.
 
 */
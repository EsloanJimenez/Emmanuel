using CarritoDeCompras.Enum;
using ListaEstudiantes.Class;

namespace CarritoDeCompras.Clases
{
    public static class EditAmount
    {
        public static void RAN(int op, Dictionary<int, int> item, int selectId, int selectAmount, int currentValue)
        {
            do
            {
                op = ValidateInput.GetValidateIntInput();
                switch (op)
                {
                    case (int)OptionARN.raise:
                        if (item.TryGetValue(selectId, out int val)) {
                            Console.Write("Cantidad: \t");
                            selectAmount = ValidateInput.GetValidateIntInput();

                            currentValue = val + selectAmount;
                            item[selectId] = currentValue;

                            Console.WriteLine($"\nSe han aumentado los {selectAmount} articulos con exito.");
                            return;
                        }
                        break;
                    case (int)OptionARN.reduce:
                        if (item.TryGetValue(selectId, out int val2))
                        {
                            Console.Write("Cantidad: \t");
                            selectAmount = int.Parse(Console.ReadLine());

                            currentValue = val2 - selectAmount;
                            item[selectId] = currentValue;

                            Console.WriteLine($"\nSe han reducido los {selectAmount} articulos con exito.");
                            return;
                        }
                        break;
                    case (int)OptionARN.neutral:
                        break;
                    default:
                        Console.WriteLine("La opcion seleccionada no esta contemplada.");
                        Console.WriteLine("Por favor seleccione una opcion del menu.");
                        break;
                }

            } while (op <= 0 || op >= 4);
        }
    }
}

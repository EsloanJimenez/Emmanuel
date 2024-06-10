namespace CondicionIF
{
    public class Condicion
    {
        public void NumeroRandon(int numeroRandon, string nombre)
        {
            // IF - CON UNA SOLA LINEA DE CODIGO Y UNA SOLA CONDICION -

            if (numeroRandon <= 5) 
                Console.WriteLine("El numero es menor a 5");

            // IF - CON UNA SOLA LINEA DE CODIGO Y VARIAS CONDICIONES -

            if (numeroRandon >= 6 && numeroRandon <= 10) 
                Console.WriteLine("El numero esta entre 6 y 10");


            // IF - CON VARIAS LINEAS DE CODIGO -

            if (numeroRandon >= 11 && numeroRandon <= 15)
            {
                Console.WriteLine($"El numero randon es: \t{numeroRandon}");
                Console.WriteLine("Ganaste...");
            }

            // IF ELSE CON UNA SOLA LINEA DE CODIGO -

            if (numeroRandon >= 16 && numeroRandon <= 20) Console.WriteLine("Esta entre 16 y 20");
            else Console.WriteLine("El numero no esta entre 16 y 20");

            // IF, ELSE IF, ELSE CON UNA SOLA LINEA DE CODIGO -

            if (numeroRandon >= 21 && numeroRandon <= 25) 
                Console.WriteLine("Esta entre 21 y 25");
            else if (numeroRandon >= 26 && numeroRandon <= 30) 
                Console.WriteLine("Esta entre 26 y 30");
            else 
                Console.WriteLine("Es mayor a 30");


            //IF ANIDADOS

            if (numeroRandon >= 31 && numeroRandon <= 35)
            {
                if (numeroRandon >= 31) Console.WriteLine("El numero es: 31");
                else if (numeroRandon >= 32) Console.WriteLine("El numero es: 32");
                else if (numeroRandon >= 33) Console.WriteLine("El numero es: 33");
                else if (numeroRandon >= 34) Console.WriteLine("El numero es: 34");
                else if (numeroRandon >= 35) Console.WriteLine("El numero es: 35");
            }
            else
            {
                Console.WriteLine("El numero es mayor a 35");
            }

            // TERNARIO

            string result = (nombre.Length >= 7) ? "El nombre es muy largo" : "El nombre tiene buana longitud";

            Console.WriteLine(result);

            if(true)
            {
                //codigo a ejercutar
            }

            string mostrar = (true) ? "verdadero" : "falso";

            if(true)
            {
                mostrar = "verdadero";
            } else
            {
                mostrar = "falso";
            }
        }
    }
}

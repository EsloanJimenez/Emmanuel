namespace CondicionWHILE
{
    public class Condicion
    {
        public void CondicionWhile(int numero)
        {
            int i = 0;
            while (i <= numero)
            {
                Console.WriteLine(i);

                i++;
            }

            Console.WriteLine("YA SALI DEL WHILE");


        }
    }
}

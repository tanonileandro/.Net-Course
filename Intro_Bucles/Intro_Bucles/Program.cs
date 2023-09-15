namespace Intro_Bucles
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 10; i++) 
            {
                Console.WriteLine("Iteracion " + i);
            }

            Console.WriteLine("");
            Console.WriteLine("Se repite el bucle for escrito de otra manera...");

            // Otra manera de escribirlo
            for (int i = 0; i <= 10; i += 1)
            {
                Console.WriteLine("Iteracion " + i);
            }

            // ---------------------------------------------------------------------------------

            Console.WriteLine("");
            Console.WriteLine("Bucle While");

            int iterador = 0;
            while (iterador <= 10)
            {
                Console.WriteLine("Iteracion " + iterador);
                iterador++; // sin esto se generaria un bucle infinito
            }

            // ---------------------------------------------------------------------------------

            Console.WriteLine("");
            Console.WriteLine("Bucle Do While");

            int iterador2 = 0;

            do
            {
                
                Console.WriteLine("Iteracion " + iterador2);
                iterador2++;

            } while (iterador2 <= 10);

            Console.Read();

        }
    }
}
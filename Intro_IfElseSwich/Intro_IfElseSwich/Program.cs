namespace Intro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe tu nombre: ");
            string nombre = Console.ReadLine();

            if (nombre == "Leandro")
            {
                Console.WriteLine("Hola Leandro");
            }
            else if (nombre == "Test")
            {
                Console.WriteLine("Test");
            }
            else if (nombre == "Test2")
            {
                Console.WriteLine("Buenos dias");
            }
            else
            {
                Console.WriteLine("Hola Desconocido.");
            }

            // otra forma de escribir el if en una sola linea

            int edad = nombre == "Leandro" ? 27 : 20;
            Console.WriteLine("Tu edad es: " + edad);

            // Generamos las mismas condiciones del if pero con un swich

            switch (nombre)
            {
                case "Leandro":
                    Console.WriteLine("Eres Programador");
                    break;
                case "Test":
                    Console.WriteLine("Eres de soporte IT");
                    break;
                case "Test3": // si ponemos dos case seguidos, los dos ejecutaran el mismo codigo
                case "Test2":
                    Console.WriteLine("Eres de soporte IT nivel 2");
                    break;
                default:
                    Console.WriteLine("No se a que te dedicas");
                    break;

            }

            Console.Read(); // para que pare la ejecucion del programa
        }
    }
}


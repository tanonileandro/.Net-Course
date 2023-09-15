// See https://aka.ms/new-console-template for more information
using Intro.Espacio2; // se importo automaticamente la referencia de la clase usada en el otro espacio
using System;

namespace  Intro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola Mundo");
            Console.ReadKey();

            var ejemploNameSpace = new TestClase();
        }
    }
}
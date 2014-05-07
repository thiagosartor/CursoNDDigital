using System;

namespace UNIDADE_VI
{
    internal class Operadores
    {
        public static void Main_()
        {
            Console.WriteLine("Pré-Incremento:\n");

            int x = 0;

            Console.WriteLine("x = " + x);

            Console.WriteLine("\n++x +20 = \n");

            Console.WriteLine(++x + 20 + "\n");

            Console.WriteLine("\nPós-Incremento:\n");

            x = 0;

            Console.WriteLine("\nx++ +20 = \n");

            Console.WriteLine(x++ + 20 + "\n");

            Console.WriteLine("\nPré-Decremento:\n");

            x = 0;

            Console.WriteLine("x = " + x);

            Console.WriteLine("\n--x +20 = \n");

            Console.WriteLine(--x + 20 + "\n");

            Console.WriteLine("\nPós-Decremento:\n");

            x = 0;

            Console.WriteLine("\nx-- +20 = \n");

            Console.WriteLine(x-- + 20 + "\n");

            Console.ReadKey();
        }

        public static void Main()
        {

        }
    }
}
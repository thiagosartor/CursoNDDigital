using System;

namespace Slides
{
    internal class Class1
    {
        public static void Main()
        {
            int i = 0;

            Random gerador = new Random();

            // número no intervalo [0 ,99]
            int numeroAleatorio = (int)(gerador.NextDouble() * 100);

            while (i < numeroAleatorio)
            {
                Console.WriteLine(" Mensagem número " + (i + 1));
                i++;
            }
        }
    }
}
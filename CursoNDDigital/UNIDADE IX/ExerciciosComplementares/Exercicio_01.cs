using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIDADE_IX.ExerciciosComplementares
{
    class Exercicio_01
    {
        static void Main1(string[] args)
        {
            Random gerador = new Random();
            int[] gabarito = new int[10];
            Console.WriteLine("======== Gabarito ======\n");
            for (int i = 0; i < gabarito.Length; i++)
            {
                gabarito[i] = gerador.Next(1, 4);
                Console.WriteLine("\t"+ gabarito[i]);
            }
            Console.ReadKey();
        }
    }
}

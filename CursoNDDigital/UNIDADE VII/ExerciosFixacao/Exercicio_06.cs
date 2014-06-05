using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIDADE_VII.ExerciosFixacao
{
    class Exercicio_06
    {
        static void Main1(string[] args)
        {
            int[] contador = new int[6];
            Random gerador = new Random();
            for (int i = 0; i < 100; i++)
            {
                contador[gerador.Next(0, 6)]++;
            }
            Console.WriteLine("=== RESULTADO ===");
            for (int i = 0; i < contador.Length; i++)
            {
                Console.WriteLine("Numero {0}: {1} vezes", i + 1, contador[i]);
            }
            Console.ReadKey();
        }

    }
}

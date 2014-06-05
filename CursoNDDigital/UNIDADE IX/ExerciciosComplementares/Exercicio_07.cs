using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIDADE_IX.ExerciciosComplementares
{
    class Exercicio_07
    {
        static void Main2(string[] args)
        {
            int[] a = new int[50];
            int[] b = new int[50];
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("Digite o valor {0} de A: ", i + 1);
                a[i] = int.Parse(Console.ReadLine());
                Console.Write("Digite o valor {0} de B: ", i + 1);
                b[i] = int.Parse(Console.ReadLine());
                Console.WriteLine();
            }
            int soma = 0;
            for (int i = 0; i < a.Length; i++)
            {
                soma += a[i] - b[b.Length - (i + 1)];
            }
            Console.WriteLine("Soma: {0}", soma);
            Console.ReadKey();
        }
    }
}

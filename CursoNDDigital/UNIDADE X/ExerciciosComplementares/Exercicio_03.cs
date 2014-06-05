using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIDADE_X.ExerciciosFixacao.ExerciciosComplementares
{
    class Exercicio_03
    {
        static int[] idade = new int[5];
        private static void Main(string[] args)
        {
            lerIdade();
            Console.Clear();
            maiorIdade();
            menorIdade();
            imprimirIdade();
            Console.ReadKey();
        }

        static void lerIdade()
        {
            for (int i = 0; i < idade.Length; i++)
            {
                Console.Write("Digite a idade {0}: ", i + 1);
                idade[i] = int.Parse(Console.ReadLine());
            }
        }
        static void maiorIdade()
        {
            int maior = 0;
            for (int i = 0; i < idade.Length; i++)
            {
                if (idade[i] > maior || i == 0)
                {
                    maior = idade[i];
                }
            }
            Console.WriteLine("A maior idade é: {0}", maior);
        }
        static void menorIdade()
        {
            int menor = 0;
            for (int i = 0; i < idade.Length; i++)
            {
                if (idade[i] < menor || i == 0)
                {
                    menor = idade[i];
                }
            }
            Console.WriteLine("A menor idade é: {0}", menor);
        }

        static void imprimirIdade()
        {
            Console.WriteLine("\n====== IDADES =======\n");
            for (int i = 0; i < idade.Length; i++)
            {
                Console.WriteLine("Idade {0}: {1}", i + 1, idade[i]);
            }
        }

    }
}

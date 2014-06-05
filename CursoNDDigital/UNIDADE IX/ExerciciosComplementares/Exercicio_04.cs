using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIDADE_IX.ExerciciosComplementares
{
    class Exercicio_04
    {
        static void Main1(string[] args)
        {
            // Random gerador = new Random();
            int[] vet1 = new int[12];
            int[] vet2 = new int[12];
            for (int i = 0; i < vet1.Length; i++)
            {
                Console.Write("Digite o {0}º valor: ", i + 1);
                vet1[i] = int.Parse(Console.ReadLine());
                //vet1[i] = gerador.Next(0, 2);            // Gera os valores automaticos
                if (vet1[i] == 0)
                {
                    vet2[i] = 1;
                }
                else
                {
                    vet2[i] = vet1[i];
                }
            }
            Console.WriteLine();
            exibirVetor(vet1);
            exibirVetor(vet2);
            Console.ReadKey();

        }

        static void exibirVetor(int[] vetor)
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write(vetor[i] + " ");
            }
            Console.WriteLine("\n");
        }
    }
}

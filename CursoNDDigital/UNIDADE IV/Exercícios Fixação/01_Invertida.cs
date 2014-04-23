using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UNIDADE_IV.Exercícios_Fixação
{
    class Program
    {
        // Função :  Faça um programa que exibe o conteúdo de um vetor tamanho 10 de forma invertida.
        
        static void Main1(string[] args)
        {
            int[] vet = new int[10];
            for (int i = 0; i < vet.Length; i++)
            {
                vet[i] = i;
            }

            for (int i = vet.Length- 1; i > 0; i--)
            {
                Console.WriteLine(vet[i]);
            }
            Console.ReadKey();
        }
    }
}

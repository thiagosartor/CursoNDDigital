using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UNIDADE_IV.Exercícios_Fixação
{
    class _03_Matriz
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[3, 4];
            int[,] matrizModificada = new int[3, 4];
            for (int linha = 0; linha < 3; linha++)
            {
                for (int coluna = 0; coluna < 4; coluna++)
                {
                    Console.Write("Digite o valor de " + linha + "," + coluna + ": ");
                    matriz[linha, coluna] = int.Parse(Console.ReadLine());
                    if (matriz[linha, coluna] < 0)
                    {
                        matrizModificada[linha, coluna] = 0;
                    }
                    else
                    {
                        matrizModificada[linha, coluna] = matriz[linha, coluna];
                    }
                }
            }
            Console.WriteLine("=== Original ====");
            for (int linha = 0; linha < 3; linha++)
            {
                for (int coluna = 0; coluna < 4; coluna++)
                {
                    Console.Write(matriz[linha, coluna] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("=== Modificada ====");
            for (int linha = 0; linha < 3; linha++)
            {
                for (int coluna = 0; coluna < 4; coluna++)
                {
                    Console.Write(matrizModificada[linha, coluna] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}

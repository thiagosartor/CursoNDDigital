using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIDADE_IX.ExercicioFixacao
{
    class Tabuada
    {
        static void Main1(string[] args)
        {
            int[,] arrayDeArrays = new int[3, 10];
            int numLinhas = arrayDeArrays.GetLength(0);
            int numColunas = arrayDeArrays.GetLength(1);
            for (int coluna = 0; coluna < numColunas; coluna++)
            {
                for (int linha = 0; linha < numLinhas; linha++)
                {
                    Console.Write("{0} x {1} = {2}\t", linha + 1, coluna + 1, (linha + 1) * (coluna + 1));

                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}

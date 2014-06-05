using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIDADE_IX.ExercicioFixacao
{
    class TabelaQualquer
    {
        static void Main1(string[] args)
        {
            int[,] arrayDeArrays = new int[5, 5];
            int numLinhas = arrayDeArrays.GetLength(0);
            int numColunas = arrayDeArrays.GetLength(1);
            for (int linha = 0; linha < numLinhas; linha++)
            {
                for (int coluna = 0; coluna < numColunas; coluna++)
                {
                    arrayDeArrays[linha, coluna] = 1;
                    Console.Write(arrayDeArrays[linha, coluna] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();

        }


    }
}

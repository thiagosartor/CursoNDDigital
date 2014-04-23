using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UNIDADE_IV.Exercícios_Fixação
{
    class _06_Classe
    {
        static void Main1(string[] args)
        {
            string nomeProf;
            string[,] vet = new string[3, 4];
            nomeProf = "Thiago";
            vet[1, 1] = "Giorgi";
            vet[1, 2] = "Lucas";
            vet[1, 3] = "Camila";
            vet[1, 4] = "Greicy";
            vet[1, 5] = "Mateus";

            vet[2, 1] = "Lucas 2";
            vet[2, 2] = "Guilherme";
            vet[2, 3] = "Arnaldo";
            vet[2, 4] = "Felipe";
            vet[2, 5] = " - ";

            vet[3, 1] = "Luiz";
            vet[3, 2] = "Raul";
            vet[3, 3] = "Aprigio";
            vet[3, 4] = "Antonio";
            vet[3, 5] = "Rafael";

            Console.WriteLine(nomeProf);
            Console.WriteLine();

            for (int linha = 0; linha < 3; linha++)
            {
                for (int coluna = 0; coluna < 4; coluna++)
                {
                    Console.Write(vet[linha, coluna]);
                    Console.Write("|");
                }
                Console.WriteLine();
            }
            Console.ReadKey();

        }
    }
}

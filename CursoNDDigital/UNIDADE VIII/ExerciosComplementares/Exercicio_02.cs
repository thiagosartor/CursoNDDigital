using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIDADE_VIII.ExerciosComplementares
{
    class Exercicio_02
    {
        static void Main1(string[] args)
        {
            int numEspaco = 0;
            for (int desenho = 0; desenho < 3; desenho++) // 3 desenhos
            {
                for (int  linha = 0; linha < 5; linha++) // 5 linhas por desenho
                {
                    for (int espaco = 0; espaco < numEspaco; espaco++) // Espacos
                    {
                        Console.Write(" ");
                    }
                    for (int simbolo = 0; simbolo < 9; simbolo++) // 9 asteriscos por linha
                    { 
                        Console.Write("*");
                    }
                    Console.WriteLine(); // Quebra a linha
                    numEspaco++; // aumenta o numero de espacos
                }
                numEspaco = 0;
            }
            Console.ReadKey();
        }
    }
}

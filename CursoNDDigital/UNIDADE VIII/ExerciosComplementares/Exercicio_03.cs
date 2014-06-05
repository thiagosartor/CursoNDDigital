using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIDADE_VIII.ExerciosComplementares
{
    class Exercicio_03
    {
        static void Main(string[] args)
        {
            int numApt = 10;
            int vaga = 0;
            for (int bloco = 1; bloco <= 3; bloco++)
            {
                Console.WriteLine("\n===============  Bloco {0}  ================\n", bloco);
                for (int andar = 1; andar <= 9; andar++)
                {
                    for (int apt = 1; apt <= 4; apt++)
                    {
                        Console.WriteLine("Vaga: {0} - Bloco: {1} - Andar: {2} - Apartamento: {3}", ++vaga, bloco, andar, apt + numApt);
                    }
                    Console.WriteLine();
                    numApt += 10;
                }
                numApt = 10;
            }
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIDADE_VIII.ExerciosComplementares
{
    class Exercicio_04
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("=== TABUADA ====\n");
            for (int numTab = 1; numTab <= 10; numTab++)
            {
                for (int numMultiplicador = 1; numMultiplicador <= 10; numMultiplicador++)
                {
                    Console.WriteLine("{0} x {1} = {2}", numTab, numMultiplicador, numTab * numMultiplicador);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}

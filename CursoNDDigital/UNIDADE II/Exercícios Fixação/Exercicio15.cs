using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIDADE_II
{
    class Exercicio15
    {
        static void Main15(string[] args)
        {
            string[] nomes = new string[10];

            for (int i = 0; i < nomes.Length; i++)
            {
                nomes[i] = Console.ReadLine();
            }

            for (int i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine(nomes[i] + "           " + nomes[9 - i]);
            }
            Console.ReadKey();
        }
    }
}

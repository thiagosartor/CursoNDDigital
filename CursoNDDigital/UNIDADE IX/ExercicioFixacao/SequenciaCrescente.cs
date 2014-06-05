using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Fixacao
{
    class SequenciaCrescente
    {
        static void Main1(string[] args)
        {
            int[] numeros = new int[10];
            Console.WriteLine("Numeros: ");
            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = i + 1;
                Console.WriteLine("\t" + numeros[i]);
            }
            Console.ReadKey();
        }
    }
}

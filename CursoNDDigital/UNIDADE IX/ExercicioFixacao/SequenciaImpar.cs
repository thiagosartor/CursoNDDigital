using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Fixacao
{
    class SequenciaImpar
    {
        static void Main1(string[] args)
        {
            int[] numeros = new int[10];
            Console.WriteLine("Numeros: ");
            int proxImpar = -1;
            for (int i = 0; i < 10; i++)
            {
                proxImpar += 2;
                numeros[i] = proxImpar;
                Console.WriteLine("\t" + numeros[i]);
            }
            Console.ReadKey();
        }

    }
}

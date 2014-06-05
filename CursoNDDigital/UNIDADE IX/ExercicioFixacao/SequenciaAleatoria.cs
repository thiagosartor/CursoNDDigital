using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIDADE_IX.ExercicioFixacao
{
    class SequenciaAleatoria
    {
        static void Main1(string[] args)
        {
            int[] numeros = new int[10];
            Random gerador = new Random();
            Console.WriteLine("Numeros: ");
            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = gerador.Next(0, 101);
                Console.WriteLine("\t" + numeros[i]);
            }
            Console.ReadKey();
        }
    }
}

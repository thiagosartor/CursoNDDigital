using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIDADE_XI.ExerciciosComplemetares
{
    class TrocaElementos
    {
        static void Main1(string[] args)
        {
            double[] array = { 10, 20, 30 };
            exibirArray(array);
            Troca(array, 0, array.Length - 1);
            exibirArray(array);
            Console.ReadKey();
        }


        public static void Troca(double[] array, int pos, int pos2)
        {
            double aux = array[pos];
            array[pos] = array[pos2];
            array[pos2] = aux;
        }

        static void exibirArray(double[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Array[{0}] = {1}\t", i , array[i]);
            }
            Console.WriteLine("\n\n");
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIDADE_XI.ExerciciosComplemetares
{
    class MediaElementos
    {
        static void Main1(string[] args)
        {
            double[] array = { 10, 20, 30 };
            double media = Media(array);
            Console.WriteLine("A média é: {0}", media);
            Console.ReadKey();
        }

        static double Media(double[] array)
        {
            double soma = SomaElementos.Soma(array); // Soma os elementos
            return (double) soma / array.Length;
        }
    }
}

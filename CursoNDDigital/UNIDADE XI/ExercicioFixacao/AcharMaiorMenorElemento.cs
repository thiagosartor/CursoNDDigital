using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIDADE_XI.ExerciciosComplemetares
{
    class AcharMaiorMenorElemento
    {
        static void Main1(string[] args)
        {
            double[] array = {-4, -5, 0, 80, 65};

            double menor = array[Menor(array, 0)];
            double maior = array[Maior(array)];
            Console.WriteLine("O maior é: {0}", maior);
            Console.WriteLine("O menor é: {0}", menor);
            Console.ReadKey();
        }

        public static int Maior(double[] array)
        {
            int posMaior = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[posMaior])
                {
                    posMaior = i;
                }
            }
            return posMaior;
        }



        public static int Menor(double[] array, int posInicio)
        {
            int posMenor = posInicio;
            for (int i = posInicio + 1; i < array.Length; i++)
            {
                if (array[i] < array[posMenor])
                {
                    posMenor = i;
                }
            }
            return posMenor;
        }

        public static int Maior(double[] array, int posInicio)
        {
            int posMaior = posInicio;
            for (int i = posInicio + 1; i < array.Length; i++)
            {
                if (array[i] > array[posMaior])
                {
                    posMaior = i;
                }
            }
            return posMaior;
        }



    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIDADE_XI.ExerciciosComplemetares
{
    class OrdenarElementos
    {
        static void Main1(string[] args)
        {
            double[] array = {20, 80,10 };
            Console.WriteLine("===== ORDEM CRESCENTE =====");
            OrdernarArray(array);
            exibirArray(array);
            Console.WriteLine("===== ORDEM DECRESCENTE =====");
            OrdernarArrayDecrecente(array);
            exibirArray(array);
            Console.ReadKey();

        }

        static void OrdernarArray(double[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int menor = AcharMaiorMenorElemento.Menor(array, i);
                TrocaElementos.Troca(array, i, menor);
            }
        }

        static void OrdernarArrayDecrecente(double[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int maior = AcharMaiorMenorElemento.Maior(array, i);
                TrocaElementos.Troca(array, i, maior);
            }
        }

        static void exibirArray(double[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Array[{0}] = {1}\t", i, array[i]);
            }
            Console.WriteLine("\n\n");
        }

    }
}

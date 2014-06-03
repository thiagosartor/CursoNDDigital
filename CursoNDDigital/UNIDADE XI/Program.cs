using System;
namespace UNIDADE_XI
{
    public static class Program
    {
        public static void Main()
        {
            double[] array = new double[] { 4.4, 6.7, 8.9, 10.4, 2.3 };
            int[] array2 = new int[] { 4, 7, 9, 10, 3 };
            //Encontrar o maior ou o menor elemento de um array
            int resultadomaior = Maior(array);
            Console.WriteLine(resultadomaior);
            Console.ReadKey();

            //soma elementos de um array
            double resultadoSoma = Soma(array);
            Console.WriteLine(resultadoSoma);
            Console.ReadKey();

            //Encontrar a média dos elementos de um array
            double resultadoMedia = Media(array);
            Console.WriteLine(resultadoMedia);
            Console.ReadKey();

            //Ordenar os elementos de um array
            Ordenar(array2);
            Console.WriteLine();
            Console.ReadKey();
        }
        public static int Maior(double[] array)
        {
            int posicaoDoMaior = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[posicaoDoMaior] < array[i])
                {
                    posicaoDoMaior = i;
                }
            }
            return posicaoDoMaior;
        }
        public static double Soma(double[] array)
        {
            double soma = 0;

            for (int i = 0; i < array.Length; i++)
            {
                soma += array[i];
            }

            return soma;
        }

        public static double Media(double[] array)
        {
            double soma = Soma(array);
            double media = soma / array.Length;

            return media;
        }

        public static void Troca(int[] array, int i, int j)
        {
            int auxiliar = array[i];
            array[i] = array[j];
            array[j] = auxiliar;
        }

        public static int Menor(int[] array, int inicio)
        {
            int menor = inicio;

            for (int i = inicio + 1; i < array.Length; i++)
            {
                if (array[menor] > array[i])
                {
                    menor = i;
                }
            }
            return menor;
        }

        public static void Ordenar(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int menor = Menor(array, i);
                Troca(array, i, menor);
            }
        }
    }
}
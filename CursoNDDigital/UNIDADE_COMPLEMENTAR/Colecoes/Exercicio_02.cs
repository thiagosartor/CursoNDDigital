using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace UNIDADE_COMPLEMENTAR.Colecoes
{
    /// <summary>
    /// 2)	Faça um algoritmo que leia uma coleção com 80 números decimais e encontre o menor valor, o maior valor, a média e a soma de todos os valores.
    /// </summary>
    internal class Exercicio_02
    {
        public static List<double> Numeros = new List<double>();
        public static Random Gerador = new Random();

        public static void Main1()
        {
            Console.WriteLine("ADICIONANDO NUMEROS:");
            AdicionandoNumeros();
            Console.WriteLine("O MENOR VALOR É:{0:F2} " , MenorValor());
            Console.WriteLine("O MAIOR VALOR É: {0:F2} ", MaiorValor());
            Console.WriteLine("A MÉDIA DOS VALORES É: {0:F2} ", MediaValores());
            Console.WriteLine("A SOMA DE TODOS OS VALORES É:{0:F2} ", +SomaValores());
            Console.ReadKey();
        }

        private static double MaiorValor()
        {
            return Numeros.Max();
        }

        private static double MediaValores()
        {
            return Numeros.Average();
        }

        private static double SomaValores()
        {
            return Numeros.Sum();
        }

        private static double MenorValor()
        {
            return Numeros.Min();
        }

        private static void AdicionandoNumeros()
        {
            for (int i = 0; i < 10; i++)
            {
                double numero = Gerador.NextDouble()*100;
                Numeros.Add(numero);
                Console.WriteLine("{0:F2} " ,numero);
            }
        }
    }
}
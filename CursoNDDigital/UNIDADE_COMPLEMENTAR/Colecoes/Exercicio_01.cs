using System;
using System.Collections.Generic;

namespace UNIDADE_COMPLEMENTAR.Colecoes
{
    /// <summary>
    /// 1)	Faça um algoritmo que adicione 100 números em qualquer coleção que vocês preferir, ao final imprima esses números decrescente e depois crescente
    /// </summary>
    internal class Exercicio_01
    {
        public static List<int> Numeros = new List<int>();
        public static Random Gerador = new Random();

        public static void Main1()
        {
            Console.WriteLine("ADICIONANDO NUMEROS:");
            AdicionandoNumeros();
            Console.WriteLine("ORDENANDO NUMEROS ASC:");
            OrdernandoCrescente();
            Console.WriteLine("ORDENANDO NUMEROS DESC:");
            OrdernaDecrescente();

            Console.ReadKey();
        }

        private static void OrdernaDecrescente()
        {
            Numeros.Reverse();
            PercorreNumeros();
        }

        private static void OrdernandoCrescente()
        {
            Numeros.Sort();
            PercorreNumeros();
        }

        private static void PercorreNumeros()
        {
            foreach (var numero in Numeros)
            {
                Console.WriteLine(numero);
            }
        }

        private static void AdicionandoNumeros()
        {
            for (int i = 0; i < 100; i++)
            {
                int numero = Gerador.Next(0, 999);
                Numeros.Add(numero);
                Console.WriteLine(numero);
            }
        }
    }
}
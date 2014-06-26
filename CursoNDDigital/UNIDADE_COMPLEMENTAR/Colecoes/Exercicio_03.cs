using System;
using System.Collections.Generic;

namespace UNIDADE_COMPLEMENTAR.Colecoes
{
    /// <summary>
    /// 3)	Faça um programa que leia n nomes inserindo-os em uma lista de forma ordenada utilizando a ideia do algoritmo da inserção. No final, o programa deve mostrar todos os nomes ordenados alfabeticamente.
    /// </summary>
    internal class Exercicio_03
    {
        public static List<string> Nomes = new List<string>() { "Thiago", "Giorgi", "Lucas M.", "Camila", "Greicy", "Mateus", "Felipe", "Rafael", "Antonio", "Raul", "Aprigio", "Luis", "Arnaldo", "Guilherme", "Lucas S." };

        public static void Main1()
        {
            Nomes.Sort();
            foreach (var nome in Nomes)
            {
                Console.WriteLine(nome);
            }
            Console.ReadKey();
        }
    }
}
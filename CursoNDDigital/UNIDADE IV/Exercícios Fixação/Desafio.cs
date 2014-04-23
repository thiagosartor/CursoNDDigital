using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UNIDADE_IV.Exercícios_Fixação
{
    class Desafio
    {
        static void Main1(string[] args)
        {
            int result = 0;
            int[] a = new int[50];
            int[] b = new int[50];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < b.Length; i++)
            {
                b[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < a.Length; i++)
            {
                result += (a[i] - b[51 - i]);
            }
            Console.WriteLine("Total da soma: " + result);
            Console.ReadKey();
        }
    }
}

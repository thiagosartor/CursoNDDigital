using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UNIDADE_III
{
    class _03_Funcao
    {
        static void Main1(string[] args)
        {
            int num1, num2;
            double media;
            Console.Write("Digite o numero 1: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o numero 2: ");
            num2 = int.Parse(Console.ReadLine());
            media = calcularMedia(num1, num2);
            Console.WriteLine("Media: " + media.ToString("#0.00"));
            Console.ReadKey();
        }

        static double calcularMedia(int num1, int num2)
        {
            return (num1 + num2) / 2;
        }
    }
}

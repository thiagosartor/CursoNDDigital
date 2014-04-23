using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UNIDADE_III
{
    class _04
    {
        public static int num1, num2, result;

        static void Main1(string[] args)
        {
            Console.Write("Digite o numero 1: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o numero 2: ");
            num2 = int.Parse(Console.ReadLine());
            multiplicacao();
            Console.WriteLine("Resultado: " + result);
            Console.ReadKey();
        }

        static void multiplicacao()
        {
            result = num1 * num2;
        }
    }
}

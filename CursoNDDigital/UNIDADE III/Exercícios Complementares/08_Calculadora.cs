using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UNIDADE_III
{
    class _08_Calculadora
    {
        static int num1, num2;
        static double result;
        static void Main1(string[] args)
        {
            int op;
            Console.WriteLine("=== Calculadora ===");
            Console.WriteLine("1 - Adição");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.Write("Digite a opção: ");
            op = int.Parse(Console.ReadLine());
            switch (op)
            {
                case 1:
                    ler();
                    adicao();
                    break;
                case 2:
                    ler();
                    subtracao();
                    break;
                case 3:
                    ler();
                    multiplicacao();
                    break;
                case 4:
                    ler();
                    divisao();
                    break;
                default:
                    Console.WriteLine("Opção Inválida !!");
                    break;
            }
        }

        private static void ler()
        {
            Console.Write("Digite o numero 1: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o numero 2: ");
            num2 = int.Parse(Console.ReadLine());
        }

        private static void divisao()
        {
            result = num1 / num2;
            Console.WriteLine("Resultado: "+ result);
        }

        private static void multiplicacao()
        {
            result = num1 * num2;
            Console.WriteLine("Resultado: " + result);
        }

        private static void adicao()
        {
            result = num1 + num2;
            Console.WriteLine("Resultado: " + result);
        }

        private static void subtracao()
        {
            result = num1 - num2;
            Console.WriteLine("Resultado: " + result);
        }
    }
}

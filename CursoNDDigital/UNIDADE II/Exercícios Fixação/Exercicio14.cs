using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIDADE_II
{
    class Exercicio14
    {
        static void Main14(string[] args)
        {
            double num1, num2;
            Console.Write("Digite o primeiro numero: ");
            num1 = double.Parse(Console.ReadLine());
            Console.Write("Digite o segundo numero: ");
            num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine(!(num1 < num2));
            Console.WriteLine(!(num1 > num2));
            Console.WriteLine(!(num1 <= num2));
            Console.WriteLine(!(num1 >= num2));
            Console.WriteLine(!(num1 != num2));
            Console.WriteLine(!(num1 == num2));

            Console.ReadKey();
        }
    }
}

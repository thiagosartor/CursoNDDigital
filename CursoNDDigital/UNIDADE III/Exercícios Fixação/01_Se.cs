using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIDADE_III
{
    class _01_Se
    {
        static void Main1(string[] args) {
            float num;
            Console.Write("Digite um numero: ");
            num = float.Parse(Console.ReadLine());
            if (num > 10)
            {
                Console.WriteLine("Maior que 10");
            }
            else
            {
                Console.WriteLine("Menor que 10");
            }
            Console.ReadKey();
        }
        

    }
}

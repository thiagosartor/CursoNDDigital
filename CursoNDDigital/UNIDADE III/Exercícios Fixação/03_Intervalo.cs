using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIDADE_III
{
    class _03_Intervalo
    {
        static void Main1(string[] args)
        {
            float num;
            Console.Write("Digite um numero: ");
            num = float.Parse(Console.ReadLine());
            if (num >= 100 && num <= 200)
            {
                Console.WriteLine("Está entre 100 e 200");
            }
            else
            {
                Console.WriteLine("Fora do intervalo");
            }
            Console.ReadKey();
        }
    }
}

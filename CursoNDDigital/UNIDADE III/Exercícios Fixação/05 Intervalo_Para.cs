using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIDADE_III
{
    class _05
    {
        static void Main1(string[] args)
        {
            float num, cont = 0;
            for (int i = 0; i < 80; i++)
            {
                Console.Write("Digite um numero: ");
                num = float.Parse(Console.ReadLine());
                if (num >= 10 && num <= 150)
                {
                    cont++;
                }
            }
            Console.WriteLine("Contagem de numeros entre 10 e 150: " + cont);
            Console.ReadKey();
        }
    }
}

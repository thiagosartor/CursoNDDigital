using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIDADE_III
{
    class _13_Numeros
    {
        static void Main1(string[] args)
        {
            float num;
            Console.Write("Digite um numero: ");
            num = float.Parse(Console.ReadLine());
            if (num > 0)
            {
                Console.WriteLine("Numero é positivo");
            } else if (num < 0)
            {
                Console.WriteLine("Numero é negativo");
            } else if (num == 0)
            {
                Console.WriteLine("Igual a zero");
            }
            Console.ReadKey();
        }
    }
}

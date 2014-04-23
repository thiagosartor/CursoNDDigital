using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UNIDADE_III
{
    class _05_Positivo_Negativo_Zero
    {
        static void Main1(string[] args)
        {
            int num;
            Console.Write("Digite um numero: ");
            num = int.Parse(Console.ReadLine());
            if (positivo(num))
            {
                Console.WriteLine("É positivo");
            }
            else if (negativo(num))
            {
                Console.WriteLine("É negativo");
            }
            else if(zero(num)){
                Console.WriteLine("É zero");
            }
            Console.ReadKey();
        }

        static bool positivo(int num)
        {
            if (num > 0)
            {
                return true;
            }
            return false;
        }

        static bool negativo(int num)
        {
            if (num < 0)
            {
                return true;
            }
            return false;
        }

        static bool zero(int num)
        {
            if (num == 0)
            {
                return true;
            }
            return false;
        }

    }
}

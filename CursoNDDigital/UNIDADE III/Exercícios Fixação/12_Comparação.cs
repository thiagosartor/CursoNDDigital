using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIDADE_III
{
    class _12_Comparação
    {
        static void Main1(string[] args)
        {
            float num;
            Console.Write("Digite um numero: ");
            num = float.Parse(Console.ReadLine());
            if (num > 80)
            {
                Console.WriteLine("Numero é maior que 80");
            }
            if (num < 25)
            {
                Console.WriteLine("Numero é menor que 25");
            }
            if (num == 40)
            {
                Console.WriteLine("Numero é igual a 40");
            }
            Console.ReadKey();
        }
    }
}

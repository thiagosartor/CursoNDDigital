using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIDADE_III
{
    class _02_Comparação
    {
        static void Main1(string[] args)
        {
            float num1, num2;
            Console.WriteLine("Digite o primeiro valor: ");
            num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor: ");
            num2 = float.Parse(Console.ReadLine());
            if (num1 == num2)
            {
                Console.WriteLine("Iguais");
            }
            else if(num1 > num2){
                Console.WriteLine("O primeiro é maior");
            }
            else
            {
                Console.WriteLine("O segundo é maior");
            }
            Console.ReadKey();

        }

    }
}

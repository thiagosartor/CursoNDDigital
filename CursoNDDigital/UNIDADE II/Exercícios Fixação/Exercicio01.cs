using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIDADE_II
{
    class Exercicio_01
    {
        static void Main1(string[] args)
        {
            double n1, n2, result;
            Console.Write("Digite o primeiro numero: ");
            n1 = double.Parse(Console.ReadLine());
            Console.Write("Digite o segundo numero: ");
            n2 = double.Parse(Console.ReadLine());
            result = n1 + n2;
            Console.Write("Resultado (soma):  " + result);
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIDADE_II
{
    class Exercicio_02
    {
        static void Main2(string[] args)
        {
            double n1, n2;
            Console.Write("Digite o primeiro numero: ");
            n1 = double.Parse(Console.ReadLine());
            Console.Write("Digite o segundo numero: ");
            n2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Resultado:  ");
            Console.WriteLine("\tSoma: " + (n1 + n2));
            Console.WriteLine("\tSubtração: " + (n1 - n2));
            Console.WriteLine("\tMultiplicação: " + (n1 * n2));
            Console.WriteLine("\tDivisão: " + Math.Round((n1 / n2), 2));
            Console.ReadKey();
        }
    }
}

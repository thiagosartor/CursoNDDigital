using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIDADE_II
{
    class Exercicio_06
    {
        static void Main6(string[] args)
        {
            double a, b, aux;
            Console.Write("Digite o valor de a: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor de b: ");
            b = double.Parse(Console.ReadLine());
            aux = a;
            a = b;
            b = aux;
            Console.WriteLine("==== Resultado ====");
            Console.WriteLine("Valor de A e B: " + a + " " + b);
            Console.ReadKey();
        }
    }
}

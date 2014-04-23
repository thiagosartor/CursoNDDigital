using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIDADE_II
{
    class Exercicio02
    {
        static void Main2(string[] args)
        {
            double bas, alt;
            Console.Write(("Digite a base: "));
            bas = double.Parse(Console.ReadLine());
            Console.Write(("Digite a altura: "));
            alt = double.Parse(Console.ReadLine());
            Console.Write("Area: " + (bas * alt));
            Console.ReadKey();
        }
    }
}

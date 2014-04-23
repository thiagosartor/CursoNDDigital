using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIDADE_II
{
    class Exercicio11
    {
        static void Main11(string[] args)
        {
            double precoCusto, valorRenda, percentAcresc;
            Console.WriteLine("Digite o preço de custo: ");
            precoCusto = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o percentual (%): ");
            percentAcresc = double.Parse(Console.ReadLine());
            valorRenda = precoCusto + (precoCusto * (percentAcresc / 100));
            Console.WriteLine("Valor da renda: ", valorRenda);
            Console.ReadKey();
        }
    }
}

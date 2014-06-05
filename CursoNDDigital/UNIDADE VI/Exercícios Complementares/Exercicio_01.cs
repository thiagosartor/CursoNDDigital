using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIDADE_VI.Exercícios_Complementares
{
    class Exercicio_01
    {
        static void Main1(string[] args)
        {
            Console.Write("Digite o numero de maças compradas: ");
            int numMaca = Convert.ToInt32(Console.ReadLine());
            double total, taxa;
            if (numMaca >= 12)
            {
                taxa = 0.25;
            }
            else
            {
                taxa = 0.30;
            }
            total = taxa * numMaca;
            Console.WriteLine("Custo de cada maça: {0}\nTotal é: {1:F2}", taxa, total);
            Console.ReadKey();
        }
    }
}

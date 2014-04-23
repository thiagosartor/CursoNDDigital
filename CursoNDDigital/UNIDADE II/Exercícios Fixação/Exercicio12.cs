using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIDADE_II
{
    class Exercicio12
    {
        static void Main12(string[] args)
        {
            double custoFabrica, custoTotal;
            Console.Write("Digite o custo de fábrica: ");
            custoFabrica = double.Parse(Console.ReadLine());
            //  Acréscimo de Imposto
            custoTotal = custoFabrica + (custoFabrica * 0.45);
            // Acrécimo de Distribuidor
            custoTotal = custoTotal + (custoTotal * 0.28);
            Console.WriteLine("Custo total (R$): " + custoTotal);
            Console.ReadKey();
        }
    }
}

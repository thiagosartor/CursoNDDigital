using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIDADE_II
{
    class Exercicio_03
    {
        static void Main3(string[] args)
        {
            double distancia, totalCombustivel;
            Console.Write("Digite a distancia: ");
            distancia = double.Parse(Console.ReadLine());
            Console.Write("Digite o total de combustível: ");
            totalCombustivel = double.Parse(Console.ReadLine());
            String result = (distancia / totalCombustivel).ToString("#0.0");
            Console.WriteLine("\nConsumo Médio: " + result);
            Console.ReadKey();
        }
    }
}

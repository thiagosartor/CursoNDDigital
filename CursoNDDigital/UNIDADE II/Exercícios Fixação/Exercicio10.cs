using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIDADE_II
{
    class Exercicio_10
    {
        static void Main10(string[] args)
        {
            double valorCompra;
            Console.Write("Digite o valor da compra: ");
            valorCompra = double.Parse(Console.ReadLine());
            Console.WriteLine("Valor com juros: " + (valorCompra / 5));
            Console.ReadKey();
        }
    }
}

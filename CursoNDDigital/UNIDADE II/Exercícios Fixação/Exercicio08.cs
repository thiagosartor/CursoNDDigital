using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIDADE_II
{
    class Exercicio_08
    {
        static void Main8(string[] args)
        {
            double valorDolar, valorReal, cotacao;
            Console.WriteLine("Digite a cotacao: ");
            cotacao = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor em dólar (US$): ");
            valorDolar = double.Parse(Console.ReadLine());
            valorReal = (valorDolar * cotacao);
            Console.WriteLine("Valor convertido(R$): " + valorReal);
            Console.ReadKey();
        }
    }
}

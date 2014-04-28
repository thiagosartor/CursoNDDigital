using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIDADE_VI.Exercícios_Fixação
{
    class Exercicio10_Loja
    {
        static void Main10()
        {
            string[] nomes = new string[4];
            double[] precos = new double[4];
            double[] descontos = new double[4];
            double[] total = new double[4];
            for (int i = 0; i < nomes.Length; i++)
            {
                Console.Write("Digite o nome do artigo " + (i + 1) + ": ");
                nomes[i] = Console.ReadLine();
                Console.Write("Digite o preco de artigo: ");
                precos[i] = double.Parse(Console.ReadLine());
                Console.Write("Digite o desconto do artigo: ");
                descontos[i] = double.Parse(Console.ReadLine());
                total[i] = precos[i] - (precos[i] * (descontos[i] / 100));
                Console.WriteLine();
            }
            for (int i = 0; i < nomes.Length; i++)
            {

                Console.WriteLine("=== Artigo " + (i + 1) + " ======");
                Console.WriteLine("Nome: " + nomes[i]);
                Console.WriteLine("Preco: " + precos[i]);
                Console.WriteLine("Desconto: " + descontos[i] + "%");
                Console.WriteLine("TOTAL: " + total[i]);
                Console.WriteLine("\n");
            }
            Console.ReadKey();
        }
    }
}

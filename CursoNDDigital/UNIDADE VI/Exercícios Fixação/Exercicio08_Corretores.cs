using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIDADE_VI.Exercícios_Fixação
{
    class Exercicio08_Corretores
    {
        static void Main() 
        {
            string[] nome = new string[3];
            double[] venda = new double[3];
            double[] comissao = new double[3];
            double[] totalVendas = new double[3];
            double soma = 0;

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Digite o nome do corretor:");
                nome[i] = Console.ReadLine();
                Console.WriteLine("Digite o valor de venda:");
                venda[i] = Convert.ToDouble(Console.ReadLine());
            }

            for (int i = 0; i < 3; i++)
            {
                soma += venda[i];
                if (venda[i] > 50000)
                {
                    comissao[i] = venda[i] * 0.12;
                }
                if (venda[i] >= 30000 && venda[i] <= 50000)
                {
                    comissao[i] = venda[i] * 0.095;
                }
                else
                {
                    comissao[i] = venda[i] * 0.07;
                }
            }
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Corretor: " + nome[i]);
                Console.WriteLine("Comissão: " + comissao[i]);
                Console.WriteLine("Total de venda: " + venda[i]);
            }
            Console.WriteLine(soma);
        }
    }
}

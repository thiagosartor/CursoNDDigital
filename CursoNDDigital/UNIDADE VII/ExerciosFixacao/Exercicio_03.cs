using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIDADE_VII.ExerciosFixacao
{
    class Exercicio_03
    {
        static void Main1(string[] args)
        {
            Console.Write("Digite o numero total de mercadorias: ");
            int qtdMercadoria = int.Parse(Console.ReadLine());
            double totalMercadoria = 0;
            for (int i = 0; i < qtdMercadoria; i++)
            {
                Console.WriteLine("Digite o valor da mercadoria {0}: ", i + 1);
                totalMercadoria += double.Parse(Console.ReadLine());
                Console.WriteLine();
            }
            Console.WriteLine("\n===== Resultado =====\n");
            Console.WriteLine("Valor total: R$ {0}", totalMercadoria);
            Console.WriteLine("Média de valor: R$ {0}", totalMercadoria / qtdMercadoria);
            Console.ReadKey();
        }
    }
}

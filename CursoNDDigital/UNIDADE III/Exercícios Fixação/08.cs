using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIDADE_III
{
    class _08
    {
        static void Main1(string[] args)
        {
            float valorTotal, valorCarro, ano, desc;
            int cont2000 = 0, contGeral = 0;
            string op;
            Console.WriteLine("====== CARANGO VELHO ======");
            do
            {
                Console.Write("Digite o ano do carro: ");
                ano = float.Parse(Console.ReadLine());
                Console.Write("Digite o valor do carro: ");
                valorCarro = float.Parse(Console.ReadLine());
                if (ano <= 2000)
                {
                    desc = 0.12f;
                    cont2000++;
                }
                else
                {
                    desc = 0.07f;
                }
                valorTotal = valorCarro - (valorCarro * desc);
                Console.WriteLine("Valor com desconto de " + (desc * 100), "% : " + valorTotal);
                contGeral++;
                Console.Write("Continuar calculando desconto ?(S ou N): ");
                op = Console.ReadLine();
            } while (op == "N");
            Console.WriteLine();
            Console.WriteLine("Total de carros até 2000: " + cont2000);
            Console.WriteLine("Total de carros: " + contGeral);
            Console.ReadKey();
        }
    }
}

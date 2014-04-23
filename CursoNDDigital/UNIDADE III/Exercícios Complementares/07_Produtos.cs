using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UNIDADE_III
{
    class _07_Produtos
    {
        static void Main1(string[] args)
        {
            int cod, qtd;
            double total = 0;
            Console.Write("Digite o codigo do lanche: ");
            cod = int.Parse(Console.ReadLine());
            Console.Write("Digite a quantidade: ");
            qtd = int.Parse(Console.ReadLine());
            switch (cod)
            {
                case 100:
                case 103:
                    total = 1.10 * qtd;
                    break;
                case 105:
                    total = 1.00 * qtd;
                    break;
                case 101:
                case 104:
                    total = 1.30 * qtd;
                    break;
                case 102:
                    total = 1.50 * qtd;
                    break;
                default:
                    Console.WriteLine("Opcao Inválida !!");
                    break;
            }
            Console.WriteLine("Total: " + total);
            Console.ReadKey();
        }

    }
}

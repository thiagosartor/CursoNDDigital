using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIDADE_III
{
    class _10_Preco
    {
        static void Main1(string[] args){
            float precoCusto, precoVenda, totalCusto = 0, totalVenda = 0;
            int numProduto = 40;   // Numero de produtos (40)
            for (int i = 0; i < numProduto; i++)
            {
                Console.WriteLine("=== Produto" +  i + " ===");
                Console.Write("Digite o preço de custo: ");
                precoCusto = float.Parse(Console.ReadLine());
                Console.Write("Digite o preço de venda: ");
                precoVenda = float.Parse(Console.ReadLine());
                if (precoCusto < precoVenda)
                {
                    Console.WriteLine("Resultado: Prejuízo");
                }
                if (precoCusto > precoVenda)
                {
                    Console.WriteLine("Resultado: Prejuízo");
                }
                if (precoCusto == precoVenda)
                {
                    Console.WriteLine("Resultado: Empate");
                }
                totalCusto += precoCusto;
                totalVenda += precoVenda;
                Console.WriteLine();
            }
            Console.WriteLine("Média do preço de custo: " + (totalCusto / numProduto).ToString("#0.00"));
            Console.WriteLine("Média do preço de venda: " + (totalVenda / numProduto).ToString("#0.00"));
            Console.ReadKey();
        }
        
    }
}

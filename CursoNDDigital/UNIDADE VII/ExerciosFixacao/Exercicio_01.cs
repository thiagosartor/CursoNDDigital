using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIDADE_VII.ExerciosFixacao
{
    class Exercicio_01
    {
        static void Main1(string[] args)
        {
            int qtdProdutos = 2; // 15 produtos
            int  maiorCodigo = 0, codigo = 0;
            double maiorPreco = 0, somaProdutos = 0, preco = 0;
            for (int i = 0; i < qtdProdutos; i++)
            {
                Console.WriteLine("\n==== PRODUTO {0} ====", i +1);
                Console.Write("Digite o codigo: ");
                codigo = int.Parse(Console.ReadLine());
                Console.Write("Digite o preco: ");
                preco = double.Parse(Console.ReadLine());
                if (preco > maiorPreco)
                {
                    maiorPreco = preco;
                    maiorCodigo = codigo;
                }
                somaProdutos += preco; 
            }
            double media = somaProdutos / qtdProdutos;
            Console.WriteLine("\n==== RESULTADO =====");
            Console.WriteLine("Codigo do produto de maior preco: {0}", maiorCodigo);
            Console.WriteLine("Maior preco: {0}", maiorPreco);
            Console.WriteLine("Média: {0}", media);
            Console.ReadKey();
        }
    }
}

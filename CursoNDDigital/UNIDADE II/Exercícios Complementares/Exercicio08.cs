using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIDADE_II
{
    class Exercicio08
    {
        static void Main8(string[] args)
        {
            float qtdAtual, qtdMax, qtdMin, qtdMedia;
            Console.Write("Digite a quantidade atual: ");
            qtdAtual = float.Parse(Console.ReadLine());
            Console.Write("Digite a quantidade maxima: ");
            qtdMax = float.Parse(Console.ReadLine());
            Console.Write("Digite a quantidade minima: ");
            qtdMin = float.Parse(Console.ReadLine());
            qtdMedia = (qtdMax + qtdMin) / 2;
            Console.Write("Quantidade Média: " + qtdMedia);
            if (qtdAtual >= qtdMedia)
            {
                Console.WriteLine("   (Não Efetuar Compra)");
            }
            else
            {
                Console.WriteLine("  (Efetuar Compra)");
            }
            Console.ReadKey();
        }
    }
}

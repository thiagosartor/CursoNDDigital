using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MendindoAFebreV
{
    class Questao08
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a descricao do produto: ");
            string descricao = Console.ReadLine();
            Console.Write("Digite a quantidade adquirida: ");
            int qtd = int.Parse(Console.ReadLine());
            Console.Write("Digite o preco unitario: ");
            double preco = double.Parse(Console.ReadLine());
            double total = (double)qtd * preco;
            int desconto = 0;
            if (qtd > 10)
            {
                desconto = 5;
            }
            else if (qtd > 5)
            {
                desconto = 3;
            }
            else
            {
                desconto = 2;
            }
            double percent = total * (desconto / (double)100);
            double totalPagar = total - percent;
            Console.WriteLine("\n==== RESULTADO ====");
            Console.WriteLine("Total: R${0:F2}", total);
            Console.WriteLine("Desconto: {0}% (R$ {1:F2})", desconto, percent);
            Console.WriteLine("Total a Pagar: {0:F2}", totalPagar);
            Console.ReadKey();

        }
    }
}

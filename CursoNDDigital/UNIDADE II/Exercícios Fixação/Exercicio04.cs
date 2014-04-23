using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIDADE_II
{
    class Exercicio_04
    {
        static void Main4(string[] args)
        {
            string nome;
            double salario, totalVendas, totalSalario;
            Console.Write("Digite o nome: ");
            nome = Console.ReadLine();
            Console.Write("Digite o salario fixo: ");
            salario = double.Parse(Console.ReadLine());
            Console.Write("Digite o total vendas: ");
            totalVendas = double.Parse(Console.ReadLine());
            totalSalario = salario + (totalVendas * 0.15);
            Console.WriteLine("\n====== Resultado ======");
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Salario Fixo: " + salario);
            Console.WriteLine("Salario Líquido: " + totalSalario.ToString("#0.00"));
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIDADE_IV.Exercícios_Fixação
{
    class Exe7
    {
        public static void Main (string[] args)
        {
            int salario_minimo = 750;
            double comissao = 0.05;
            double salario_total;
            string nome;
            double valor_ganho;
            int quant_carros_vendidos;
            

            Console.WriteLine("Digite o seu nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("Quantos carros "+nome+" vendeu?");
            quant_carros_vendidos = int.Parse(Console.ReadLine());
            valor_ganho = (150 * quant_carros_vendidos);
            salario_total = (valor_ganho * comissao) + (salario_minimo * 2) + valor_ganho;
            Console.WriteLine("Nome: "+nome+". Salário total: R$ "+salario_total);
            Console.ReadKey();

        }
    }
}

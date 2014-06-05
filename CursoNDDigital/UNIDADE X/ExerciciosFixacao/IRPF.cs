using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIDADE_X.ExerciciosFixacao.ExerciciosFixacao
{
    class IRPF
    {
        static void Main1(string[] args)
        {
            bool aposentado = false;

            Console.WriteLine("====== Calculadora de IRPF ======");
            Console.Write("Digite o rendimento: ");
            double rendimento = double.Parse(Console.ReadLine());
            Console.Write("Digite os gastos com INSS: ");
            double inss = double.Parse(Console.ReadLine());
            Console.Write("Digite os gastos com pensão alimentcia: ");
            double pensao = double.Parse(Console.ReadLine());
            Console.Write("Digite o nº de dependentes: ");
            int numDependente = int.Parse(Console.ReadLine());
            Console.Write("É aposentado ou pensionista com mais de 65 anos  (s/n): ");
            string op = Console.ReadLine();
            if (op == "s")
                aposentado = true;
            calculaValorRetido(rendimento, inss, pensao, numDependente, aposentado);
            Console.ReadKey();
        }

        static void calculaValorRetido(double rendimento, double inss, double pensao, int numDependente, bool aposent)
        {
            double baseCalculo = rendimento;
            baseCalculo -= (inss + pensao + (numDependente * 179.71));
            if (aposent)
            {
                baseCalculo -= 1787.77;
            }
            Console.WriteLine("\n\n\tValor à ser retido na fonte: {0:F2}", defineDeducao(baseCalculo));

        }

        static double defineDeducao(double baseCalculo)
        {
            if (baseCalculo <= 1787.77)
            {
                return 0;
            }
            else if (baseCalculo <= 2679.29)
            {
                return baseCalculo * (7.5 / 100) - 134.08;
            }
            else if (baseCalculo <= 3572.43)
            {
                return baseCalculo * (15 / 100) - 335.03;
            }
            else if (baseCalculo <= 4463.81)
            {
                return baseCalculo * (22.5 / 100) - 602.96;
            }
            else
            {
                return baseCalculo * (27.5 / 100) - 826.15;
            }
        }


    }
}

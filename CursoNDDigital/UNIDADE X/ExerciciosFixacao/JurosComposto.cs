using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIDADE_X.ExerciciosFixacao.ExerciciosFixacao
{
    class JurosComposto
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("===== Calculadora de Juros compostos ======");
           
            Console.Write("Digite o montante: ");
            double montante = double.Parse(Console.ReadLine());

            Console.Write("Digite a taxa: ");
            double taxa = double.Parse(Console.ReadLine());

            Console.Write("Digite o tempo: ");
            double tempo = double.Parse(Console.ReadLine());

            double result = CalculaJuroComposto(montante, taxa, tempo);
            Console.WriteLine("\nMontante com Juro: {0:F2}", result);
            Console.WriteLine("Juro: {0:F2}", result - montante);
            Console.WriteLine();
            Console.ReadKey();

        }


        static double CalculaJuroComposto(double montante, double taxa, double tempo)
        {
            taxa = (double)taxa / 100;
            double x = Math.Pow((1 + taxa), tempo) ;
            return montante * x;
        }

    }
}

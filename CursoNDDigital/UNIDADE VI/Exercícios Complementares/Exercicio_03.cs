using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIDADE_VI.Exercícios_Complementares
{
    class Exercicio_03
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("==== Calculadora de Peso Ideal =====");
            Console.Write("Digite o sexo: ");
            int sexo = int.Parse(Console.ReadLine());
            Console.Write("Digite a altura: ");
            double altura = double.Parse(Console.ReadLine());
            double pesoIdeal = 0;
            switch (sexo)
            {
                case 1:
                    pesoIdeal = (62.1 * altura) - 44.7;
                    break;
                case 2:
                    pesoIdeal = (72.7 * altura) - 58;
                    break;
                default:
                    Console.WriteLine("Sexo Inválido !!");
                    break;
            }
            Console.WriteLine("Peso Ideal: {0:F2}", pesoIdeal);
            Console.ReadLine();
        }
    }
}

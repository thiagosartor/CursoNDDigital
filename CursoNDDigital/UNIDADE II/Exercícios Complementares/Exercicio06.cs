using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIDADE_II
{
    class Exercicio06
    {
        static void Main6(string[] args)
        {
            double numHoras, salarioHora, total, horaExtraValor;
            Console.Write("Digite o salario por hora (R$): ");
            salarioHora = double.Parse(Console.ReadLine());
            Console.Write("Digite o numero de horas trabalhadas: ");
            numHoras = double.Parse(Console.ReadLine());
            if (numHoras > 160)
            {
                horaExtraValor = (salarioHora * 0.5) + salarioHora;
                total = (160 * salarioHora) + (horaExtraValor * (numHoras - 160));
            }
            else
            {
                total = numHoras * salarioHora;
            }

            Console.WriteLine("Valor total do salario: " + total);
            Console.ReadKey();
        }
    }
}

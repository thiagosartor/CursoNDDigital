using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIDADE_VII.ExerciosFixacao
{
    class Exercicio_02
    {
        static void Main1(string[] args)
        {
            double salario = 0, maiorSalario = 0, somaSalario = 0, contSalarioMenor = 0;
            int numTotalFilhos = 0, numPessoas = 0;
            while (true)
            {
                Console.Write("Digite o salario do habitante (negativo p/ sair): ");
                salario = double.Parse(Console.ReadLine());
                if (salario < 0)
                    break;
                Console.Write("Digite o numero de filhos: ");
                numTotalFilhos += int.Parse(Console.ReadLine());
                if (maiorSalario < salario)
                {
                    maiorSalario = salario;
                }
                if (salario < 150)
                {
                    contSalarioMenor++;
                }
                somaSalario += salario;
                numPessoas++;
                Console.WriteLine("\n");
            }
            Console.WriteLine("\n==== RESULTADO =====\n");
            double mediaSalario = somaSalario / numPessoas;
            Console.WriteLine("Media salario da população: R$ {0:F2}", mediaSalario);
            Console.WriteLine("Media de numero de filhos: {0}", numTotalFilhos / numPessoas );
            Console.WriteLine("Maior salario dos habitantes: R$ {0:F2}", maiorSalario);
            double percenAbaixo = ((double)contSalarioMenor / (double) numPessoas) * 100;
            Console.WriteLine("Percentual de pessoas com salario abaixo de R$ 150: {0:F2}%", percenAbaixo);
            Console.ReadKey();
        }
    }
}

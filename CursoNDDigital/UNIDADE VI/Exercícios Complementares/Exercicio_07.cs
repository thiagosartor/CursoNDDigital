using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIDADE_VI.Exercícios_Complementares
{
    class Exercicio_07
    {
        static void Main1(string[] args)
        {
            double salBruto = 0;
            double salarioHora = 0, salarioMes = 0, salarioDia = 0;
            int numHora, numFalta;
            Console.WriteLine("=== Calculadora de Salario Bruto ====");
            Console.Write("H - Horista \nM - Mensalista\n");
            Console.Write("\nDigite o tipo de funcionario: ");
            string op = Console.ReadLine();
            op = op.ToUpper();
            switch (op)
            {
                case "H": // Horista
                    Console.Write("\nDigite o salario por hora: ");
                    salarioHora = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Digite o numero de horas trabalhadas: ");
                    numHora = Convert.ToInt32(Console.ReadLine());
                    salBruto = numHora * salarioHora;
                    Console.WriteLine("==== Resultado Horista =====");
                    break;
                case "M":     // Mensalista              
                    Console.Write("\nDigite o salario por mes: ");
                    salarioMes = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Digite o numero faltas (em dias): ");
                    numFalta = Convert.ToInt32(Console.ReadLine());

                    salarioDia = (double) salarioMes / 30; // Salario por dia
                    salBruto = salarioMes - (salarioDia * numFalta); // Fórmula: salario do mes - (salarioPorDia * numFaltas)

                    Console.WriteLine("\n=== Resultado Mensalista =====");
                    Console.WriteLine("Salario por dia: {0:F2}", salarioDia);
                    Console.WriteLine("Numero de Faltas: {0}", numFalta);
                    break;
                default:
                    Console.WriteLine("Opção Invalida !!");
                    break;
            }
            Console.WriteLine("\nSalario Bruto: R${0:F2}", salBruto);
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UNIDADE_III
{
    class _09_Salario
    {
        static void Main1(string[] args)
        {
            string nome, categoria;
            double salario, percent;

            Console.Write("Digite o nome: ");
            nome = Console.ReadLine();
            Console.Write("Digite o salario: ");
            salario = double.Parse(Console.ReadLine());
            Console.Write("Digite a categoria: ");
            categoria = Console.ReadLine();
            switch (categoria)
            {
                case "A":
                case "C":
                case "F":
                case "H":
                    percent = 0.1;   // 10%
                    break;
                case "B":
                case "D":
                case "E":
                case "I":
                case "J":
                case "T":
                    percent = 0.15;    // 15%
                    break;
                case "K":
                case "R":
                    percent = 0.25;     // 25%
                    break;
                case "L":
                case "M":
                case "N":
                case "O":
                case "P":
                case "Q":
                case "S":
                    percent = 0.35; // 35%
                    break;
                case "U":
                case "V":
                case "X":
                case "Y":
                case "W":
                case "Z":
                    percent = 0.5;    // 50 %
                    break;
                default:
                    Console.WriteLine("Categoria Inválida !!");
                    percent = 0;
                    break;
            }
            salario += (salario * percent);   // Salario fixo + percentual
            Console.WriteLine("=== Resultado ===");
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Salario com aumento de " + (percent * 100) + " %: " + salario);
            Console.ReadKey();
        }
    }
}

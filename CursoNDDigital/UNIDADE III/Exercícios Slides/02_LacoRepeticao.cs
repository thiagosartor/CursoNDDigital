using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIDADE_III
{
    class LacoRepeticao
    {
        static void Main1(string[] args)
        {
            string time;
            Console.Write("Digite o nome de um time de futebol: ");
            time = Console.ReadLine();
            switch (time)
            {
                case "Flamengo":
                case "Fluminense":
                case "Vasco":
                case "Botafogo":
                    Console.Write("É um time carioca");
                    break;
                case "São paulo":
                case "Palmeiras":
                case "Santos":
                case "Corinthias":
                    Console.Write("É um time paulista");
                    break;
                case "Internacional":
                case "Gremio":
                    Console.Write("É um time gaúcho.");
                    break;
                case "Inter de Lages":
                    Console.Write("É o time de LAGES(Leão Baio).");
                    break;
                default:
                    Console.Write(" É de outro estado");
                    break;
            }
            Console.ReadKey();
        }
    }
}


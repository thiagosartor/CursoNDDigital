using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIDADE_III
{
    class _07_Sexo
    {
        static void Main1(string[] args)
        {
            string nome, sexo;
            int contH = 0, contM = 0;
            for (int i = 0; i < 56; i++)
            {
                Console.Write("Digite o nome: ");
                nome = Console.ReadLine();
                Console.Write("Digite o sexo (M ou F): ");
                sexo = Console.ReadLine();
                switch (sexo)
                {
                    case "M":
                    case "m":
                        contH++;
                        break;
                    case "F":
                    case "feminino":
                        contM++;
                        break;
                    default:
                        Console.WriteLine("Sexo Inválido !!");
                        break;
                }
                Console.WriteLine("Total de Mulheres: "+ contM);
                Console.WriteLine("Total de Homens: " + contH);
                Console.ReadKey();
            }
        }
    }
}

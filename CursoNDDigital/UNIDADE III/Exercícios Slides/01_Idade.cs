using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIDADE_III
{
    class Idade
    {
        static void Main1(string[] args)
        {
            int idade;
            Console.Write("Digite a idade: ");
            idade = int.Parse(Console.ReadLine());
            if (idade <= 14) {
                    Console.WriteLine("criança");
            } else {
                if (idade >= 15 && idade <= 19) {
                    Console.WriteLine("adolescente");
                } else {
                    Console.WriteLine("Adulto");
                }
            }
            Console.ReadKey();

        }
    }
}

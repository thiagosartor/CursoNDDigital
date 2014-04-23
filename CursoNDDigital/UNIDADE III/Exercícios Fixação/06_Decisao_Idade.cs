using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIDADE_III
{
    class _06_Decisao_Idade
    {
        
        static void Main1(string[] args)
        {
            int idade;
            Console.WriteLine("Digite a idade: ");
            idade = int.Parse(Console.ReadLine());
            if (idade > 18)
            {
                Console.WriteLine("Maior de idade");
            }
            else
            {
                Console.WriteLine("Menor de idade");
            }
            Console.ReadKey();
        }
    }
}

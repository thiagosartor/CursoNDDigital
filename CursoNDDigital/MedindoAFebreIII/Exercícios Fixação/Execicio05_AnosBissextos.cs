using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedindoAFebreIII.Exercícios_Fixação
{
    class Exe5__Anos_Bissextos
    {
        public static void Maini(string[] args)
        {
            Console.WriteLine("Digite um ano: ");
            int ano = int.Parse(Console.ReadLine());
            if (ano % 4 == 0 && ano % 100 != 0 || ano % 400 == 0)
            {
                Console.WriteLine("Este ano é bissexto!");
            }
            else
            {
                Console.WriteLine("Este ano não é bissexto!");
            }
            Console.ReadKey();
        }
    }
}

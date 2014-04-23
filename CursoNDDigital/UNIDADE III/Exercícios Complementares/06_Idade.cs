using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UNIDADE_III
{
    class _06_Idade
    {
        static void Main1(string[] args)
        {
            int idade;
            Console.Write("Digite a idade: ");
            idade = int.Parse(Console.ReadLine());
            if (idade > 25 || idade < 5)
            {
                Console.WriteLine("Idade fora do limite de 25 ate 5 anos !!");
            }
            else
            {
                Console.WriteLine("Categoria do nadador: " + definirCategoria(idade));
            }
            Console.ReadKey();
        }

        static string definirCategoria(int idade)
        {
            if (idade >= 18)
            {
                return "Senior";
            }
            else if (idade >= 14)
            {
                return "Juvenil B";
            }
            else if (idade >= 11)
            {
                return "Juvenil A";
            }
            else if (idade >= 8)
            {
                return "Infantil B";
            }
            else
            {
                return "Infantil A";
            }
        }



    }
}

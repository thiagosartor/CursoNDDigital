using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIDADE_III
{
    class _04_Media
    {
        static void Main1(string[] args)
        {
            string nome;
            float n1, n2, n3, media;
            Console.WriteLine("Digite o nome: ");
            nome = Console.ReadLine();
            Console.Write("Digite a nota 1: ");
            n1 = float.Parse(Console.ReadLine());
            Console.Write("Digite a nota 2: ");
            n2 = float.Parse(Console.ReadLine());
            Console.Write("Digite a nota 3: ");
            n3 = float.Parse(Console.ReadLine());
            media = (n1 + n2 + n3) / 3;
            Console.WriteLine("Media: " + media.ToString("#0.00"));
            if (media >= 7)
            {
                Console.WriteLine("Aprovado !!");
            }
            else if (media >= 5.1)
            {
                Console.WriteLine("Em recuperação");
            }
            else
            {
                Console.WriteLine("Reprovado !!");
            }
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UNIDADE_III
{
    class Desafio
    {
        static void Main1(string[] args)
        {
 
            int num;
            double n1, n2, n3, mediaEx, mediaAp;
            Console.WriteLine("Digite o numero do aluno: ");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a nota 1: ");
            n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a nota 2: ");
            n2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a nota 3: ");
            n3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a media dos exercícios: ");
            mediaEx = double.Parse(Console.ReadLine());
            mediaAp = (n1 + n2 + n3 + mediaEx) / 4;
            if (mediaAp >= 9)
            {
                Console.WriteLine("Conceito A - Aprovado");
            }
            else if ((mediaAp >= 7.5 && mediaAp < 9))
            {
                Console.WriteLine("Conceito B - Aprovado");
            }
            else if ((mediaAp >= 6 && mediaAp < 7.5))
            {
                Console.WriteLine("Conceito C - Aprovado");
            }
            else if ((mediaAp >= 4 && mediaAp > 6))
            {
                Console.WriteLine("Conceito D - Reprovado");
            }
            else if (mediaAp < 4)
            {
                Console.WriteLine("Conceito E - Reprovado");
            }
            Console.ReadKey();
        }
    }
}

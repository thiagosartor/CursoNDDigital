using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UNIDADE_III
{
    class _10_Triangulo
    {
        static void Main1(string[] args)
        {
            int x, y, z;
            Console.Write("Digite o x: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Digite o y: ");
            y = int.Parse(Console.ReadLine());
            Console.Write("Digite o z: ");
            z = int.Parse(Console.ReadLine());
            if ((x >= (y + z)) || (y >= (x + z)) || (z >= (x + y)))
            {
                Console.WriteLine("Não é um triângulo");
            }
            else if (x == y && x == z)
            {
                Console.WriteLine("Triângulo equilátero");
            }
            else if ((x == y) || (x == z) || (y == z))
            {
                Console.WriteLine("Triângulo isósceles");
            }
            else
            {
                Console.WriteLine("Triângulo escaleno");
            }
            Console.ReadKey();
        }
    }
}

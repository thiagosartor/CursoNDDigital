using System;

namespace UNIDADE_III
{
    internal class _14_ABC
    {
        public static float a, b, c, maior, menor, medio;
        public static int i;

        private static void Main1(string[] args)
        {
            Console.WriteLine("Digite o valor de i: ");
            i = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de a: ");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de b: ");
            b = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de c: ");
            c = float.Parse(Console.ReadLine());
            if (!verificarIgualdade())
            {
                definirSequencia();
            }
            switch (i)
            {
                case 1:
                    Console.WriteLine("Ordem crescente: " + " " + menor + " " + medio + " " + maior);
                    break;

                case 2:
                    Console.WriteLine("Ordem decrescente: " + maior + " " + medio + " " + menor);
                    break;

                case 3:
                    Console.WriteLine("Ordem crescente: " + menor + " " + maior + " " + medio);
                    break;

                default:
                    break;
            }
            Console.ReadKey();
        }

        public static void definirSequencia()
        {
            // A
            if (a > b && a > c)
            {
                maior = a;
            }
            else if (a > b || a > c)
            {
                medio = a;
            }
            else
            {
                menor = a;
            }
            // B
            if (b > a && b > c)
            {
                maior = b;
            }
            else if (b > a || b > c)
            {
                medio = b;
            }
            else
            {
                menor = b;
            }
            // C
            if (c > a && c > b)
            {
                maior = c;
            }
            else if (c > a || c > b)
            {
                medio = c;
            }
            else
            {
                menor = c;
            }
        }

        public static bool verificarIgualdade()
        {
            if ((a == b || a == c || b == c))
            {
                maior = a;
                menor = a;
                medio = a;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
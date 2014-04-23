using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UNIDADE_III
{
    class _02
    {
        public static int potenciaP = 1, potencia = 1, expoente, bas;

        static void Main1(string[] args)
        {
            Console.Write("Digite o expoente: ");
            expoente = int.Parse(Console.ReadLine());
            Console.Write("Digite a base: ");
            bas = int.Parse(Console.ReadLine());
            potenciacaoComParametro(expoente, bas);
            potenciacao();
            Console.WriteLine("Potenciação com parametro: " + potenciaP);
            Console.WriteLine("Potenciação: " + potencia);
            Console.ReadKey();
        }

        public static void potenciacaoComParametro(int expo, int bas)
        {
            for (int i = 1; i < expo; i++)
            {
                potenciaP = potenciaP * bas;
            }
        }

        public static void potenciacao()
        {
            for (int i = 0; i < expoente; i++)
            {
                potencia = potencia * bas;
            }
        }



    }
}

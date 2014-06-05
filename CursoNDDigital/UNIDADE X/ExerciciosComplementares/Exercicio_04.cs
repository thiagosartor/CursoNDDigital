using System;

namespace UNIDADE_X.ExerciciosFixacao.ExerciciosComplementares
{
    internal class Exercicio_04
    {
        private static void Main1(string[] args)
        {
            Console.Write("Digite um numero: ");
            int num = int.Parse(Console.ReadLine());
            Console.Clear();
            tabuada(num);
            Console.ReadKey();
        }
        private static void tabuada(int num)
        {
            Console.WriteLine("==== TABUADA ======");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} x {1} : {2}", i, num, i * num);
            }
            Console.WriteLine();
        }
    }
}
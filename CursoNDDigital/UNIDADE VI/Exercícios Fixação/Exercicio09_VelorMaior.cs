using System;

namespace UNIDADE_VI.Exercícios_Fixação
{
    internal class Exercicio09_VelorMaior
    {

        public static void Main9(String[] args)
        {
            double A, B, C;
            Console.WriteLine("Valor de A: ");
            A = double.Parse(Console.ReadLine());
            Console.WriteLine("Valor de B: ");
            B = double.Parse(Console.ReadLine());
            Console.WriteLine("Valor de C: ");
            C = double.Parse(Console.ReadLine());

            if ((A + B) > C)
            {
                Console.WriteLine("Soma de A: " + A + " com B: " + B + " é maior que C: " + C);
            }
            if ((A + B) == C)
            {
                Console.WriteLine("Soma de A: " + A + " com B: " + B + " é igual a C: " + C);
            }
            if ((A + B) < C)
            {
                Console.WriteLine("Soma de A: " + A + " com B: " + B + " é menor que C: " + C);
            }
            Console.ReadKey();
        }
    }
}
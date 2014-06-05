using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIDADE_VII.ExerciosFixacao
{
    class Exercicio_05
    {
        static int numEspaco = 0;
        static void Main(string[] args)
        {
            Console.Write("Digite um numero máximo ímpar: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine();
            bool valido = (num % 2) == 0 ?  false : escreveNumeros(1, num);
            if (!valido)
            {
                Console.WriteLine("Numero Invalido !!");
            }
            Console.ReadKey();
        }
        static bool escreveNumeros(int numMin, int numMax)
        {
            for (int i = 0; i < numEspaco; i++)
            {
                Console.Write(' ');
            }
            for (int i = numMin; i <= numMax; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            if (numMax != numMin)
            {
                numEspaco += 2;
                escreveNumeros(++numMin, --numMax);
            }
            return true;
        }
    }
}

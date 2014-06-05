using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIDADE_IX.ExerciciosComplementares
{
    class Exercicio_03
    {
        static void Main1(string[] args)
        {
            int[] numeros = new int[7];
            int menor = 0, indice = 0;
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write("Digite o {0}º valor: ", i + 1);
                numeros[i] = int.Parse(Console.ReadLine());
            }
            menor = numeros[0];
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] < menor)
                {
                    menor = numeros[i];
                    indice = i;
                }
            }
            Console.WriteLine("\n===== Resultado =====");
            Console.WriteLine("Menor número: {0} \nIndice: {1}", menor, indice);
            Console.ReadKey();
        }
    }
}

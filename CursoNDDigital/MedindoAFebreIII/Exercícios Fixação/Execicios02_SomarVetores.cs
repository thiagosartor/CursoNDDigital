using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedindoAFebreIII.Exercícios_Fixação
{
    class Exe2
    {
        public static void Maini(string[] args)
        {
            int[] vetorA = new int[11];
            int[] vetorB = new int[16];
            int[] vetorC = new int[16];
            int[] vetorD = new int[1];

            for (int i = 0; i < vetorB.Length; i++)
            {
                Console.WriteLine("Digite um valor para A: ");
                vetorA[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite um valor para B: ");
                vetorB[i] = int.Parse(Console.ReadLine());
                vetorC[i] = vetorA[i] + vetorB[i];
            }
            Console.Clear();

                for (int i = 0; i < vetorC.Length; i++)
			{
                Console.WriteLine(vetorC[i]);
                vetorD[0] = vetorC[i] + vetorD[0];
			}
            
                Console.WriteLine("Soma total: "+vetorD[0]);
                Console.ReadKey();
        }
    }
}

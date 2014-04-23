using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedindoAFebreIII.Exercícios_Fixação
{
    class Exe1
    {
        static void Maini(string[] args)
        {
            int[] vetorInteiro = new int[21];
            
            int countPos = 0;
            int countNeg = 0;
            int countZero = 0;

            for (int i = 0; i < vetorInteiro.Length; i++)
            {
                Console.WriteLine("Digite um valor: ");
                vetorInteiro[i] = int.Parse(Console.ReadLine());
                if (vetorInteiro[i] >= 1)
                {
                    countPos++;
                }
                if (vetorInteiro[i] == 0)
                {
                    countZero++;
                }
                if (vetorInteiro[i] < 0)
	            {
		            countNeg++;
	            }
            }
            Console.Clear();
            for (int i = 0; i < vetorInteiro.Length; i++)
            {
                if (vetorInteiro[i] > 0)
                {
                    Console.WriteLine(vetorInteiro[i]);
                }
            }
            Console.WriteLine("Quantidade de positivos: "+countPos);
            Console.WriteLine("Quantidade de negativos: "+countNeg);
            Console.WriteLine("Quantidade de zeros: "+countZero);
            
            Console.ReadKey();
        }
    }
}

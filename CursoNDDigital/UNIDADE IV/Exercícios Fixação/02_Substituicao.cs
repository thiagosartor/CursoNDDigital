using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UNIDADE_IV.Exercícios_Fixação
{
    class _02_Substituicao
    {
        static void Main1(string[] args)
        {
            int[] vet1 = new int[10];
            int[] vet2 = new int[10];
            for (int i = 0; i < vet1.Length; i++)
            {
                vet1[i] = int.Parse(Console.ReadLine());
                if (vet1[i] < 0)
                {
                    vet2[i] = 1;
                }
                else
                {
                    vet2[i] = vet1[i];
                }
            }

            for (int i = 0; i < vet1.Length; i++)
            {
                Console.Write(vet1[i] + " " + vet2[i]);
            }
            Console.ReadKey();
        }
    }
}

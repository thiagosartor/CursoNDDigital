using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UNIDADE_IV.Exercícios_Fixação
{
    class _05_Ordem
    {
        static void Main1(string[] args)
        {
            int cod;
            double[] vet = new double[50];
            for (int i = 0; i < vet.Length; i++)
            {
                vet[i] = int.Parse(Console.ReadLine());
            }
            do
            {
                Console.Write("Digite o código: ");
                cod =  int.Parse(Console.ReadLine());
                switch (cod)
                {
                    case 0:
                        Console.WriteLine("Encerrado !!");
                        break;
                    case 1:
                        Console.WriteLine("Ordem Direta: ");
                        for (int i = 0; i < vet.Length; i++)
                        {
                            Console.Write(vet[i]);
                        }
                        break;
                    case 2:
                         Console.WriteLine("Ordem inversa: ");
                        for (int i = vet.Length - 1; i < 0 ; i--)
                        {
                            Console.Write(vet[i]);
                        }
                        break;
                    default:
                        Console.WriteLine("Inválido !!");
                        break;
                }
            } while (cod == 0);
            Console.ReadKey();

        }
    }
}

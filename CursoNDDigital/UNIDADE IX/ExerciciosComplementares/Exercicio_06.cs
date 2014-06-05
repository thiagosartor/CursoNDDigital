using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIDADE_IX.ExerciciosComplementares
{
    class Exercicio_06
    {
        static void Main1(string[] args)
        {
            int[] clientes = new int[50];
            int[] promocao = new int[50];
            for (int i = 0; i < clientes.Length; i++)
            {
                Console.Write("Digite a quantidade de filme do cliente {0}: ",i + 1);
                clientes[i] = int.Parse(Console.ReadLine());
                promocao[i] = calculaPromocao(clientes[i]);
                Console.WriteLine("Quantidade de Dvd's: {0}", promocao[i]);
                Console.WriteLine("----------------------------------------\n");
            }
            Console.ReadKey();
        }

        static int calculaPromocao(int num)
        {
            int numDvd = 0;
            while (num >= 10)
            {
                numDvd++;
                num -= 10; 
            }
            return numDvd;
        }
    }
}

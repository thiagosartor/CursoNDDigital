using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIDADE_IX.ExerciciosComplementares
{
    class Exercicio_02
    {
        static void Main1(string[] args)
        {
            bool[,] estacionamento = new bool[4, 10];
            Random gerador = new Random();
            Console.WriteLine("Andares: \n 1  2  3  4\n");
            for (int vagas = 0; vagas < 10; vagas++)
            {
                for (int andar = 0; andar < 4; andar++)
                {
                    estacionamento[andar, vagas] = gerarValor(gerador);
                    if (estacionamento[andar, vagas])
                    {
                        Console.Write(" O ");
                    }
                    else
                    {
                        Console.Write(" V ");
                    }
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }

        static bool gerarValor(Random gerador)
        {
            int valor = gerador.Next(0, 2);
            if (valor > 0)
                return true;
            return false;
        }



    }
}

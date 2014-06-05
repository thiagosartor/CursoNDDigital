using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIDADE_IX.ExerciciosComplementares
{
    class Exercicio_05
    {
        static void Main1(string[] args)
        {
            Random gerador = new Random();
            char[] gabarito = new char[10];
            char[,] respostas = new char[2, 10];
            lerGabarito(ref gabarito);
            int numAcertos = 0;
            for (int aluno = 0; aluno < 2; aluno++)
            {
                Console.WriteLine("===== Aluno {0} ======", aluno + 1);
                for (int resposta = 0; resposta < 10; resposta++)
                {
                    Console.Write("Digite a resposta do aluno {0} na questao {1}: ", aluno + 1, resposta + 1);
                    respostas[aluno, resposta] = Console.ReadLine().ToUpper().ToCharArray()[0];

                    if (respostas[aluno, resposta].Equals(gabarito[resposta]))
                    {
                        ++numAcertos;
                    }

                }
                string msg = numAcertos >= 6 ? " APROVADO !!" : "REPROVADO";
                Console.WriteLine("Numero de acertos: {0} - " + msg, numAcertos);
                Console.WriteLine("-------------------------------------------------------------\n");
                numAcertos = 0;
            }
            Console.ReadKey();

        }


        static void lerGabarito(ref char[] gabarito)
        {
            for (int i = 0; i < gabarito.Length; i++)
            {
                Console.Write("Digite a resposta {0} do gabarito: ", i + 1);
                gabarito[i] = Console.ReadLine().ToUpper().ToCharArray()[0];
            }
            Console.WriteLine("\n");
        }
       


    }
}

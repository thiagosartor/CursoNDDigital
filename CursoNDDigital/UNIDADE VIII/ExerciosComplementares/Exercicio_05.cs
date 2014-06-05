using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIDADE_VIII.ExerciosComplementares
{
    class Exercicio_05
    {
        static void Main1(string[] args)
        {
            Random gerador = new Random();
            int numJogada, soma = 0, contSeis = 0;
            bool perdeu = false;
            for (int jogadas = 0; jogadas < 10; jogadas++)
            {
                numJogada = gerador.Next(1, 7);
                if (numJogada == 6)
                {
                    contSeis++;
                    if (contSeis >= 2)
                    {
                        Console.WriteLine("Perdeu !! Jogou 2 vezes o numero 6");
                        perdeu = true;
                        break;
                    }
                    continue;
                }
                if ((numJogada % 2) == 0 || numJogada == 1)
                {
                    continue;
                }
                soma += numJogada;
            }
            if (!perdeu)
            {
                Console.WriteLine((soma % 2) == 0 ? "Perdeu !!!" : "Ganhou !!!"); // Se for par a soma ele perde, senão(ímpar) ganha
            } 
            Console.ReadKey();
        }
    }
}

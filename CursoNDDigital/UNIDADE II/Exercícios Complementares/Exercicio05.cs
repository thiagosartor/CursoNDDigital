using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIDADE_II
{
    class Exercicio05
    {
        static void Main5(string[] args)
        {
            int horaInicio, horaFim, total;
            Console.WriteLine("Digite a hora inicial: ");
            horaInicio = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a hora final: ");
            horaFim = int.Parse(Console.ReadLine());
            if (horaInicio == horaFim)
            {
                Console.WriteLine("\t\tTempo de limite atingido: 24 horas de jogo !");
            }
            else
            {
                if (horaInicio > horaFim)
                {
                    total = horaFim + (24 - horaInicio);
                }
                else
                {
                    total = horaFim - horaInicio;
                }
                Console.WriteLine("Total de horas de jogo é: ", total);
            }
        }
    }
}

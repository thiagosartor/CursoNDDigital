using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UNIDADE_III
{
    class _01_Distancia
    {
        static void Main(string[] args)
        {
            double tempo, velMedia, distancia, litrosUsados;
            Console.Write("Digite o tempo da viagem: ");
            tempo = double.Parse(Console.ReadLine());
            Console.Write("Digite a velocidade média: ");
            velMedia = double.Parse(Console.ReadLine());
            distancia = tempo * velMedia;
            litrosUsados = distancia / 12;
            Console.WriteLine("==== Resultados ====");
            Console.WriteLine("Velcidade Média: " + velMedia);
            Console.WriteLine("Tempo: " + tempo);
            Console.WriteLine("Distancia percorrida: "+ distancia);
            Console.WriteLine("Quantidade de Litros: " +litrosUsados.ToString("#0.00") + "L");
            Console.ReadKey();
        }
    }
}

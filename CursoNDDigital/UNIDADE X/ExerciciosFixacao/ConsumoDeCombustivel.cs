using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIDADE_X.ExerciciosFixacao.ExerciciosFixacao
{
    class ConsumoDeCombustivel
    {
        static void Main1(string[] args)
        {
            Console.Write("Digite a distancia percorrida: ");
            double distancia = double.Parse(Console.ReadLine());
            Console.Write("Digite a quantidade de litros: ");
            double qtdLitros = double.Parse(Console.ReadLine());
            double consumo = CalculaConsumo(distancia, qtdLitros);
            Console.WriteLine("Consumo: {0} KM/L", consumo);
            Console.ReadKey();
        }

        static double CalculaConsumo(double distancia, double qtdLitros)
        {
            return (double) distancia / qtdLitros;
        }

    }
}

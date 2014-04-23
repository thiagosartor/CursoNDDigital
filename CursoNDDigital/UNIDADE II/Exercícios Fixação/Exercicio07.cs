using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIDADE_II
{
    class Exercicio_07
    {
        static void Main7(string[] args)
        {
            double tempC, tempF;
            Console.Write("Digite a temperatura ºC: ");
            tempC = double.Parse(Console.ReadLine());
            tempF = (9 * tempC + 160) / 5;
            Console.WriteLine("==== Resultado ====");
            Console.WriteLine("Temperatura em ºF: " + tempF);
            Console.ReadKey();
        }
    }
}

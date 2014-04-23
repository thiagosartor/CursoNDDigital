using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIDADE_II
{
    class Exercicio04
    {
        static void Main4(string[] args)
        {
            int total, branco, nulo, valido;
            int totalBranco, totalNulo, totalValido;

            Console.WriteLine("Digite o Total: ");
            total = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o total de votos brancos: ");
            branco = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o total de votos nulos: ");
            nulo = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o total de votos validos: ");
            valido = int.Parse(Console.ReadLine());

            totalBranco = (branco / total) * 100;
            totalNulo = (nulo / total) * 100;
            totalValido = (valido / total) * 100;

            Console.WriteLine("======= Porcentagens =======");
            Console.WriteLine("Votos Brancos: " + totalBranco + "%");
            Console.WriteLine("Votos Nulos: " + totalNulo + "%");
            Console.WriteLine("Votos Validos: " + totalValido + "%");
            Console.ReadKey();
        }
    }
}

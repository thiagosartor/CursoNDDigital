using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MendindoAFebreV
{
    class Questao07
    {
        public static int Idade = 0;
        private static void Main()
        {
            Console.WriteLine("Digite sua idade.");
            Idade = int.Parse(Console.ReadLine());
            var comparacao = Idade >= 18 ? "Maior idade,Adulto." : "Menor idade, não adulto.";
            var identificador = new Random();
            Console.WriteLine("Identificador numero: " + identificador.Next(0, 9999));
            Console.WriteLine(comparacao);
            Console.ReadKey();
        }
    }
}

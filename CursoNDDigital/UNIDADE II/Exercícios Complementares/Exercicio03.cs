using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIDADE_II
{
    class Exercicio03
    {
        static void Main(string[] args)
        {
            int anos, meses, dia, idade;
            Console.Write("Digite a idade em anos: ");
            anos = int.Parse(Console.ReadLine());
            Console.Write("Digite a idade em meses: ");
            meses = int.Parse(Console.ReadLine());
            Console.Write("Digite a idade em dias: ");
            dia = int.Parse(Console.ReadLine());
            idade = (anos * 365) + (meses * 30) + dia;
            Console.WriteLine("Idade em dias: " + idade);
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIDADE_II
{
    class Exercicio_05
    {
        static void Mai5n(string[] args)
        {
            string nome;
            double n1, n2, n3, media;
            Console.Write("Digite o nome: ");
            nome = Console.ReadLine();
            Console.Write("Digite a primeira nota: ");
            n1 = double.Parse(Console.ReadLine());
            Console.Write("Digite a segunda nota: ");
            n2 = double.Parse(Console.ReadLine());
            Console.Write("Digite a terceira nota: ");
            n3 = double.Parse(Console.ReadLine());
            media = (n1 + n2 + n3) / 3;

            Console.WriteLine("==== Resultado ====");
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Salario Líquido: " + media.ToString("#0.0"));
            Console.ReadKey();
        }
    }
}

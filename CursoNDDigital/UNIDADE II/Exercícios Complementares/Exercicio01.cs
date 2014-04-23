using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIDADE_II
{
    class Exercicio01
    {
        static void Main1(string[] args)
        {
            int valor;
            Console.Write("Digite um valor: ");
            valor = int.Parse(Console.ReadLine());
            Console.WriteLine("Antecessor: " + (valor - 1));
            Console.ReadKey();
        }
    }
}

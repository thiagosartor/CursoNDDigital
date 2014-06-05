using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIDADE_VIII.ExerciosComplementares
{
    class Exercicio_01
    {
        static void Main1(string[] args)
        {
            Random gerador = new Random();
            int num1 = gerador.Next(), num2 = gerador.Next();
            Console.WriteLine("Numero 1: {0} \nNumero 2: {1}", num1, num2);
            string msg = (num1 > num2) ? "Primeiro > Segundo" : (num1 < num2) ? "Segundo < Primeiro" : "Primeiro = Segundo";
            Console.WriteLine(msg);
            Console.ReadKey();
        }
    }
}

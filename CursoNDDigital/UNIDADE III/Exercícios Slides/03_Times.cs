using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIDADE_III
{
    class Times
    {
        static void Main1(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Vou ser escrito 10 vezes na tela");
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i.ToString("#0.00"));
            }
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedindoAFebreIII.MedindoAFebre
{
    class _09_Espacos
    {
        static void Main333(string[] args)
        {
            string frase;
            Console.Write("Digite  a frase: ");
            frase = Console.ReadLine();
            Console.WriteLine("\n\n");
            Console.WriteLine("Resultado: " + frase.Replace("#", " "));
            Console.ReadKey();
        }
    }
}

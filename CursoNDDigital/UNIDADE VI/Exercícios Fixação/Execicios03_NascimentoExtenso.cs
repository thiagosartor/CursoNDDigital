using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIDADE_IV.Exercícios_Fixação
{
    class Program
    {
       
        static void Maini(string[] args)
        {
            int dia;
            int mes;
            int ano;
            Console.WriteLine("Digite o dia em que você nasceu: ");
            dia = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o mês em que você nasceu: ");
            mes = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o ano em que você nasceu: ");
            ano = int.Parse(Console.ReadLine());

            DateTime dt = new DateTime(ano, mes, dia);
            Console.WriteLine(dt.ToLongDateString());
            Console.ReadKey();
            


        }
    }
}

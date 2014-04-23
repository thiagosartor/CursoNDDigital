using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIDADE_III
{
    class _15_Notas
    {
        public static double valor, aux;
        public static int contCem = 0, contCin = 0, contDez = 0, contCinco = 0, contUm = 0;

        static void Main1(string[] args)
        {
            Console.Write("Digite o valor:  ");
            valor = double.Parse(Console.ReadLine());
            aux = 0;
            do
            {
                if ((aux + 100) <= valor)
                {
                    contCem++;
                    aux += 100;
                }
                else if ((aux + 50) <= valor)
                {
                    contCin++;
                    aux += 50;
                }
                else if ((aux + 10) <= valor)
                {
                    contDez++;
                    aux += 10;
                }
                else if ((aux + 5) <= valor)
                {
                    contCinco++;
                    aux += 5;
                }
                else if ((aux + 1) <= valor)
                {
                    contUm++;
                    aux += 1;
                }
            } while (aux < valor);
            Console.WriteLine(("======= Numero de Notas ======="));
            if (contCem > 0)
            {
                Console.WriteLine("Numero de notas de cem: " + contCem);
            }
            if (contCin > 0)
            {
                Console.WriteLine("Numero de notas de cinquenta: " + contCin);
            }
            if (contDez > 0)
            {
                Console.WriteLine("Numero de notas de Dez: " + contDez);
            }
            if (contCinco > 0)
            {
                Console.WriteLine("Numero de notas de cinco: " + contCinco);
            }
            if (contUm > 0)
            {
                Console.WriteLine("Numero de notas de um: " + contUm);
            }
            Console.ReadKey();
        }
    }
}

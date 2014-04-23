using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIDADE_II
{
    class Exercicio07
    {
        static void Main7(string[] args)
        {
            int numConta;
            float saldo, debito, credito, saldoAtual;
            Console.Write("Digite o numero da conta: ");
            numConta = int.Parse(Console.ReadLine());
            Console.Write("Digite o saldo: ");
            saldo = float.Parse(Console.ReadLine());
            Console.Write("Digite o saldo do débito: ");
            debito = float.Parse(Console.ReadLine());
            Console.Write("Digite o saldo do crédito: ");
            credito = float.Parse(Console.ReadLine());
            saldoAtual = saldo - (debito + credito);
            if (saldoAtual >= 0)
            {
                Console.WriteLine("   (Saldo Positivo)");
            }
            else
            {
                Console.WriteLine("   (Saldo Negativo)");
            }
            Console.ReadKey();
        }
    }
}

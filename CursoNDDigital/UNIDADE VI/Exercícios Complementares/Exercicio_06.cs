using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIDADE_VI.Exercícios_Complementares
{
    class Exercicio_06
    {
        static void Main1(string[] args)
        {
            double altura, maiorAltura = 0;
            string nome = null, nomeAlta = null;
            int qtdMocas = 0;
            while (true)
            {
                Console.Write("\nDigite o nome da moça (fim p/ finalizar): ");
                nome = Console.ReadLine();
                if (nome.ToLower() == "fim")
                {
                    Console.WriteLine();
                    break;
                }
                Console.Write("Digite a altua da moça: ");
                altura = double.Parse(Console.ReadLine());
                if (altura > maiorAltura)
                {
                    maiorAltura = altura;
                    nomeAlta = nome;
                }
                qtdMocas++;
                Console.WriteLine();
            }
            Console.WriteLine("====== RESULTADO =====");
            Console.WriteLine("Nome da mais alta: {0}", nomeAlta);
            Console.WriteLine("Altura: {0} metros", maiorAltura);
            Console.WriteLine("Quantidade de moças: {0}", qtdMocas);
            Console.ReadKey();
        }
    }
}

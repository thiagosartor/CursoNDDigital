using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIDADE_II
{
    class Exercicio09
    {
        static void Main9(string[] args)
        {
            float numLitros, valorTotal, valorLitro = 0, desconto = 0;
            string tipo;

            Console.Write("Digite quantidade de litros: ");
            numLitros = float.Parse(Console.ReadLine());
            Console.Write("Digite o tipo de combustível(A - Alcool / G - Gasolina): ");
            tipo = Console.ReadLine();
            switch (tipo)
            {
                case "a":
                    valorLitro = 2.90f;
                    if (numLitros <= 20)
                    {
                        desconto = 0.03f;
                    }
                    else
                    {
                        desconto = 0.05f;
                    }
                    break;
                case "g":
                    valorLitro = 3.30f;
                    if (numLitros <= 20)
                    {
                        desconto = 0.04f;
                    }
                    else
                    {
                        desconto = 0.06f;
                    }
                    break;
                default:
                    Console.WriteLine("Tipo Inválido !!");
                    break;
            }
            valorTotal = (valorLitro * numLitros);
            valorTotal = valorTotal - ((valorTotal * desconto) * numLitros);
            Console.WriteLine("Valor Total: " + valorTotal);
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIDADE_VI.Exercícios_Complementares
{
    class Exercicio_05
    {
        static void Main1(string[] args)
        {
            bool valido = true;
            Console.Write("Digite o numero do trabalhor: ");
            int numTrabalhor = int.Parse(Console.ReadLine());
            Console.Write("Digite o idade do trabalhor: ");
            int idade = int.Parse(Console.ReadLine());
            Console.Write("Digite a quantidade de caixas: ");
            int qtdCaixas = int.Parse(Console.ReadLine());
            double valorCaixa = 0;

            valorCaixa = defineValorCaixa(ref valido, qtdCaixas, valorCaixa);  // Defini o valor por caixa
            double salario = qtdCaixas * valorCaixa; // Calcula o salario 
            salario = calcularAdicional(ref valido, idade, salario);   // Acrescenta o adiconal no salario

            if (valido) // Se o trabalhador é válido (quantidade e idade)
            {
                Console.WriteLine("\n====== RESULTADO ======");
                Console.WriteLine("Nº trabalhador: {0} \nIdade: {1} \nPreco por caixa: R${2} \nSalario Total: R${3} ", numTrabalhor, idade, valorCaixa, salario);
            }
            Console.ReadKey();
        }

        private static double calcularAdicional(ref bool valido, int idade, double salario)
        {
            if (idade > 65 || idade < 18)
            {
                Console.WriteLine("\nIdade inválida !!");
                valido = false;

            }
            else if (idade >= 45)
            {
                salario += salario * 0.2;
            }
            else
            {
                salario += salario * 0.1;
            }
            return salario;
        }

        private static double defineValorCaixa(ref bool valido, int qtdCaixas, double valorCaixa)
        {
            if (qtdCaixas >= 21)
            {
                valorCaixa = 5;
            }
            else if (qtdCaixas >= 11)
            {
                valorCaixa = 3.50;
            }
            else if (qtdCaixas >= 6)
            {
                valorCaixa = 2.50;
            }
            else if (qtdCaixas > 0)
            {
                valorCaixa = 2;
            }
            else
            {
                Console.WriteLine("\nQuantidade Inválida !!");
                valido = false;
            }
            return valorCaixa;
        }
    }
}

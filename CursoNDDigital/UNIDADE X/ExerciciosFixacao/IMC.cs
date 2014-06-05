using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIDADE_X.ExerciciosFixacao.ExerciciosFixacao
{
    class IMC
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("===== CALCULADORA DE IMC ======");
            Console.WriteLine("Digite a altura: ");
            double alt = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o peso: ");
            double peso = double.Parse(Console.ReadLine());
            calculaIMC(peso, alt);
            Console.ReadLine();
 
        }

        static void calculaIMC(double peso, double altura)
        {
            double imc = peso / Math.Pow(altura, 2);
            Console.WriteLine("O IMC é: {0}", imc);
            Console.WriteLine("Status do IMC: {0}", statusIMC(imc));
        }

        static string statusIMC(double imc)
        {
            if (imc < 17)
            {
                return "Muito abaixo do peso !!";
            }
            else if (imc <= 18.49)
            {
                return "Abaixo do peso !!";
            }
            else if (imc <= 24.99)
            {
                return "Peso normal";
            }
            else if (imc <= 29.99)
            {
                return "Acima do peso !!";
            } else if (imc <= 34.99){
                return "Obesidade I !!";
            }
            else if (imc <= 39.99)
            {
                return "Obesidade II (severa)!!";
            }
            {
                return "Obesidade III (mórbida)";
            }
        }


    }
}

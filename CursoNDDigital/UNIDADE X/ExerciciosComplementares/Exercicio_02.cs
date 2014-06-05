using System;

namespace UNIDADE_X.ExerciciosFixacao.ExerciciosComplementares
{
    internal class Exercicio_02
    {
        private static void Main1(string[] args)
        {
            Console.Write("Digite a data: ");
            string data = Console.ReadLine();
            DateTime date;
            if (DateTime.TryParse(data, out date))
            {
                Console.WriteLine("É válido !!");
            }
            else
            {
                Console.WriteLine("Não é valido !!");
            }
            Console.ReadKey();

            // Modo campeiro

            /* Console.Write("Digite o dia: ");
             int dia = int.Parse(Console.ReadLine());
             Console.Write("Digite o mes: ");
             int mes = int.Parse(Console.ReadLine());
             Console.Write("Digite o ano: ");
             int ano = int.Parse(Console.ReadLine());

             if (verificaData(dia, mes, ano))
             {
                 Console.WriteLine("É válido !!");
             }
             else
             {
                 Console.WriteLine("Não é valido !!");
             }
             Console.ReadKey();*/
        }

        private static bool verificaData(int dia, int mes, int ano)
        {
            switch (mes)
            {
                case 1:
                case 3:
                case 5:
                case 6:
                case 8:
                case 10:
                case 12:
                    if (dia > 31)
                        return false;
                    break;

                case 2:
                    if (isBissexto(ano))
                    {
                        if (dia > 29)
                        {
                            return false;
                        }
                    }
                    else
                    {
                        if (dia > 28)
                            return false;
                    }
                    break;

                default:
                    if (dia > 30)
                    {
                        return false;
                    }
                    break;
            }
            return true;
        }

        private static bool isBissexto(int ano)
        {
            if (ano % 400 == 0) // É multiplo de 400
            {
                return true;
            }
            if (ano % 100 == 0) // É multiplo de 100
            {
                return false;
            }
            if (ano % 4 == 0) // É multiplo de 4
            {
                return true;
            }
            return false;
        }
    }
}
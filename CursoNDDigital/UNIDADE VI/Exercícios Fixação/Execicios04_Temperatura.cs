using System;

namespace UNIDADE_IV.Exercícios_Fixação
{
    internal class Exe4___Temperatura_do_mês
    {
        public static void Maini(string[] args)
        {
            // Ler um vetor armazenando a temperatura média do dia durante um mês completo.
            //Ao final calcular a temperatura média no mês, considerando 30 dias, e calcular a quantidade de dias que a temperatura passou da média de 35 graus no dia.

            int[] temp_mes = new int[31];
            int soma_dia_mais_quante = 0;

            for (int i = 1; i < temp_mes.Length; i++)

            {
                Console.WriteLine("Digite a temperatura do dia " + i + "...");
                temp_mes[i] = int.Parse(Console.ReadLine());
                if (temp_mes[i] >= 35)
                {
                    soma_dia_mais_quante++;
                }
            }
            Console.WriteLine("Quantidade de dias que passaram dos 35 graus: "+soma_dia_mais_quante+" dias.");
            Console.ReadKey();
        }
    }
}
using System;

namespace UNIDADE_VII.ExerciosFixacao
{
    internal class BiroBiro1_5
    {
        public static string[] Anagramas = new string[100];
        public static int Cont = 0;

        public static void Main1()
        {
            const string palavra = "biro";
            Anagrama(palavra, palavra.Length);
            Console.ReadKey();
        }

        public static void Anagrama(string palavra, int tamanho)
        {
            if (tamanho == 1)
                Console.Write("{0} ", palavra);
            else
            {
                string palavraAtual = palavra;
                for (int i = 0; i < tamanho; i++)
                {
                    palavraAtual = palavraAtual.Substring(1, tamanho - 1) + palavraAtual[0] +
                                   palavraAtual.Substring(tamanho);
                    Anagrama(palavraAtual, tamanho - 1);
                }
            }
        }
    }
}
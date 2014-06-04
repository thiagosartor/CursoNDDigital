using System;
namespace UNIDADE_XI.ExerciciosComplemetares
{
/*1)Implemente um gerador (Aleatório) de números sorteados da mega-sena. É necessário acertar a sena, o que significa obter coincidência entre seis dos números apostados e os seis números sorteados, de um total de sessenta dezenas (de 01 a 60), independentemente da ordem da aposta ou da ordem do sorteio.

  2)Continuando na questão 1, o usuário agora deve informar os 6 números que ele deseja escolher. Esses 6 dados devem ser armazenados em um array também, como os números premiados da questão 1. Caso o usuário escolha um número fora do intervalo do cartão da mega-sena, o software deve avisa-lo.

  3)Continuando no software da mega-sena. Faça um método que Ordene do menor para o maior número. E mostre os números sorteados da seguinte forma: [ 2 ] [34] [36] [45] [51] [59]

  4)Continuando no software da mega-sena. Implemente um método que mostre quantos números ele acertou, comparando os arrays. Caso tenha acertado 5 mostre que ele acertou a quina.*/

    internal class MegaSena
    {
        public static Random sorteado = new Random();
        public static int[] NumerosSortedos = new int[6];
        public static int[] NumerosEscolhidos = new int[6];
        public static void Main()
        {
            SortearNumeros();
            JogarNaMega();
            Resultado();
        }

        private static void Resultado()
        {

        }

        private static void JogarNaMega()
        {

        }

        private static void SortearNumeros()
        {
            for (int i = 0; i < ; i++)
            {
               NumerosSortedos[i] = sorteado.Next(1, 61);  
            }
           
        }
    }
}
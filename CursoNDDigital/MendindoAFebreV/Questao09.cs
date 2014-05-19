using System;

namespace MendindoAFebreV
{
    internal class Questao09
    {
        public static string NomeProduto = "";
        public static int QuantidadeAdiquirida = 0;
        public static double PrecoProduto = 0;
        public static double Desconto = 0;
        public static double TotalAdiquirido = 0;
        public static double TotalaPagar = 0;

        public static void Main(String[] args)
        {
            System.DateTime dt = new System.DateTime(2010, 8, 27);

            // Acrescentando 140 dias 
            dt = dt.AddDays(140);
            // Subtraindo 2 anos
            dt = dt.AddYears(-2);
            // Acrescentando 20 segundos
            dt = dt.AddSeconds(20);


            Console.WriteLine("Digite o nome do produto.");
            NomeProduto = Console.ReadLine();
            Console.WriteLine("Digite a quantidade adiquirida do produto.");
            QuantidadeAdiquirida = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o preço de cada unidade do produto.");
            PrecoProduto = double.Parse(Console.ReadLine());
            TotalAdiquirido = QuantidadeAdiquirida * PrecoProduto;
            if (QuantidadeAdiquirida <= 5)
            {
                Desconto = (TotalAdiquirido * 2) / 100;
            }
            else if (QuantidadeAdiquirida > 5 & QuantidadeAdiquirida <= 10)
            {
                Desconto = (TotalAdiquirido * 3) / 100;
            }
            else
            {
                Desconto = (TotalAdiquirido * 5) / 100;
            }
            TotalaPagar = TotalAdiquirido - Desconto;
            Console.WriteLine("Produto: " + NomeProduto);
            Console.WriteLine("Valor total das compras: " + TotalAdiquirido + " Reais.");
            Console.WriteLine("Valor do desconto recebido: " + Desconto + " Reais.");
            Console.WriteLine("Valor total a pagar: " + TotalaPagar + " Reais.");
            Console.ReadKey();
        }
    }
}
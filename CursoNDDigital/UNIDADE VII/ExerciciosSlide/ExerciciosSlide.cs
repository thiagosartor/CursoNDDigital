using System;

namespace UNIDADE_VII.ExerciciosSlide
{
    public class ExerciciosSlide
    {
        public static void Main1()
        {
            //Exercicio2();
            //Exercicio3();
            //Exercicio4();
            //Exercicio5();
            //Exercicio6();
            //Exercicio7();
            //Exercicio8();
            //Exercicio9();
            //Exercicio10();
            Exercicio11();
        }

        public static void Exercicio2()//Operadores Aritméticos.
        {
            int soma = 1 + 1;
            int div = 5 / 2;
            int sub = 1 - 1;
            int mult = 1 * 5;
            bool operadorE = true && false;
            bool operadorOU = true || false;

            Console.WriteLine(soma);
            Console.WriteLine(div);
            Console.WriteLine(sub);
            Console.WriteLine(mult);
            Console.WriteLine(operadorE);
            Console.WriteLine(operadorOU);
        }

        public static void Exercicio3() //Operadores de Divisão inteira
        {
            int divInteira = 5 / 2;
            double divCast = (double)5 / 2;
            double divCast2 = (double)5 / (double)2;

            Console.WriteLine(divInteira);
            Console.WriteLine(divCast);
            Console.WriteLine(divCast2);
        }

        public static void Exercicio4() //Operadores de Concatenação
        {
            string testeConcatenacao = 1 + 2 + 3 + "testando";
            string testeConcatenacao2 = "testando" + 1 + 2 + 3;
            Console.WriteLine(testeConcatenacao);
            Console.WriteLine(testeConcatenacao2);

            Console.ReadKey();
        }

        public static void Exercicio5() //Operadores de atribuição
        {
            int valor = 10;
            valor += 1;
            valor -= 1;
            valor *= 1;
            valor /= 1;
            valor %= 1;
            valor++;
            valor--;
            --valor;
            ++valor;
        }

        public static void Exercicio6() //Operadores Relacionais
        {
            int i = 7;
            bool j = false;
            j = (i == 7);
            j = (i != 7);
            j = (i >= 5);
            j = (i <= 3);
        }

        public static void Exercicio7() //Operadores Lógicos
        {
            int i = 7;
            bool j = false;
            j = (i == 6 && i != 7); // E
            j = (i <= 10 || i >= 5); // OU
            j = (i == 7 ^ i <= 10);   // XOR
        }

        public static void Exercicio8() //Operadores ternário
        {
            Random gerador = new Random();
            double nota = gerador.NextDouble() * 100;
            string resultado = nota >= 0.5 ? "Aprovado" : "Reprovado";
        }

        public static void Exercicio9() //Operador de negação
        {
            Console.WriteLine(!(1 > 2));
            Console.ReadKey();
        }

        public static void Exercicio10() //Operador de incremento e decremento pós e pré
        {
            int i = 10;
            int t = ++i + i--;
            int c = i++ + --i;
            Console.WriteLine(t);
            Console.WriteLine(t);
            Console.ReadKey();
        }

        public static void Exercicio11()
        {
            //Descobrir a quantidade de caracteres de uma string.
            //string s = "Nome da Pessoa";

            //int length = s.Length;

            //Console.WriteLine(length);

            ////Recuperar umcaractere de acordo com a sua posição na string.
            //string s = "Nome da Pessoa";

            //char c = s[0];

            //Console.WriteLine(c);

            ////Podemos verificar se uma determinada sequência de caracteres está contida em uma string.
            //string s = "Apostila de Java";

            //bool resultado1 = s.Contains("C#");
            //bool resultado2 = s.Contains("Java");

            //// False
            //Console.WriteLine(resultado1);

            //// True
            //Console.WriteLine(resultado2);

            //Podemos verificar se uma string termina com uma determinada sequência de caracteres.

            //string s = "Apostila de C#";

            //bool resultado1 = s.EndsWith("Java");
            //bool resultado2 = s.EndsWith("C#");

            //// False
            //Console.WriteLine(resultado1);

            //// True
            //Console.WriteLine(resultado2);

            ////Podemos verificar se uma string começa com uma determinada sequência de caracteres.

            //string s = "Apostila de C#";

            //bool resultado1 = s.StartsWith("C#");
            //bool resultado2 = s.StartsWith("Apostila");

            //// False
            //Console.WriteLine(resultado1);

            //// True
            //Console.WriteLine(resultado2);

            ////Podemos extrair um trecho de uma string.
            //string s1 = " Thiago Sartor ";

            //string s2 = s1.Substring(1,1);
            //string s3 = s1.Substring(0, 6);

            //// Sartor
            //Console.WriteLine(s2);

            //// Thiago
            //Console.WriteLine(s3);

            ////Podemos eliminar os espaços em branco do começo e do término de uma string.
            //string s1 = "  Thiago Sartor    ";

            //string s2 = s1.Trim();

            //// " Thiago Sartor "
            //Console.WriteLine(s2);

            ////Letra Maiuscula
            //string nome = "thiago";
            //nome.ToUpper();
            ////Letra Minuscula
            //nome.ToLower();
            ////Separador
            //nome = "Thiago-Sartor";
            //string[] stringArray = nome.Split('-');
            ////stringArray[0] = Thiago
            ////stringArray[1] = Sartor
            //nome.Replace('-', ' ');


            //DateTime dt = new DateTime(2010, 8, 27);

            // Acrescentando 140 dias
            //dt = dt.AddDays(140);

            // Subtraindo 2 anos
            //dt = dt.AddYears(-2);

            // Acrescentando 20 segundos
            //dt = dt.AddSeconds(20);
        }
    }
}
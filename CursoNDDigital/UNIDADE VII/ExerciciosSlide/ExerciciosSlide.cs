namespace UNIDADE_VII.ExerciciosSlide
{
    public class ExerciciosSlide
    {
        public static void Main()
        {
            Exercicio2();
            Exercicio3();
            Exercicio4();
            Exercicio5();
            Exercicio6();
            Exercicio7();
            Exercicio8();
            Exercicio9();
            Exercicio10();
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
            j(i == 7 ^ i <= 10);   // XOR
        }

        public static void Exercicio8()
        {
        }
        public static void Exercicio9()
        {
        }
        public static void Exercicio10()
        {
        }
    }
}
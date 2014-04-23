using System;

namespace UNIDADE_III
{
    internal class _09
    {
        public static int contAp = 0, contNap = 0, idade = 0;
        public static string nome, sexo, saude, op;

        private static void Main1(string[] args)
        {
            do
            {
                Console.Write("Digite o nome: ");
                nome = Console.ReadLine();
                Console.Write("Digite o sexo: ");
                sexo = Console.ReadLine();
                Console.Write("Digite o saude(Bom ou Ruim): ");
                saude = Console.ReadLine();
                Console.Write("Digite a idade: ");
                idade = int.Parse(Console.ReadLine());
                if (!verificaApto())
                {
                    Console.WriteLine("Resultado: Não - Apto");
                }
                Console.Write("Continuar cadastrando(S ou N): ");
                op = Console.ReadLine();
            } while (op == "N");
            Console.WriteLine("Total de Aptos: " + contAp);
            Console.WriteLine("Total de não aptos: " + contNap);
            Console.WriteLine("Total Geral: " + (contAp + contNap));
            Console.ReadKey();
        }

        public static bool verificaApto()
        {
            if ((sexo == "F") || (saude == "ruim") || (idade < 18))
            {
                contNap++;
                return false;
            }
            else
            {
                contAp++;
                Console.WriteLine("Resultado: Apto");
                return true;
            }
        }
    }
}
using System;

namespace MedindoAFebreVI
{
    public class Questao12
    {
        public static int[] Matricula = new int[100];

        public static int[] Frequencia = new int[100];

        public static double[] NotaFinal = new double[100];

        public static double MaiorNota = 0, Turma = 0;

        public static int TotalAlunos = Matricula.Length;

        public static void Main()
        {
            for (int i = 0; i < Matricula.Length; i++)
            {
                Console.Write("Digite o numero de matricula: ");
                Matricula[i] = int.Parse(Console.ReadLine());

                Console.Write("A frequencia: ");
                Frequencia[i] = int.Parse(Console.ReadLine());

                NotaFinal[i] = CalcularMedia();

                if (NotaFinal[i] > MaiorNota)
                    MaiorNota = NotaFinal[i];

                Turma += NotaFinal[i];
                Console.WriteLine("\n");
            }

            ExibirAlunos(ref NotaFinal, ref Frequencia, ref Matricula);
            Console.WriteLine("Maior nota: {0:F2}", MaiorNota);
            Console.WriteLine("Menor nota: {0:F2}", MenorNota(ref NotaFinal));
            Console.WriteLine("Media da Turma: {0:F2}", Turma / TotalAlunos);
            Console.WriteLine("Total de alunos: {0}", TotalAlunos);
            Console.ReadKey();
        }

        private static double MenorNota(ref double[] NotaFinal)
        {
            double menorNota = NotaFinal[0];
            for (int i = 0; i < NotaFinal.Length; i++)
            {
                if (NotaFinal[i] < menorNota)
                    menorNota = NotaFinal[i];
            }
            return menorNota;
        }

        private static void ExibirAlunos(ref double[] NotaFinal, ref int[] Frequencia, ref int[] Matricula)
        {
            int contReprovados = 0;
            for (int i = 0; i < Matricula.Length; i++)
            {
                Console.WriteLine("Aluno {0}", i + 1);
                Console.WriteLine("Matricula: {0}", Matricula[i]);
                Console.WriteLine("Nota Final: {0}", NotaFinal[i]);
                Console.WriteLine("Frequencia: {0}", Frequencia[i]);
                Console.Write("Codigo: ");
                if (NotaFinal[i] >= 60 && Frequencia[i] >= 40)
                {
                    Console.Write("Aprovado!");
                }
                else
                {
                    Console.Write("Reprovado!");
                    contReprovados++;
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine("Reprovados: {0}", contReprovados);
        }

        private static double CalcularMedia()
        {
            double nota1 = 0, nota2 = 0, nota3 = 0;
            Console.Write("Digite a nota 1: ");
            nota1 = double.Parse(Console.ReadLine());

            Console.Write("Digite a nota 2: ");
            nota2 = double.Parse(Console.ReadLine());

            Console.Write("Digite a nota 3: ");
            nota3 = double.Parse(Console.ReadLine());

            return (nota1 + nota2 + nota3) / 3;
        }
    }
}
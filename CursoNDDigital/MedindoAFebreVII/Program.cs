using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedindoAFebreVII
{
    internal class Program
    {
        private static string[] nome = new string[5];

        private static int[] idade = new int[5];
        private static double[] altura = new double[5];
        private static char[] sexo = new char[5];
        private static bool[] adulto = new bool[5];

        private static char[] sexos = { 'M', 'F' };
        private static bool[] adultos = { true, false };

        private static void Main(string[] args)
        {
            inicializaVetores();
            porcentagemAdultos();
            porcentagemSexo();
            porcentagemAltos();
            exibeValores();
            exibeDezMaisVelhos();
            exibeDezMaisNovos();
            exibeMaisAlta();
            exibeMaisBaixa();
            Console.ReadLine();
        }

        /* Inicializar */

        private static void inicializaVetores()
        {
            Random gerador = new Random();
            for (int i = 0; i < nome.Length; i++)
            {
                nome[i] = "nome" + i;
                idade[i] = gerador.Next(1, 100);
                sexo[i] = sexos[gerador.Next(0, 2)];
                adulto[i] = adultos[gerador.Next(0, 2)];
                altura[i] = gerador.NextDouble() + 1;
            }
        }

        /* Porcentagens */

        private static void porcentagemAdultos()
        {
            int contN = 0, contS = 0;
            for (int i = 0; i < adulto.Length; i++)
            {
                if (adulto[i] == true)
                {
                    contS++;
                }
                else
                {
                    contN++;
                }
            }
            Console.WriteLine("====== ADULTOS =======");
            double percent = (contS / (double)adulto.Length) * 100;
            Console.WriteLine("São adultos: {0}%", percent);
            percent = (contN / (double)adulto.Length) * 100;
            Console.WriteLine("Não são adultos: {0}%\n", percent);
        }

        private static void porcentagemSexo()
        {
            int contM = 0, contF = 0;
            for (int i = 0; i < sexo.Length; i++)
            {
                if (sexo[i] == 'M')
                {
                    contM++;
                }
                else
                {
                    contF++;
                }
            }
            Console.WriteLine("====== SEXO =======");
            double percent = (contF / (double)sexo.Length) * 100;
            Console.WriteLine("Feminino: {0}%", percent);
            percent = (contM / (double)sexo.Length) * 100;
            Console.WriteLine("Masculino: {0}%\n", percent);
        }

        private static void porcentagemAltos()
        {
            int contMaior = 0, contMenor = 0;
            for (int i = 0; i < altura.Length; i++)
            {
                if (altura[i] > 1.70)
                {
                    contMaior++;
                }
                else
                {
                    contMenor++;
                }
            }
            Console.WriteLine("====== ALTURA =======");
            double percent = (contMaior / (double)altura.Length) * 100;
            Console.WriteLine("Maior que 1.70: {0}%", percent);
            percent = (contMenor / (double)altura.Length) * 100;
            Console.WriteLine("Menor que 1.70: {0}%\n", percent);
        }

        /* Exibir Todos */

        private static void exibeValores()
        {
            Console.WriteLine("\n ========= LISTAR TODOS =========");
            for (int i = 0; i < nome.Length; i++)
            {
                Console.WriteLine("Nome: {0}", nome[i]);
                Console.WriteLine("Idade: {0}", idade[i]);
                Console.WriteLine("Sexo: {0}", sexo[i]);
                Console.WriteLine("Adulto: {0}", adulto[i]);
                Console.WriteLine("--------------------------------");
            }
            Console.WriteLine();
        }

        /* ==== Exibe os 10 mais velhos =====*/

        private static int[] maisVelhos()
        {
            int[] maisVelhos = new int[5];
            int[] idades = (int[])idade.Clone();
            int idadeMaisNova = idade[descobrirMaisNovo(idades)];
            for (int i = 0; i < maisVelhos.Length; i++)
            {
                int pos = descobrirMaisVelho(idades);
                maisVelhos[i] = pos;
                idades[pos] = idadeMaisNova;
            }
            return maisVelhos;
        }

        private static int descobrirMaisVelho(int[] idades)
        {
            int maisVelho = idades[0];
            int pos = 0;
            for (int i = 0; i < idades.Length; i++)
            {
                if (idades[i] > maisVelho)
                {
                    pos = i;
                    maisVelho = idades[i];
                }
            }
            return pos;
        }

        private static void exibeDezMaisVelhos()
        {
            int[] posicao = maisVelhos();
            Console.WriteLine("\n ========= 10 MAIS VELHOS =========");
            int pos = 0;
            for (int i = 0; i < posicao.Length; i++)
            {
                pos = posicao[i];
                Console.WriteLine("Nome: {0}", nome[pos]);
                Console.WriteLine("Idade: {0}", idade[pos]);
                Console.WriteLine("Sexo: {0}", sexo[pos]);
                Console.WriteLine("Adulto: {0}", adulto[pos]);
                Console.WriteLine("--------------------------------");
            }
            Console.WriteLine();
        }

        /* ==== Exibe os 5 mais Novos ==== */

        private static int[] maisNovos()
        {
            int[] maisNovo = new int[3];
            int[] idades = (int[])idade.Clone();

            int idadeMaisVelha = idade[descobrirMaisVelho(idades)];

            for (int i = 0; i < maisNovo.Length; i++)
            {
                int pos = descobrirMaisNovo(idades);
                maisNovo[i] = pos;
                idades[pos] = idadeMaisVelha;
            }
            return maisNovo;
        }

        private static int descobrirMaisNovo(int[] idades)
        {
            int maisNovo = idades[0];
            int pos = 0;
            for (int i = 0; i < idades.Length; i++)
            {
                if (idades[i] < maisNovo)
                {
                    pos = i;
                    maisNovo = idades[i];
                }
            }
            return pos;
        }

        private static void exibeDezMaisNovos()
        {
            int[] posicao = maisNovos();
            Console.WriteLine("\n ========= 5 MAIS NOVOS =========");
            int pos = 0;
            for (int i = 0; i < posicao.Length; i++)
            {
                pos = posicao[i];
                Console.WriteLine("Nome: {0}", nome[pos]);
                Console.WriteLine("Idade: {0}", idade[pos]);
                Console.WriteLine("Sexo: {0}", sexo[pos]);
                Console.WriteLine("Adulto: {0}", adulto[pos]);
                Console.WriteLine("--------------------------------");
            }
            Console.WriteLine();
        }


        /* Mais alta */

        private static void exibeMaisAlta()
        {
            Console.WriteLine("===== MAIS ALTA =====");
            double maisAlta = 0;
            int pos = 0;
            for (int i = 0; i < altura.Length; i++)
            {
                if (altura[i] > maisAlta || i == 0)
                {
                    maisAlta = altura[i];
                    pos = i;
                }
            }
            Console.WriteLine("Nome: {0}", nome[pos]);
            Console.WriteLine("Idade: {0}", idade[pos]);
            Console.WriteLine("Sexo: {0}", sexo[pos]);
            Console.WriteLine("Adulto: {0}", adulto[pos]);
            Console.WriteLine("Altura: {0}", altura[pos]);
            Console.WriteLine("--------------------------------");
        }

        /* Mais Baixa */

        private static void exibeMaisBaixa()
        {
            Console.WriteLine("===== MAIS BAIXA =====");
            double maisBaixa = 0;
            int pos = 0;
            for (int i = 0; i < altura.Length; i++)
            {
                if (altura[i] < maisBaixa || i == 0)
                {
                    maisBaixa = altura[i];
                    pos = i;
                }
            }
            Console.WriteLine("Nome: {0}", nome[pos]);
            Console.WriteLine("Idade: {0}", idade[pos]);
            Console.WriteLine("Sexo: {0}", sexo[pos]);
            Console.WriteLine("Adulto: {0}", adulto[pos]);
            Console.WriteLine("--------------------------------");
        }
    }
}

using System;
using System.Linq;

namespace UNIDADE_XI.ExerciciosComplemetares
{
    internal class Exercicio_01
    {
        private static Random Gerador = new Random();

        public static void Main()
        {
            int[] resultado = new int[6];
            int[] aposta = new int[6];
            GerarResultado(ref resultado);
            GerarAposta(ref aposta);
            Ordenar(ref resultado);
            ExibirResultado(ref aposta, ref resultado);
            Console.ReadKey();
        }

        private static void GerarAposta(ref int[] aposta)
        {
            bool valido = false;
            int num = 0;
            Console.WriteLine("******** APOSTA *******\n");
            for (int i = 0; i < aposta.Length; i++)
            {
                valido = false;
                while (!valido)
                {
                    Console.Write("Digite o {0} numero: ", i + 1);
                    num = int.Parse(Console.ReadLine());
                    if (num < 1 || num > 60)
                    {
                        Console.WriteLine("\nNumero Inválido !! Digite novamente. (1 a 60)\n");
                        continue;
                    }
                    valido = true;
                    aposta[i] = num;
                }
            }
        }

        private static void GerarResultado(ref int[] resultado)
        {
            //Summary:
            //       Metodo usado para gerar o resultado da mega-sena
            for (int i = 0; i < resultado.Length; i++)
            {
                resultado[i] = Gerador.Next(0, 61);
            }
        }

        private static void ExibirResultado(ref int[] aposta, ref int[] resultado)
        {
            bool ganhou = true;
            int contAcertos = 0;
            Console.Write("\nSorteados: ");
            for (int i = 0; i < resultado.Length; i++)
            {
                Console.Write(" [ {0} ]", resultado[i]);
            }

            for (int i = 0; i < aposta.Length; i++)
            {
                if (!resultado.Contains(aposta[i]))
                {
                    ganhou = false;
                    break;
                }
                else
                {
                    contAcertos++;
                }
            }
            Console.Write("\t\t\n\nRESULTADO : ");
            if (ganhou)
            {
                Console.WriteLine("Ganhou !!");
            }
            else
            {
                Console.WriteLine("Perdeu !! ");
            }
            Console.Write("\nNumero de Acertos: {0}", contAcertos);
            if (contAcertos == 5)
            {
                Console.Write("\tQuina !!");
            }
        }

        private static int descobrirMenor(int[] array, int posInicio)
        {
            int posMenor = posInicio;
            for (int i = posInicio + 1; i < array.Length; i++)
            {
                if (array[i] < array[posMenor])
                {
                    posMenor = i;
                }
            }
            return posMenor;
        }

        private static void TrocarValores(ref int[] array, int pos1, int pos2)
        {
            int aux = array[pos1];
            array[pos1] = array[pos2];
            array[pos2] = aux;
        }

        private static void Ordenar(ref int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int menor = descobrirMenor(array, i);
                TrocarValores(ref array, i, menor);
            }
        }
    }
}
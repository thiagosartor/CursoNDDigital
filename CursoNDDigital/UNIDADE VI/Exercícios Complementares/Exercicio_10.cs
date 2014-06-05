using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIDADE_VI.Exercícios_Complementares
{
	class Exercicio_10
	{
		static void Main1(string[] args)
		{
			int valor1 = 0;
			int valor2 = 0;
			bool[] resultados = new bool[3];
			Console.WriteLine("==== Calculadora de Amizade de Numeros ====");
			for (int i = 0; i < 3; i++)
			{
				Console.WriteLine("==== Par {0} ====", i + 1);
				Console.Write("Digite o primeiro valor do par {0}: ", i + 1);
				valor1 = int.Parse(Console.ReadLine());
				Console.Write("Digite o segundo valor do par {0}: ", i + 1);
				valor2 = int.Parse(Console.ReadLine());
				resultados[i] = verificaAmizade(valor1, valor2); // Guarda o resultado: se são amigos (true) ou não são (false)
				Console.WriteLine("------------------------------- \n");
			}
			exibirResultados(ref resultados); // chama o metodo para exibir os resultados
			Console.ReadKey();
		}

		/*
		 * Metodo usado para verificar a amizade de dois valores (v1 , v2) 
		 */
		static bool verificaAmizade(int v1, int v2)
		{
			int somaDividoresV1 = divisores(v1); // chama o metodo para somar os divisores de v1
			int somaDivisoresV2 = divisores(v2); // chama o metodo para somar os divisores de v2
			if ((somaDividoresV1 == v2) && (somaDivisoresV2 == v1)) 
			{
				return true; // são amigos
			}
			return false; // não são
		}


		/**
		 * Metodo usado para encontrar a soma dos  divisores de um numero enviado por parametro (int num) 
		 */
		static int divisores(int num)
		{
			int[] divisores = new int[0];
			int somaDivisores = 0;
			for (int i = 1; i < num; i++)
			{
				if ((num % i) == 0)
				{
					somaDivisores += i;
				}
			}
			return somaDivisores;
		}

		/*
		 *Metodo usado para mostrar o resultado de cada par 
		 */
		static void exibirResultados(ref bool[] resultados)
		{
			Console.WriteLine("\n===== RESULTADOS =====");
			for (int i = 0; i < resultados.Length; i++)
			{
				if (resultados[i] == true)
				{
					Console.WriteLine("O par {0} sao numeros amigos !!", i + 1);
				}
				else
				{
					Console.WriteLine("O par {0} nao sao numeros amigos !!", i + 1);
				}
				Console.WriteLine();
			}
		}


	}
}

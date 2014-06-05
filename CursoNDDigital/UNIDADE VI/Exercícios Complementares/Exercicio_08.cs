using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIDADE_VI.Exercícios_Complementares
{
    class Exercicio_08_Alternativa
    {
        static void Main1(string[] args)
        {
            int numAutores = 0;
            Console.Write("Digite o numero de autores: ");
            numAutores = int.Parse(Console.ReadLine());

            string[] resultados = new string[numAutores];
            for (int i = 0; i < numAutores; i++)
            {
                Console.Write("\nDigite o nome do autor {0}: ", i+ 1);
                string texto = Console.ReadLine();
                resultados[i] = formatar(texto); // chama o metodo para formatar o texto e guarda o resultado
                Console.WriteLine();
            }
            exibirResultados(ref resultados);
            Console.ReadLine();
        }
        static string formatar(string texto)
        {
            string nome = texto.Substring(0, texto.LastIndexOf(' '));    // Copia a parte da variável texto até o ultimo espaço (retira o sobrenome)

            string sobrenome = texto.Remove(0, texto.LastIndexOf(' '));  // Remove a parte da variavel texto até o ultimo espaco (retira o nome)

            char[] nomeArrayChar = nome.ToLower().ToCharArray();        // todo o nome em miniscula, e tranforma em char[]

            nomeArrayChar[0] = Char.ToUpper(nome[0]);                   // primeira letra do nome maiuscula, substitui np char[]

            nome = new string(nomeArrayChar);                           // tranforma o array de char em string novamente

            return sobrenome.ToUpper() + ", " + nome; // SOBRENOME, nome
        }

        static void exibirResultados(ref string[] resultados)
        {
            Console.WriteLine("\n===== Resultados =======\n");
            for (int i = 0; i < resultados.Length; i++)
            {
                Console.WriteLine(resultados[i]); // mostra cada resultado
                Console.WriteLine();
            }
        }
    }


}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIDADE_VI.Exercícios_Complementares
{
    class Exercicio_09
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("===== Calculadora de Buracos =====");
            string texto;
            Console.Write("Digite um texto: ");
            texto = Console.ReadLine();
            Console.WriteLine("\n\n***** Resultado ******\n");
            Console.WriteLine("Texto: {0}", texto.ToUpper());
            Console.WriteLine("Numero de buracos do texto: {0}", contaBuracos(ref texto)); // Passa por referencia o texto digitado
            Console.ReadKey();
        }


        /**
         * Método usado para contar os buracos de um texto
         * 
         */
        static int contaBuracos(ref string texto)
        {
            int numBuracos = 0;
            char[] arrayTexto = texto.Trim().ToCharArray(); //  .Trim() retira os espaços 
            for (int i = 0; i < arrayTexto.Length; i++)
            {
                char letra = arrayTexto[i];
                numBuracos += contaNumBuracos(letra); // cada letra do texto para o metodo para obter o numero de buracos de cada letra, somando no total
            }
            return numBuracos; // retorna o total de buracos do texto 
        }


        /** 
         * Metodo usado para contar quantos buracos possui na letra passada por parametro
         */
        static int contaNumBuracos(char letra)
        { 
            // Converte a letra para maiúscula
            letra = Char.ToUpper(letra);
            switch (letra)
            {
               // Unicas letras que possuem buracos são A, D, O, P, Q e R
                case 'A':
                case 'Á':
                case 'À':
                case 'D':
                case 'O':
                case 'P':
                case 'Q':
                case 'R':
                    return 1;
                case 'B': // Apenas a letra B possui 2 buracos
                    return 2;
                default: // Qualquer uma diferente das citadas acima não possui buraco algum
                    return 0;
            }
        }

    }
}

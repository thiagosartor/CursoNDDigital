using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIDADE_VI.Exercícios_Complementares
{
    class Exercicio_02
    {
        static void Main1(string[] args)
        {
            string pass = "NomeUsuario123";
            bool acesso = false;
            if (obterDataCriacao(ref pass)) // Chama o metodo 
            {
                while (!acesso)
                {
                    Console.Write("Digite a senha: ");
                    string senha = Console.ReadLine();
                    if (senha.Equals(pass, StringComparison.InvariantCultureIgnoreCase)) // compara ignorando o case sensitive
                    {
                        Console.WriteLine("ACESSO PERMITIDO !!");
                        acesso = true; 
                    }
                    else
                    {
                        Console.WriteLine("ACESSO NEGADO !!");
                    }
                    Console.WriteLine();
                }
            }
            Console.ReadKey();
        }


        /**
         *  Metodo para verificar os dias passados
         */
        public static bool obterDataCriacao(ref String pass)
        {
            DateTime dtAtual = DateTime.Now;
            DateTime dtCriacao = new DateTime();
            bool valido = false;
            while (!valido)
            {
                Console.Write("Digite a data do cadastro (dd/MM/aaaa):  ");
                string dataCadastro = Console.ReadLine();
                if (converterData(dataCadastro, ref dtCriacao, ref dtAtual))
                {
                    valido = true;
                }
                Console.WriteLine();
            }
            int diasAtual = (dtAtual.Month * 30) + (dtAtual.Year * 360) + dtAtual.Day; // Total dias atual
            int diasCriacao = (dtCriacao.Month * 30) + (dtCriacao.Year * 360) + dtCriacao.Day; // Total dias da criacao
            int diasPassados = diasAtual - diasCriacao; // Diferença entre a data atual e a data de criacao em dias
            if (diasPassados >= 15)
            {
                dtCriacao = cadastrarSenha(ref pass);
            }
            return true;
        }


        private static DateTime cadastrarSenha(ref String pass)
        {
            DateTime dtCriacao;
            Console.WriteLine("==== Nessessário cadastro de nova senha ======");
            Console.WriteLine("O tempo da senha expirou. Cadastre uma nova senha !");
            Console.Write("Digite a nova senha: ");
            string novaSenha = Console.ReadLine();
            pass = novaSenha;
            dtCriacao = DateTime.Now;
            Console.WriteLine("Senha definida com sucesso !!");
            Console.WriteLine();
            return dtCriacao;
        }

        public static bool converterData(string dataCadastro, ref DateTime dtCriacao, ref DateTime dtAtual)
        {
            if (DateTime.TryParse(dataCadastro, out dtCriacao)) // Tenta converter
            {
                dtCriacao = DateTime.Parse(dataCadastro);
            }
            else
            {
                Console.WriteLine("Data Inválida !!");
                return false;
            }
            if (dtCriacao.CompareTo(dtAtual) > 0) // Data de criação é depois da data atual
            {
                Console.WriteLine("Data Inválida !!");
                return false;
            }
            Console.WriteLine();
            return true;
        }

    }
}

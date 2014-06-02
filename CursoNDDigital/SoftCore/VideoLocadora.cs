using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftCore
{
    internal class VideoLocadora
    {
        /* Tipo de consulta */
        private static int TIPO_CLIENTE = 1;
        private static int TIPO_FILME = 2;
        private static int TIPO_PRODUTO = 3;
        /* LOGIN*/
        public static int OpcaoLogin = 0;
        public static string CadastraNomeLogin = "";
        public static string CadastraSenhaLogin = "";
        public static string NomeLogin = "";
        public static string SenhaLogin = "";

        public static int contCliente = 4, contProduto = 4, contFilmes = 4;
        public static string[] CADASTRO_CLIENTE = { "Lucas", "Guilherme", "Felipe", "Thiago", "", "", "", "", "" };//[4]VAZIA pra ser alterada
        public static string[] CPF_CLIENTE = { "0123456", "987654", "6549843", "1598436", "", "", "", "", "" };
        public static string[] MATRICULA_CLIENTE = { "A123", "D456", "H789", "I8795", "", "", "", "" };
        public static double[] TOTAL_GASTO_CLIENTE = { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        public static string[,] PESSOAS_AUTORIZADAS = new string[2, 9];

        public static string[] CADASTRO_FILMES = { "Robocop", "Lagoa Azul", "Jogos Mortais", "Escritores da Liberdade", "", "", "", "", "" };
        public static string[] GENEROS_FILMES = { "Aventura", "Romance", "Terror", "Drama", "", "", "", "", "" };
        public static string[] CLASSIFICACAO_FILMES = { "Lançamento", "Antigo", "Clássicos ", "Educativos ", "", "", "", "", "" };
        public static int[] QUANTIDADE_FILMES = { 3, 4, 5, 6, 0, 0, 0, 0, 0 };

        public static string[] CADASTRO_PRODUTOS = { "Bala", "Refrigerante", "Salgadinho", "Pipoca", "", "", "", "", "" };
        public static double[] PREÇO_PRODUTOS = { 0.60, 4.00, 3.25, 3.50, 0, 0, 0, 0 };
        public static string[] CODIGO_PRODUTOS = { "B123", "R123", "S123", "P123", "", "", "", "", "" };
        public static int[] QUANTIDADE_PRODUTOS = { 3, 4, 5, 6, 0, 0, 0, 0, 0 };
        public static int[] QUANTIDADE_VENDA_PRODUTOS = { 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        // ARRAYS PARA A LOCAÇÃO
        public static int[] QUANTIDADE_FILMES_CLIENTE = { 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        public static int[] RESERVA_FILMES = { 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        public static int[] RESERVA_FILMES_CLIENTE = { 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        public static DateTime[] DATA_FILMES_CLIENTE = new DateTime[9];
        //---------------------------

        public static string Opc2, NomeCliente, NomeFilme, GeneroFilme, NomeProduto, OpcEscolha = null;
        public static double PrecoProduto;
        private static int numResult = 0;

        public static int OpcaoMenu = 0;
        public static int OpcaoSubmenu = 0;

        public static int NumLocacao = 0;

        public static int NumDevolucao = 0;

        private static void Main(string[] args)
        {
            //MenuInicialLoginOuCadastro();
            Menu();
        }

        private static void Menu()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\t       <<<<<< VIDEO LOCADORA BRASILEIRINHAS >>>>>> \t\t\t");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("  \t\t 1- CADASTRO \t\t 2- CONSULTA");
            Console.WriteLine("  \t\t 3- LOCAÇÃO  \t\t 4- VENDAS");
            Console.WriteLine("  \t\t 5- RELATÓRIOS \t\t 6- AJUDA \n\n");
            Console.Write("Digite a opção referente à ação a ser realizada: ");
            int.TryParse(Console.ReadLine(), out OpcaoMenu);
            switch (OpcaoMenu)
            {
                case 1: // CADASTRO;
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("\t       <<<<<< VIDEO LOCADORA BRASILEIRINHAS >>>>>> \t\t\t");
                    Console.BackgroundColor = ConsoleColor.Black;
                    OperacoesCadastro();
                    break;

                case 2: // CONSULTA;
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("\t       <<<<<< VIDEO LOCADORA BRASILEIRINHAS >>>>>> \t\t\t");
                    Console.BackgroundColor = ConsoleColor.Black;
                    OperacoesConsulta();
                    break;

                case 3: // LOCAÇÃO;
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("\t       <<<<<< VIDEO LOCADORA BRASILEIRINHAS >>>>>> \t\t\t");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.WriteLine("  \t\t 1- LOCAÇÃO DE FILMES");
                    Console.WriteLine("  \t\t 2- DEVOLUÇÃO DE FILMES");
                    Console.WriteLine("  \t\t 3- RESERVA DE FILMES");
                    Console.WriteLine("  \t\t 4- REMOVER RESERVA DE FILME");
                    Console.WriteLine("  \t\t 5- LOCAÇÃO POR AUTORIZAÇÃO");
                    Console.WriteLine("  \t\t 6- RETORNA AO MENU PRINCIPAL \n\n");
                    Console.Write(" Digite a opção referente à ação a ser realizada: ");
                    int.TryParse(Console.ReadLine(), out OpcaoSubmenu);
                    switch (OpcaoSubmenu)
                    {
                        case 1:
                            LocarFilme();
                            break;

                        case 2:
                            DevolverFilme();
                            break;

                        case 3:
                            ReservarFilme();
                            break;

                        case 4:
                            RemoverReservaFilme();
                            break;

                        case 5:
                            LocarFilmePorAutorizacao();
                            break;

                        case 6:
                            Menu();
                            break;

                        default:
                            Console.Clear();
                            Console.BackgroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("\t       <<<<<< VIDEO LOCADORA BRASILEIRINHAS >>>>>> \t\t\t");
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.WriteLine("\n\n");
                            Console.WriteLine("Você digitou um código inválido!!\n\n");
                            Console.WriteLine("Aperte qualquer tecla para voltar ao menu inicial...");
                            Console.ReadKey();
                            Menu();
                            break;
                    }
                    break;

                case 4: //VENDAS;
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("\t       <<<<<< VIDEO LOCADORA BRASILEIRINHAS >>>>>> \t\t\t");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.WriteLine("  \t\t 1- VENDA DE PRODUTOS");
                    Console.WriteLine("  \t\t 2- RETORNA AO MENU PRINCIPAL \n\n");
                    Console.Write(" Digite a opção referente à ação a ser realizada: ");
                    int.TryParse(Console.ReadLine(), out OpcaoSubmenu);
                    switch (OpcaoSubmenu)
                    {
                        case 1:
                            VenderProduto();
                            break;

                        case 2:
                            Menu();
                            break;

                        default:
                            Console.Clear();
                            Console.BackgroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("\t       <<<<<< VIDEO LOCADORA BRASILEIRINHAS >>>>>> \t\t\t");
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.WriteLine("\n\n");
                            Console.WriteLine("Você digitou um código inválido!!\n\n");
                            Console.WriteLine("Aperte qualquer tecla para voltar ao menu inicial...");
                            Console.ReadKey();
                            Menu();
                            break;
                    }
                    break;

                case 5: //RELATÓRIO;
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("\t       <<<<<< VIDEO LOCADORA BRASILEIRINHAS >>>>>> \t\t\t");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.WriteLine("   \t\t 1- FILMES    \t\t   2- CLIENTES");
                    Console.WriteLine("   \t\t 3- PRODUTOS  \t\t   4- VENDAS");
                    Console.WriteLine("   \t\t 7- RETORNA AO MENU PRINCIPAL \n\n");
                    Console.Write(" Digite a opção referente à ação a ser realizada: ");
                    int.TryParse(Console.ReadLine(), out OpcaoSubmenu);
                    switch (OpcaoSubmenu)
                    {
                        case 1:
                            RelTodosFilmes();

                            break;

                        case 2:
                            RelTodosCliente();
                            break;

                        case 3:
                            RelTodosProdutos();
                            break;

                        case 4:
                            RelatorioVendas();

                            break;

                        case 7:
                            Menu();
                            break;

                        default:

                            Console.Clear();
                            Console.BackgroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("\t       <<<<<< VIDEO LOCADORA BRASILEIRINHAS >>>>>> \t\t\t");
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.WriteLine("\n\n");
                            Console.WriteLine("Você digitou um código inválido!!\n\n");
                            Console.WriteLine("Aperte qualquer tecla para voltar ao menu inicial...");
                            Console.ReadKey();
                            Menu();
                            break;
                    }
                    break;

                case 6: // AJUDA;
                    MenuAjuda();
                    break;

                default: // TRATAMENTO DE ERROS;
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("\t       <<<<<< VIDEO LOCADORA BRASILEIRINHAS >>>>>> \t\t\t");
                    Console.BackgroundColor = ConsoleColor.Black;

                    Console.WriteLine("Você digitou um código inválido!!\n\n");
                    Console.WriteLine("Aperte qualquer tecla para voltar ao menu inicial...");
                    Console.ReadKey();
                    Menu();
                    break;
            }
            Console.ReadKey();
        }

        private static void MenuAjuda()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\t       <<<<<< VIDEO LOCADORA BRASILEIRINHAS >>>>>> \t\t\t");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("\n");
            Console.WriteLine("---------------------------------- CADASTROS -----------------------------------");
            Console.WriteLine("? Esta área é restrita para manutenção de sua locadora, tanto como cadastros de ");
            Console.WriteLine("clientes, filmes e produtos.\n");
            Console.WriteLine("? As opções dentro do menu CADASTROS ajudará você a cadastrar o item desejado.\n\n");
            Console.WriteLine("----------------------------------- CONSULTAS ----------------------------------");
            Console.WriteLine("? Está área foi desenvolvida para conferir preços, consultar os clientes e seus");
            Console.WriteLine("dados, preços, e mercadorias.");
            Console.WriteLine("? Use a opção correta para acessar a consulta, use apenas o número no menu para");
            Console.WriteLine("consultar a opção desejada.\n\n");
            Console.WriteLine("----------------------------------- LOCAÇÃO ----------------------------------");
            Console.WriteLine("? Área restrita aos funcionários, esta função você acessará sempre que alugar");
            Console.WriteLine("um filme ao seu cliente.");
            Console.WriteLine("? As opções dentro do menu LOCAÇÃO ajudará você a cadastrar o item desejado.\n\n");
            Console.WriteLine("------------------------------------ VENDAS ----------------------------------");
            Console.WriteLine("? Área restrita aos funcionários, esta função você acessará sempre que vender");
            Console.WriteLine("um produto ao seu cliente.(Bala/Refrigerante/Pipoca)");
            Console.WriteLine("? As opções dentro do menu VENDAS ajudará você a cadastrar o item desejado.\n\n");
            Console.WriteLine("---------------------------------- RELATÓRIOS ----------------------------------");
            Console.WriteLine("? Está opção você consultará relatórios gerais, como total de filmes alugados,");
            Console.WriteLine("valor das vendas e dos empréstimos.");
            Console.WriteLine("? As opções dentro do menu RELATÓRIOS ajudará você a cadastrar o item desejado.\n\n");
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine("Deseja voltar ao menu inicial? Aperte quaquer tecla para voltar...");
            Console.ReadKey();
            Menu();
        }

        //OPERAÇÕES CONSULTA CADASTRO
        private static void OperacoesConsulta()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\t       <<<<<< VIDEO LOCADORA BRASILEIRINHAS >>>>>> \t\t\t");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("  \t\t 16- CONSULTA DE CLIENTE");
            Console.WriteLine("  \t\t 17- CONSULTA DE FILME");
            Console.WriteLine("  \t\t 18- CONSULTA DE PRODUTOS");
            Console.WriteLine("  \t\t 19- RETORNA AO MENU PRINCIPAL \n\n");
            Console.Write(" Digite a opção referente à ação a ser realizada: ");

            Opc2 = Console.ReadLine();
            if (Opc2 == "19")
            {
                Menu();
            }
            if (Opc2 != "16" && Opc2 != "17" && Opc2 != "18")
            {
                Console.WriteLine("Opção Inválida !!\n\n");
                Console.WriteLine("Digite a tecla T para tentar novamente...");
                Console.WriteLine("Digite qualquer tecla para voltar ao menu....");
                Console.Write("OPÇÃO: ");
                OpcEscolha = Console.ReadLine();
                if (OpcEscolha == "T" || OpcEscolha == "t")
                {
                    OperacoesConsulta();
                }
                if (OpcEscolha != "T" && OpcEscolha != "t")
                {
                    Menu();
                }
            }
            if (Opc2 == "16")
            {
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("\t       <<<<<< VIDEO LOCADORA BRASILEIRINHAS >>>>>> \t\t\t");
                Console.BackgroundColor = ConsoleColor.Black;
                Opc2 = "";
                Console.WriteLine("  \t\t 1 - CONSULTA POR NOME");
                Console.WriteLine("  \t\t 2 - CONSULTA POR CPF");
                Console.WriteLine("  \t\t 3 - CONSULTA POR MATRÍCULA");
                Console.WriteLine("  \t\t 4 - RETORNA AO MENU PRINCIPAL \n\n");
                Console.Write(" Digite a opção referente à ação a ser realizada: ");
                Opc2 = Console.ReadLine();
                if (Opc2 != "1" && Opc2 != "2" && Opc2 != "3" && Opc2 != "4")
                {
                    Console.WriteLine("Opção Inválida !!\n\n");
                    Console.WriteLine("Aperte a tecla T para tentar novamente...");
                    Console.WriteLine("Aperte qualquer tecla para voltar ao menu....");
                    OpcEscolha = Console.ReadLine();
                    if (OpcEscolha == "T" || OpcEscolha == "t")
                    {
                        OperacoesConsulta();
                    }
                    if (OpcEscolha != "T" && OpcEscolha != "t")
                    {
                        Menu();
                    }
                }
                if (Opc2 == "1")
                {
                    ConsultaClientePorNome();
                }
                if (Opc2 == "2")
                {
                    ConsultaClientePorCPF();
                }
                if (Opc2 == "3")
                {
                    ConsultaClientePorMatricula();
                }
                if (Opc2 == "4")
                {
                    Menu();
                }
            }
            if (Opc2 == "17")
            {
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("\t       <<<<<< VIDEO LOCADORA BRASILEIRINHAS >>>>>> \t\t\t");
                Console.BackgroundColor = ConsoleColor.Black;
                Opc2 = "";
                Console.WriteLine("  \t\t 1 - CONSULTA POR NOME");
                Console.WriteLine("  \t\t 2 - CONSULTA POR GÊNERO");
                Console.WriteLine("  \t\t 3 - CONSULTA POR CLASSIFICAÇÃO");
                Console.WriteLine("  \t\t 4 - RETORNA AO MENU PRINCIPAL \n\n");
                Console.Write(" Digite a opção referente à ação a ser realizada: ");
                Opc2 = Console.ReadLine();
                if (Opc2 != "1" && Opc2 != "2" && Opc2 != "3" && Opc2 != "4")
                {
                    Console.WriteLine("Opção Inválida !!\n\n");
                    Console.WriteLine("Aperte a tecla T para tentar novamente...");
                    Console.WriteLine("Aperte qualquer tecla para voltar ao menu....");
                    OpcEscolha = Console.ReadLine();
                    if (OpcEscolha == "T" || OpcEscolha == "t")
                    {
                        OperacoesConsulta();
                    }
                    if (OpcEscolha != "T" && OpcEscolha != "t")
                    {
                        Menu();
                    }
                }
                if (Opc2 == "1")
                {
                    ConsultaFilmePorNome();
                }
                if (Opc2 == "2")
                {
                    ConsultaFilmePorGenero();
                }
                if (Opc2 == "3")
                {
                    ConsultaFilmePorClassificacao();
                }
                if (Opc2 == "4")
                {
                    Menu();
                }
            }
            if (Opc2 == "18")
            {
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("\t       <<<<<< VIDEO LOCADORA BRASILEIRINHAS >>>>>> \t\t\t");
                Console.BackgroundColor = ConsoleColor.Black;
                Opc2 = "";
                Console.WriteLine("  \t\t 1 - CONSULTA POR NOME ");
                Console.WriteLine("  \t\t 2 - CONSULTA POR CÓDIGO");
                Console.WriteLine("  \t\t 3 - CONSULTA POR PREÇO");
                Console.WriteLine("  \t\t 4 - RETORNA AO MENU PRINCIPAL \n\n");
                Console.Write(" Digite a opção referente à ação a ser realizada: ");
                Opc2 = Console.ReadLine();
                if (Opc2 != "1" && Opc2 != "2" && Opc2 != "3" && Opc2 != "4")
                {
                    Console.WriteLine("Opção Inválida !!\n\n");
                    Console.WriteLine("Aperte a tecla T para tentar novamente...");
                    Console.WriteLine("Aperte qualquer tecla para voltar ao menu....");
                    OpcEscolha = Console.ReadLine();
                    if (OpcEscolha == "T" || OpcEscolha == "t")
                    {
                        OperacoesConsulta();
                    }
                    if (OpcEscolha != "T" && OpcEscolha != "t")
                    {
                        Menu();
                    }
                }
                if (Opc2 == "1")
                {
                    ConsultaProdutoPorNome(); ;
                }
                if (Opc2 == "2")
                {
                    ConsultaProdutoPorCodigo();
                }
                if (Opc2 == "3")
                {
                    ConsultaProdutoPorPreco();
                }
                if (Opc2 == "4")
                {
                    Menu();
                }
            }
        }

        private static void OperacoesCadastro()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\t       <<<<<< VIDEO LOCADORA BRASILEIRINHAS >>>>>> \t\t\t");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("  \t\t 11 - CADASTRO DE CLIENTE");
            Console.WriteLine("  \t\t 12 - CADASTRO DE FILMES");
            Console.WriteLine("  \t\t 13 - CADASTRO DE PRODUTOS");
            Console.WriteLine("  \t\t 14 - ALTERAÇÕES");
            Console.WriteLine("  \t\t 15 - DELETAR");
            Console.WriteLine("  \t\t 16 - AUTORIZAR PESSOA");
            Console.WriteLine("  \t\t 17 - RETORNA AO MENU \n\n");
            Console.Write("Digite a opção desejada: ");
            Opc2 = Console.ReadLine();
            if (Opc2 != "11" && Opc2 != "12" && Opc2 != "13" && Opc2 != "14" && Opc2 != "15" && Opc2 != "16" && Opc2 != "17")
            {
                Console.WriteLine("Opção Inválida !!\n\n");
                Console.WriteLine("Digite qualquer tecla para voltar ao menu inicial...");
                Console.ReadKey();
                OperacoesCadastro();
            } if (Opc2 == "17")
            {
                Menu();
            }
            CadastrarCliente();
            CadastrarFilmes();
            CadastrarProdutos();
            Alteracoes();
            Remover();
            AutorizarPessoa();
        }

        private static void CadastrarProdutos()
        {
            if (Opc2 == "13")
            {
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("\t       <<<<<< VIDEO LOCADORA BRASILEIRINHAS >>>>>> \t\t\t");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine("\n");
                if (contProduto >= CADASTRO_PRODUTOS.Length)
                {
                    Console.WriteLine("A MEMÓRIA ESTÁ CHEIA!");
                    Console.WriteLine("NÃO SERÁ POSSIVEL FAZER NOVOS CADASTROS!");
                    return;
                }
                Console.Write("Digite o nome do produto que deseja efetuar o cadastro: ");
                NomeProduto = Console.ReadLine();
                CADASTRO_PRODUTOS[contProduto] = NomeProduto;
                Console.Write("Digite o preço do produto digitado: ");
                PrecoProduto = Convert.ToDouble(Console.ReadLine());
                PREÇO_PRODUTOS[contProduto] = PrecoProduto;
                Console.Write("Digite o código do produto: ");
                CODIGO_PRODUTOS[contProduto] = Console.ReadLine();
                Console.Write("Digite o quantidade do produto {0}: ", NomeProduto);
                QUANTIDADE_PRODUTOS[contProduto] = Convert.ToInt32(Console.ReadLine());
                contProduto++;
                Console.WriteLine("");
                Console.WriteLine("Produto {0} cadastrado com sucesso !!", NomeProduto);
                Console.WriteLine("Aperte qualquer tecla para voltar ao menu inicial...");
                Console.ReadKey();
                Menu();
            }
        }

        private static void CadastrarFilmes()
        {
            if (Opc2 == "12")
            {
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("\t       <<<<<< VIDEO LOCADORA BRASILEIRINHAS >>>>>> \t\t\t");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine("\n");
                if (contFilmes >= CADASTRO_FILMES.Length)
                {
                    Console.WriteLine("A MEMÓRIA ESTÁ CHEIA!");
                    Console.WriteLine("NÃO SERÁ POSSÍVEL CADASTRAR NOSSOS FILMES! ");
                    return;
                }
                Console.Write("Digite o nome do filme para efetuar o cadastro: ");
                NomeFilme = Console.ReadLine();
                CADASTRO_FILMES[contFilmes] = NomeFilme;
                Console.Write("Digite o gênero do filme digitado (Aventura/Romance/Terror/Drama): "); //Aventura", "Romance", "Terror", "Drama", "", "", "", "", "" };
                GeneroFilme = Console.ReadLine();
                GENEROS_FILMES[contFilmes] = GeneroFilme;
                Console.Write("Digite a classificação do filme: (Lançamento/Antigo/Clássicos/Educativos)");
                CLASSIFICACAO_FILMES[contFilmes] = Console.ReadLine();
                Console.Write("Digite o quantidade do filme {0}: ", NomeFilme);
                QUANTIDADE_FILMES[contFilmes] = Convert.ToInt32(Console.ReadLine());
                contFilmes++;
                Console.WriteLine("");
                Console.WriteLine("Filme {0} cadastrado com sucesso !!", NomeFilme);
                Console.WriteLine("Aperte qualquer tecla para voltar ao menu inicial...");
                Console.ReadKey();
                Menu();
            }
        }

        private static void CadastrarCliente()
        {
            if (Opc2 == "11")
            {
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("\t       <<<<<< VIDEO LOCADORA BRASILEIRINHAS >>>>>> \t\t\t");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine("\n");
                if (contCliente >= CADASTRO_CLIENTE.Length)
                {
                    Console.WriteLine("A MEMÓRIA ESTÁ CHEIA!");
                    Console.WriteLine("NÃO SERÁ POSSÍVEL CADASTRAR NOSSOS CLIENTES! ");
                    return;
                }
                Console.WriteLine("");
                Console.Write("Digite o nome do cliente para fazer o cadastro: ");

                NomeCliente = Console.ReadLine();
                CADASTRO_CLIENTE[contCliente] = NomeCliente;
                Console.Write("Digite o CPF: ");
                CPF_CLIENTE[contCliente] = Console.ReadLine();
                Console.Write("Digite a matrícula do cliente: ");
                MATRICULA_CLIENTE[contCliente] = Console.ReadLine();
                contCliente++;
                Console.WriteLine("Cliente {0} cadastrado com sucesso !!\n", NomeCliente);
                Console.WriteLine("Aperte qualquer tecla para voltar ao menu inicial...");
                Console.ReadKey();
                Menu();
            }
        }

        private static int PesquisarPosicao(string[] array, string texto)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Equals(texto, StringComparison.CurrentCultureIgnoreCase)) // procura a posicao do array igual ao texto informado
                {
                    return i;
                }
            }
            return -1;
        }

        // Alterar

        private static void Alteracoes()
        {
            if (Opc2 == "14")
            {
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("\t       <<<<<< VIDEO LOCADORA BRASILEIRINHAS >>>>>> \t\t\t");
                Console.BackgroundColor = ConsoleColor.Black;

                Console.WriteLine("   \t\t 1 - ALTERAÇÃO DE CLIENTE");
                Console.WriteLine("   \t\t 2 - ALTERAÇÃO DE PRODUTO");
                Console.WriteLine("   \t\t 3 - ALTERAÇÃO DE FILME");
                Console.WriteLine("   \t\t 4 - ADICIONAR ESTOQUES");
                Console.WriteLine("   \t\t 5 - VOLTAR AO MENU INICIAL\n\n");
                Console.Write(" Digite a opção referente à ação a ser realizada: ");
                int op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        Console.Clear();
                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("\t       <<<<<< VIDEO LOCADORA BRASILEIRINHAS >>>>>> \t\t\t");
                        Console.BackgroundColor = ConsoleColor.Black;
                        AlterarCliente();
                        break;

                    case 2:
                        Console.Clear();
                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("\t       <<<<<< VIDEO LOCADORA BRASILEIRINHAS >>>>>> \t\t\t");
                        Console.BackgroundColor = ConsoleColor.Black;
                        AlterarProduto();
                        break;

                    case 3:
                        Console.Clear();
                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("\t       <<<<<< VIDEO LOCADORA BRASILEIRINHAS >>>>>> \t\t\t");
                        Console.BackgroundColor = ConsoleColor.Black;
                        AlterarFilme();
                        break;

                    case 4:

                        AdicionarEstoque();
                        break;

                    case 5:
                        Menu();
                        break;

                    default:
                        Console.WriteLine("");
                        Console.WriteLine("Opção Inválida !!\n\n");
                        Console.WriteLine("Digite qualquer tecla para voltar ao menu inicial...");
                        Console.ReadKey();
                        Alteracoes();
                        break;
                }
            }
        }

        private static void AlterarCliente()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\t       <<<<<< VIDEO LOCADORA BRASILEIRINHAS >>>>>> \t\t\t");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("");
            Console.Write("Digite o nome do cliente: ");
            string nome = Console.ReadLine();
            int posicao = PesquisarPosicao(CADASTRO_CLIENTE, nome);
            if (posicao < 0)
            {
                Console.WriteLine("Não encontrado !!\n\n");
                Console.WriteLine("Digite a tecla T para alterar um cliente novamente...");
                Console.WriteLine("Digite qualquer tecla para voltar ao menu....");
                Console.Write("OPÇÃO:");
                OpcEscolha = Console.ReadLine();
                if (OpcEscolha == "T" || OpcEscolha == "t")
                {
                    AlterarCliente();
                }
                if (OpcEscolha != "T" && OpcEscolha != "t")
                {
                    Menu();
                }
            }
            else
            {
                Console.Write("Digite o novo nome do cliente: ");
                string nomeCliente = Console.ReadLine();
                CADASTRO_CLIENTE[posicao] = nomeCliente;

                Console.Write("Digite o novo CPF do cliente: ");
                string cpfCliente = Console.ReadLine();
                CPF_CLIENTE[posicao] = cpfCliente;

                Console.Write("Digite a nova matrícula do cliente: ");
                string matCliente = Console.ReadLine();
                MATRICULA_CLIENTE[posicao] = matCliente;
                Console.WriteLine("");
                Console.WriteLine("Cliente alterado com susesso !!\n\n");
                Console.WriteLine("Digite a tecla T para alterar um cliente novamente...");
                Console.WriteLine("Digite qualquer tecla para voltar ao menu....");
                Console.Write("OPÇÃO:");
                OpcEscolha = Console.ReadLine();
                if (OpcEscolha == "T" || OpcEscolha == "t")
                {
                    AlterarCliente();
                }
                if (OpcEscolha != "T" && OpcEscolha != "t")
                {
                    Menu();
                }
            }
        }

        private static void AlterarProduto()
        {
            Console.WriteLine("");
            Console.Write("Digite o nome do produto: ");
            string nome = Console.ReadLine();
            int posicao = PesquisarPosicao(CADASTRO_PRODUTOS, nome);
            if (posicao < 0)
            {
                Console.WriteLine("Não encontrado !!\n");
                Console.WriteLine("Digite a tecla T para alterar produto novamente...");
                Console.WriteLine("Digite qualquer tecla para voltar ao menu....");
                Console.Write("OPÇÃO:");
                OpcEscolha = Console.ReadLine();
                if (OpcEscolha == "T" || OpcEscolha == "t")
                {
                    AlterarProduto();
                }
                if (OpcEscolha != "T" && OpcEscolha != "t")
                {
                    Menu();
                }
            }
            else
            {
                Console.Write("Digite o novo nome do produto: ");
                string nomeProduto = Console.ReadLine();
                CADASTRO_PRODUTOS[posicao] = nomeProduto;

                Console.Write("Digite o novo preço  do produto: ");
                string precoProduto = Console.ReadLine();
                PREÇO_PRODUTOS[posicao] = double.Parse(precoProduto);

                Console.Write("Digite o novo código do produto: ");
                string codProduto = Console.ReadLine();
                MATRICULA_CLIENTE[posicao] = codProduto;

                Console.Write("Digite a nova quantidade  do produto: ");
                string qtdProduto = Console.ReadLine();
                QUANTIDADE_PRODUTOS[posicao] = int.Parse(qtdProduto);
                Console.WriteLine("");
                Console.WriteLine("Produto alterado com susesso !!\n\n");
                Console.WriteLine("Digite a tecla T para alterar produto novamente...");
                Console.WriteLine("Digite qualquer tecla para voltar ao menu....");
                Console.Write("OPÇÃO:");
                OpcEscolha = Console.ReadLine();

                if (OpcEscolha == "T" || OpcEscolha == "t")
                {
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("\t       <<<<<< VIDEO LOCADORA BRASILEIRINHAS >>>>>> \t\t\t");
                    Console.BackgroundColor = ConsoleColor.Black;
                    AlterarProduto();
                }
                if (OpcEscolha != "T" && OpcEscolha != "t")
                {
                    Console.Clear();
                    Menu();
                }
            }
        }

        private static void AlterarFilme()
        {
            Console.WriteLine("");
            Console.Write("Digite o nome do filme: ");
            string nome = Console.ReadLine();
            int posicao = PesquisarPosicao(CADASTRO_FILMES, nome);
            if (posicao < 0)
            {
                Console.WriteLine("Não encontrado !!");
                Console.ReadKey();
            }
            else
            {
                Console.Write("Digite o novo nome do filme: ");
                string nomeProduto = Console.ReadLine();
                CADASTRO_FILMES[posicao] = nomeProduto;

                Console.Write("Digite o novo gênero do filme (Aventura/Romance/Terror/Drama): "); //Aventura", "Romance", "Terror", "Drama", "", "", "", "", "" };
                GENEROS_FILMES[posicao] = Console.ReadLine();

                Console.Write("Digite a nova classificação do filme (Lançamento/Antigo/Clássicos/Educativos): ");
                CLASSIFICACAO_FILMES[posicao] = Console.ReadLine();
                Console.WriteLine("");
                Console.WriteLine("Produto alterado com susesso !!\n\n");
                Console.WriteLine("Digite a tecla T para alterar um filme novamente...");
                Console.WriteLine("Digite qualquer tecla para voltar ao menu....");
                Console.Write("OPÇÃO:");
                OpcEscolha = Console.ReadLine();

                if (OpcEscolha == "T" || OpcEscolha == "t")
                {
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("\t       <<<<<< VIDEO LOCADORA BRASILEIRINHAS >>>>>> \t\t\t");
                    Console.BackgroundColor = ConsoleColor.Black;
                    AlterarFilme();
                }
                if (OpcEscolha != "T" && OpcEscolha != "t")
                {
                    Console.Clear();
                    Menu();
                }
            }
        }

        /*   Remover */

        private static void Remover()
        {
            if (Opc2 == "15")
            {
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("\t       <<<<<< VIDEO LOCADORA BRASILEIRINHAS >>>>>> \t\t\t");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine("    \t\t1 - REMOVER CLIENTE");
                Console.WriteLine("    \t\t2 - REMOVER PRODUTO");
                Console.WriteLine("    \t\t3 - REMOVER FILME");
                Console.WriteLine("    \t\t4 - VOLTAR AO MENU\n\n");
                Console.Write(" Digite a opção referente à ação a ser realizada: ");
                int op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        Console.Clear();
                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("\t       <<<<<< VIDEO LOCADORA BRASILEIRINHAS >>>>>> \t\t\t");
                        Console.BackgroundColor = ConsoleColor.Black;
                        RemoverCliente();
                        break;

                    case 2:
                        Console.Clear();
                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("\t       <<<<<< VIDEO LOCADORA BRASILEIRINHAS >>>>>> \t\t\t");
                        Console.BackgroundColor = ConsoleColor.Black;
                        RemoverProduto();
                        break;

                    case 3:
                        Console.Clear();
                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("\t       <<<<<< VIDEO LOCADORA BRASILEIRINHAS >>>>>> \t\t\t");
                        Console.BackgroundColor = ConsoleColor.Black;
                        RemoverFilme();
                        break;

                    case 4:
                        Menu();
                        break;

                    default:

                        Console.WriteLine("Opção Inválida !!\n\n");
                        Console.WriteLine("Digite qualquer tecla para voltar ao menu inicial...");
                        Console.ReadKey();

                        Remover();
                        break;
                }
            }
        }

        private static void RemoverCliente()
        {
            Console.WriteLine("");
            Console.Write("Digite o nome do cliente a ser removido: ");
            string nome = Console.ReadLine();
            int posicao = PesquisarPosicao(CADASTRO_CLIENTE, nome);
            if (posicao < 0)
            {
                Console.WriteLine("Não encontrado !!");
                Console.WriteLine("Digite qualquer tecla para voltar ao menu inicial...");
                Console.ReadKey();
                Menu();
            }
            else
            {
                CADASTRO_CLIENTE[posicao] = "";
                CPF_CLIENTE[posicao] = "";
                MATRICULA_CLIENTE[posicao] = "";
                Console.WriteLine("Removido com sucesso!!!\n");
                Console.WriteLine("Digite qualquer tecla para voltar ao menu inicial...");
                Console.ReadKey();
                Menu();
            }
        }

        private static void RemoverProduto()
        {
            Console.WriteLine("");
            Console.Write("Digite o nome do produto a ser removido: ");
            string nome = Console.ReadLine();
            int posicao = PesquisarPosicao(CADASTRO_PRODUTOS, nome);
            if (posicao < 0)
            {
                Console.WriteLine("Não encontrado !!");
                Console.WriteLine("Digite qualquer tecla para voltar ao menu inicial...");
                Console.ReadKey();
                Menu();
            }
            else
            {
                CADASTRO_PRODUTOS[posicao] = "";
                PREÇO_PRODUTOS[posicao] = 0;
                MATRICULA_CLIENTE[posicao] = "";
                Console.WriteLine("Removido com sucesso!!!\n");
                Console.WriteLine("Digite qualquer tecla para voltar ao menu inicial...");
                Console.ReadKey();
                Menu();
            }
        }

        private static void RemoverFilme()
        {
            Console.WriteLine("");
            Console.Write("Digite o nome do filme a ser removido: ");
            string nome = Console.ReadLine();
            int posicao = PesquisarPosicao(CADASTRO_FILMES, nome);
            if (posicao < 0)
            {
                Console.WriteLine("Não encontrado !!\n");
                Console.WriteLine("Digite qualquer tecla para voltar ao menu inicial...");
                Console.ReadKey();
                Menu();
            }
            else
            {
                CADASTRO_FILMES[posicao] = "";
                GENEROS_FILMES[posicao] = "";
                CLASSIFICACAO_FILMES[posicao] = "";
                Console.WriteLine("Removido com sucesso!!!\n");
                Console.WriteLine("Digite qualquer tecla para voltar ao menu inicial...");
                Console.ReadKey();
                Menu();
            }
        }

        /*  Pesquisa */

        /*  Pesquisa */

        public static void Pesquisar(string[] array, string texto, int tipo)
        {
            bool encontrou = false;
            numResult = 0;
            Console.WriteLine("\n======== RESULTADO DA CONSULTA =========\n");
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Equals(texto, StringComparison.CurrentCultureIgnoreCase)) // procura a posicao do array igual ao texto informado
                {
                    if (tipo == TIPO_CLIENTE)
                    {
                        ExibirValores(CADASTRO_CLIENTE[i], CPF_CLIENTE[i], MATRICULA_CLIENTE[i], TOTAL_GASTO_CLIENTE[i].ToString(), i, TIPO_CLIENTE); //  exibe os valores do cliente na posicao i
                    }
                    else if (tipo == TIPO_FILME)
                    {
                        ExibirValores(CADASTRO_FILMES[i], GENEROS_FILMES[i], CLASSIFICACAO_FILMES[i].ToString(), QUANTIDADE_FILMES[i].ToString(), 0, TIPO_FILME); // exibe os filmes na posicao i
                    }
                    else
                    {
                        ExibirValores(CADASTRO_PRODUTOS[i], PREÇO_PRODUTOS[i].ToString(), CODIGO_PRODUTOS[i], null, 0, TIPO_PRODUTO); // exibe os produtos na posicao i
                    }
                    numResult++;
                    encontrou = true;
                }
            }
            if (!encontrou)
            {
                Console.WriteLine("");
                Console.Write("- Não Encontrado !!");
            }
            Console.WriteLine("\tNº de Resultados: {0}", numResult);
            Console.WriteLine("Digite qualquer tecla para voltar ao menu inicial...");
            Console.ReadKey();
            Menu();
        }

        private static void ExibirValores(string result1, string result2, string result3, string result4, int posCliente, int tipo)
        {
            string campo1 = null, campo2 = null, campo3 = null, campo4 = null;
            if (tipo == TIPO_CLIENTE)
            {
                campo1 = "Nome do cliente:";
                campo2 = "CPF:";
                campo3 = "Matricula: ";
                campo4 = "Total Gasto: R$";
            }
            else if (tipo == TIPO_FILME)
            {
                campo1 = "Nome do filme:";
                campo2 = "Gênero:";
                campo3 = "Clasificação:";
                campo4 = "Quantidade: ";
            }
            else
            {
                campo1 = "Nome do produto:";
                campo2 = "Preço:";
                campo3 = "Código:";
            }
            Console.WriteLine("{0} {1}\n", campo1, result1);
            Console.WriteLine("{0} {1}\n", campo2, result2);
            Console.WriteLine("{0} {1}\n", campo3, result3);
            Console.WriteLine("{0} {1}\n", campo4, result4);
            if (tipo == TIPO_CLIENTE)
            {
                ExibirAutorizadas(posCliente);
            }
            Console.WriteLine("--------------------------------");
        }

        /*  ============ Consulta  Cliente ================== */

        private static void ConsultaClientePorNome()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\t       <<<<<< VIDEO LOCADORA BRASILEIRINHAS >>>>>> \t\t\t");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("");
            Console.Write("Digite o nome do cliente para fazer a consulta: ");
            string nomePesquisa = Console.ReadLine();
            Pesquisar(CADASTRO_CLIENTE, nomePesquisa, TIPO_CLIENTE);
            Console.WriteLine("Digite qualquer tecla para voltar ao menu inicial...");
            Console.ReadKey();
            OperacoesConsulta();
        }

        private static void ConsultaClientePorCPF()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\t       <<<<<< VIDEO LOCADORA BRASILEIRINHAS >>>>>> \t\t\t");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("");
            Console.Write("Digite o CPF do cliente para fazer a consulta: ");
            string cpfPesquisa = Console.ReadLine();
            Pesquisar(CPF_CLIENTE, cpfPesquisa, TIPO_CLIENTE);
            Console.WriteLine("Digite qualquer tecla para voltar ao menu inicial...");
            Console.ReadKey();
            OperacoesConsulta();
        }

        private static void ConsultaClientePorMatricula()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\t       <<<<<< VIDEO LOCADORA BRASILEIRINHAS >>>>>> \t\t\t");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("");
            Console.Write("Digite a matrícula do cliente para fazer a consulta: ");
            string matriculaPesquisa = Console.ReadLine();
            Pesquisar(MATRICULA_CLIENTE, matriculaPesquisa, TIPO_CLIENTE);
            Console.WriteLine("Digite qualquer tecla para voltar ao menu inicial...");
            Console.ReadKey();
            OperacoesConsulta();
        }

        /*  ============ Consulta  Filme =============== */

        private static void ConsultaFilmePorNome()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\t       <<<<<< VIDEO LOCADORA BRASILEIRINHAS >>>>>> \t\t\t");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("");
            Console.Write("Digite o nome do filme para fazer a consulta: ");
            string nomePesquisa = Console.ReadLine();
            Pesquisar(CADASTRO_FILMES, nomePesquisa, TIPO_FILME);
            Console.WriteLine("Digite qualquer tecla para voltar ao menu inicial...");
            Console.ReadKey();
            OperacoesConsulta();
        }

        private static void ConsultaFilmePorGenero()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\t       <<<<<< VIDEO LOCADORA BRASILEIRINHAS >>>>>> \t\t\t");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("");
            Console.Write("Digite o gênero do filme para fazer a consulta: ");
            string generoPesquisa = Console.ReadLine();
            Pesquisar(GENEROS_FILMES, generoPesquisa, TIPO_FILME);
            Console.WriteLine("Digite qualquer tecla para voltar ao menu inicial...");
            Console.ReadKey();
            OperacoesConsulta();
        }

        private static void ConsultaFilmePorClassificacao()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\t       <<<<<< VIDEO LOCADORA BRASILEIRINHAS >>>>>> \t\t\t");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("");
            Console.Write("Digite a classificação do filme para fazer a consulta: ");
            string classPesquisa = Console.ReadLine();
            Pesquisar(CLASSIFICACAO_FILMES, classPesquisa, TIPO_FILME);
            Console.WriteLine("Digite qualquer tecla para voltar ao menu inicial...");
            Console.ReadKey();
            OperacoesConsulta();
        }

        /* =========== Consulta Produtos =========== */

        private static void ConsultaProdutoPorNome()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\t       <<<<<< VIDEO LOCADORA BRASILEIRINHAS >>>>>> \t\t\t");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("");
            Console.Write("Digite o nome do produto para fazer a consulta: ");
            string nomePesquisa = Console.ReadLine();
            Pesquisar(CADASTRO_PRODUTOS, nomePesquisa, TIPO_PRODUTO);
            Console.WriteLine("Digite qualquer tecla para voltar ao menu inicial...");
            Console.ReadKey();
            OperacoesConsulta();
        }

        private static void ConsultaProdutoPorPreco()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\t       <<<<<< VIDEO LOCADORA BRASILEIRINHAS >>>>>> \t\t\t");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("");
            Console.Write("Digite o preço do produto (Use vírgula): ");
            string precoPesquisa = double.Parse(Console.ReadLine()).ToString();
            Pesquisar(ArrayDoubleToArrayString(PREÇO_PRODUTOS), precoPesquisa, TIPO_PRODUTO);
            Console.WriteLine("Digite qualquer tecla para voltar ao menu inicial...");
            Console.ReadKey();
            OperacoesConsulta();
        }

        private static void ConsultaProdutoPorCodigo()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\t       <<<<<< VIDEO LOCADORA BRASILEIRINHAS >>>>>> \t\t\t");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("");
            Console.Write("Digite o código do produto para fazer a consulta: ");
            string codPesquisa = Console.ReadLine();
            Pesquisar(CODIGO_PRODUTOS, codPesquisa, TIPO_PRODUTO);
            Console.WriteLine("Digite qualquer tecla para voltar ao menu inicial...");
            Console.ReadKey();
            OperacoesConsulta();
        }

        /* ========== LOCAÇÃO DEVOLUÇÃO E RESERVAS ==*/
        /* Reservas */

        private static void ReservarFilme()
        {
            if (OpcaoSubmenu == 3)
            {
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("\t       <<<<<< VIDEO LOCADORA BRASILEIRINHAS >>>>>> \t\t\t");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine("");
                Console.Write("Digite o nome do cliente que quer fazer reserva: ");
                string nome = Console.ReadLine();
                int posicaoCliente = PesquisarPosicao(CADASTRO_CLIENTE, nome);
                if (posicaoCliente < 0)
                {
                    Console.WriteLine("\nNão encontrado !!\n");
                    Console.WriteLine("Aperte uma tecla para voltar ao menu...");
                    Console.ReadKey();
                    Menu();
                    return;
                }
                Console.WriteLine("");
                Console.Write("Digite o nome do filme a ser reservado: ");
                string nomeFilme = Console.ReadLine();
                int posicaoFilme = PesquisarPosicao(CADASTRO_FILMES, nomeFilme);
                if (posicaoFilme < 0)
                {
                    Console.WriteLine("\nNão encontrado !!");
                    Console.WriteLine("Aperte uma tecla para voltar ao menu...");
                    Console.ReadKey();
                    Menu();
                    return;
                }

                if (QUANTIDADE_FILMES[posicaoFilme] <= 0)
                {
                    Console.WriteLine("Sem quantidade no estoque !!");
                    Console.WriteLine("Aperte uma tecla para voltar ao menu...");
                    Console.ReadKey();
                    Menu();
                    return;
                }
                if (RESERVA_FILMES[posicaoFilme] == QUANTIDADE_FILMES[posicaoFilme])
                {
                    Console.WriteLine("Todos os filmes disponíveis já estão reservados !!");
                    Console.WriteLine("Aperte uma tecla para voltar ao menu...");
                    Console.ReadKey();
                    Menu();
                    return;
                }
                RESERVA_FILMES[posicaoFilme]++;
                RESERVA_FILMES_CLIENTE[posicaoCliente]++;
                Console.WriteLine("\n\t\t\tReserva Realizada com Sucesso !!!!\n");
                Console.WriteLine("Aperte qualquer tecla para voltar ao menu inicial...");
                Console.ReadKey();
                Menu();
            }
        }

        private static void RemoverReservaFilme()
        {
            if (OpcaoSubmenu == 4)
            {
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("\t       <<<<<< VIDEO LOCADORA BRASILEIRINHAS >>>>>> \t\t\t");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine("");
                Console.Write("Digite o nome do cliente: ");
                string nome = Console.ReadLine();
                int posicaoCliente = PesquisarPosicao(CADASTRO_CLIENTE, nome);
                if (posicaoCliente < 0)
                {
                    Console.WriteLine("\nNão encontrado !!\n");
                    Console.WriteLine("Aperte uma tecla para voltar ao menu...");
                    Console.ReadKey();
                    Menu();
                    return;
                }
                Console.Write("Digite o nome do filme para remover a reserva: ");
                string nomeFilme = Console.ReadLine();
                int posicaoFilme = PesquisarPosicao(CADASTRO_FILMES, nomeFilme);
                if (posicaoFilme < 0)
                {
                    Console.WriteLine("\nNão encontrado !!");
                    Console.WriteLine("Aperte uma tecla para voltar ao menu...");
                    Console.ReadKey();
                    Menu();
                    return;
                }
                if (RESERVA_FILMES[posicaoFilme] > 0)
                {
                    RESERVA_FILMES[posicaoFilme]--;
                    RESERVA_FILMES_CLIENTE[posicaoCliente]--;
                }
                else
                {
                    Console.WriteLine("O filme {0} não possui reservas !!", CADASTRO_FILMES[posicaoFilme]);
                    Console.WriteLine("Aperte uma tecla para voltar ao menu...");
                    Console.ReadKey();
                    Menu();
                    return;
                }
                Console.WriteLine("\n\t\t\tReserva Removida com Sucesso !!!!\n");
                Console.WriteLine("Aperte qualquer tecla para voltar ao menu inicial...");
                Console.ReadKey();
                Menu();
            }
        }

        /* Locação */

        private static void LocarFilme()
        {
            if (OpcaoSubmenu == 1)
            {
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("\t       <<<<<< VIDEO LOCADORA BRASILEIRINHAS >>>>>> \t\t\t");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine("Lançamento: R$7.00  Antigo: R$4.50  Clássicos: R$4.00  Educatios: R$3.50");

                Console.WriteLine("");
                Console.Write("Digite o nome do cliente que quer locar: ");
                string nome = Console.ReadLine();
                int posicaoCliente = PesquisarPosicao(CADASTRO_CLIENTE, nome);
                if (posicaoCliente < 0)
                {
                    Console.WriteLine("\nNão encontrado !!\n");
                    Console.WriteLine("Aperte uma tecla para voltar ao menu...");
                    Console.ReadKey();
                    Menu();
                    return;
                }
                Console.Write("Digite o nome do filme a ser locado: ");
                string nomeFilme = Console.ReadLine();
                int posicaoFilme = PesquisarPosicao(CADASTRO_FILMES, nomeFilme);
                if (posicaoFilme < 0)
                {
                    Console.WriteLine("\nNão encontrado !!\n");
                    Console.WriteLine("Aperte uma tecla para voltar ao menu...");
                    Console.ReadKey();
                    Menu();
                    return;
                }

                if (QUANTIDADE_FILMES[posicaoFilme] <= 0)
                {
                    Console.WriteLine("Sem quantidade no estoque !!\n");
                    Console.WriteLine("Aperte uma tecla para voltar ao menu...");
                    Console.ReadKey();
                    Menu();
                    return;
                }
                if (RESERVA_FILMES[posicaoFilme] == QUANTIDADE_FILMES[posicaoFilme])
                {
                    Console.WriteLine("\nTodos os filmes disponíveis já estão reservados!!\n");
                    Console.WriteLine("Aperte uma tecla para voltar ao menu...");
                    Console.ReadKey();
                    Menu();
                    return;
                }
                bool valido = false;
                while (!valido)
                {
                    Console.Write("Digite a data de locação (dd/MM/yyyy): ");
                    string data = Console.ReadLine();
                    if (DateTime.TryParse(data, out DATA_FILMES_CLIENTE[posicaoCliente]))
                    {
                        valido = true;
                    }
                    else
                    {
                        Console.WriteLine("Data Inválida !!! \n");
                    }
                }
                QUANTIDADE_FILMES[posicaoFilme]--;
                QUANTIDADE_FILMES_CLIENTE[posicaoCliente]++;
                TOTAL_GASTO_CLIENTE[posicaoCliente] += definirPrecoLocacao(CLASSIFICACAO_FILMES[posicaoFilme]);
                NumLocacao++;
                Console.WriteLine("\n\t\t\tLocação Realizada com Sucesso !!!!\n");
                Console.WriteLine("Aperte qualquer tecla para voltar ao menu inicial...");
                Console.ReadKey();
                Menu();
            }
        }

        private static double definirPrecoLocacao(string classificacao)
        {
            string[] classificacoes = { "Lançamento", "Antigo", "Clássicos ", "Educativos " };
            double[] precos = { 7.00, 4.50, 4.00, 3.50 }; // Lançamento: R$7.00  Antigo: R$4.50  Clássicos: R$4.00  Educatios: R$3.50
            for (int i = 0; i < classificacoes.Length; i++)
            {
                if (classificacoes[i].Equals(classificacao, StringComparison.CurrentCultureIgnoreCase))
                {
                    return precos[i];
                }
            }
            return -1;
        }

        /* Devolução */

        private static void DevolverFilme()
        {
            if (OpcaoSubmenu == 2)
            {
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("\t       <<<<<< VIDEO LOCADORA BRASILEIRINHAS >>>>>> \t\t\t");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine("");
                Console.Write("Digite o nome do cliente que devolveu o filme: ");
                string nome = Console.ReadLine();
                int posicaoCliente = PesquisarPosicao(CADASTRO_CLIENTE, nome);
                if (posicaoCliente < 0)
                {
                    Console.WriteLine("\nNão encontrado !!\n");
                    Console.WriteLine("Aperte uma tecla para voltar ao menu...");
                    Console.ReadKey();
                    Menu();
                    return;
                }
                Console.Write("Digite o nome do filme a ser devolvido: ");
                string nomeFilme = Console.ReadLine();
                int posicaoFilme = PesquisarPosicao(CADASTRO_FILMES, nomeFilme);
                if (posicaoFilme < 0)
                {
                    Console.WriteLine("\nNão encontrado !!");
                    Console.WriteLine("Aperte uma tecla para voltar ao menu...");
                    Console.ReadKey();
                    Menu();
                    return;
                }
                if (QUANTIDADE_FILMES_CLIENTE[posicaoCliente] > 0)
                {
                    QUANTIDADE_FILMES[posicaoFilme]++;
                    QUANTIDADE_FILMES_CLIENTE[posicaoCliente]--;
                }
                else
                {
                    Console.WriteLine("O cliente {0} não possui filmes locados !!\n", CADASTRO_CLIENTE[posicaoCliente]);
                }
                DATA_FILMES_CLIENTE[posicaoCliente] = new DateTime();
                NumDevolucao++;
                Console.WriteLine("\n\t\t\tDevolução Realizada com Sucesso !!!!\n");
                Console.WriteLine("Aperte qualquer tecla para voltar ao menu inicial...");
                Console.ReadKey();
                Menu();
            }
        }

        /* PÁGINA LOGIN*/

        private static void MenuInicialLoginOuCadastro()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\t    <<<<<< VIDEO LOCADORA BRASILEIRINHAS >>>>>> \t\t\t");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("  \t\t 1 - CADASTRAR    ");
            Console.WriteLine("  \t\t 2 - EFETUAR LOGIN     ");
            Console.WriteLine("  \t\t 3 - ENCERRAR PROGRAMA  \n\n");
            Console.Write(" Digite a opção referente à ação a ser realizada: ");
            OpcaoLogin = int.Parse(Console.ReadLine());
            switch (OpcaoLogin)
            {
                case 1: //cadastra login
                    CadastraLoginESenha();

                    break;

                case 2: //efetua login
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("\t    <<<<<< VIDEO LOCADORA BRASILEIRINHAS >>>>>> \t\t\t");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.WriteLine("\n");
                    Console.Write("Digite o nome de usuario para logar: ");
                    NomeLogin = Console.ReadLine();
                    VerificaLogin();
                    Console.ReadKey();
                    break;

                case 3:
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("\t    <<<<<< VIDEO LOCADORA BRASILEIRINHAS >>>>>> \t\t\t");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Environment.Exit(1);
                    break;

                default:
                    break;
            }
        }

        private static void VerificaLogin()
        {
            if (NomeLogin == CadastraNomeLogin)
            {
                VerificaSenha();
            }
            else
            {
                Console.WriteLine("Usuario não cadastrado, efetue o cadastro antes de logar...\n ");
                Console.Write("Aperte qualquer tecla para ir pra página de cadastros.");
                Console.ReadKey();
                CadastraLoginESenha();
            }
        }

        private static void VerificaSenha()
        {
            Console.Write("Digite a senha para logar: ");
            SenhaLogin = Console.ReadLine();
            if (SenhaLogin == CadastraSenhaLogin)
            {
                Menu();
            }
            else
            {
                Console.WriteLine("");
                Console.Write("Senha incorreta,por favor digite a senha novamente: ");
                Console.ReadKey();
                VerificaSenha();
            }
        }

        public static void CadastraLoginESenha()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\t    <<<<<< VIDEO LOCADORA BRASILEIRINHAS >>>>>> \t\t\t");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("\n");
            Console.Write("Digite o seu nome de usuario para cadastrar o login: ");
            CadastraNomeLogin = Console.ReadLine();
            CadastraNomeLogin += "123";
            CadastraSenhaLogin = "123" + CadastraNomeLogin;
            Console.WriteLine("\n");
            Console.WriteLine("Seu nome de usuario para login é: " + CadastraNomeLogin);
            Console.WriteLine("Sua senha de login é: " + CadastraSenhaLogin);
            Console.WriteLine("");
            Console.WriteLine("Aperte qualquer tecla para voltar à página de LOGIN...");
            Console.ReadKey();
            MenuInicialLoginOuCadastro();
        }

        // PRODUTOS VENDAS
        private static void VenderProduto()
        {
            if (OpcaoSubmenu == 1)
            {
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("\t       <<<<<< VIDEO LOCADORA BRASILEIRINHAS >>>>>> \t\t\t");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine("");
                Console.Write("Digite o nome do cliente: ");
                string nomeCliente = Console.ReadLine();
                int posicaoCliente = PesquisarPosicao(CADASTRO_CLIENTE, nomeCliente);
                if (posicaoCliente < 0)
                {
                    Console.WriteLine("Não encontrado!");
                    Console.ReadKey();
                    Menu();
                    return;
                }

                Console.Write("Digite o nome do produto que quer comprar: ");
                string nomeProduto = Console.ReadLine();
                int posicaoProduto = PesquisarPosicao(CADASTRO_PRODUTOS, nomeProduto);
                if (posicaoProduto < 0)
                {
                    Console.WriteLine("Não encontrado !!\n");
                    Console.WriteLine("Digite a tecla T para tentar novamente...");
                    Console.WriteLine("Digite qualquer tecla para voltar ao menu....");
                    Console.Write("OPÇÃO: ");
                    OpcEscolha = Console.ReadLine();
                    if (OpcEscolha == "T" || OpcEscolha == "t")
                    {
                        VenderProduto();
                    }
                    if (OpcEscolha != "T" && OpcEscolha != "t")
                    {
                        Menu();
                    }
                }
                else
                {
                    if (QUANTIDADE_PRODUTOS[posicaoProduto] <= 0)
                    {
                        Console.WriteLine("Quantidade Indiponível !! Há 0 produtos em estoque !!");
                        Console.WriteLine("Aperte qualquer tecla para voltar ao menu de Vendas...");
                        Console.ReadKey();
                        VenderProduto();
                        return;
                    }

                    Console.Write("Digite a quantidade desejada do produto {0}: ", CADASTRO_PRODUTOS[posicaoProduto]);

                    int qtdProduto = int.Parse(Console.ReadLine());
                    if (qtdProduto > QUANTIDADE_PRODUTOS[posicaoProduto])
                    {
                        Console.WriteLine("Quantidade Indiponível !! No estoque há {0} unidades de {1}\n", QUANTIDADE_PRODUTOS[posicaoProduto], CADASTRO_PRODUTOS[posicaoProduto]);
                        Console.WriteLine("Aperte qualquer tecla para voltar ao menu principal...");
                        Console.ReadKey();
                        Menu();
                        return;
                    }
                    Console.WriteLine("Compra realizada com sucesso!!");
                    Console.WriteLine("Total gasto em {0}: R${1:F2}\n", CADASTRO_PRODUTOS[posicaoProduto], (PREÇO_PRODUTOS[posicaoProduto] * qtdProduto));
                    QUANTIDADE_PRODUTOS[posicaoProduto] -= qtdProduto;
                    QUANTIDADE_VENDA_PRODUTOS[posicaoProduto]++;
                    TOTAL_GASTO_CLIENTE[posicaoCliente] += PREÇO_PRODUTOS[posicaoProduto] * qtdProduto;
                    Console.WriteLine("Aperte qualquer tecla para voltar ao menu principal...");
                    Console.ReadKey();
                    Menu();
                }
            }
        }

        //ESTOQUES
        private static void AdicionarEstoque()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\t       <<<<<< VIDEO LOCADORA BRASILEIRINHAS >>>>>> \t\t\t");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("");
            Console.Write("Digite o nome do produto que pretende adicionar estoque: ");
            string nome = Console.ReadLine();
            int posicao = PesquisarPosicao(CADASTRO_PRODUTOS, nome);
            if (posicao < 0)
            {
                Console.WriteLine("Não encontrado !!\n");
                Console.WriteLine("Digite a tecla T para cadastrar estoque novamente...");
                Console.WriteLine("Digite qualquer tecla para voltar ao menu....");
                Console.Write("OPÇÃO:");
                OpcEscolha = Console.ReadLine();
                if (OpcEscolha == "T" || OpcEscolha == "t")
                {
                    AdicionarEstoque();
                }
                if (OpcEscolha != "T" && OpcEscolha != "t")
                {
                    Menu();
                }
            }
            else
            {
                Console.Write("Digite a quantidade adicionada do produto {0}: ", CADASTRO_PRODUTOS[posicao]);
                int qtdNova = int.Parse(Console.ReadLine());
                if (qtdNova < 0)
                {
                    Console.WriteLine("Quantidade Inválida !!\n\n");
                    Console.WriteLine("Digite a tecla T para cadastrar estoque novamente...");
                    Console.WriteLine("Digite qualquer tecla para voltar ao menu....");
                    Console.Write("OPÇÃO:");
                    OpcEscolha = Console.ReadLine();
                    if (OpcEscolha == "T" || OpcEscolha == "t")
                    {
                        AdicionarEstoque();
                    }
                    if (OpcEscolha != "T" && OpcEscolha != "t")
                    {
                        Menu();
                    }
                    return;
                }
                QUANTIDADE_PRODUTOS[posicao] += qtdNova;
                Console.WriteLine("");
                Console.WriteLine("{0} quantidades do produto {1} cadastrado com sucesso!!", qtdNova, nome);
                Console.WriteLine("Agora o produto {0} possui {1} unidade(s).", nome, QUANTIDADE_PRODUTOS[posicao]);
                Console.WriteLine("");
                Console.WriteLine("Digite a tecla T para cadastrar estoque novamente...");
                Console.WriteLine("Digite qualquer tecla para voltar ao menu....");
                Console.Write("OPÇÃO:");
                OpcEscolha = Console.ReadLine();
                if (OpcEscolha == "T" || OpcEscolha == "t")
                {
                    AdicionarEstoque();
                }
                if (OpcEscolha != "T" && OpcEscolha != "t")
                {
                    Menu();
                }
            }
        }

        // RELATÓRIOS
        private static void RelTodosCliente()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\t       <<<<<< VIDEO LOCADORA BRASILEIRINHAS >>>>>> \t\t\t");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("");
            Console.WriteLine("========== Relatório de Clientes ==========");
            Console.WriteLine("Todos os clientes: \n");
            for (int i = 0; i < CADASTRO_CLIENTE.Length; i++)
            {
                if (CADASTRO_CLIENTE[i] != "")
                {
                    Console.WriteLine("Nome: {0}", CADASTRO_CLIENTE[i]);
                    Console.WriteLine("CPF: {0}", CPF_CLIENTE[i]);
                    Console.WriteLine("Matricula: {0}", MATRICULA_CLIENTE[i]);
                    Console.WriteLine("Quantidade de filmes em locação: {0}", QUANTIDADE_FILMES_CLIENTE[i]);
                    Console.WriteLine("Quantidade de filmes em reserva: {0}", RESERVA_FILMES_CLIENTE[i]);
                    Console.WriteLine("-------------------------------------------------------------------\n");
                }
            }
            Console.WriteLine("Aperte qualquer tecla para voltar ao menu....");
            Console.ReadKey();
            Menu();
        }

        private static void RelTodosFilmes()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\t       <<<<<< VIDEO LOCADORA BRASILEIRINHAS >>>>>> \t\t\t");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("");
            Console.WriteLine("========== Relatório de Filmes ==========");
            Console.WriteLine("Todos os filmes: \n");
            for (int i = 0; i < CADASTRO_FILMES.Length; i++)
            {
                if (CADASTRO_FILMES[i] != "")
                {
                    Console.WriteLine("Nome do Filme: {0}", CADASTRO_FILMES[i]);
                    Console.WriteLine("Gênero: {0}", GENEROS_FILMES[i]);
                    Console.WriteLine("Classificação: {0}", CLASSIFICACAO_FILMES[i]);
                    Console.WriteLine("Quantidade de filmes disponíveis: {0}", QUANTIDADE_FILMES[i]);
                    Console.WriteLine("Quantidade de filmes reservados: {0}", RESERVA_FILMES[i]);
                    Console.WriteLine("-------------------------------------------------------------------\n");
                }
            }
            Console.WriteLine("Aperte qualquer tecla para voltar ao menu...");
            Console.ReadKey();
            Menu();
        }

        private static void RelTodosProdutos()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\t       <<<<<< VIDEO LOCADORA BRASILEIRINHAS >>>>>> \t\t\t");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("");
            Console.WriteLine("========== Relatório de Produtos ==========");
            Console.WriteLine("Todos os produtos: \n");
            for (int i = 0; i < CADASTRO_PRODUTOS.Length; i++)
            {
                if (CADASTRO_PRODUTOS[i] != "")
                {
                    Console.WriteLine("Nome: {0}", CADASTRO_PRODUTOS[i]);
                    Console.WriteLine("PREÇO: {0}", PREÇO_PRODUTOS[i]);
                    Console.WriteLine("CÓDIGO: {0}", CODIGO_PRODUTOS[i]);
                    Console.WriteLine("Quantidade de {0}: {1}", CADASTRO_PRODUTOS[i], QUANTIDADE_PRODUTOS[i]);
                    Console.WriteLine("-------------------------------------------------------------------\n");
                }
            }
            Console.WriteLine("Aperte qualquer tecla para voltar ao menu...");
            Console.ReadKey();
            Menu();
        }

        private static void RelatorioVendas()
        {
            int totalQtdVendas = 0;
            double totalVendas = 0;
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\t       <<<<<< VIDEO LOCADORA BRASILEIRINHAS >>>>>> \t\t\t");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("");
            Console.WriteLine("========== Relatório de Vendas ==========");
            Console.WriteLine("Numero de vendas por produto: \n");
            for (int i = 0; i < QUANTIDADE_VENDA_PRODUTOS.Length; i++)
            {
                if (CADASTRO_PRODUTOS[i] != "")
                {
                    Console.WriteLine("Nome: {0}", CADASTRO_PRODUTOS[i]);
                    Console.WriteLine("Quantidade de vendas de {0}: {1}", CADASTRO_PRODUTOS[i], QUANTIDADE_VENDA_PRODUTOS[i]);
                    Console.WriteLine("Preço: {0:F2}", PREÇO_PRODUTOS[i]);
                    totalQtdVendas += QUANTIDADE_VENDA_PRODUTOS[i];
                    totalVendas += QUANTIDADE_VENDA_PRODUTOS[i] * PREÇO_PRODUTOS[i];
                    Console.WriteLine("-------------------------------------------------------------------\n");
                }
            }
            Console.WriteLine("\n****** RESULTADOS *****\n");
            Console.WriteLine("Total de Vendas: R$ {0}", totalVendas);
            Console.WriteLine("Quantidade Total de Vendas: {0}", totalQtdVendas);
            Console.WriteLine("");
            Console.WriteLine("Aperte qualquer tecla para voltar ao menu...");
            Console.ReadKey();
            Menu();
        }

        private static void AutorizarPessoa()
        {
            if (Opc2 == "16")
            {
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("\t       <<<<<< VIDEO LOCADORA BRASILEIRINHAS >>>>>> \t\t\t");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write("\n\nDigite o nome do cliente autorizador: ");
                string nome = Console.ReadLine();
                int posicaoCliente = PesquisarPosicao(CADASTRO_CLIENTE, nome);
                if (posicaoCliente < 0)
                {
                    Console.WriteLine("\nNão encontrado !!\n");
                    Console.WriteLine("Aperte qualquer tecla para voltar ao menu inicial...");
                    Menu();
                    return;
                }
                Console.Write("Digite o nome da pessoa autorizada: ");
                string nomeAuto = Console.ReadLine();
                Console.Write("Digite a ordem da pessoa autorizada (1ª ou 2ª): ");
                int ordem = int.Parse(Console.ReadLine());
                PESSOAS_AUTORIZADAS[posicaoCliente, --ordem] = nomeAuto;
                Console.WriteLine("\n\nPessoa Autorizada com Sucesso !!");
                Console.WriteLine("\nAperte qualquer tecla para voltar ao menu inicial...");
                Console.ReadKey();
                Menu();
            }
        }

        private static void LocarFilmePorAutorizacao()
        {
            if (OpcaoSubmenu == 5)
            {
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("\t       <<<<<< VIDEO LOCADORA BRASILEIRINHAS >>>>>> \t\t\t");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine("Lançamento: R$7.00  Antigo: R$4.50  Clássicos: R$4.00  Educatios: R$3.50");
                Console.WriteLine("");
                Console.Write("Digite o nome do cliente autorizador: ");
                string nome = Console.ReadLine();
                int posicaoCliente = PesquisarPosicao(CADASTRO_CLIENTE, nome);
                if (posicaoCliente < 0)
                {
                    Console.WriteLine("\nNão encontrado !!\n");
                    Console.WriteLine("Aperte uma tecla para voltar ao menu...");
                    Console.ReadKey();
                    Menu();
                    return;
                }
                Console.Write("Digite o nome da pessoa autorizada: ");
                string nomeAuto = Console.ReadLine();
                int posAutorizado = PesquisarPosicao(GetAutorizadas(posicaoCliente), nomeAuto);
                if (posAutorizado < 0)
                {
                    Console.WriteLine("\nNão encontrado !!\n");
                    Console.WriteLine("Aperte qualquer tecla para voltar ao menu inicial...");
                    Console.ReadKey();
                    Menu();
                    return;
                }
                Console.Write("Digite o nome do filme a ser locado: ");
                string nomeFilme = Console.ReadLine();
                int posicaoFilme = PesquisarPosicao(CADASTRO_FILMES, nomeFilme);
                if (posicaoFilme < 0)
                {
                    Console.WriteLine("\nNão encontrado !!\n");
                    Console.WriteLine("Aperte uma tecla para voltar ao menu...");
                    Console.ReadKey();
                    Menu();
                    return;
                }

                if (QUANTIDADE_FILMES[posicaoFilme] <= 0)
                {
                    Console.WriteLine("Sem quantidade no estoque !!\n");
                    Console.WriteLine("Aperte uma tecla para voltar ao menu...");
                    Console.ReadKey();
                    Menu();
                    return;
                }
                if (RESERVA_FILMES[posicaoFilme] == QUANTIDADE_FILMES[posicaoFilme])
                {
                    Console.WriteLine("\nTodos os filmes disponíveis já estão reservados!!\n");
                    Console.WriteLine("Aperte uma tecla para voltar ao menu...");
                    Console.ReadKey();
                    Menu();
                    return;
                }
                bool valido = false;
                while (!valido)
                {
                    Console.Write("Digite a data de locação (dd/MM/yyyy): ");
                    string data = Console.ReadLine();
                    if (DateTime.TryParse(data, out DATA_FILMES_CLIENTE[posicaoCliente]))
                    {
                        valido = true;
                    }
                    else
                    {
                        Console.WriteLine("Data Inválida !!! \n");
                    }
                }
                QUANTIDADE_FILMES[posicaoFilme]--;
                QUANTIDADE_FILMES_CLIENTE[posicaoCliente]++;
                TOTAL_GASTO_CLIENTE[posicaoCliente] += definirPrecoLocacao(CLASSIFICACAO_FILMES[posicaoFilme]);
                NumLocacao++;
                Console.WriteLine("\n\t\t\tLocação Realizada com Sucesso !!!!\n");
                Console.WriteLine("Aperte qualquer tecla para voltar ao menu inicial...");
                Console.ReadKey();
                Menu();
            }
        }

        private static void ExibirAutorizadas(int posCliente)
        {
            string[] autorizadas = GetAutorizadas(posCliente);

            Console.WriteLine("Pessoas Autorizadas: ");
            for (int i = 0; i < autorizadas.Length; i++)
            {
                Console.WriteLine("\t\t\t- " + PESSOAS_AUTORIZADAS[i, posCliente]);
            }
        }

        /* *** Metodos Auxiliares **** */

        private static string[] GetAutorizadas(int posCliente)
        {
            string[] autorizadas = new string[2];
            string nome;
            for (int i = 0; i < 2; i++)
            {
                nome = PESSOAS_AUTORIZADAS[i, posCliente];
                if (nome != null)
                {
                    autorizadas[i] = nome;
                }
                else
                {
                    autorizadas[i] = "";
                }
            }
            return autorizadas;
        }

        private static string[] ArrayDoubleToArrayString(double[] array)
        {
            string[] novo = new string[array.Length];
            for (int i = 0; i < novo.Length; i++)
            {
                novo[i] = array[i].ToString();
            }
            return novo;
        }
    }
}

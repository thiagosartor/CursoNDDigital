using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftGRA
{
    internal class Program
    {
        #region

        //VARIÁVEIS GLOBAIS

        public static int auxilia2 = 0;
        public static int auxilia = 0;
        public static int escolha;
        public static string[,] fornecedor = new string[31, 10];
        public static string[,] fornecedorEntrada = new string[31, 10];
        public static string[,] produtoEntrada = new string[31, 10];
        public static string[,] produto = new string[31, 10];
        public static int[,] quantidadeProduto = new int[31, 10];
        public static int[,] quantidadeProdutoSaida = new int[31, 10];
        public static double[,] precoProdutoSaida = new double[31, 10];
        public static double[,] precoProdutoEntrada = new double[31, 10];
        public static bool continuar = true;
        public static int aux = 0;
        public static int aux2 = 0;
        public static int teclou = 0;
        public static int i = 0;
        public static int j = 0;
        public static int i2 = 0;
        public static int dia = 0;
        public static int mes = 0;
        public static int[] SomaQuantidadeProduto = new int[99];
        public static int[,] SomaQuantidade = new int[31, 10];
        private static int somaProdutos = 0;
        private static int somaProdutosSaida = 0;
        private static int[] somaFornecedor = new int[4];
        private static int[] ajudaDia = new int[31];
        private static int somatorio = 0;
        private static int count = 0;
        private static int[,] SomaQuantidadeProdutoSaida = new int[31, 10];
        #endregion
        #region

        //MÉTODO MAIN - CHAMANDO MÉTODOS
        private static void Main(string[] args)
        {
            //Login();
            PedeData();
            escolha = Menu();
            AvaliaSituacao(escolha);
            Console.ReadKey();
        }

        // TELA DE LOGIN
        private static void Login()
        {
        Volta:
            Console.Clear();
            string login, senha;
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("\t\t\t ****************************** \n\t\t\t*\t\t\t       *\n");
            Console.Write("\t\t\t*\t  SmartGRA Super       *\n\t\t\t*         ______________       *\n");
            Console.Write("\t\t\t*\t                       *\n\t\t\t*\t\t\t       *\n");
            Console.Write("\t\t\t*\t  Login:\t       *\n\t\t\t*\t\t\t       *\n");
            Console.Write("\t\t\t*\t  Senha:\t       *\n\t\t\t*\t\t\t       *\n");
            Console.Write("\t\t\t*\t                       *\n\t\t\t*\t\t\t       *\n");
            Console.Write("\t\t\t ****************************** \n\t\t\t\t\t\t       \n");

            Console.SetCursorPosition(40, 6);
            Console.ForegroundColor = ConsoleColor.DarkGray;
            login = Console.ReadLine();
            Console.SetCursorPosition(40, 8);
            Console.ForegroundColor = ConsoleColor.Black;
            senha = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkGray;
            if (login.ToLower() == "thiago" && senha.ToLower() == "thiago123")
                Console.Clear();
            else
            {
                Console.WriteLine("\n\t\t\t*  Senha ou Conta Inexistente!");
                Console.WriteLine("\n\n\n\t\t    Aperte uma tecla para tentar novamente!");
                Console.ReadKey();
                goto Volta;
            }
        }

        // TELA QUE PEDE A DATA
        private static void PedeData()
        {
            if (teclou == 1)
            {
                Login();
            }
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("\t\t\t ****************************** \n\t\t\t*\t\t\t       *\n");
            Console.Write("\t\t\t*\t  SmartGRA Super       *\n\t\t\t*         ______________       *\n");
            Console.Write("\t\t\t*\t                       *\n\t\t\t*\t\t\t       *\n");
            Console.Write("\t\t\t*\t  Data:\t               *\n\t\t\t*\t\t\t       *\n");
            Console.Write("\t\t\t*\t                       *\n\t\t\t*\t\t\t       *\n");
            Console.Write("\t\t\t ****************************** \n\t\t\t\t\t\t       \n");
            Console.SetCursorPosition(39, 6);
            try
            {
                dia = int.Parse(Console.ReadLine());
                if (dia > 30 || dia < 1)
                {
                    PedeData();
                }
            }
            catch (Exception)
            {
                PedeData();
            }

            Console.SetCursorPosition(41, 6);
            Console.Write("/10");
            Console.SetCursorPosition(42, 6);

            if (somatorio != 0)
            {
                for (int i = 0; i <= somatorio; i++)
                {
                    if (dia < ajudaDia[i])
                    {
                        Console.SetCursorPosition(15, 12);
                        Console.WriteLine("Não se pode pedir um dia que não foi cadastrado no sistema!");
                        Console.SetCursorPosition(15, 13);
                        Console.WriteLine("     Deseja voltar? S/N - Se for não, o sistema fechará.");
                        Console.SetCursorPosition(20, 14);
                        Console.Write("          Resposta: ");
                        char aceita2 = char.Parse(Console.ReadLine());
                        if (aceita2 == 'S' || aceita2 == 's')
                        {
                            PedeData();
                        }
                    }
                }
            }

            somatorio++;
            ajudaDia[somatorio] = dia;
            Console.SetCursorPosition(26, 8);
            Console.Write(" Deseja ir ao menu? S/N?[ ]");
            Console.SetCursorPosition(51, 8);
            try
            {
                char aceita = char.Parse(Console.ReadLine());
                if (aceita == 'S' || aceita == 's')
                {
                    VoltaMenu();
                }
                else
                    PedeData();
            }
            catch (Exception)
            {
                PedeData();

            }





        }

        // TELA QUE MOSTRA O MENU COM AS OPÇÕES
        private static int Menu()
        {
            Console.Clear();
            Console.Write("\t ************************************************************** \n\t*\t\t\t\t\t\t\t       *\n");
            Console.WriteLine("\t*\t\t\t SmartGRA Super       \t\t       *\n\t*\t\t\t ______________       \t\t       *\n\t*\t\t\t\t\t\t\t       *\n\t*\t\t\t\t\t\t\t       *\n\t*\t\t\t\t\t\t               *");
            Console.WriteLine("\t*       1. IMPLEMENTAR CADASTRO                                *");
            Console.WriteLine("\t*                                                              *");
            Console.WriteLine("\t*       2. CONSULTAS                                           *");
            Console.WriteLine("\t*                                                              *");
            Console.WriteLine("\t*       3. RELATÓRIO                                           *");
            Console.WriteLine("\t*                                                              *");
            Console.WriteLine("\t*       4. AJUDA                                               *");
            Console.WriteLine("\t*                                                              *");
            Console.WriteLine("\t*       5. DATA                                                *");
            Console.WriteLine("\t*                                                              *");
            Console.WriteLine("\t*       ESCOLHA:                                               *");
            Console.Write("\t ************************************************************** \n\n");
            Console.SetCursorPosition(25, 17);
            return int.Parse(Console.ReadLine());
        }

        #endregion
        #region

        // MENU DE IMPLEMENTO (CADASTRO, TABELA, CONTROLE, FORNECEDOR)
        private static void ImplementoCadastro()
        {
            Console.Clear();
            Console.Write("\t ************************************************************** \n\t*\t\t\t\t\t\t\t       *\n");
            Console.WriteLine("\t*\t\t\t SmartGRA Super       \t\t       *\n\t*\t\t\t ______________       \t\t       *\n\t*\t\t\t\t\t\t\t       *\n\t*\t\t\t\t\t\t\t       *\n\t*\t\t\t\t\t\t               *");
            Console.WriteLine("\t*       1. REMOVER PRODUTOS                                    *");
            Console.WriteLine("\t*                                                              *");
            Console.WriteLine("\t*       2. TABELA - VENDA E CUSTO                              *");
            Console.WriteLine("\t*                                                              *");
            Console.WriteLine("\t*       3. CONTROLE & CADASTRO DE PRODUTOS (SAÍDA-ENTRADA)     *");
            Console.WriteLine("\t*                                                              *");
            Console.WriteLine("\t*       4. FORNECEDOR                                          *");
            Console.WriteLine("\t*                                                              *");
            Console.WriteLine("\t*       0. MENU                                                *");
            Console.WriteLine("\t*                                                              *");
            Console.WriteLine("\t*       ESCOLHA:                                               *");
            Console.Write("\t ************************************************************** \n\n");
            Console.SetCursorPosition(25, 17);
            escolha = int.Parse(Console.ReadLine());
            #region
            switch (escolha)
            {
                case 1:
                    RemoverProdutos();
                    break;

                case 2:
                    Tabela();
                    break;

                case 3:
                    Controle();
                    break;

                case 4:
                    Fornecedor();
                    break;

                case 0:
                    VoltaMenu();
                    break;
            #endregion
            }
        }

        //CADASTRAMENTO DE PRODUTOS
        private static void RemoverProdutos()
        {
            Console.Clear();
            Console.Write("\t ************************************************************** \n\t*\t\t\t\t\t\t\t       *\n");
            Console.WriteLine("\t* Qual Produto Deseja Remover?                                 *");
            Console.WriteLine("\t*                                                              *");
            Console.WriteLine("\t* Qual Fornecedor?                                             *");
            Console.WriteLine("\t*                                                              *");
            Console.WriteLine("\t*                                                              *");
            Console.WriteLine("\t*                                                              *");
            Console.WriteLine("\t*                                                              *");
            Console.WriteLine("\t*                                                              *");
            Console.Write("\t ************************************************************** \n\n");
            Console.SetCursorPosition(39, 2);
            string remove = Console.ReadLine();
            Console.SetCursorPosition(27, 4);
            string fornece = Console.ReadLine();
            bool ajudaMetodo = false;
            for (int i = 0; i <= aux; i++)
            {
                for (int z = 0; z <= dia; z++)
                {
                    if (produtoEntrada[z, i] == remove && fornecedorEntrada[dia, i] == fornece)
                    {
                        ajudaMetodo = true;
                        if (ajudaMetodo == true)
                        {
                            produtoEntrada[z, i] = null;
                            produto[z, i] = null;
                            Console.SetCursorPosition(32, 6);
                            Console.WriteLine("Produto removido com sucesso!");
                            goto vai;
                        }
                    }
                }
            }
            if (ajudaMetodo == false)
            {
                Console.SetCursorPosition(25, 6);
                Console.WriteLine("Produto não encontrado!");
            }
        vai:
            Console.SetCursorPosition(25, 7);
            Console.WriteLine("Deseja voltar ao menu? S/N: ");
            Console.SetCursorPosition(53, 7);
            char voltamenu = char.Parse(Console.ReadLine());
            if (voltamenu == 'S' || voltamenu == 's')
            {
                VoltaMenu();
            }
            else
            {
                RemoverProdutos();
            }
        }

        // MOSTRA OS PRODUTOS EM TABELA
        private static void Tabela()
        {
            Console.Clear();
            for (int i = 0; i < aux; i++)
            {
                for (int c = 0; c <= dia; c++)
                {
                    if (produtoEntrada[c, i] != null)
                    {
                        Console.WriteLine("Produto: " + produtoEntrada[c, i]);
                        Console.WriteLine("Quantidade de entrada: " + quantidadeProduto[c, i]);
                        Console.WriteLine("Valor de Entrada: " + precoProdutoEntrada[c, i]);
                        Console.WriteLine(" ");
                        Console.WriteLine("--------------------------------------");
                    }
                }
            }
            Console.WriteLine("");
            int j = 0;
            for (int i = 0; i < aux; i++)
            {
                for (int c = 0; c <= dia; c++)
                {
                    if (produto[c, i] != null)
                    {
                        Console.SetCursorPosition(40, j++);
                        Console.WriteLine("Produto: " + produto[c, i]);
                        Console.SetCursorPosition(40, j++);
                        Console.WriteLine("Quantidade de saída: " + quantidadeProdutoSaida[c, i]);
                        Console.SetCursorPosition(40, j++);
                        Console.WriteLine("Valor de Saída: " + precoProdutoSaida[c, i]);
                        Console.SetCursorPosition(40, j++);
                        Console.WriteLine("Quantidade atual: " + Soma(c, i));
                        Console.SetCursorPosition(40, j++);
                        Console.WriteLine("----------------------------------");
                    }
                }
            }
            Console.WriteLine("\n\n\t\t\t    Digite algo para sair...");

            string escreve = Console.ReadLine();
            if (escreve != null)
            {
                VoltaMenu();
            }
        }

        #region

        // CONTROLE DE ENTRADA E SAÍDA
        private static void Controle()
        {
            continuar = true;
            Console.Clear();
            Console.Write(
                "\t ************************************************************** \n\t*\t\t\t\t\t\t\t       *\n");
            Console.WriteLine(
                "\t*\t\t\t SmartGRA Super       \t\t       *\n\t*\t\t\t ______________       \t\t       *\n\t*\t\t\t\t\t\t\t       *\n\t*\t\t\t\t\t\t\t       *\n\t*\t\t\t\t\t\t               *");
            Console.WriteLine("\t*                           CONTROLE                           *");
            Console.WriteLine("\t*                                                              *");
            Console.WriteLine("\t*    1.  Entrada                                               *");
            Console.WriteLine("\t*                                                              *");
            Console.WriteLine("\t*    2.  Saída                                                 *");
            Console.WriteLine("\t*                                                              *");
            Console.WriteLine("\t*    DIGITE AQUI:                                              *");
            Console.WriteLine("\t*                                                              *");
            Console.Write("\t ************************************************************** \n\n");
            try
            {
                Console.SetCursorPosition(26, 13);
                escolha = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                VoltaMenu();
            }

            switch (escolha)
            {
                case 1:
                    Entrada();
                    break;

                case 2:
                    Saida();
                    break;

                default:
                    VoltaMenu();
                    break;
            }
        }

        // MÉTODO QUE FAZ A ENTRADA DOS PRODUTOS
        private static void Entrada()
        {
            EscreveEntrada();

            while (continuar != false)
            {
                #region
                Console.SetCursorPosition(24, 9);
                fornecedorEntrada[dia, i] = Console.ReadLine();
                for (int d = 0; d < aux; d++)
                {
                    if (fornecedorEntrada[dia, i] == fornecedorEntrada[dia, d])
                    {
                        fornecedorEntrada[dia, i] = null;
                    }
                }

                Console.SetCursorPosition(21, 11);
                produtoEntrada[dia, i] = Console.ReadLine();
            volta2:
                try
                {
                    Console.SetCursorPosition(60, 11);
                    quantidadeProduto[dia, i] = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    goto volta2;
                }
                #endregion

                for (int z = 0; z < aux; z++)
                {
                    for (int d = 0; d <= dia; d++)
                    {
                        if (produtoEntrada[dia, i] == produtoEntrada[d, z] && aux != 0 && fornecedor[dia, i] == fornecedor[d, z])
                        {
                            quantidadeProduto[d, z] += quantidadeProduto[dia, i];
                            quantidadeProduto[dia, i] = 0;
                            produtoEntrada[dia, i] = null;
                            goto vai;
                        }
                    }
                }

                Console.SetCursorPosition(30, 13);
                precoProdutoEntrada[dia, i] = double.Parse(Console.ReadLine());
            vai:
                Console.SetCursorPosition(55, 13);
                char sair = char.Parse(Console.ReadLine());
                if (sair == 'n' || sair == 'N')
                {
                    continuar = false;
                }

                i++;
                j++;
                aux++;
                EscreveEntrada();
            }
            Controle();
        }

        // MÉTODO QUE FAZ A SAÍDA DOS PRODUTOS
        private static void Saida()
        {
            EscreveSaida();
            #region
            while (continuar != false)
            {
                bool recebe = false;
                Console.SetCursorPosition(24, 9);
                fornecedor[dia, i2] = Console.ReadLine();
                for (int c = 0; c <= aux; c++)
                {
                    for (int z = 0; z <= dia; z++)
                    {
                        if (fornecedor[dia, i2] == fornecedorEntrada[z, c])
                        {
                            recebe = true;
                            break;
                        }
                    }
                }
                if (recebe == false)
                {
                    Saida();
                }
                recebe = false;
                Console.SetCursorPosition(21, 11);
                produto[dia, i2] = Console.ReadLine();

                for (int i = 0; i <= aux; i++)
                {
                    for (int z = 0; z <= dia; z++)
                    {
                        if (produto[dia, i2] == produtoEntrada[z, i])
                        {
                            recebe = true;
                            break;
                        }
                    }
                }
                if (recebe == false)
                {
                    Saida();
                }
            #endregion
                count++;
            volta:

                Console.SetCursorPosition(60, 11);
                try
                {
                    quantidadeProdutoSaida[dia, i2] = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {

                    Saida();
                }


                if (quantidadeProdutoSaida[dia, i2] == 0)
                {
                    goto volta2;
                }

                for (int d = 0; d <= aux2; d++)
                {
                    if (quantidadeProdutoSaida[dia, i2] > quantidadeProduto[dia, d] && fornecedor[dia, i2] == fornecedor[dia, d] && produtoEntrada[dia, d] == produto[dia, i2])
                    {
                        quantidadeProdutoSaida[dia, i2] = 0;
                        goto volta;
                    }
                }
                if (aux2 != 0)
                {
                    for (int z = 0; z < aux2; z++)
                    {
                        for (int d = 0; d <= dia; d++)
                        {
                            if (produto[dia, i2] == produtoEntrada[d, z])
                            {
                                somaProdutosSaida += quantidadeProdutoSaida[dia, i];
                                produto[dia, i] = null;
                                quantidadeProdutoSaida[dia, i2] = 0;
                                goto volta2;
                            }
                        }
                    }
                }


                Console.SetCursorPosition(30, 13);
                precoProdutoSaida[dia, i2] = double.Parse(Console.ReadLine());
            volta2:
                Console.SetCursorPosition(55, 13);
                char sair = char.Parse(Console.ReadLine());
                if (sair == 'N' || sair == 'n')
                {
                    continuar = false;
                }
                i2++;
                aux2++;
                EscreveSaida();
            }

            Controle();
        }

        // MÉTODO QUE ESCREVE A ENTRADA DE PRODUTOS
        private static void EscreveEntrada()
        {
            Console.Clear();
            Console.Write(
                "\t ************************************************************** \n\t*\t\t\t\t\t\t\t       *\n");
            Console.WriteLine(
                "\t*\t\t\t SmartGRA Super       \t\t       *\n\t*\t\t\t ______________       \t\t       *\n\t*\t\t\t\t\t\t\t       *\n\t*\t\t\t\t\t\t\t       *\n\t*\t\t\t\t\t\t               *");
            Console.WriteLine("\t*                           Entrada                            *");
            Console.WriteLine("\t*                                                              *");
            Console.WriteLine("\t*    Fornecedor:                                               *");
            Console.WriteLine("\t*                                                              *");
            Console.WriteLine("\t*    Produto:                 Quantidade do Produto:           *");
            Console.WriteLine("\t*                                                              *");
            Console.WriteLine("\t*    Preço do Produto:        Continuar(S/N):                  *");
            Console.WriteLine("\t*                                                              *");
            Console.Write("\t ************************************************************** \n\n");
        }

        // MÉTODO QUE ESCREVE A SAÍDA DE PRODUTOS
        private static void EscreveSaida()
        {
            Console.Clear();
            Console.Write(
                "\t ************************************************************** \n\t*\t\t\t\t\t\t\t       *\n");
            Console.WriteLine(
                "\t*\t\t\t SmartGRA Super       \t\t       *\n\t*\t\t\t ______________       \t\t       *\n\t*\t\t\t\t\t\t\t       *\n\t*\t\t\t\t\t\t\t       *\n\t*\t\t\t\t\t\t               *");
            Console.WriteLine("\t*                           Saída                              *");
            Console.WriteLine("\t*                                                              *");
            Console.WriteLine("\t*    Fornecedor:                                               *");
            Console.WriteLine("\t*                                                              *");
            Console.WriteLine("\t*    Produto:                 Quantidade do Produto:           *");
            Console.WriteLine("\t*                                                              *");
            Console.WriteLine("\t*    Preço do Produto:        Continuar (S/N):                 *");
            Console.WriteLine("\t*                                                              *");
            Console.Write("\t ************************************************************** \n\n");
        }

        #endregion

        // MOSTRA OS FORNECEDORES
        private static void Fornecedor()
        {
            Console.Clear();
            Console.WriteLine("\t\t\t\tFornecedores\n\t\t\t    ____________________");
            Console.WriteLine("");
            for (int i = 0; i < aux; i++)
            {
                if (fornecedorEntrada[dia, i] != null)
                {
                    Console.WriteLine("\n\n\t     Fornecedor: * " + fornecedorEntrada[dia, i]);
                }
            }
            Console.SetCursorPosition(20, 2);
            Console.WriteLine("\n\t\t\tDeseja Voltar ao Menu? S/N [ ]\n\n");
            Console.SetCursorPosition(52, 3);
            char escolhe = char.Parse(Console.ReadLine());
            if (escolhe == 'S' || escolhe == 's')
            {
                VoltaMenu();
            }
            else
            {
                Fornecedor();
            }
        }

        #endregion

        // FAZ A CONSULTA DE DETERMINADO PRODUTO
        private static void Consultas()
        {
            Console.Clear();
            Console.Clear();
            Console.Write("\t ************************************************************** \n\t*\t\t\t\t\t\t\t       *\n");
            Console.WriteLine("\t*\t\t\t SmartGRA Super       \t\t       *\n\t*\t\t\t ______________       \t\t       *\n\t*\t\t\t\t\t\t\t       *\n\t*\t\t\t\t\t\t\t       *\n\t*\t\t\t\t\t\t               *");
            Console.WriteLine("\t*              Deseja qual Produto?                            *");
            Console.WriteLine("\t*                                                              *");
            Console.WriteLine("\t*              Qual Fornecedor?                                *");
            Console.WriteLine("\t*                                                              *");
            Console.WriteLine("\t*                                                              *");
            Console.WriteLine("\t*                                                              *");
            Console.WriteLine("\t*                                                              *");
            Console.WriteLine("\t*                                                              *");
            Console.WriteLine("\t*                                                              *");
            Console.WriteLine("\t*                                                              *");
            Console.WriteLine("\t*                                                              *");
            Console.Write("\t ************************************************************** \n\n");
            Console.SetCursorPosition(44, 7);
            string escolhe = Console.ReadLine();
            Console.SetCursorPosition(40, 9);
            string escolha = Console.ReadLine();
            bool verdade = false;
            for (int i = 0; i <= aux; i++)
            {
                for (int c = 0; c <= dia; c++)
                {
                    if (escolhe == produtoEntrada[c, i] && escolha == fornecedorEntrada[c, i])
                    {
                        verdade = true;
                        Console.SetCursorPosition(23, 11);
                        Console.Write("Produto Encontrado!");
                        Console.SetCursorPosition(23, 12);
                        Console.Write("Quantidade: " + quantidadeProduto[dia, i]);
                        goto volta;
                    }
                }
            }
        volta:
            if (verdade == false)
            {
                Console.SetCursorPosition(23, 11);
                Console.WriteLine("Produto não encontrado!");
            }


            Console.SetCursorPosition(23, 13);
            Console.WriteLine("Deseja Sair (S/N)?");
            Console.SetCursorPosition(42, 13);
            try
            {
                char sair = char.Parse(Console.ReadLine());
                if (sair == 'S' || sair == 's')
                {
                    VoltaMenu();
                }
                else
                    Consultas();
            }
            catch (Exception)
            {
                Consultas();
            }
        }

        #region

        // RELATA A ENTRADA E A SAÍDA DE PRODUTOS NO DIA, O QUANTO LUCROU OU O QUANTO ESTÁ EM DÍVIDA (DIA E MÊS).
        private static void Relatorios()
        {
            Console.Clear();
            Console.Write("\t ************************************************************** \n\t*\t\t\t\t\t\t\t       *\n");
            Console.WriteLine("\t*\t\t\t SmartGRA Super       \t\t       *\n\t*\t\t\t ______________       \t\t       *\n\t*\t\t\t\t\t\t\t       *\n\t*\t\t\t\t\t\t\t       *\n\t*\t\t\t\t\t\t               *");
            Console.WriteLine("\t*       1. RELATÓRIO DE ENTRADA DO DIA                         *");
            Console.WriteLine("\t*                                                              *");
            Console.WriteLine("\t*       2. RELATÓRIO DE SAÍDA DO DIA                           *");
            Console.WriteLine("\t*                                                              *");
            Console.WriteLine("\t*       3. ACUMULO MENSAL                                      *");
            Console.WriteLine("\t*                                                              *");
            Console.WriteLine("\t*       4. MOSTRA SALDO                                        *");
            Console.WriteLine("\t*                                                              *");
            Console.WriteLine("\t*       5. MENU                                                *");
            Console.WriteLine("\t*                                                              *");
            Console.WriteLine("\t*       ESCOLHA:                                               *");
            Console.Write("\t ************************************************************** \n\n");
            Console.SetCursorPosition(25, 17);
            int escolha = int.Parse(Console.ReadLine());
            #region
            switch (escolha)
            {
                case 1: RelatorioEntrada();
                    break;

                case 2: RelatorioSaida();
                    break;

                case 3: AcumuloMensal();
                    break;

                case 4: MostraSaldo();
                    break;

                default: VoltaMenu();
                    break;
            }
            #endregion
        }

        private static void MostraSaldo()
        {
            Console.Clear();
            double somaMercado = 0;
            for (int i = 0; i <= aux2; i++)
            {
                somaMercado += (quantidadeProdutoSaida[dia, i] * precoProdutoSaida[dia, i]);
            }
            for (int i = 0; i <= aux; i++)
            {
                somaMercado -= (quantidadeProduto[dia, i] * precoProdutoEntrada[dia, i]);
            }

            Console.WriteLine("Lucro do dia R$" + dia + ": " + somaMercado);
            Console.Write("\n\nDeseja voltar ao menu? S/N: ");
            char voltamenu = char.Parse(Console.ReadLine());
            if (voltamenu == 'S' || voltamenu == 's')
            {
                VoltaMenu();
            }
            else
            {
                MostraSaldo();
            }
        }

        private static void AcumuloMensal()
        {
            Console.Clear();
            double somaMercadoMensal = 0;
            for (int i = 0; i <= aux2; i++)
            {
                for (int z = 0; z <= dia; z++)
                {
                    somaMercadoMensal += (quantidadeProdutoSaida[z, i] * precoProdutoSaida[z, i]) - (quantidadeProduto[z, i] * precoProdutoEntrada[z, i]);
                }
            }
            if (somaMercadoMensal < 0)
            {
                Console.WriteLine("Mercado está em dívida : R$" + somaMercadoMensal);
            }
            if (somaMercadoMensal == 0)
            {
                Console.WriteLine("Mercado está zerado: R$" + somaMercadoMensal);
            }
            if (somaMercadoMensal > 0)
            {
                Console.WriteLine("Mercado está positivo: R$ " + somaMercadoMensal);
            }

            Console.Write("\n\nDeseja voltar ao menu? [ ]");
            Console.SetCursorPosition(24, 3);
            char voltamenu = char.Parse(Console.ReadLine());
            if (voltamenu == 'S' || voltamenu == 's')
            {
                VoltaMenu();
            }
            else
            {
                AcumuloMensal();
            }
        }

        private static void RelatorioSaida()
        {
            Console.Clear();
            for (int i = 0; i < aux2; i++)
            {
                for (int z = dia; z <= dia; z++)
                {
                    if (produto[z, i] != null)
                    {
                        Console.WriteLine("Produto: " + produto[z, i] + " - Quantidade: " + quantidadeProdutoSaida[z, i] + " - Preço: " + precoProdutoSaida[z, i]);
                    }
                }

            }
            Console.Write("\n\nDeseja voltar ao menu? ");
            char voltamenu = char.Parse(Console.ReadLine());
            if (voltamenu == 'S' || voltamenu == 's')
            {
                VoltaMenu();
            }
            else
            {
                RelatorioSaida();
            }
        }

        private static void RelatorioEntrada()
        {
            Console.Clear();
            for (int i = 0; i < aux; i++)
            {
                for (int z = dia; z <= dia; z++)
                {
                    if (produtoEntrada[z, i] != null)
                    {
                        Console.WriteLine("Produto: " + produtoEntrada[z, i] + " - Quantidade: " + quantidadeProduto[z, i] + " - Preço: " + precoProdutoEntrada[z, i]);
                    }

                }
            }
            Console.Write("\n\nDeseja voltar ao menu? ");
            char voltamenu = char.Parse(Console.ReadLine());
            if (voltamenu == 'S' || voltamenu == 's')
            {
                VoltaMenu();
            }
            else
            {
                RelatorioEntrada();
            }
        }

        #endregion

        // MÉTODO AJUDA
        private static void Ajuda()
        {
            Console.Clear();
            Console.WriteLine(@"                Esse material servirá de apoio ao usuário

1. Data - A data serve para o usuário informar o dia em que o sistema está sendo utilizado

2. Menu - O menu traz os principais setores do software. Para acessar um dos
setores, basta digitar o número que está ao lado do título.

3. Implemento Cadastro - É onde o usuário irá cadastrar seus produtos, editá-los, poder acessar os fornecedores e utilizar a tabela para ter maior controle do  que entrou e do que saiu.
----------------------------------------------------------------------------
3.1 Remover Produtos - Serve para remover um produto que o usuário já não
utilize mais.

3.2 Tabela (Venda e Custo) - É onde o usuário acessará para ter controle de tudo o que o mercado já comprou e vendeu.

3.3 Controle e Cadastro - É utilizado para adicionar os produtos que estão sendo comprados e para informar ao sistema a quantidade de produtos que já saiu.

3.4 Fornecedor - É onde o usuário poderá acessar os seus fornecedores.

3.5 Menu - Usado para voltar ao menu.
-----------------------------------------------------------------------------
4.  Consultas - O usuário poderá utilizar do mesmo para achar o produto que está procurando.

5. Relatório - É onde o usuário poderá verificar a entrada de produto e a saída do dia, e o saldo do mercado do dia e mensal.

6. Ajuda - É o local onde o usuário irá ter informações acerca do software.

7. Data - Serve para mudar o dia de uso do software.

Para Sair digite qualquer tecla...");
            Console.SetCursorPosition(35, 35);
            string sair = Console.ReadLine();
            if (sair != null)
            {
                VoltaMenu();
            }
            else
            {
                Ajuda();
            }
        }

        #region

        private static void AvaliaSituacao(int escolha)
        {
            switch (escolha)
            {
                case 1: ImplementoCadastro();
                    break;

                case 2: Consultas();
                    break;

                case 3: Relatorios();
                    break;

                case 4: Ajuda();
                    break;

                case 5:
                    teclou = 1;
                    PedeData();
                    break;

                default: Menu();
                    break;
            }
        }

        private static void VoltaMenu()
        {
            int escolha = Menu();
            switch (escolha)
            {
                case 1: ImplementoCadastro();
                    break;

                case 2: Consultas();
                    break;

                case 3: Relatorios();
                    break;

                case 4: Ajuda();
                    break;

                case 5: teclou = 1;
                    PedeData();
                    break;

                default: Menu();
                    break;
            }
        }

        private static int Soma(int c, int i)
        {
            if (produto[c, i] == produtoEntrada[c, i])
            {
                somaProdutos = quantidadeProduto[c, i] - quantidadeProdutoSaida[c, i];
                goto vai;
            }

        vai:
            return somaProdutos;
        }

        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberCode
{
    class Program
    {
        //Variaveis Globais
        static int CarroCadastrado = 0;
        static int ClienteCadastrado = 0;
        static int constante = 20;
        static string Opcao = null;
        static string Pesquisa = null;
        static int Achou = 0;
        static string Resposta = null;
        static string SenhaTeste = null;
        static string UsuarioTeste = null;
        static int Posicao = 0;
        static int Tentativas = 0;
        static int CarrosRemovidos, ClientesRemovidos = 0;
        static double RendaMensal = 0;
        static double RendaCaixa = 0;
        static int PosicaoCliente = 0;
        static string[] Usuarios = { "aprigio", "luis", "mateus", "greicy", "thiago" };
        static int garagem = 0;
        static int rodando = 0;
        static int reservado = 0;

        // Variaveis Relacionadas aos Carros

        static string[] Marca = new string[constante];
        static string[] Modelo = new string[constante];
        static string[] Placa = new string[constante];
        static string[] Cor = new string[constante];
        static double[] Quilometragem = new double[constante];
        static string[] Situacao = new string[constante];
        static int[] DiasLocado = new int[constante];
        static double[] ValorDiaria = new double[constante];

        // Variaveis Relacionadas aos Clientes

        static string[] Nome = new string[constante];
        static double[] Saldo = new double[constante];
        static string[] Carro = new string[constante];
        static string[] RG = new string[constante];
        static string[] CPF = new string[constante];
        static string[,] Endereco = new string[7, constante];
        //Endereço: Linha 1 = Pais; Linha 2= Estado; Linha 3 =Cidade; Linha 4= Rua; Linha 5 = Bairro; Linha 6 = Numero; Linha 7 = Complemento

        //metodo principal... chama o login
        static void Main(string[] args)
        {

            Login();
            //Chamando o método MENU           
            Console.ReadKey();
        }

        //login chama o menu
        static void Login()
        {
            Achou = 0;
            Tentativas = 0;
            Console.WriteLine();
            Console.WriteLine("░░░░░░░░░░░░░░░░░░░░ LOCACAO DE VEICULOS - CYBER CAR ░░░░░░░░░░░░░░░░░░░░░");
            Console.WriteLine("╔════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                                  LOGIN                                 ║");
            Console.WriteLine("╠════════════════════════════════════════════════════════════════════════╣");
            Console.WriteLine("║                     INFORME SUA SENHA E SEU LOGIN                      ║");
            Console.WriteLine("╚════════════════════════════════════════════════════════════════════════╝");
            do
            {
                Console.Write("\t\t\t\tLOGIN: ");
                UsuarioTeste = Console.ReadLine();
                Console.Write("\t\t\t\tSENHA: ");
                SenhaTeste = Console.ReadLine();
                Tentativas += 1;
                for (int i = 0; i < 5; i++)
                {
                    if (UsuarioTeste == Usuarios[i])
                    {
                        if (SenhaTeste == Usuarios[i] + "123")
                        {
                            Console.WriteLine("Login realizado com sucesso!");
                            Achou += 1;
                            Console.ReadKey();
                            Menu();
                            break;
                        }
                    }
                }
                if (Achou == 0 && Tentativas < 3)
                {
                    Console.WriteLine("Senha incorreta! Tente Novamente... (máximo 3 tentativas)\n\n");
                }
                if (Achou == 1)
                {
                    break;
                }
                if (Tentativas == 3 && Achou == 0)
                {
                    Console.WriteLine("Você errou 3 vezes o login ou a senha... O programa esta sendo encerrado!");
                    Console.ReadKey();
                    break;
                }
            } while (Tentativas != 3);
        }

        // Metodos dos Menus
        static void Menu()
        {
            do
            {

                Opcao = null;
                Console.Clear();
                //Console.BackgroundColor = ConsoleColor.;
                Console.WriteLine();
                Console.WriteLine("░░░░░░░░░░░░░░░░░░░░ LOCACAO DE VEICULOS - CYBER CAR ░░░░░░░░░░░░░░░░░░░░░");
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("║                                  MENU                                  ║");
                Console.WriteLine("╠════════════════════════════════════════════════════════════════════════╣");
                Console.WriteLine("║                             1 - CADASTRO                               ║");
                Console.WriteLine("║                             2 - CONSULTA                               ║");
                Console.WriteLine("║                             3 - MOVIMENTO                              ║");
                Console.WriteLine("║                             4 - ALTERACAO                              ║");
                Console.WriteLine("║                             5 - REMOCAO                                ║");
                Console.WriteLine("║                             6 - RELATORIO                              ║");
                Console.WriteLine("║                             7 - AJUDA                                  ║");
                Console.WriteLine("║                             8 - SAIR                                   ║");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════╝");

                Opcao = Console.ReadLine();
                switch (Opcao)
                {
                    case "1":
                        MenuCadastro();
                        break;
                    case "2":
                        MenuConsulta();
                        break;
                    case "3":
                        MenuMovimento();
                        break;
                    case "4":
                        MenuAlteracao();
                        break;
                    case "5":
                        MenuRemocao();
                        break;
                    case "6":
                        MenuRelatorio();
                        break;
                    case "7":
                        MenuAjuda();
                        break;
                    case "8":
                        Console.WriteLine("\nO programa está sendo encerrado. Aperte qualquer tecla para continuar!");
                        break;
                    default:
                        Console.WriteLine("Voce digitou uma opcao invalida! Aperte uma tecla para continuar.");
                        Console.ReadKey();
                        continue;
                }
            } while (Opcao != "8");
        }
        static void MenuCadastro()
        {
            do
            {
                Opcao = null;
                Console.Clear();
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("║                              MENU CADASTRO                             ║");
                Console.WriteLine("╠════════════════════════════════════════════════════════════════════════╣");
                Console.WriteLine("║                         1 - CADASTRO VEICULO                           ║");
                Console.WriteLine("║                         2 - CADASTRO CLIENTE                           ║");
                Console.WriteLine("║                         3 - VOLTAR                                     ║");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════╝");

                Opcao = Console.ReadLine();
                switch (Opcao)
                {
                    case "1":
                        //Chama o  metodo cadastro carro
                        CadastroCarro();
                        break;
                    case "2":
                        //Chamar metodo cadastro cliente
                        CadastroCliente();
                        break;
                    case "3":
                        break;
                    default:
                        Console.WriteLine("Voce digitou uma opcao invalida! Tente novamente.");
                        Console.ReadKey();
                        continue;
                }
            } while (Opcao != "3");
        }
        static void MenuConsulta()
        {
            do
            {
                Console.Clear();
                Opcao = null;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("║                              MENU CONSULTA                             ║");
                Console.WriteLine("╠════════════════════════════════════════════════════════════════════════╣");
                Console.WriteLine("║                         1 - CONSULTAR VEICULO                          ║");
                Console.WriteLine("║                         2 - CONSULTAR CLIENTE                          ║");
                Console.WriteLine("║                         3 - SITUACAO DO VEICULO                        ║");
                Console.WriteLine("║                         4 - VOLTAR                                     ║");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════╝");


                Opcao = Console.ReadLine();

                switch (Opcao)
                {

                    case "1":
                        //Chama o  metodo CONSULTA carro
                        ConsultaCarros();
                        break;
                    case "2":
                        //Chamar metodo CONSULTA cliente
                        ConsultaCliente();
                        break;
                    case "3": Console.Clear();
                        //Chama o metodo de situação dos carros
                        SituacaoDosCarros();
                        break;
                    case "4":
                        //Chama o menu novamente
                        break;
                    default:
                        Console.WriteLine("Voce digitou uma opcao invalida! Tente novamente.");
                        Console.ReadKey();
                        continue;
                }
            } while (Opcao != "4");
        }
        static void MenuMovimento()
        {
            do
            {

                Opcao = null;
                Console.Clear();
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("║                             MENU MOVIMENTO                             ║");
                Console.WriteLine("╠════════════════════════════════════════════════════════════════════════╣");
                Console.WriteLine("║                              1 - RESERVA                               ║");
                Console.WriteLine("║                              2 - LOCACAO                               ║");
                Console.WriteLine("║                              3 - DEVOLUCAO                             ║");
                Console.WriteLine("║                              4 - Voltar                                ║");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════╝");

                Opcao = Console.ReadLine();

                switch (Opcao)
                {

                    case "1":
                        //Chama o  metodo RESERVA carro
                        Reserva();
                        break;
                    case "2":
                        //Chamar metodo LOCACAO carro
                        Locacao();
                        break;
                    case "3":
                        //Chamar o metodo DEVOLUCAO carro
                        Devolucao();
                        break;
                    case "4":
                        break;
                    default:
                        Console.WriteLine("Voce digitou uma opcao invalida! Tente novamente.");
                        Console.ReadKey();
                        continue;
                }
            } while (Opcao != "4");
        }
        static void MenuAlteracao()
        {
            do
            {
                Console.Clear();
                Opcao = null;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("║                             MENU ALTERACAO                             ║");
                Console.WriteLine("╠════════════════════════════════════════════════════════════════════════╣");
                Console.WriteLine("║                          1 - ALTERAR VEICULO                           ║");
                Console.WriteLine("║                          2 - ALTERAR CLIENTE                           ║");
                Console.WriteLine("║                          3 - VOLTAR                                    ║");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════╝");

                Opcao = Console.ReadLine();
                switch (Opcao)
                {
                    case "1":
                        //Chama o  metodo ALTERACAO carro
                        AlterarCarro();
                        break;
                    case "2":
                        //Chamar metodo ALTERACAO cliente
                        AlterarCliente();
                        break;
                    case "3":
                        break;
                    default:
                        Console.WriteLine("Voce digitou uma opcao invalida! Tente novamente.");
                        Console.ReadKey();
                        continue;
                }
            } while (Opcao != "3");
        }
        static void MenuRemocao()
        {
            do
            {
                Console.Clear();
                Opcao = null;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("║                              MENU REMOCAO                              ║");
                Console.WriteLine("╠════════════════════════════════════════════════════════════════════════╣");
                Console.WriteLine("║                          1 - REMOCAO VEICULO                           ║");
                Console.WriteLine("║                          2 - REMOCAO CLIENTE                           ║");
                Console.WriteLine("║                          3 - VOLTAR                                    ║");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════╝");


                Opcao = Console.ReadLine();

                switch (Opcao)
                {

                    case "1":
                        //Chama o  metodo REMOCAO carro
                        RemoverCarro();
                        break;
                    case "2":
                        //Chamar metodo REMOCAO cliente
                        RemoverCliente();
                        break;
                    case "3":
                        break;
                    default:
                        Console.WriteLine("Voce digitou uma opcao invalida! Tente novamente.");
                        Console.ReadKey();
                        continue;
                }
            } while (Opcao != "3");
        }
        static void MenuAjuda()
        {
            Console.Clear();
            Console.WriteLine("╔═══════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║░░░░░░░░░░░░░░░░░░░░░░░░░░░░░   MENU AJUDA   ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░║");
            Console.WriteLine("╚═══════════════════════════════════════════════════════════════════════════╝");
            Console.WriteLine("╔═══════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                    Passo a Passo para acesso ao Sistema                   ║");
            Console.WriteLine("║░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░║");
            Console.WriteLine("║1. Cadastro Cliente: Nome, CPF e Endereço.                                 ║");
            Console.WriteLine("║Para Cadastro do cliente informe os dados pessoais é o endereço.           ║");
            Console.WriteLine("║░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░║");
            Console.WriteLine("║2. Cadastro Automóvel: MARCA, PLACA, KM inicial e KM final                 ║");
            Console.WriteLine("║Insira os dados do Automóvel para obter o valor do aluguel e               ║");
            Console.WriteLine("║se o automóvel se encontra na garagem.                                     ║");
            Console.WriteLine("║░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░║");
            Console.WriteLine("║3. Consultas: Automóvel e Cliente                                          ║");
            Console.WriteLine("║Dados de consulta Automóvel rodando, Automóvel na garagem.                 ║");
            Console.WriteLine("║Dados do Cliente                                                           ║");
            Console.WriteLine("║Tabela de Preços dos Automóveis                                            ║");
            Console.WriteLine("║░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░║");
            Console.WriteLine("║4. Movimento: Movimento Diário                                             ║");
            Console.WriteLine("║Controle de Locação                                                        ║");
            Console.WriteLine("║Controle de Devolução                                                      ║");
            Console.WriteLine("║Reserva: No ato de locação, informar se o cliente está bloqueado,          ║");
            Console.WriteLine("║se o cliente já locou ou está devendo, se o carro está reservado.          ║");
            Console.WriteLine("║░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░║");
            Console.WriteLine("║5. Alteração: Automóvel e Cliente                                          ║");
            Console.WriteLine("║Altera os dados do Automóvel                                               ║");
            Console.WriteLine("║Altera os dados do Cliente                                                 ║");
            Console.WriteLine("║░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░║");
            Console.WriteLine("║6. Remoção: Automóvel                                                      ║");
            Console.WriteLine("║Remove Automóvel fora de linha ou com defeito                              ║");
            Console.WriteLine("║░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░║");
            Console.WriteLine("║7. Relatório: Cliente, Automóvel e Funcionario                             ║");
            Console.WriteLine("║Dados do Cliente                                                           ║");
            Console.WriteLine("║Dados do Automóvel                                                         ║");
            Console.WriteLine("║Dados da Locação                                                           ║");
            Console.WriteLine("║Dados do Funcionário Cadastrado                                            ║");
            Console.WriteLine("║░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░║");
            Console.WriteLine("║8. Sair: Encerramento do programa.                                         ║");
            Console.WriteLine("╚═══════════════════════════════════════════════════════════════════════════╝");
            Console.ReadKey();
        }
        static void MenuRelatorio()
        {
            do
            {
                Console.Clear();
                Opcao = null;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("║                             MENU RELATORIO                             ║");
                Console.WriteLine("╠════════════════════════════════════════════════════════════════════════╣");
                Console.WriteLine("║                        1 - RELATORIO DO VEICULO                        ║");
                Console.WriteLine("║                        2 - RELATORIO DO CLIENTE                        ║");
                Console.WriteLine("║                        3 - RELATORIO DA RENDA MENSAL                   ║");
                Console.WriteLine("║                        4 - RELATORIO DO CAIXA                          ║");
                Console.WriteLine("║                        5 - TABELA DE PREÇO                             ║");
                Console.WriteLine("║                        6 - VOLTAR                                      ║");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════╝");

                Opcao = Console.ReadLine();
                switch (Opcao)
                {

                    case "1":
                        //Chama o  metodo RELATORIO carro
                        RelatorioCarro();
                        break;
                    case "2":
                        //Chamar metodo RELATORIO cliente
                        RelatorioCliente();
                        break;
                    case "3":
                        //Chamar metodo RELATORIO reda mensal
                        RelatorioMes();
                        break;
                    case "4":
                        //Chamar metodo RELATORIO do caixa
                        RelatorioCaixa();
                        break;
                    case "5":
                        TabelaPrecoCarros();
                        break;
                    case "6":
                        break;
                    default:
                        Console.WriteLine("Voce digitou uma opcao invalida! Tente novamente.");
                        Console.ReadKey();
                        continue;
                }
            } while (Opcao != "6");
        }

        // Metodos dos Itens
        static void Reserva()
        {
            do
            {
                int data = 0;
                Opcao = null;
                Posicao = 0;
                ConsultaCliente();
                Console.Clear();
                if (Achou == 1)
                {
                    Console.WriteLine("Nome.........: {0}", Nome[Posicao]);
                    Console.WriteLine("RG...........: {0}", RG[Posicao]);
                    Console.WriteLine("CPF..........: {0}", CPF[Posicao]);
                    Console.WriteLine("Saldo........: {0}", Saldo[Posicao]);
                    PosicaoCliente = Posicao;
                    if (Saldo[Posicao] > 0)
                    {
                        do
                        {
                            Console.WriteLine("Cliente devendo um saldo de {0}, deseja efetuar o pagamento ?   (S/N) ", Saldo[Posicao]);
                            Opcao = Console.ReadLine();
                            Opcao = Opcao.ToLower();
                        } while (Opcao != "n" || Opcao != "s");
                        if (Opcao == "s")
                        {
                            Saldo[Posicao] = 0;
                            RendaMensal += Saldo[Posicao];
                            RendaCaixa += Saldo[Posicao];
                            Console.WriteLine("Voce paga suas dividas bom homem, iremos reiniciar a nossa consulta.");
                            Console.ReadKey();
                            continue;
                        }
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Pesquisando carro ...");
                        Console.ReadKey();
                        ConsultaCarros();
                        Console.Clear();
                        Console.WriteLine("\nMarca............: {0}", Marca[Posicao]);
                        Console.WriteLine("Modelo...........: {0}", Modelo[Posicao]);
                        Console.WriteLine("Placa............: {0}", Placa[Posicao]);
                        Console.WriteLine("Cor..............: {0}", Cor[Posicao]);
                        Console.WriteLine("Km Atual.........: {0}", Quilometragem[Posicao]);
                        Console.WriteLine("Valor Diária.....: {0}", ValorDiaria[Posicao]);
                        Opcao = "s";
                        if (DiasLocado[Posicao] > 0)
                        {
                            Console.WriteLine("O carro voltará daqui a {0} dias. Gostaria de reservar para o dia de retorno?", DiasLocado[Posicao] + 1);
                            Console.WriteLine("(S/N)");
                            Opcao = Console.ReadLine();
                            Opcao = Opcao.ToLower();
                        }
                        if (Opcao == "n")
                        {
                            Console.WriteLine("Fica pra próxima então, o carro está {0}.", Situacao[Posicao]);
                            Console.ReadKey();
                        }
                        else if (Opcao == "s")
                        {
                            do
                            {
                                Console.WriteLine("\nDeseja locar o automovel quantos dias?");
                                data = int.Parse(Console.ReadLine());
                                if (data < 1 || data > 365)
                                {
                                    Console.WriteLine("Data incorreta, digite novamente.");
                                    Console.ReadKey();
                                }
                            } while (data < 1 && data > 365);
                            Situacao[Posicao] = "Reservado";
                            DiasLocado[Posicao] += data;
                            Carro[PosicaoCliente] = Placa[Posicao];
                            reservado += 1;

                        }

                    }
                    Opcao = null;
                    Console.Write("\n\nDeseja tentar outra reserva ?     (S/N) ");
                    Opcao = Console.ReadLine();
                    Opcao = Opcao.ToLower();
                }
            } while (Opcao != "n");
        }
        static void Locacao()
        {
            do
            {
                int dia = 0;
                Opcao = null;
                Posicao = 0;
                ConsultaCliente();
                Console.Clear();
                if (Achou == 1)
                {
                    Console.WriteLine("Nome.........: {0}", Nome[Posicao]);
                    Console.WriteLine("RG...........: {0}", RG[Posicao]);
                    Console.WriteLine("CPF..........: {0}", CPF[Posicao]);
                    Console.WriteLine("Saldo........: {0}", Saldo[Posicao]);
                    PosicaoCliente = Posicao;
                    if (Saldo[Posicao] > 0)
                    {
                        do
                        {
                            Console.WriteLine("Cliente devendo um saldo de {0}, deseja efetuar o pagamento ?   (S/N) ", Saldo[Posicao]);
                            Opcao = Console.ReadLine();
                            Opcao = Opcao.ToLower();
                        } while (Opcao != "n" || Opcao != "s");
                        if (Opcao == "s")
                        {
                            Saldo[Posicao] = 0;
                            RendaMensal += Saldo[Posicao];
                            RendaCaixa += Saldo[Posicao];
                            continue;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Pesquisando carro ...");
                        Console.ReadKey();
                        ConsultaCarros();
                        Console.Clear();
                        if (DiasLocado[Posicao] == 0 && Situacao[Posicao] == "Garagem")
                        {
                            Console.WriteLine("\nMarca............: {0}", Marca[Posicao]);
                            Console.WriteLine("Modelo...........: {0}", Modelo[Posicao]);
                            Console.WriteLine("Placa............: {0}", Placa[Posicao]);
                            Console.WriteLine("Cor..............: {0}", Cor[Posicao]);
                            Console.WriteLine("Km Atual.........: {0}", Quilometragem[Posicao]);
                            Console.WriteLine("Valor Diária.....: {0}", ValorDiaria[Posicao]);
                            do
                            {
                                Console.WriteLine("\nDeseja locar o automovel por quantos dias ?");
                                dia = int.Parse(Console.ReadLine());
                                if (dia < 1 || dia > 365)
                                {
                                    Console.WriteLine("Quantidade incorreta, insira novamente.");
                                    Console.ReadKey();
                                    continue;
                                }
                            } while (dia < 1 || dia > 365);

                            Saldo[PosicaoCliente] = dia * ValorDiaria[Posicao];
                            Situacao[Posicao] = "Rodando";
                            DiasLocado[Posicao] = dia;
                            Carro[PosicaoCliente] = Placa[Posicao];
                            rodando += 1;
                            garagem -= 1;
                        }
                        else
                        {
                            Console.WriteLine("Carro indisponível. {0}", Situacao[Posicao]);
                            Console.Write("\n\nDeseja tentar outra locação ?     (S/N) ");
                            Opcao = Console.ReadLine();
                            Opcao = Opcao.ToLower();
                        }
                    }
                }
            } while (Opcao != "n");
        }
        static void Devolucao()
        {
            double km = 0;
            Opcao = null;
            Posicao = 0;
            ConsultaCliente();
            Console.Clear();
            if (Achou == 1)
            {
                Console.WriteLine("Nome............: {0}", Nome[Posicao]);
                Console.WriteLine("RG..............: {0}", RG[Posicao]);
                Console.WriteLine("CPF.............: {0}", CPF[Posicao]);
                Console.WriteLine("Saldo...........: {0}", Saldo[Posicao]);
                Console.WriteLine("Placa do carro...:{0}", Carro[Posicao]);
                PosicaoCliente = Posicao;
                for (int i = 0; i < CarroCadastrado; i++)
                {
                    if (Carro[PosicaoCliente] == Placa[i])
                    {
                        Console.WriteLine("Marca....................: {0}", Marca[i]);
                        Console.WriteLine("Modelo...................: {0}", Modelo[Posicao]);
                        Console.WriteLine("Placa....................: {0}", Placa[i]);
                        Console.WriteLine("Cor......................: {0}", Cor[i]);
                        Console.WriteLine("Quilometragem Inicial....: {0}", Quilometragem[i]);
                    }
                }
                do
                {
                    Console.Write("Quilometragem da volta : ");
                    km = double.Parse(Console.ReadLine());
                    if (km < Quilometragem[Posicao])
                    {
                        Console.WriteLine("Quilometragem errada, insira a correta.");
                        Console.ReadKey();
                        continue;
                    }
                    else
                    {
                        Quilometragem[Posicao] = km;
                    }
                } while (km < Quilometragem[Posicao]);
                do
                {
                    Console.WriteLine("Cliente devendo um saldo de {0}, deseja efetuar o pagamento ?   (S/N) ", Saldo[PosicaoCliente]);
                    Opcao = Console.ReadLine();
                    Opcao = Opcao.ToLower();
                } while (Opcao != "n" && Opcao != "s");
                if (Opcao == "s")
                {
                    RendaMensal += Saldo[Posicao];
                    RendaCaixa += Saldo[Posicao];
                    Saldo[PosicaoCliente] = 0;
                    garagem += 1;
                    rodando -= 1;
                }
                else
                {
                    Console.WriteLine("Voce precisa pagar, obtenha dinheiro !!");
                    garagem += 1;
                    rodando -= 1;
                    Console.ReadKey();
                }
            }
        }
        static void CadastroCarro()
        {
            do
            {
                Opcao = null;
                Console.Clear();
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("║░░░░░░░░░░░░░░░░░░░░░░░░░░ CADASTRO - VEICULO ░░░░░░░░░░░░░░░░░░░░░░░░░░║");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════╝");
                Console.Write("Marca: ");
                Marca[CarroCadastrado - CarrosRemovidos] = Console.ReadLine();
                Console.Write("Modelo : ");
                Modelo[CarroCadastrado - CarrosRemovidos] = Console.ReadLine();
                do
                {
                    Console.Write("Placa: \t(XXX000)");
                    Placa[CarroCadastrado - CarrosRemovidos] = Console.ReadLine();
                } while (Placa[CarroCadastrado - CarrosRemovidos].Length != 6);
                Console.Write("Cor: ");
                Cor[CarroCadastrado - CarrosRemovidos] = Console.ReadLine();
                Console.Write("Km Atual: ");
                Quilometragem[CarroCadastrado - CarrosRemovidos] = double.Parse(Console.ReadLine());
                Situacao[CarroCadastrado - CarrosRemovidos] = "Garagem";
                DiasLocado[CarroCadastrado - CarrosRemovidos] = 0;
                Console.WriteLine("Qual o valor da diária deste carro ?");
                ValorDiaria[CarroCadastrado - CarrosRemovidos] = double.Parse(Console.ReadLine());
                garagem += 1;
                CarroCadastrado += 1;
                Console.Write("\n\nDeseja cadastrar outro automóvel ?     (S/N) ");
                Opcao = Console.ReadLine();
                Opcao = Opcao.ToLower();

            } while (Opcao != "n");
        }
        static void CadastroCliente()
        {
            do
            {
                Console.Clear();
                Opcao = null;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("║░░░░░░░░░░░░░░░░░░░░░░░░░░ CADASTRO - CLIENTE ░░░░░░░░░░░░░░░░░░░░░░░░░░║");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════╝");
                Console.Write("Nome : ");
                Nome[ClienteCadastrado - ClientesRemovidos] = Console.ReadLine();
                do
                {
                    Console.Write("RG   (10 digitos) : ");
                    RG[ClienteCadastrado - ClientesRemovidos] = Console.ReadLine();
                } while (RG[ClienteCadastrado - ClientesRemovidos].Length != 10);
                do
                {
                    Console.Write("CPF  (11 digitos) : ");
                    CPF[ClienteCadastrado - ClientesRemovidos] = Console.ReadLine();
                } while (CPF[ClienteCadastrado - ClientesRemovidos].Length != 11);
                Console.Write("Pais : ");
                Endereco[ClienteCadastrado - ClientesRemovidos, 0] = Console.ReadLine();
                Console.Write("Estado : ");
                Endereco[ClienteCadastrado - ClientesRemovidos, 1] = Console.ReadLine();
                Console.Write("Cidade : ");
                Endereco[ClienteCadastrado - ClientesRemovidos, 2] = Console.ReadLine();
                Console.Write("Rua : ");
                Endereco[ClienteCadastrado - ClientesRemovidos, 3] = Console.ReadLine();
                Console.Write("Bairro : ");
                Endereco[ClienteCadastrado - ClientesRemovidos, 4] = Console.ReadLine();
                Console.Write("Numero : ");
                Endereco[ClienteCadastrado - ClientesRemovidos, 5] = Console.ReadLine();
                Console.Write("Complemento : ");
                Endereco[ClienteCadastrado - ClientesRemovidos, 6] = Console.ReadLine();
                Saldo[ClienteCadastrado - ClientesRemovidos] = 0;
                ClienteCadastrado += 1;
                Console.Write("\n\nDeseja cadastrar outro cliente ?     (S/N) ");
                Opcao = Console.ReadLine();
                Opcao = Opcao.ToLower();

            } while (Opcao != "n");
        }
        static void ConsultaCliente()
        {
            do
            {
                Pesquisa = null;
                Achou = 0;
                Opcao = null;
                Console.Clear();
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("║░░░░░░░░░░░░░░░░░░░░░░░░░░ CONSULTA - CLIENTE ░░░░░░░░░░░░░░░░░░░░░░░░░░║");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════╝");
                Console.Write("Digite o CPF do cliente : ");
                Pesquisa = Console.ReadLine();
                if (Pesquisa.Length != 11)
                {
                    Console.WriteLine("CPF invalido, digite no formato correto do CPF (11 digitos).");
                    Console.ReadKey();
                    continue;
                }
                for (int i = 0; i < constante; i++)
                {
                    if (Pesquisa == CPF[i])
                    {
                        Console.WriteLine("\tNome.........: {0}", Nome[i]);
                        Console.WriteLine("\tRG...........: {0}", RG[i]);
                        Console.WriteLine("\tCPF..........: {0}", CPF[i]);
                        Console.WriteLine("\tPais.........: {0}", Endereco[i, 0]);
                        Console.WriteLine("\tEstado.......: {0}", Endereco[i, 1]);
                        Console.WriteLine("\tCidade.......: {0}", Endereco[i, 2]);
                        Console.WriteLine("\tRua..........: {0}", Endereco[i, 3]);
                        Console.WriteLine("\tBairro.......: {0}", Endereco[i, 4]);
                        Console.WriteLine("\tNumero.......: {0}", Endereco[i, 5]);
                        Console.WriteLine("\tComplemento..: {0}", Endereco[i, 6]);
                        Console.WriteLine("\tSaldo........: {0}", Saldo[i]);
                        Achou = 1;
                        Posicao = i;
                    }
                }
                if (Achou == 0)
                {
                    Console.WriteLine("Cliente não cadastrado.");
                }
                Console.WriteLine("\n\nDeseja realizar outra pesquisa?      (S/N)");
                Opcao = Console.ReadLine();
                Opcao = Opcao.ToLower();

            } while (Opcao != "n");
        }
        static void ConsultaCarros()
        {

            do
            {
                Pesquisa = null;
                Achou = 0;
                Opcao = null;
                Console.Clear();
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("║░░░░░░░░░░░░░░░░░░░░░░░░░░ CONSULTA - VEICULO ░░░░░░░░░░░░░░░░░░░░░░░░░░║");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════╝");
                Console.Write("Digite a placa do carro : ");
                Pesquisa = Console.ReadLine();
                if (Pesquisa.Length != 6)
                {
                    Console.WriteLine("Placa invalida, digite no formato correto da mesma (6 digitos, 3 letras e 3 numeros).");
                    continue;
                }
                for (int i = 0; i < CarroCadastrado - CarrosRemovidos; i++)
                {
                    if (Pesquisa == Placa[i])
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("\tMarca............: {0}", Marca[i]);
                        Console.WriteLine("\tModelo...........: {0}", Modelo[i]);
                        Console.WriteLine("\tPlaca............: {0}", Placa[i]);
                        Console.WriteLine("\tCor..............: {0}", Cor[i]);
                        Console.WriteLine("\tKm Atual.........: {0}", Quilometragem[i]);
                        Console.WriteLine("\tSituação.........: {0}", Situacao[i]);
                        Console.WriteLine("\tDisponivel em....: {0} dias", DiasLocado[i]);
                        Console.WriteLine("\tValor Diária.....: {0} R$", ValorDiaria[i]);
                        Achou = 1;
                        Posicao = i;

                    }
                }
                if (Achou == 0)
                {
                    Console.WriteLine("Carro não cadastrado.");
                }
                Console.WriteLine("\n\nDeseja realizar outra pesquisa?      (S/N)");
                Opcao = Console.ReadLine();
                Opcao = Opcao.ToLower();

            } while (Opcao != "n");
        }
        static void TabelaPrecoCarros()
        {
            do
            {
                Opcao = null;
                Console.Clear();
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("║░░░░░░░░░░░░░░░░░░░░░░░░░░  TABELA DE PRECOS  ░░░░░░░░░░░░░░░░░░░░░░░░░░║");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════╝");
                for (int i = 0; i < CarroCadastrado - CarrosRemovidos; i++)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("Marca............: {0}", Marca[i]);
                    Console.WriteLine("Modelo...........: {0}", Modelo[i]);
                    Console.WriteLine("Placa............: {0}", Placa[i]);
                    Console.WriteLine("Valor Diária.....: {0} R$", ValorDiaria[i]);
                }
                Console.WriteLine("\n\nDeseja sair da tabela ?      (S/N)");
                Opcao = Console.ReadLine();
                Opcao = Opcao.ToLower();

            } while (Opcao != "s");
        }
        static void SituacaoDosCarros()
        {
            Console.WriteLine("╔════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║░░░░░░░░░░░░░░░░░░░░░░░░░░ SITUACAO - VEICULO ░░░░░░░░░░░░░░░░░░░░░░░░░░║");
            Console.WriteLine("╚════════════════════════════════════════════════════════════════════════╝");
            do
            {
                Opcao = null;
                Console.Clear();
                for (int i = 0; i < CarroCadastrado - CarrosRemovidos; i++)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("Marca............: {0}", Marca[i]);
                    Console.WriteLine("Modelo...........: {0}", Modelo[i]);
                    Console.WriteLine("Local............: {0}", Situacao[i]);
                    Console.WriteLine("Disponivel em....: {0} dias", DiasLocado[i]);
                }
                Console.WriteLine("\n\nDeseja sair ?      (S/N)");
                Opcao = Console.ReadLine();
                Opcao = Opcao.ToLower();

            } while (Opcao != "s");
        }
        static void RelatorioCliente()
        {
            Console.WriteLine("╔════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║░░░░░░░░░░░░░░░░░░░░░░░░░ RELATORIO - CLIENTE  ░░░░░░░░░░░░░░░░░░░░░░░░░║");
            Console.WriteLine("╚════════════════════════════════════════════════════════════════════════╝");
            do
            {
                Opcao = null;
                Console.Clear();
                for (int i = 0; i < ClienteCadastrado; i++)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("\n\nNome.........: {0}", Nome[i]);
                    Console.WriteLine("RG...........: {0}", RG[i]);
                    Console.WriteLine("CPF..........: {0}", CPF[i]);
                    Console.WriteLine("Pais.........: {0}", Endereco[i, 0]);
                    Console.WriteLine("Estado.......: {0}", Endereco[i, 1]);
                    Console.WriteLine("Cidade.......: {0}", Endereco[i, 2]);
                    Console.WriteLine("Rua..........: {0}", Endereco[i, 3]);
                    Console.WriteLine("Bairro.......: {0}", Endereco[i, 4]);
                    Console.WriteLine("Numero.......: {0}", Endereco[i, 5]);
                    Console.WriteLine("Complemento..: {0}", Endereco[i, 6]);
                    Console.WriteLine("Saldo........: {0}", Saldo[i]);
                }
                Console.WriteLine("\n\nDeseja sair da consulta ?      (S/N)");
                Opcao = Console.ReadLine();
                Opcao = Opcao.ToLower();
            } while (Opcao != "s");
        }
        static void RelatorioCarro()
        {
            Console.WriteLine("╔════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║░░░░░░░░░░░░░░░░░░░░░░░░░  RELATORIO - VEICULO  ░░░░░░░░░░░░░░░░░░░░░░░░║");
            Console.WriteLine("╚════════════════════════════════════════════════════════════════════════╝");
            do
            {
                Opcao = null;
                Console.Clear();
                for (int i = 0; i < CarroCadastrado - CarrosRemovidos; i++)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("Marca............: {0}", Marca[i]);
                    Console.WriteLine("Modelo...........: {0}", Modelo[i]);
                    Console.WriteLine("Placa............: {0}", Placa[i]);
                    Console.WriteLine("Cor..............: {0}", Cor[i]);
                    Console.WriteLine("Km Atual.........: {0}", Quilometragem[i]);
                    Console.WriteLine("Situação.........: {0}", Situacao[i]);
                    Console.WriteLine("Disponivel em....: {0} dias", DiasLocado[i]);
                    Console.WriteLine("Valor Diária.....: {0}", ValorDiaria[i]);
                }
                Console.WriteLine("\n\nDeseja sair da consulta ?      (S/N)");
                Opcao = Console.ReadLine();
                Opcao = Opcao.ToLower();
            } while (Opcao != "s");
        }
        static void RelatorioCaixa()
        {
            Console.Clear();
            Console.WriteLine("╔════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║░░░░░░░░░░░░░░░░░░░░░░░░░░  RELATORIO - CAIXA  ░░░░░░░░░░░░░░░░░░░░░░░░░║");
            Console.WriteLine("╚════════════════════════════════════════════════════════════════════════╝");
            Console.WriteLine("\n\nTemos {0} carros na garagem.", garagem);
            Console.WriteLine("Temos {0} carros rodando.", rodando);
            Console.WriteLine("Temos {0} carros reservados.", reservado);
            Console.WriteLine("Dinheiro em caixa : {0} R$", RendaCaixa);
            Console.WriteLine("\n\nAperte qualquer tecla para continuar!");
            Console.ReadKey();
        }
        static void RelatorioMes()
        {
            double dinheiroFaltando = 0;
            Console.Clear();
            Console.WriteLine("╔════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║░░░░░░░░░░░░░░░░░░░░░░░░░   RELATORIO - MENSAL   ░░░░░░░░░░░░░░░░░░░░░░░║");
            Console.WriteLine("╚════════════════════════════════════════════════════════════════════════╝");
            Console.WriteLine("\nClientes : {0}", ClienteCadastrado - ClientesRemovidos);
            Console.WriteLine("Carros : {0}", CarroCadastrado - CarrosRemovidos);
            Console.WriteLine("Temos {0} carros na garagem.", garagem);
            Console.WriteLine("Temos {0} carros rodando.", rodando);
            Console.WriteLine("Temos {0} carros reservados.", reservado);
            for (int i = 0; i < ClienteCadastrado - ClientesRemovidos; i++)
            {
                if (Saldo[i] > 0)
                {
                    dinheiroFaltando += Saldo[i];
                }
            }
            Console.WriteLine("Dinheiro : {0} R$", RendaMensal);
            Console.WriteLine("A receber : {0} R$", dinheiroFaltando);
            Console.WriteLine("Total = {0} R$", RendaMensal + dinheiroFaltando);
            Console.WriteLine("\n\nAperte qualquer tecla para continuar!");
            Console.ReadKey();
        }
        static void RemoverCarro()
        {
            int remover = 0;
            ConsultaCarros();
            if (Achou == 1)
            {
                Console.WriteLine("Tem certeza que deseja remover este carro?");
                do
                {
                    Console.WriteLine("S/N)");
                    Resposta = Console.ReadLine();
                    Resposta = Resposta.ToUpper();
                    if (Resposta != "S" && Resposta != "N")
                    {
                        Console.WriteLine("Resposta incorreta, digite novamente! ");
                    }
                } while (Resposta != "S" && Resposta != "N");
                if (Resposta == "S")
                {
                    Tentativas = 3;
                    do
                    {
                        Console.WriteLine("Digite a senha de usuario para confirmar: ");
                        SenhaTeste = Console.ReadLine();
                        Tentativas -= 1;
                        for (int i = 0; i < 5; i++)
                        {
                            if (Usuarios[i] + "123" == SenhaTeste)
                            {
                                for (int j = Posicao; j < CarroCadastrado; j++)
                                {
                                    Marca[j] = Marca[j + 1];
                                    Modelo[j] = Modelo[j + 1];
                                    Placa[j] = Placa[j + 1];
                                    Cor[j] = Cor[j + 1];
                                    Quilometragem[j] = Quilometragem[j + 1];
                                    Situacao[j] = Situacao[j + 1];
                                    DiasLocado[j] = DiasLocado[j + 1];
                                }
                                CarrosRemovidos += 1;
                                remover = 1;
                                break;
                            }
                        }
                        if (remover == 1)
                        {
                            break;
                        }
                        if (remover == 0)
                        {
                            Console.WriteLine("Senha incorreta! Tente Novamente... (máximo 3 tentativas)");
                            if (Tentativas == 3)
                            {
                                Console.WriteLine("3 tentativas... Voce acabou de cancelar a remoção do carro.");
                            }
                        }

                    } while (Tentativas != 0);
                }
            }
        }
        static void RemoverCliente()
        {
            int remover = 0;
            ConsultaCliente();
            if (Achou == 1)
            {
                Console.WriteLine("Tem certeza que deseja remover este cliente?");
                do
                {
                    Console.WriteLine("(S/N)");
                    Resposta = Console.ReadLine();
                    Resposta = Resposta.ToUpper();
                    if (Resposta != "S" && Resposta != "N")
                    {
                        Console.WriteLine("Resposta incorreta, digite novamente! ");
                    }
                } while (Resposta != "S" && Resposta != "N");
                if (Resposta == "S")
                {
                    Tentativas = 3;
                    do
                    {
                        Console.WriteLine("Digite a senha de usuario para confirmar: ");
                        SenhaTeste = Console.ReadLine();
                        Tentativas -= 1;
                        for (int i = 0; i < 5; i++)
                        {
                            if (Usuarios[i] + "123" == SenhaTeste)
                            {
                                for (int j = Posicao; j < ClienteCadastrado; j++)
                                {
                                    Nome[j] = Nome[j + 1];
                                    RG[j] = RG[j + 1];
                                    CPF[j] = CPF[j + 1];
                                    Saldo[j] = Saldo[j + 1];
                                    for (int e = 0; e < 7; e++)
                                    {
                                        Endereco[j, e] = Endereco[j + 1, e];
                                    }
                                }
                                ClientesRemovidos += 1;
                                remover = 1;
                                break;
                            }
                        }
                        if (remover == 1)
                        {
                            break;
                        }
                        if (remover == 0)
                        {
                            Console.WriteLine("Senha incorreta! Tente Novamente... (máximo 3 tentativas)");
                            if (Tentativas == 3)
                            {
                                Console.WriteLine("3 tentativas... Voce acabou de cancelar a remoção do cliente.");
                            }
                        }

                    } while (Tentativas != 0);
                }
            }
        }
        static void AlterarCliente()
        {
            ConsultaCliente();
            if (Achou == 1)
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine(" ");
                    Console.WriteLine("\t'1' - Nome.........: {0}", Nome[Posicao]);
                    Console.WriteLine("\t'2' - RG...........: {0}", RG[Posicao]);
                    Console.WriteLine("\t'3' - CPF..........: {0}", CPF[Posicao]);
                    Console.WriteLine("\t'4' - Pais.........: {0}", Endereco[Posicao, 0]);
                    Console.WriteLine("\t'5' - Estado.......: {0}", Endereco[Posicao, 1]);
                    Console.WriteLine("\t'6' - Cidade.......: {0}", Endereco[Posicao, 2]);
                    Console.WriteLine("\t'7' - Rua..........: {0}", Endereco[Posicao, 3]);
                    Console.WriteLine("\t'8' - Bairro.......: {0}", Endereco[Posicao, 4]);
                    Console.WriteLine("\t'9' - Numero.......: {0}", Endereco[Posicao, 5]);
                    Console.WriteLine("\t'10' - Complemento..: {0}", Endereco[Posicao, 6]);
                    Console.WriteLine("\t'11' - Saldo........: {0}", Saldo[Posicao]);
                    Console.WriteLine("\t'12' - Sair.");
                    Console.WriteLine("\nO que você deseja alterar?");
                    Opcao = Console.ReadLine();
                    switch (Opcao)
                    {
                        case "1":
                            Console.Write("Novo: ");
                            Nome[Posicao] = Console.ReadLine();
                            break;
                        case "2":
                            Console.Write("Novo: ");
                            RG[Posicao] = Console.ReadLine();
                            break;
                        case "3":
                            Console.Write("Novo: ");
                            CPF[Posicao] = Console.ReadLine();
                            break;
                        case "4":
                            Console.Write("Novo: ");
                            Endereco[Posicao, 0] = Console.ReadLine();
                            break;
                        case "5":
                            Console.Write("Novo: ");
                            Endereco[Posicao, 1] = Console.ReadLine();
                            break;
                        case "6":
                            Console.Write("Novo: ");
                            Endereco[Posicao, 2] = Console.ReadLine();
                            break;
                        case "7":
                            Console.Write("Novo: ");
                            Endereco[Posicao, 3] = Console.ReadLine();
                            break;
                        case "8":
                            Console.Write("Novo: ");
                            Endereco[Posicao, 4] = Console.ReadLine();
                            break;
                        case "9":
                            Console.Write("Novo: ");
                            Endereco[Posicao, 5] = Console.ReadLine();
                            break;
                        case "10":
                            Console.Write("Novo: ");
                            Endereco[Posicao, 6] = Console.ReadLine();
                            break;
                        case "11":
                            Console.Write("Novo: ");
                            Saldo[Posicao] = double.Parse(Console.ReadLine());
                            break;
                        default: Console.WriteLine("Opção incorreta! Digite novamente!");
                            continue;
                    }
                } while (Opcao != "12");
            }
        }
        static void AlterarCarro()
        {
            ConsultaCarros();
            if (Achou == 1)
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("\t'1' - Marca............: {0}", Marca[Posicao]);
                    Console.WriteLine("\t'2' - Modelo...........: {0}", Modelo[Posicao]);
                    Console.WriteLine("\t'3' - Placa............: {0}", Placa[Posicao]);
                    Console.WriteLine("\t'4' - Cor..............: {0}", Cor[Posicao]);
                    Console.WriteLine("\t'5' - Km Atual.........: {0}", Quilometragem[Posicao]);
                    Console.WriteLine("\t'6' - Situação.........: {0}", Situacao[Posicao]);
                    Console.WriteLine("\t'7' - Disponibilidade..: {0} dias", DiasLocado[Posicao]);
                    Console.WriteLine("\t'8' - Valor Diária.....: {0}", ValorDiaria[Posicao]);
                    Console.WriteLine("\t'9' - Sair.");
                    Console.WriteLine("\nO que você deseja alterar?");
                    Opcao = Console.ReadLine();
                    switch (Opcao)
                    {
                        case "1":
                            Console.Write("Novo: ");
                            Marca[Posicao] = Console.ReadLine();
                            break;
                        case "2":
                            Console.Write("Novo: ");
                            Modelo[Posicao] = Console.ReadLine();
                            break;
                        case "3":
                            do
                            {
                                Console.Write("Novo: ");
                                Console.WriteLine("(XXX-000): ");
                                Placa[Posicao] = Console.ReadLine();
                                if (Placa[Posicao].Length != 6)
                                {
                                    Console.WriteLine("Placa invalida. Digite novamente com 6 digitos!");
                                }
                            } while (Placa[Posicao].Length != 6);
                            break;
                        case "4":
                            Console.Write("Novo: ");
                            Cor[Posicao] = Console.ReadLine();
                            break;
                        case "5":
                            Console.Write("Novo: ");
                            Quilometragem[Posicao] = double.Parse(Console.ReadLine());
                            break;
                        case "6":
                            do
                            {
                                Console.WriteLine("(Garagem - Rodando - Reservado): ");
                                Situacao[Posicao] = Console.ReadLine();
                            } while (Situacao[Posicao] != "Garagem" || Situacao[Posicao] != "Rodando" || Situacao[Posicao] != "Reservado");
                            break;
                        case "7":
                            Console.Write("Novo: ");
                            DiasLocado[Posicao] = int.Parse(Console.ReadLine());
                            break;
                        case "8":
                            Console.Write("Novo: ");
                            ValorDiaria[Posicao] = double.Parse(Console.ReadLine());
                            break;
                        default: Console.WriteLine("Opção incorreta! Digite novamente!");
                            continue;
                    }
                } while (Opcao != "9");
            }
        }
    }
}

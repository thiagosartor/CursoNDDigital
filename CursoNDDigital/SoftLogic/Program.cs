using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftLogic
{
    class Program
    {
        public static string User = "";
        public static string Senha = "";
        public static int OpcaoMenu;
        public static int QuestoesObjetivas;
        public static int QuestoesDescritivas;
        public static int TotalDeQuestoes;
        public static string[,] Alternativas;
        public static int Codigo;
        public static string[] Gabarito;
        public static string[] EnunciadosObjetivas;
        public static string[] EnunciadosDescritivas;
        public static int posicao;

        static void Main(string[] args)
        {
            bool status = false;
            int tentativasErradas = 0;
            do
            {
                status = VerificarCredenciais();
                if (!status)
                {
                    Console.Clear();
                    Console.WriteLine("=========================== ATENÇÃO! ===========================");
                    Console.WriteLine("\n\n\n\n\n\n\n\n");
                    Console.WriteLine("ATENÇÃO: Nome de usuário e senha não conferem! Verifique-os.\n \nAperte ENTER para continuar");
                    tentativasErradas++;
                    Console.ReadKey();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("=========================== HOME ===========================");
                    Console.WriteLine("\n\n\n\n\n");
                    Console.Write("SUCESSO! Você está logado!\n\n\n\n\nAperte ENTER para continuar");
                    Console.ReadKey();
                    Console.Clear();
                }

                if (tentativasErradas == 3)
                {
                    Console.Clear();
                    Console.WriteLine("=========================== ATENÇÃO! ===========================");
                    Console.WriteLine("\n\n\n\n\n\n\n\n");
                    Console.WriteLine("USUÁRIO BLOQUEADO! \nDados informados incorretamente por 3 vezes seguidas!\n");
                    Console.WriteLine("\n\n\n\n\n\n\n\n\n");
                    break;
                }
            } while (!status);

            if (!status)
                Console.WriteLine("Tente novamente mais tarde!");
            else
            {
                do
                {
                    Console.Clear();
                    OpcaoMenu = MostrarMenu();
                    switch (OpcaoMenu)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine(" ========== CADASTRO ==========\n");
                            Console.Write("Informe a quantidade de questões descritivas: ");
                            QuestoesDescritivas = int.Parse(Console.ReadLine());
                            Console.Write("Informe a quantidade de questões objetivas: ");
                            QuestoesObjetivas = int.Parse(Console.ReadLine());
                            TotalDeQuestoes = QuestoesDescritivas + QuestoesObjetivas;
                            if (QuestoesDescritivas > 0 && QuestoesObjetivas > 0)
                            {
                                EnunciadosObjetivas = CadastroEnunciadosQuestoesObjetivas(QuestoesObjetivas);
                                Alternativas = CadastroAlternativasQuestoesObjetivas(QuestoesObjetivas);
                                EnunciadosDescritivas = CadastroEnunciadosQuestoesDescritivas(QuestoesDescritivas);
                                Codigo = 3;
                            }
                            if (QuestoesDescritivas > 0 && QuestoesObjetivas == 0)
                            {
                                EnunciadosDescritivas = CadastroEnunciadosQuestoesDescritivas(QuestoesDescritivas);
                                Codigo = 2;
                            }
                            if (QuestoesDescritivas == 0 && QuestoesObjetivas > 0)
                            {
                                EnunciadosObjetivas = CadastroEnunciadosQuestoesObjetivas(QuestoesObjetivas);
                                Alternativas = CadastroAlternativasQuestoesObjetivas(QuestoesObjetivas);
                                Codigo = 1;
                            }
                            if (QuestoesDescritivas == 0 && QuestoesObjetivas == 0)
                            {
                                Console.WriteLine("ATENÇÃO: Quantidade Incorreta!");
                            }
                            break;
                        case 2:
                            Gabarito = GerarGabarito(QuestoesObjetivas, QuestoesDescritivas);
                            Console.WriteLine("Gabarito gerado!");
                            Console.ReadKey();
                            break;
                        case 3:
                            Console.Clear();
                            if (QuestoesObjetivas > 0)
                            {
                                ImprimirEnunciadoObjetivas(EnunciadosObjetivas, Alternativas);
                            }
                            if (QuestoesObjetivas == 0)
                            {
                                Console.WriteLine("ATENÇÃO: Não há questões objetivas cadastradas!");
                            }
                            Console.ReadKey();
                            break;
                        case 4:
                            Console.Clear();
                            if (QuestoesDescritivas > 0)
                            {
                                ImprimirEnunciadosDescritivas(EnunciadosDescritivas);
                            }
                            if (QuestoesDescritivas == 0)
                            {
                                Console.WriteLine("ATENÇÃO: Não há questões descritivas cadastradas!");
                            }
                            Console.ReadKey();
                            break;
                        case 5:
                            Console.Clear();
                            if (Gabarito == null)
                            {
                                Console.WriteLine("O gabarito para esta prova ainda não está cadastrado,\n Voltar para o menu principal e aperte 2 para gerar o Gabarito");
                                Console.ReadKey();
                            }
                            else
                            {
                                ImprimirGabarito(Gabarito, Codigo);
                                Console.WriteLine("Pressione ENTER para continuar: ");
                                Console.ReadKey();
                            }

                            break;
                        case 6:
                            Console.Clear();
                            if (QuestoesObjetivas == 0)
                            {
                                Console.WriteLine("ATENÇÃO: não há questões objetivas disponiveis para serem editadas");
                            }
                            else
                            {
                                Console.WriteLine("Informe o número da questão: ");
                                posicao = int.Parse(Console.ReadLine());
                                if (!VerificaPosicao(EnunciadosObjetivas, posicao))
                                {
                                    EditarEnunciado(EnunciadosObjetivas, posicao);
                                    Console.WriteLine("Deseja alterar a resposta de alguma questão(S/N): ");
                                    string cont = Console.ReadLine();
                                    if (cont.ToUpper() == "S")
                                    {
                                        Console.WriteLine("Informe o número da questão: ");
                                        posicao = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Informe a nova resposta: ");
                                        string alternativa = Console.ReadLine();
                                        switch (alternativa.ToUpper())
                                        {
                                            case "A":
                                                EditarAlternativa(Alternativas, posicao, 0);
                                                break;
                                            case "B":
                                                EditarAlternativa(Alternativas, posicao, 1);
                                                break;
                                            case "C":
                                                EditarAlternativa(Alternativas, posicao, 2);
                                                break;
                                            case "D":
                                                EditarAlternativa(Alternativas, posicao, 3);
                                                break;
                                            case "E":
                                                EditarAlternativa(Alternativas, posicao, 4);
                                                break;
                                        }
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("ATENÇÃO: posição vazia!");
                                    Console.ReadKey();
                                }

                            }

                            Console.ReadKey();
                            break;
                        case 7:
                            Console.Clear();
                            if (QuestoesDescritivas == 0)
                            {
                                Console.WriteLine("Não há questoes descritivas cadastradas!");
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.WriteLine("Informe o número da questão: ");
                                posicao = int.Parse(Console.ReadLine());
                                if (!VerificaPosicao(EnunciadosDescritivas, posicao))
                                {

                                    EditarEnunciado(EnunciadosDescritivas, posicao);
                                    Console.WriteLine("Deseja alterar a resposta da questão(S/N): ");
                                    string opc = Console.ReadLine();
                                    if (opc.ToUpper() == "S")
                                    {
                                        EditarResposta(Gabarito, posicao);
                                    }
                                    Console.ReadKey();
                                }
                                else
                                {
                                    Console.WriteLine("ATENÇÃO:posição vazia!");
                                    Console.ReadKey();
                                }
                            }


                            break;
                        case 8:
                            Console.Clear();
                            if (EnunciadosDescritivas.Length > 0)
                            {
                                Console.WriteLine("Informe o número da questão: ");
                                posicao = int.Parse(Console.ReadLine());
                                RemoveEnunciado(posicao, EnunciadosDescritivas);
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.WriteLine("Vazio");
                            }

                            break;
                        case 9:
                            Console.Clear();
                            if (EnunciadosObjetivas.Length > 0)
                            {
                                Console.WriteLine("Informe o número da questão: ");
                                posicao = int.Parse(Console.ReadLine());
                                RemoveEnunciado(posicao, EnunciadosObjetivas, Alternativas);
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.WriteLine("Vazio");
                            }

                            break;
                        case 10:
                            Console.Clear();
                            GeraGabaritosDeProvasEstaticas();
                            Console.ReadKey();
                            break;
                        case 11:
                            MostrarAjuda();
                            break;
                        case 12:
                            MostrarSobre();
                            break;
                        case 0:
                            Console.Clear();
                            Console.WriteLine("=========================== SAINDO ===========================");
                            Console.WriteLine("\n\n\n\n\n\n\n\n ");
                            Console.WriteLine("ATÉ LOGO!");
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("ATENÇÃO: Opção Inválida! \nPressione ENTER para continuar.");
                            Console.ReadKey();
                            break;
                    }
                } while (OpcaoMenu != 0);
            }
            Console.ReadKey();
        }

        public static int MostrarMenu()
        {
            Console.WriteLine("=========================== MENU ===========================");
            Console.WriteLine("\n\n");
            Console.WriteLine("1 - Cadastrar Prova (Opcional)");
            Console.WriteLine("2 - Gerar Gabarito");
            Console.WriteLine("3 - Imprimir Enunciados Objetivas");
            Console.WriteLine("4 - Imprimir Enunciados Descritivas");
            Console.WriteLine("5 - Imprimir Gabarito");
            Console.WriteLine("6 - Editar Objetivas");
            Console.WriteLine("7 - Editar Descritivas");
            Console.WriteLine("8 - Remover Enunciado Descritiva");
            Console.WriteLine("9 - Remover Enunciado Objetiva");
            Console.WriteLine("10- Imprimir Provas Estaticas (Exemplos)");
            Console.WriteLine("11 - Ajuda");
            Console.WriteLine("12 - Sobre");
            Console.WriteLine("0 - Encerrar o programa.");
            Console.WriteLine("\n\n\n\n");
            Console.Write("Informe a opção desejada: ");
            return int.Parse(Console.ReadLine());
        }

        public static bool VerificarCredenciais()
        {
            Console.Clear();
            Console.WriteLine(" =========================== LOGIN ===========================");
            Console.WriteLine("\n\n");
            Console.Write("Informe o nome de usuário: ");
            string nameUser = Console.ReadLine();
            Console.Write("Informe a senha: ");
            string senhaUser = Console.ReadLine();
            Senha = nameUser + "123";
            if (Senha == senhaUser)
                return true;
            else
                return false;
        }

        static void MostrarSobre()
        {
            Console.Clear();
            Console.WriteLine(" ===== SOBRE =====\n");
            Console.WriteLine("Nome do Programa: CONTROLE DE AVALIAÇÕES");
            Console.WriteLine("Empresa: SOFTLOGIC");
            Console.WriteLine("\n ===== Equipe de Desenvolvimento =====\n \n- ARNALDO MADEIRA \n- CAMILA SILVA \n- LUCAS SIQUEIRA \n- RAFAEL ALDO");
            Console.Write("\nPressione ENTER para continuar: ");
            Console.ReadKey();
        }

        public static void MostrarAjuda()
        {
            int opc = 0;
            do
            {
                Console.Clear();
                Console.WriteLine(" ========== MENU AJUDA (?) ==========");
                Console.WriteLine("\nSelecione uma das opções abaixo para obter ajuda sobre a funcionalidade");
                Console.WriteLine("1 - CADASTRO DE PROVAS");
                Console.WriteLine("2 - GERAR GABARITOS");
                Console.WriteLine("3 - EXIBIR QUESTÕES OBJETIVAS");
                Console.WriteLine("4 - EXIBIR QUESTÕES DESCRITIVAS");
                Console.WriteLine("5 - EXIBIR GABARITO");
                Console.WriteLine("6 - EDITAR OBJETIVAS");
                Console.WriteLine("7 - EDITAR DESCRITIVAS");
                Console.WriteLine("8 - REMOVER ENUNCIADO DESCRITIVAS");
                Console.WriteLine("9 - REMOVER ENUNCIADO OBJETIVAS");
                Console.WriteLine("10 - EXIBIR EXEMPLO DE PROVAS");
                Console.WriteLine("0 - RETORNAR AO MENU PRINCIPAL");
                Console.WriteLine("\n\nInforme a opção que deseja: ");
                opc = Convert.ToInt32(Console.ReadLine());
                switch (opc)
                {
                    case 1:
                        Console.WriteLine("\nRealiza o cadastro da prova a partir da quantidade informada de questões descritivas com seus respectivos enunciados e de questões objetivas com seus enunciados incluindo as alternativas de A a E com uma opção correta.");
                        Console.WriteLine("Aperte ENTER para continuar");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.WriteLine("\nGera o gabarito das provas objetivas cadastradas e sua opção certa, e também gera a resposta das descritivas.");
                        Console.WriteLine("\nAperte ENTER para continuar");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.WriteLine("\nExibe as questões objetivas anteriormente cadastradas pelo usuário (Questões objetivas possuem enunciado e opções de A a E sendo que somente uma é a correta)");
                        Console.WriteLine("\nAperte ENTER para continuar");
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.WriteLine("\nExibe as questões descritivas anteriormente cadastradas pelo usuário (Possuem um enunciado da pergunta e uma resposta descrita)");
                        Console.WriteLine("\nAperte ENTER para continuar");
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.WriteLine("\nExibe gabarito com respostas das questões objetivas respectivamente apontadas com uma opção de A a E, e as questões descritivas com a resposta escrita");
                        Console.WriteLine("\nAperte ENTER para continuar");
                        Console.ReadKey();
                        break;
                    case 6:
                        Console.WriteLine("\nEdita as respostas alternativas (A a E) colocadas como correta na resposta da questão");
                        Console.WriteLine("\nAperte ENTER para continuar");
                        Console.ReadKey();
                        break;
                    case 7:
                        Console.WriteLine("\nEdita as respostas nas perguntas descritivas colocadas anteriormente");
                        Console.WriteLine("\nAperte ENTER para continuar");
                        Console.ReadKey();
                        break;
                    case 8:
                        Console.WriteLine("\nRemove o enunciado da questão descritiva, a pergunta anteriormente posta");
                        Console.WriteLine("\nAperte ENTER para continuar");
                        Console.ReadKey();
                        break;
                    case 9:
                        Console.WriteLine("\nRemove o enunciado da questão objetiva, a pergunta anteriormente posta");
                        Console.WriteLine("\nAperte ENTER para continuar");
                        Console.ReadKey();
                        break;
                    case 10:
                        Console.WriteLine("\nExibir provas ja elaboradas estaticamente de exemplo");
                        Console.WriteLine("\nAperte ENTER para continuar");
                        Console.ReadKey();
                        break;
                    case 0:
                        Console.WriteLine("\nAperte ENTER para voltar ao MENU PRINCIPAL");
                        Console.ReadKey();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("\nATENÇÃO! Opção Inválida \nAperte ENTER para continuar");
                        Console.ReadKey();
                        break;
                }
            } while (opc != 0);
        }




        public static string[] CadastroEnunciadosQuestoesObjetivas(int QuestoesObjetivas)
        {
            string[] enunciadosObjetivas = new string[QuestoesObjetivas];

            if (QuestoesObjetivas > 0)
            {
                for (int i = 0; i < QuestoesObjetivas; i++)
                {
                    Console.Clear();
                    Console.WriteLine("===== Cadastro de Questões Objetivas =====");
                    Console.WriteLine("\nDigite o enunciado das questão objetiva {0}: ", i);
                    //int j = 0;
                    enunciadosObjetivas[i] = Console.ReadLine();
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("===== Cadastro de Questões Objetivas =====");
                Console.WriteLine("\nNão há questões objetivas para cadastro!");
            }
            return enunciadosObjetivas;
        }

        public static string[] CadastroEnunciadosQuestoesDescritivas(int QuestoesDescritivas)
        {
            string[] enunciadosDescritivas = new string[QuestoesDescritivas];
            if (QuestoesDescritivas > 0)
            {
                for (int i = 0; i < QuestoesDescritivas; i++)
                {
                    Console.Clear();
                    Console.WriteLine("===== Cadastro de Questões Descritivas =====");
                    Console.WriteLine("\nDigite o enunciado da questão descritiva {0}: ", i);
                    //int j = 0;
                    enunciadosDescritivas[i] = Console.ReadLine();
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("===== Cadastro de Questões Descritivas =====");
                Console.WriteLine("\nNão há questões descritivas para cadastro!");
            }
            return enunciadosDescritivas;
        }

        public static string[,] CadastroAlternativasQuestoesObjetivas(int QuestoesObjetivas)
        {
            string[] alternativas = new string[QuestoesObjetivas];
            string[,] todasAlternativas = new string[QuestoesObjetivas, 5];
            char[] letras = new char[5];
            letras[0] = 'A';
            letras[1] = 'B';
            letras[2] = 'C';
            letras[3] = 'D';
            letras[4] = 'E';
            for (int i = 0; i < QuestoesObjetivas; i++)
            {

                for (int j = 0; j < 5; j++)
                {
                    Console.Clear();
                    Console.WriteLine("===== Cadastro de Alternativas =====");
                    Console.WriteLine("\nDigite a descrição da alternativa {0}, da questão {1}: ", letras[j], i);
                    alternativas[i] = Console.ReadLine();
                    todasAlternativas[i, j] = alternativas[i];
                }
            }
            return todasAlternativas;
        }

        public static string[] GerarGabarito(int QuestoesObjetivas, int QuestoesDescritivas)
        {
            Console.Clear();
            Console.WriteLine("===== Gabarito =====");
            string[] alternativaCerta = new string[QuestoesObjetivas];
            string[] RespostaCertaDescritiva = new string[QuestoesDescritivas];
            string[] todasResposta = new string[QuestoesDescritivas + QuestoesObjetivas];

            for (int i = 0; i < QuestoesObjetivas; i++)
            {
                Console.Clear();
                Console.WriteLine(" ----- Cadastro de Respostas das Questões Objetivas ----- ");
                Console.WriteLine("\nQual é a alternativa certa da questão {0}: ", i);
                alternativaCerta[i] = Console.ReadLine();
            }

            for (int i = 0; i < QuestoesDescritivas; i++)
            {
                Console.Clear();
                Console.WriteLine(" ----- Cadastro das respostas das questoes descritivas ----");
                Console.WriteLine("\nDigite a resposta descritiva certa da questão {0}: ", i);
                RespostaCertaDescritiva[i] = Console.ReadLine();
            }
            for (int i = 0; i < QuestoesObjetivas; i++)
            {
                todasResposta[i] = alternativaCerta[i];
            }
            int count = 0;
            for (int i = QuestoesObjetivas; i < TotalDeQuestoes; i++)
            {
                todasResposta[i] = RespostaCertaDescritiva[count];
                count++;
            }

            return todasResposta;
        }

        public static void ImprimirEnunciadoObjetivas(string[] array, string[,] array2)
        {
            char[] letras = new char[5];
            letras[0] = 'A';
            letras[1] = 'B';
            letras[2] = 'C';
            letras[3] = 'D';
            letras[4] = 'E';
            Console.WriteLine(" ===== QUESTÕES OBJETIVAS =====\n");
            for (int i = 0; i < array2.GetLength(0); i++)
            {
                Console.WriteLine("Questão {0}: {1}", i, array[i]);
                for (int j = 0; j < array2.GetLength(1); j++)
                {
                    if (array2[i, 0] == null)
                    {
                        Console.WriteLine("questão:{0} deletada", i);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Alternativa {0}: {1}", letras[j], array2[i, j]);
                    }



                }
                Console.WriteLine(" ");
            }


            Console.WriteLine("Pressione ENTER para continuar: ");

        }

        public static void ImprimirAlternativasQuestoesObjetivas(string[,] array)
        {

            char[] letras = new char[5];
            letras[0] = 'A';
            letras[1] = 'B';
            letras[2] = 'C';
            letras[3] = 'D';
            letras[4] = 'E';

            for (int i = 0; i < array.GetLength(0); i++)
            {


                Console.WriteLine("Alternativas da questão:{0}", i);
                for (int j = 0; j < array.GetLength(1); j++)
                {


                    Console.WriteLine("Alternativa :{0} {1}", letras[j], array[i, j]);



                }
            }
        }

        public static void ImprimirEnunciadosDescritivas(string[] array)
        {
            Console.WriteLine("====== Enunciados das questões descritivas =====");
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != null)
                    Console.WriteLine("Questão {0}: {1}", i, array[i]);
                else
                {
                    Console.WriteLine("Questão {0}: DELETADA", i);
                    break;
                }

            }
        }

        public static void ImprimirGabarito(string[] array, int tipo)
        {

            if (tipo == 1)
            {
                Console.Clear();
                Console.WriteLine("----- Respostas Questões Objetivas -----");
                for (int i = 0; i < QuestoesObjetivas; i++)
                {
                    Console.WriteLine("Questão {0}: ", i);
                    Console.WriteLine(array[i]);
                }
            }
            if (tipo == 2)
            {
                Console.Clear();
                Console.WriteLine("----- Respostas Questões Descritivas -----");
                for (int i = 0; i < QuestoesDescritivas; i++)
                {
                    Console.WriteLine("Questão {0}: ", i);
                    Console.WriteLine(array[i]);
                }
            }
            if (tipo == 3)
            {
                Console.Clear();
                Console.WriteLine("----- Respostas de todas as questões -----");
                Console.WriteLine("\nRespostas das questões objetivas:");
                for (int i = 0; i < QuestoesObjetivas; i++)
                {
                    Console.WriteLine("Questão {0}:", i);
                    Console.WriteLine(array[i]);
                }

                Console.WriteLine("\nRespostas das questoes descritivas:");
                for (int i = QuestoesObjetivas; i < TotalDeQuestoes; i++)
                {
                    Console.WriteLine("Questão {0}:", i);
                    Console.WriteLine(array[i]);
                }
            }
        }

        public static bool VerificaPosicao(int posicao)
        {
            return posicao >= 0 && posicao <= TotalDeQuestoes;
        }

        public static void EditarEnunciado(string[] array, int pos)
        {
            if (VerificaPosicao(pos))
            {
                Console.WriteLine("Enunciado antigo: {0}", array[pos]);
                Console.WriteLine("Informe o enunciado novo: ");
                array[pos] = Console.ReadLine();
                Console.WriteLine("AVISO: Enunciado alterado com sucesso\nNovo Enunciado: {0}", array[pos]);
            }
            else
            {
                Console.WriteLine("ATENÇÃO: Posição é inválida!");
            }
            Console.WriteLine("Pression ENTER para continuar: ");

        }
        public static void EditarAlternativa(string[,] array, int posq, int posa)
        {

            if (VerificaPosicao(posq))
            {
                Console.WriteLine("Alternativa: {0}", array[posq, posa]);
                Console.WriteLine("AVISO: Alternativa alterada com sucesso! \nNova Alternativa correta: {0}", array[posq, posa]);
            }
            else
            {
                Console.WriteLine("ATENÇÃO: Posição é inválida!");
            }
            Console.WriteLine("Pression ENTER para continuar: ");
            Console.ReadKey();
        }
        public static void EditarResposta(string[] array, int pos)
        {
            if (VerificaPosicao(pos))
            {
                Console.WriteLine("Resposta: {0}", array[pos]);
                Console.WriteLine("Informe a resposta certa: ");
                array[pos] = Console.ReadLine();
                Console.WriteLine("AVISO: Resposta alterada com sucesso! \nNova resposta correta: {0}", array[pos]);
            }
            else
            {
                Console.WriteLine("ATENÇÃO: Posição é inválida!");
            }
            Console.WriteLine("Aperte ENTER para continuar: ");
        }

        public static void RemoveEnunciado(int posicao, string[] array)
        {
            if (!VerificaPosicao(posicao))
            {
                Console.WriteLine("Posição inválida");
            }
            else
            {
                Console.WriteLine("Enunciado foi removido!");
            }
            array[posicao] = null;
            TotalDeQuestoes--;
            Console.WriteLine("Aperte ENTER para continuar: ");
        }

        public static void RemoveEnunciado(int posicao, string[] array, string[,] alternativas)
        {
            if (!VerificaPosicao(posicao))
            {
                Console.WriteLine("Posição inválida");
            }
            else
            {
                Console.WriteLine("Enunciado e as alternativas foram removidos!");
            }
            array[posicao] = null;

            for (int j = 0; j < alternativas.GetLength(1); j++)
            {
                alternativas[posicao, j] = null;
            }
            TotalDeQuestoes--;
            Console.WriteLine("Aperte ENTER para continuar: ");
        }


        public static void RemoveResposta(int posicao, string[] array)
        {
            if (!VerificaPosicao(posicao))
            {
                Console.WriteLine("Posição inválida");
            }
            else
            {
                Console.WriteLine("Resposta foi removida com sucesso!");
            }
            array[posicao] = null;
            TotalDeQuestoes--;

        }

        public static bool VerificaPosicao(string[] array, int posicao)
        {
            return array[posicao] == null && posicao > TotalDeQuestoes;
        }

        public static void GeraGabaritosDeProvasEstaticas()
        {
            string[] respostasProvaObjetiva = new string[10];
            string[] respostasProvaObjetiva2 = new string[10];
            string[] respostasProvaDescritiva = new string[10];
            string[] respostasProvaMesclada = new string[10];
            string[] enunciadoProvaObjetiva = new string[10];
            string[] enunciadoProvaObjetiva2 = new string[10];
            string[] enunciadoProvaDescritiva = new string[10];
            string[] enunciadoProvaMesclada = new string[10];
            char[] alternativas = new char[5];
            char[] alternativasRandomicas = "ABCDE".ToCharArray();
            string[] enunciadosProvaMescladaDescritivas = { "teorema de pitagoras", "teorema de tio chiquinho", "teorema do thiago", "teorema do pa e bola", "teorema do zé", "teorema do tio patinhas", "teorema do tio sam", "teorema do tio pinga" };
            int t;
            Random rnd = new Random();
            for (int i = 0; i < 5; i++)
            {
                t = rnd.Next(alternativasRandomicas.Length);
                alternativas[i] = alternativasRandomicas[t];
            }

            //gabarito das 4 provas uma seguinte das outras;
            for (int j = 0; j < 10; j++)
            {
                enunciadoProvaObjetiva[j] = "Enunciado da questao " + j + " da prova objetiva 1";
                respostasProvaObjetiva[j] = "Resposta: " + "- " + j;
                enunciadoProvaObjetiva2[j] = "Enunciado da questao " + j + " da prova objetiva 2";
                respostasProvaObjetiva2[j] = "Resposta: " + "- " + j;
            }
            int l = 0;
            for (int i = 0; i < 10; i++)
            {
                enunciadoProvaDescritiva[i] = "Enunciado da questao " + i + " da prova descritiva";
                l = rnd.Next(enunciadosProvaMescladaDescritivas.Length);
                respostasProvaDescritiva[i] = enunciadosProvaMescladaDescritivas[l];
            }
            int count1 = 0;
            Console.WriteLine("===== Prova 1 (Prova Objetiva 1) =====\n");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(enunciadoProvaObjetiva[i]);
                Console.WriteLine("Alternativa " + alternativas[count1] + " " + respostasProvaObjetiva[i]);
                count1++;
                if (count1 == 3)
                {
                    count1 = 0;
                }
            }
            Console.WriteLine("===== Prova 2 (Prova Objetiva 2) =====\n");
            int count2 = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(enunciadoProvaObjetiva2[i]);
                Console.WriteLine("Alternativa " + alternativas[count2] + " " + respostasProvaObjetiva2[i]);
                count2++;
                if (count2 == 3)
                {
                    count2 = 0;
                }
            }

            int count3 = 0;
            Console.WriteLine("Prova 3 (Prova Descritiva)\n");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(enunciadoProvaDescritiva[i]);
                Console.WriteLine("Alternativa " + alternativas[count3] + " " + respostasProvaDescritiva[i]);
                count3++;
                if (count3 == 3)
                {
                    count3 = 0;
                }
            }

            int k = 0;

            for (int i = 0; i < 5; i++)
            {
                enunciadoProvaMesclada[i] = "Enunciado da questao " + i + " da prova mesclada";
                k = rnd.Next(enunciadosProvaMescladaDescritivas.Length);
                respostasProvaMesclada[i] = "Resposta " + enunciadosProvaMescladaDescritivas[k];
            }
            for (int i = 5; i < 10; i++)
            {
                enunciadoProvaMesclada[i] = "Enunciado da questao " + i + " da prova mesclada";
                respostasProvaMesclada[i] = "Resposta " + "- " + i;
            }

            Console.WriteLine("===== Prova 4 (Prova Mesclada) =====\n");
            int count4 = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(enunciadoProvaMesclada[i]);
                Console.WriteLine("Alternativa " + alternativas[count4] + " " + respostasProvaMesclada[i]);
                count4++;
                if (count4 == 3)
                {
                    count4 = 0;
                }
            }
        }
    }
}

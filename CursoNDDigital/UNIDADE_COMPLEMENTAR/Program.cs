using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace UNIDADE_COMPLEMENTAR
{
    internal class Program
    {
        public static ArrayList _ArrayList = new ArrayList(1);
        public static List<string> _ListString = new List<string>();
        public static List<int> _List = new List<int>();
        public static List<int> _ListInt = new List<int>() { 10, 23, 3, 17, 78, 19 };
        public static Dictionary<int, string> _Dictionary = new Dictionary<int, string>();

        private static void Main(string[] args)
        {
            //ARRAY LIST

            _ArrayList.Add(1); //ADICIONA UM INTEIRO
            _ArrayList.Add("Thiago"); //ADICIONA UM INTEIRO
            _ArrayList.Add(1.78); //ADICIONA UM DOUBLE
            _ArrayList.Add('M'); //ADICIONA UM CHAR
            _ArrayList.Add(true); //ADICIONA UM BOOLEAN
            _ArrayList.Insert(3, 1); //INSERE NA POSIÇÃO

            _ArrayList.Remove(1); //REMOVE POR OBJETO
            _ArrayList.Remove("Thiago"); //REMOVE POR OBJETO
            _ArrayList.Remove(1.78); //REMOVE POR OBJETO
            _ArrayList.Remove('M'); //REMOVE POR OBJETO
            _ArrayList.Remove(true); //REMOVE POR OBJETO
            int idex = _ArrayList.IndexOf(1); //MOSTRA A POSIÇÃO
            int lastIdex = _ArrayList.LastIndexOf(1); //MOSTRA A ULTIMA POSIÇÃO
            _ArrayList.Sort(); //ORDERNA CRESCENTE
            _ArrayList.Reverse(); //ORDENA DECRESCENTE
            _ArrayList.RemoveAt(0); // REMOVE POR POSIÇÃO
            _ArrayList.Clear(); //LIMPA A LISTA

            //ARRAY LIST

            //LIST

            //ALGUNS COMANDOS SÃO IGUAIS OS DO ARRAYLIST

            int max = _ListInt.Max(); //DEVOLVE O MAIOR VALOR
            int min = _ListInt.Min(); //DEVOLVE O MENOR VALOR
            int soma = _ListInt.Sum();//DEVOLVE A SOMA DOS VALORES
            double media = _ListInt.Average(); //DEVOLVE A MÉDIA DOS VALORES

            var numeroIgual2 = _List.Find(item => item == 2); //LISTA O OBJETO COM VALOR 12 E ARMAZENA EM ITEM
            var todosMaiorQue10 = _List.FindAll(item => item > 10).ToList(); //LISTA TODOS OS VALORES MAIORES QUE 10 E ARMAZENA EM ITEMS
            var nomesLetraT = _ListString.Where(x => x.Contains("T")).ToList(); //LISTA TODOS OS NOMES QUE CONTEM A LETRA T

            foreach (var item in todosMaiorQue10) //LISTA O NUMEROS
            {
                Console.WriteLine(item);
            }

            //LIST

            //IENUMERABLE

            IEnumerable<int> orderDesc =
              from i in _ListInt
              orderby i descending
              select i;
            //DESDENDIG ORDENA DECRESCENTE
            //O ORDERBY ORDENA CRESCENTE POR DEFAULT (PADRÃO)

            //IENUMERABLE

            //DICTIONARY

            _Dictionary.Add(1, "2");
            _Dictionary.Add(2, "22");
            _Dictionary.Add(3, "222");
            _Dictionary.Add(4, "3");
            _Dictionary.Add(5, "33");
            _Dictionary.Add(6, "333");
            _Dictionary.Add(7, "4");

            //DICTIONARY ( KEY, VALUE );
            //A KEY É COMO SE FOSSE O IDENTIFICADOR QUE ESTA LIGADO AO VALUE QUE É O VALOR
            //A KEY 1 REPRESENTA O VALOR "2" NO EXEMPLO ACIMA

            //DICTIONARY

            //5)1)	Crie um algoritmo com uma coleção com todos dos times da copa. Sabe-se que são 32 times que serão sorteados e divididos em 8 grupos, do A ao H. Depois de sorteados e alocados o algoritmo deve imprimir na tela todos os grupos.

            var copaDoMundo = new Dictionary<string, char>();
            var grupos = new List<char> { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H' };
            var times = new List<string>
            {
                "Alemanha", "Argélia", "Argentina", "Austrália", "Bélgica",
                "Bósnia H.","Brasil", "Camarões","Colombia", "Chile", "Coreia do S.",
                "Costa do M.", "Costa R.", "Croácia", "Equador", "Espanha",
                "Estados U.", "França", "Gana", "Grécia", "Holanda", "Honduras",
                "Inglaterra", "Irã", "Itália", "Japão", "México", "Nigéria",
                "Portugal", "Rússia", "Suíça", "Uruguai"
            };
            var sort = new Random();

            for (int j = 0; j < 8; j++)
            {
                for (int i = 0; i < 4; i++)
                {
                    int time = sort.Next(0, times.Count);

                    copaDoMundo.Add(times[time], grupos[j]);
                    times.Remove(times[time]);
                }
            }
            int count = 0;
            foreach (var t in copaDoMundo)
            {
                if (count % 4 == 0)
                {
                    Console.WriteLine("");
                    Console.WriteLine("--------------");
                    Console.WriteLine("    GRUPO " + t.Value);
                    Console.WriteLine("--------------");
                }
                Console.WriteLine("    "+t.Key);
                count++;
            }
        }
    }
}
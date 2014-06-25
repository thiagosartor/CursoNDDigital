using System;
using System.Collections;
using System.Collections.Generic;

namespace UNIDADE_COMPLEMENTAR
{
    internal class Program
    {
        public static ArrayList _ArrayList = new ArrayList(1);
        public static List<int> _List = new List<int>();
        public static List<int> _ListInt = new List<int>() { 10, 23, 3, 17, 78, 19 };
        public static Dictionary<int, string> _Dictionary = new Dictionary<int, string>();

        private static void Main(string[] args)
        {
            //ArrayList

            //ADICIONAR
            _ArrayList.Add(1);
            _ArrayList.Add("Thiago");
            _ArrayList.Add(1.78);
            _ArrayList.Add('M');
            //REMOVER
            _ArrayList.Remove(1); // REMOVE POR OBJETO
            _ArrayList.Insert(3, 1); // INSERE NA POSIÇÃO
            int idex = _ArrayList.IndexOf(1); // MOSTRA A POSIÇÃO
            int lastIdex = _ArrayList.LastIndexOf(1); //MOSTRA A ULTIMA POSIÇÃO

            _ArrayList.RemoveAt(3); // REMOVE POR POSIÇÃO

            _List.Sort(); //CRESCENTE
            _ArrayList.Reverse(); //DECRESCENTE
            _ArrayList.Clear(); // LIMPA A LISTA

            //LIST

            // ADICIONAR
            _List.Add(12);
            _List.Add(13);
            _List.Add(56);
            _List.Add(6);
            _List.Add(2);
            
            foreach (var item in _List)
            {
                Console.WriteLine(item);
            }

            _Dictionary.Add(1, "2");
            _Dictionary.Add(2, "22");
            _Dictionary.Add(3, "222");
            _Dictionary.Add(4, "3");
            _Dictionary.Add(5, "33");
            _Dictionary.Add(6, "333");
            _Dictionary.Add(7, "4");
        }
    }
}
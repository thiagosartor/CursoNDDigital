using System;
using System.Collections;
using System.Collections.Generic;

namespace UNIDADE_COMPLEMENTAR.Colecoes
{
    /// <summary>
    /// 4)	Faça 4 listas com diferentes coleções, List, ArrayList, IList, Dictionary. Adicione dados em cada uma delas e no final liste-os
    /// </summary>
    internal class Exercicio_04
    {
        public static List<string> Nomes = new List<string>() { "Thiago", "Giorgi", "Lucas M.", "Camila", "Greicy", "Mateus", "Felipe", "Rafael", "Antonio", "Raul", "Aprigio", "Luis", "Arnaldo", "Guilherme", "Lucas S." };
        public static ArrayList ArrayList = new ArrayList() { "Thiago", "Giorgi", "Lucas M.", "Camila", "Greicy", "Mateus", "Felipe", "Rafael", "Antonio", "Raul", "Aprigio", "Luis", "Arnaldo", "Guilherme", "Lucas S." };
        public static IList<string> IList = new List<string>() { "Thiago", "Giorgi", "Lucas M.", "Camila", "Greicy", "Mateus", "Felipe", "Rafael", "Antonio", "Raul", "Aprigio", "Luis", "Arnaldo", "Guilherme", "Lucas S." };
        public static Dictionary<int, string> Dictionary = new Dictionary<int, string>(){{1,"Thiago"}, {2,"Thiago"}, {3,"Thiago"}, {4,"Thiago"}};
 

        public static void Main1()
        {
            Console.ReadKey();
            foreach (var nome in Nomes)
            {
                Console.WriteLine(nome);
            }
        }
    }
}
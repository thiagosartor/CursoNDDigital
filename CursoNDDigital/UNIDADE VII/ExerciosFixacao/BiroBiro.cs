using System;

namespace UNIDADE_VII.ExerciosFixacao
{
    internal class BiroBiro
    {
        public static void Main()
        {
            string biro = "Biro";
            string[] array = new string[biro.Length];

            for (int j = 0; j < biro.Length; j++)
            {
                array[j] = biro[j].ToString();
            }

            for (int i = 0; i < 24; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine(array[0] + array[1] + array[3] + array[2]);
                }
                else if (i == 0)
                {
                }
                Console.WriteLine(array[i] + array[3]);
                //Console.WriteLine(array[i] + array[i + 1] + array[i + 3] + array[i + 2]);
                Console.ReadKey();
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIDADE_VIII.ExerciosComplementares
{
    class Exercicio_06
    {
        static void Main2(string[] args)
        {
            Random gerador = new Random();
            int num = gerador.Next(), contUm = 0;
            char[] numChar = num.ToString().ToCharArray();
            for (int i = 0; i < numChar.Length; i++)
            {
                if(numChar[i] == '1'){
                    contUm++;
                }
            }
            Console.WriteLine("Numero Aletorio: {0}", num);
            Console.WriteLine("Quantidade de '1': {0} vezes", contUm);
            Console.ReadKey();
        }
    }
}

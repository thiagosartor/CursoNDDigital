using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIDADE_VI.Exercícios_Complementares
{
    class Exercicio_04
    {
        static void Main1(string[] args)
        {
            int gremio = 0, inter = 0;
            Console.WriteLine("======== Greanal ==========");
            Random gerador = new Random();
            gremio = gerador.Next(0, 5);
            inter = gerador.Next(0, 5);
            if (inter > gremio)
            {
                Console.WriteLine("Inter venceu ! :)");
            } else if(inter < gremio) {
                Console.WriteLine("Gremio venceu ! :(");
            } else {
                Console.WriteLine("Empate !!");
            }
            Console.WriteLine("\n\n*** PLACAR *** \nGremio: {0} \nInter: {1}", gremio, inter);
            Console.ReadKey();
        }
    }
}

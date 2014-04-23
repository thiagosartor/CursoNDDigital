using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIDADE_II
{
    class Exercicio10
    {
        static void Main10(string[] args)
        {
            int idHomem1, idHomem2, idMulher1, idMulher2;
            int idhNovo, idhVelho, idmNova, idmVelha;
            Console.WriteLine(" ==== Mulheres =====");
            Console.Write("Digite a idade da primeira mulher : ");
            idMulher1 = int.Parse(Console.ReadLine());
            Console.Write("Digite a idade da segunda mulher : ");
            idMulher2 = int.Parse(Console.ReadLine());
            Console.WriteLine("====== Homens ======");
            Console.Write("Digite a idade do primeiro homem : ");
            idHomem1 = int.Parse(Console.ReadLine());
            Console.Write("Digite a idade do segundo homem : ");
            idHomem2 = int.Parse(Console.ReadLine());
            if (idMulher1 > idMulher2)
            {
                idmVelha = idMulher1;
                idmNova = idMulher2;
            }
            else
            {
                idmVelha = idMulher2;
                idmNova = idMulher1;
            }

            if (idHomem1 > idHomem2)
            {
                idhVelho = idHomem1;
                idhNovo = idHomem2;
            }
            else
            {
                idhVelho = idHomem2;
                idhNovo = idHomem1;
            }
            Console.WriteLine("====== Resultados ======");
            Console.WriteLine("Soma da idade  (homem mais velho com mulher mais nova) :  " + (idhVelho + idmNova));
            Console.WriteLine("Produto da idade  (homem mais novo com mulher mais velha) :  " + (idhNovo * idmVelha));
            Console.ReadKey();
        }
    }
}

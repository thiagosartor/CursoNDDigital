using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedindoAFebreIII.Exercícios_Fixação
{
    class Exe6
    {
        public static void Maini(string[] args)
        {
            int total_prestacoes;
            int quant_prest_pagas;
            double valor_pres;
            int prestacoes_sobrando;
            double total_pago;
            double total_devedor;

            Console.WriteLine("Digite o total de prestações: ");
            total_prestacoes = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantas prestações foram pagas: ");
            quant_prest_pagas = int.Parse(Console.ReadLine());
            Console.WriteLine("Valor das prestações: ");
            valor_pres = int.Parse(Console.ReadLine());
            prestacoes_sobrando = total_prestacoes - quant_prest_pagas;
            total_pago = quant_prest_pagas * valor_pres;
            Console.WriteLine("Total pago até agora: R$ "+total_pago);
            total_devedor = prestacoes_sobrando * valor_pres;
            Console.WriteLine("Devendo: R$ "+total_devedor);
            Console.ReadKey();


        }
    }
}

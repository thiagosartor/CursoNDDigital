using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedindoAFebreIII.MedindoAFebre
{
    class _10_Datas
    {
        static void Main(string[] args)
        {
            int i = 10;
            Console.WriteLine(i++);
            Console.WriteLine(++i);
            Console.WriteLine(i--);
            Console.WriteLine(--i);


            CultureInfo cw = new CultureInfo("pt-BR");
            string dia = null, mes = null, ano = null, data = null;
            DateTime date;

            Console.WriteLine("===== C# =====\n");
            lerValores(ref dia, ref mes, ref ano, ref data);
            date = DateTime.Parse(data);
            Console.WriteLine("O aniversário do C# foi no: " + cw.DateTimeFormat.GetDayName(date.DayOfWeek));
            Console.WriteLine("\n");

            Console.WriteLine("===== Aniversário =====\n");
            lerValores(ref dia, ref mes, ref ano, ref data);
            date = DateTime.Parse(data);
            Console.WriteLine("O seu aniversário na: " + cw.DateTimeFormat.GetDayName(date.DayOfWeek));
            Console.ReadKey();
        }

        private static void lerValores(ref string dia, ref string mes, ref string ano, ref string data)
        {
            Console.Write("Digite o dia: ");
            dia = Console.ReadLine();
            Console.Write("Digite o mes: ");
            mes = Console.ReadLine();
            Console.Write("Digite o ano: ");
            ano = Console.ReadLine();
            data = dia + "/" + mes + "/" + ano;
        }
    }
}

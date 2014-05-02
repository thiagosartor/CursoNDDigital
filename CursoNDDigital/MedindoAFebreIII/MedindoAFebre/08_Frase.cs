using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedindoAFebreIII.MedindoAFebre
{
    class _08_Frase
    {
        static void Main3(string[] args)
        {
            string frase, fraseIntercalada, fraseSubstituida;



            Console.Write("Digite  a frase: ");
            frase = Console.ReadLine();
            Console.WriteLine("\n=== Resultados ===\n");

            // Intercalar
            fraseIntercalada = frase.Replace("Curso", "CURSO");
            fraseIntercalada = fraseIntercalada.Replace("Academia", "ACADEMIA");
            fraseIntercalada = fraseIntercalada.Replace("Programador", "PROGRAMADOR");

            // Subtituir
            fraseSubstituida = frase.Replace("Curso", "Faculdade");
            fraseSubstituida = fraseSubstituida.Replace("Academia", "Campo");
            fraseSubstituida = fraseSubstituida.Replace("Programador", "Tester");

            //Apresntar
            Console.WriteLine("Maiuscula: " + frase.ToUpper() + "\n");
            Console.WriteLine("Minuscula: " + frase.ToLower() + "\n");
            Console.WriteLine("Intercalado: " + fraseIntercalada + "\n");
            Console.WriteLine("Frase substituída: " + fraseSubstituida + "\n");

            Console.ReadKey();
        }

    }
}

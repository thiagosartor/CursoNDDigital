using System;

namespace UNIDADE_VII.ExerciosFixacao
{
    internal class BiroBiro1_0
    {
        public static void Main1()
        {
            string biro = "biro";
            
            Console.Write("{0}{1}{2}{3} ",biro[0].ToString(), biro[1].ToString(), biro[2].ToString(), biro[3].ToString()); //biro
            Console.Write("{0}{1}{2}{3} ", biro[0].ToString(), biro[1].ToString(), biro[3].ToString(), biro[2].ToString()); //bior
            Console.Write("{0}{1}{2}{3} ", biro[0].ToString(), biro[2].ToString(), biro[1].ToString(), biro[3].ToString()); //brio
            Console.Write("{0}{1}{2}{3} ", biro[0].ToString(), biro[2].ToString(), biro[3].ToString(), biro[1].ToString()); //broi
            Console.Write("{0}{1}{2}{3} ", biro[0].ToString(), biro[3].ToString(), biro[1].ToString(), biro[2].ToString()); //boir
            Console.WriteLine("{0}{1}{2}{3}", biro[0].ToString(), biro[3].ToString(), biro[2].ToString(), biro[1].ToString()); //bori

            Console.Write("{0}{1}{2}{3} ", biro[1].ToString(), biro[0].ToString(), biro[2].ToString(), biro[3].ToString()); //ibro
            Console.Write("{0}{1}{2}{3} ", biro[1].ToString(), biro[0].ToString(), biro[3].ToString(), biro[2].ToString()); //ibor
            Console.Write("{0}{1}{2}{3} ", biro[1].ToString(), biro[2].ToString(), biro[0].ToString(), biro[3].ToString()); //irbo
            Console.Write("{0}{1}{2}{3} ", biro[1].ToString(), biro[2].ToString(), biro[3].ToString(), biro[0].ToString()); //irob
            Console.Write("{0}{1}{2}{3} ", biro[1].ToString(), biro[3].ToString(), biro[0].ToString(), biro[2].ToString()); //iobr
            Console.WriteLine("{0}{1}{2}{3}", biro[1].ToString(), biro[3].ToString(), biro[2].ToString(), biro[0].ToString()); //iorb

            Console.Write("{0}{1}{2}{3} ", biro[2].ToString(), biro[0].ToString(), biro[1].ToString(), biro[3].ToString()); //rbio
            Console.Write("{0}{1}{2}{3} ", biro[2].ToString(), biro[0].ToString(), biro[3].ToString(), biro[1].ToString()); //rboi
            Console.Write("{0}{1}{2}{3} ", biro[2].ToString(), biro[1].ToString(), biro[0].ToString(), biro[3].ToString()); //ribo
            Console.Write("{0}{1}{2}{3} ", biro[2].ToString(), biro[1].ToString(), biro[3].ToString(), biro[0].ToString()); //riob
            Console.Write("{0}{1}{2}{3} ", biro[2].ToString(), biro[3].ToString(), biro[1].ToString(), biro[2].ToString()); //roib
            Console.WriteLine("{0}{1}{2}{3}", biro[2].ToString(), biro[3].ToString(), biro[0].ToString(), biro[1].ToString()); //robi

            Console.Write("{0}{1}{2}{3} ", biro[3].ToString(), biro[0].ToString(), biro[1].ToString(), biro[2].ToString()); //obir
            Console.Write("{0}{1}{2}{3} ", biro[3].ToString(), biro[0].ToString(), biro[1].ToString(), biro[1].ToString()); //obri
            Console.Write("{0}{1}{2}{3} ", biro[3].ToString(), biro[1].ToString(), biro[0].ToString(), biro[2].ToString()); //oibr
            Console.Write("{0}{1}{2}{3} ", biro[3].ToString(), biro[1].ToString(), biro[2].ToString(), biro[0].ToString()); //oirb
            Console.Write("{0}{1}{2}{3} ", biro[3].ToString(), biro[2].ToString(), biro[0].ToString(), biro[1].ToString()); //orbi
            Console.Write("{0}{1}{2}{3}", biro[3].ToString(), biro[2].ToString(), biro[1].ToString(), biro[0].ToString()); //orib
            Console.ReadKey();
        }
    }
}
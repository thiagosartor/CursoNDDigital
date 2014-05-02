using System;

namespace MedindoAFebreIII.MedindoAFebre
{
    internal class Program
    {
        private static void Main777(string[] args)
        {
            // Random para definir velocidade
            Random gerador = new Random();
            // Metros que cada cachorro correu
            int cachorro1 = 0, cachorro2 = 0, cachorro3 = 0, cachorro4 = 0;
            // Verdade ou falso que cada cachorro venceu
            bool venceuC1 = false, venceuC2 = false, venceuC3 = false, venceuC4 = false;
            // Pista = 20m
            int pista = 20;
            // Podio
            int podio = 0;
            Console.WriteLine("***** Corrida de Cães ****\n\n\n");
            Console.WriteLine("===== Resultado ===== \n");

            //Repete até encontrar os 3 primeiros que alcançaram o valor >= 20 
            while (podio < 3)
            {
                correCachorro1(gerador, ref cachorro1, ref venceuC1, pista, ref podio);
                correCachorro2(gerador, ref cachorro2, ref venceuC2, pista, ref podio);
                correCachorro3(gerador, ref cachorro3, ref venceuC3, pista, ref podio);
                correCachorro4(gerador, ref cachorro4, ref venceuC4, pista, ref podio);
            }  
            Console.ReadKey(); // O valor de cada váriavel cachorro no final da execução do programa não interessa: 
                                // Importa é quais alcançaram primeiro o valor >= 20
        }

        private static void correCachorro4(Random gerador, ref int cachorro4, ref bool venceuC4, int pista, ref int podio)
        {
            int vel = gerador.Next(0, 3);
            if ((cachorro4 + vel) >= pista && !venceuC4 && podio < 3)
            {
                podio++;  // Informa para todos que há um vencedor
                Console.WriteLine(podio + "º Lugar:  Cachorro 4 ");
                venceuC4 = true;  // informa que foi o cachorro 4
                cachorro4 += vel;
            }
            else if (!venceuC4) 
            {
                cachorro4 += vel;
            }
        }

        private static void correCachorro3(Random gerador, ref int cachorro3, ref bool venceuC3, int pista, ref int podio)
        {
            int vel = gerador.Next(0, 3);
            if ((cachorro3 + vel) >= pista && !venceuC3 && podio < 3)
            {
                podio++;
                Console.WriteLine(podio + "º Lugar:  Cachorro 3 ");
                venceuC3 = true;
                cachorro3 += vel;
            }
            else if (!venceuC3)
            {
                cachorro3 += vel;
            }
        }

        private static void correCachorro2(Random gerador, ref int cachorro2, ref bool venceuC2, int pista, ref int podio)
        {
            int vel = gerador.Next(0, 3);
            if ((cachorro2 + vel) >= pista && !venceuC2 && podio < 3)
            {
                podio++;
                Console.WriteLine(podio + "º Lugar:  Cachorro 2");
                venceuC2 = true;
                cachorro2 += vel;
            }
            else if (!venceuC2)
            {
                cachorro2 += vel;
            }
        }

        private static void correCachorro1(Random gerador, ref int cachorro1, ref bool venceuC1, int pista, ref int podio)
        {
            int vel = gerador.Next(0, 3);
            if ((cachorro1 + vel) >= pista && !venceuC1 && podio < 3)
            {
                podio++;  // Informa que há um vencedor
                Console.WriteLine(podio + "º Lugar:  Cachorro 1");
                venceuC1 = true;
                cachorro1 += vel;
            }
            else if (!venceuC1)
            {
                cachorro1 += vel;
            }
        }
    }
}
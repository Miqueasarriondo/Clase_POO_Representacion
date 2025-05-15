using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace ConsoleApp2
{
    internal class Program
    {
        static Random azar = new Random();
        static void Main(string[] args)
        {
            string jugador1;
            string jugador2;
            int avance;
            int posicionJugador1 = 0;
            int posicionJugador2 = 0;

            Console.WriteLine("ingrese el nombre del jugador 1");
            jugador1 = Console.ReadLine();

            Console.WriteLine("ingrese el nombre del jugador 2");
            jugador2 = Console.ReadLine();

            int pieEscalera1 = azar.Next(1, 100);
            int cabeceraEscalera1 = azar.Next(pieEscalera1, 100);

            int pieEscalera2 = azar.Next(1, 100);
            int cabeceraEscalera2 = azar.Next(pieEscalera2, 100);

            int colaserpiente = azar.Next(1, 100);
            int cabezaserpiente = azar.Next(colaserpiente, 100);
            do
            {
                avance = azar.Next(1, 7);
                posicionJugador1 += avance;
                if (posicionJugador1 == cabezaserpiente)
                {
                    posicionJugador1 = colaserpiente;
                }
                if (posicionJugador1 == pieEscalera1)
                {
                    posicionJugador1 = cabeceraEscalera1;
                }
                if (posicionJugador1 == pieEscalera2)
                {
                    posicionJugador1 = cabeceraEscalera2;
                }
                Console.WriteLine("posicion del jugador1:" + posicionJugador1);
                avance = azar.Next(1, 7);
                posicionJugador2 += avance;
                if (posicionJugador2 == cabezaserpiente)
                {
                    posicionJugador2 = colaserpiente;
                }
                if (posicionJugador2 == pieEscalera1)
                {
                    posicionJugador2 = cabeceraEscalera1;
                }
                if (posicionJugador2 == pieEscalera2)
                {
                    posicionJugador2 = cabeceraEscalera2;
                }
                Console.WriteLine("posicion del jugador2:" + posicionJugador2);
            } while ((posicionJugador1 >= 100 ^ posicionJugador2 >= 100) == false);

            if ((posicionJugador1 >= 100 ^ posicionJugador2 >= 100) == true) 
            {
                if (posicionJugador1 >= 100)
                {
                    Console.WriteLine("gano el jugador1");
                }

                else
                {
                    Console.WriteLine("gano el jugador2");
                }
            }
            else
            {
                Console.WriteLine("no gano ningun jugador");
            }
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EPALM_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int _numJugadores = 6;

            while (true)
            {
                Console.Write("> Escribe cuantos jugadores hay (Entre 1 y 6): ");
                _numJugadores = Convert.ToInt32(Console.ReadLine());

                if (_numJugadores >= 1 && _numJugadores <= 6)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("\n| El valor no es el esperado. Repite el ingreso.");
                }
            }

            Juego _juego = new Juego(_numJugadores);

            while(true)
            {
                List<string> _partida = _juego.Ronda();

                for (int i = 0; i < _numJugadores; i++)
                {
                    Console.WriteLine($"| Jugador número {i + 1}:");
                    if (_partida[i] == "True")
                    {
                        Console.WriteLine("|> Ganó.");
                    }
                    else
                    {
                        Console.WriteLine("|> Perdió.");
                    }
                }

                if (_juego._activo)
                {
                    break;
                }

                Console.ReadKey();
            }
        }
    }
}

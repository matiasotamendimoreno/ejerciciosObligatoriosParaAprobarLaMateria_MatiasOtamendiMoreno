using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPALM_09
{
    internal class Program
    {
        static void Graficar(Sala sala)
        {
            char[] letras = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I' };
            int _espacio = 10;

            for (int columna = 0; columna < sala._lugares.GetLength(0); columna++)
            {
                for (int fila = sala._lugares.GetLength(1); fila > 0; fila--)
                {
                    Console.SetCursorPosition(_espacio + columna, 18 - fila);
                    Console.ForegroundColor = !sala._lugares[columna, fila - 1] ? ConsoleColor.Green : ConsoleColor.Red;

                    Console.Write($"{fila}{letras[columna]} ");
                }
                _espacio = _espacio + 3;
            }
        }

        static string Evaluar(List<Espectador> _espectadores, Cine _cine, Pelicula _pelicula, Sala sala)
        {
            Random rnd = new Random();

            for (int i = 0; i <_espectadores.Count; i++)
            {
                if (_cine.ComprobarEspectador(_pelicula, _espectadores[i]))
                {
                    while (true)
                    {
                        int _columna = rnd.Next(0, 9);
                        int _fila = rnd.Next(0, 8);

                        if (!sala._lugares[_columna, _fila])
                        {
                            sala._lugares[_columna, _fila] = true;
                            break;
                        }
                        else
                        {
                            int contador = 0;

                            for (int j = 0; j < sala._lugares.GetLength(0); j++)
                            {
                                for (int l = 0; l < sala._lugares.GetLength(1); l++)
                                {
                                    if (!sala._lugares[j, l])
                                    {
                                        contador++;
                                    }
                                }
                            }

                            if (contador == 0)
                            {
                                return "| Asientos agotados.";
                            }
                        }
                    }
                }
            }
            return "| Asientos libres.";
        }

        static void Main(string[] args)
        {
            List<Espectador> _espectadores = new List<Espectador>();
            Random _rnd = new Random();

            Cine _cine = new Cine("Prometeo Cines", 90);
            Pelicula _pelicula = new Pelicula("Deadpool 3", 120, 16, "Shawn Levy");
            Sala _sala = new Sala();
            string _mensaje = "";

            for (int i = 0; i < 120; i++)
            {
                _espectadores.Add(new Espectador("Floppa", _rnd.Next(1, 81), _rnd.Next(1, 201)));
            }

            for (int i = 0; 1 < 2; i++)
            {
                Graficar(_sala);
                Console.SetCursorPosition(10, 5);
                _mensaje = Evaluar(_espectadores, _cine, _pelicula, _sala);
                if (i == 0)
                {
                    Console.WriteLine(_mensaje);
                }
                Console.ReadKey(true);
                Console.Clear();
            }
        }
    }
}

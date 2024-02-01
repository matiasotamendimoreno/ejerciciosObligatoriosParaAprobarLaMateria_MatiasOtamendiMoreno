using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPALM_11
{
    internal class Program
    {
        static bool Gano(Partido _par, Humano _hum)
        {
            return _hum.Prediccion == _par.Resultado;
        }

        static void Main(string[] args)
        {
            List<Humano> _jugadores = new List<Humano>();
            int _pozo = 0;
            int _ultimoPozo = 0;

            _jugadores.Add(new Humano("Floppa"));
            _jugadores.Add(new Humano("Bingus"));
            _jugadores.Add(new Humano("Maxwel"));
            _jugadores.Add(new Humano("Falopa"));
            Random _rnd = new Random();

            Console.Write("> ¿Cuantas rondas quieres? ");
            int _rondas = Convert.ToInt32(Console.ReadLine());

            for (int j = 0; j < _rondas; j++)
            {
                Console.Clear();
                Partido _partido = new Partido();

                for (int i = 0; i < _jugadores.Count(); i++)
                {
                    if (_jugadores[i]._dinero > 0)
                    {
                        _jugadores[i].Apostar(_rnd);
                    }
                }

                bool _yaGanaron = false;
                _ultimoPozo = _pozo;

                for (int i = 0; i < _jugadores.Count(); i++)
                {
                    Console.Write("\n " + _jugadores[i].MostrarTodo());
                    if (Gano(_partido, _jugadores[i]) && !_yaGanaron)
                    {
                        _jugadores[i]._dinero += _pozo;
                        _jugadores[i].Ganar();
                        _pozo = 0;

                        _yaGanaron = true;
                        Console.Write("| ¡Ganador!");
                    }
                    else
                    {
                        _pozo += _jugadores[i]._apuesta;
                    }
                    _jugadores[i]._apuesta = 0;
                }

                Console.WriteLine("\n " + $"| Resultado del partido: {_partido.Resultado}, pozo {(_yaGanaron ? _ultimoPozo : _pozo)}.");
                Console.ReadKey();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EPALM_12
{
    internal class Juego
    {
        public List<Jugador> _jugadores = new List<Jugador>();
        public Revolver _revolver;
        Random _rnd = new Random();
        public bool _activo;

        public Juego(int _numJugadores)
        {
            _revolver = new Revolver(_rnd);
            _jugadores.Add(new Jugador(1, "Bingus", true));

            for (int i = 0; i < _numJugadores; i++)
            {
                _jugadores.Add(new Jugador(i, "Bingus", true));
            }
        }

        public void FinJuego()
        {
            _activo = true;
        }

        public List<string> Ronda()
        {
            List<string> _resultados = new List<string>();
            for (int i = 0; i < _jugadores.Count(); i++)
            {
                string _resultado = "";

                if (_jugadores[i]._schrodinger)
                {
                    _jugadores[i].Dispararse(_revolver);
                }
                else
                {
                    FinJuego();
                }

                _resultado = Convert.ToString(_jugadores[i]._schrodinger);

                _resultados.Add(_resultado);
            }

            return _resultados;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPALM_10
{
    internal class Baraja
    {
        string[] _palos =
        {
            "oro",
            "espada",
            "basto",
            "copa"
        };

        public List<string> _cartas = new List<string>();
        int _pos = 0;

        public Baraja() 
        {
            for (int j = 0; j < 4; j++)
            {
                for (int i = 1; i < 13; i++)
                {
                    if (i != 8 && i != 9)
                    {
                        _cartas.Add($"{i} de {_palos[j]}");
                    }
                }
            }
        }

        public void Barajar(Random rnd)
        {
            string _puente;
            int _indiceR;

            for (int i = _pos; i < _cartas.Count(); i++)
            {
                _indiceR = rnd.Next(_pos, _cartas.Count());

                _puente = _cartas[_indiceR];
                _cartas[_indiceR] = _cartas[i];
                _cartas[i] = _puente;
            }
        }

        public string SiguienteCarta()
        {
            if (_pos < _cartas.Count())
            {
                _pos++;

                return _cartas[_pos - 1];
            }
            else
            {
                return "| No hay más cartas";
            }
        }

        public string CartasDisponibles()
        {
            return $"| Quedan {_cartas.Count() - _pos} cartas.";
        }

        public List<string> MostrarBaraja()
        {
            List<string> _cartasBaraja = new List<string>();

            for (int i = _pos; i < _cartas.Count(); i++)
            {
                _cartasBaraja.Add(_cartas[i]);
            }

            return _cartasBaraja;
        }

        public List<string> DarCartas(int _cantidadDeCartas)
        {
            List<string> _devolverCartasPedidas = new List<string>();
            int _posMasCantidad = _pos + _cantidadDeCartas;

            if (_posMasCantidad <= _cartas.Count())
            {
                for (int i = _pos; i < _posMasCantidad; i++)
                {
                    _devolverCartasPedidas.Add(_cartas[i]);
                    _pos++;
                }
                return _devolverCartasPedidas;
            }
            else
            {
                _devolverCartasPedidas.Add("| No hay más cartas.");
                return _devolverCartasPedidas;
            }
        }

        public List<string> CartasDelMonton()
        {
            List<string> _cartasDelMonton = new List<string>();

            if (_pos != 0)
            {
                for (int i = 0; i < _pos; i++)
                   {
                    _cartasDelMonton.Add(_cartas[i]);
                }
            }
            else
            {
                _cartasDelMonton.Add("| No han salido cartas aún.");
            }

            return _cartasDelMonton;
        }
    }
}

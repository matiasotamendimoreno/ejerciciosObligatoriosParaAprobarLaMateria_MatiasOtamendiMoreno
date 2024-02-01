using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPALM_11
{
    internal class Humano
    {
        public int _dinero;
        public int _apuesta;
        string _nombre;
        string _prediccion;
        int _victoria;

        public string Nombre
        {
            get { return _nombre; }
        }
        public string Prediccion
        {
            get { return _prediccion; }
        }
        public int Victoria
        {
            get { return _victoria; }
        }
        public Humano(string _nombre)
        {
            this._nombre = _nombre;
            _dinero = 15;
        }
        
        public void Apostar(Random _rnd)
        {
            _dinero = _dinero - 1;
            _apuesta = _apuesta + 1;

            _prediccion = $"{_rnd.Next(0, 4)} - {_rnd.Next(0, 4)}";
        }

        public void Ganar()
        {
            _victoria++;
        }

        public string MostrarTodo()
        {
            return $"| {_nombre}, dinero: {_dinero}, apuesta: {_apuesta}, victorias: {_victoria}, predicción: {_prediccion}";
        }
    }
}

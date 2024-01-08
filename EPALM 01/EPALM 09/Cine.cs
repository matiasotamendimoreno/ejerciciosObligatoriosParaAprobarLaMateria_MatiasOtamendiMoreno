using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPALM_09
{
    internal class Cine
    {
        public string _tituloPelicula;
        public int _precio;
        
        public Cine() { }
        public Cine(string _titulo, int _precio)
        {
            this._tituloPelicula = _titulo;
            this._precio = _precio;
        }

        public bool ComprobarEspectador(Pelicula _Pelicula, Espectador _Espectador)
        {
            if (_Pelicula._edadMinima < _Espectador._edad && _precio < _Espectador._dinero)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

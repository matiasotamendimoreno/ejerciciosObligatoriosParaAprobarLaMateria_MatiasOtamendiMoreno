using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPALM_09
{
    internal class Pelicula
    {
        public string _titulo;
        public int _duracion;
        public int _edadMinima;
        public string _director;

        public Pelicula() { }
        public Pelicula(string _titulo, int _duracion, int _edadMinima, string _director)
        {
            this._titulo = _titulo;
            this._duracion = _duracion;
            this._edadMinima = _edadMinima;
            this._director = _director;
        }
    }
}

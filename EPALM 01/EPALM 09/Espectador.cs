using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPALM_09
{
    internal class Espectador
    {
        public string _nombre;
        public int _edad;
        public int _dinero;

        public Espectador() { }
        public Espectador(string _nombre, int _edad, int _dinero)
        {
            this._nombre = _nombre;
            this._edad = _edad;
            this._dinero = _dinero;
        }
    }
}

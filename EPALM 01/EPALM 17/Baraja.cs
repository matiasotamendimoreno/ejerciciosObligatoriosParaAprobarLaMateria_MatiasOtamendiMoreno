using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPALM_17
{
    internal abstract class Baraja
    {
        public int _pos = 0;

        public Baraja(int _pos)
        {
            this._pos = _pos;
        }

        public abstract void crearBaraja();
        public abstract void mostrarBaraja();
        
        public int Posicion
        {
            get { return _pos; }
        }
    }
}

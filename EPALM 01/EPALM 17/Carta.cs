using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPALM_17
{
    internal class Carta<T>
    {
        T _palo;

        public Carta(T _palo)
        {
            this._palo = _palo;
        }

        public string MostrarPalo()
        {
            return $"| {_palo.ToString()}";
        }
    }
}

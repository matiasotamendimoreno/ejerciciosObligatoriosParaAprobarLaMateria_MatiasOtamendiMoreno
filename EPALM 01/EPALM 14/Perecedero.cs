using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace EPALM_14
{
    internal class Perecedero : Productos
    {
        public int _diasACaducar;

        public Perecedero(string _nombre, int _precio, int _diasACaducar) : base(_nombre, _precio)
        {
            this._diasACaducar = _diasACaducar;
        }

        public int DiasACaducar
        {
            get
            {
                return _diasACaducar;
            }
            set
            {
                _diasACaducar = value;
            }
        }

        public int Calcular(int _cantidadDeProductos)
        {
            if (DiasACaducar == 1)
            {
                Precio = (Precio * _cantidadDeProductos) / 4;
            }
            else if (DiasACaducar == 2)
            {
                Precio = (Precio * _cantidadDeProductos) / 3;
            }
            else
            {
                Precio = (Precio * _cantidadDeProductos) / 2;
            }

            return Precio;
        }
    }
}

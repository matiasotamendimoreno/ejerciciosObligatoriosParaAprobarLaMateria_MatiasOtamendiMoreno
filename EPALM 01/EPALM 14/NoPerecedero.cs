using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPALM_14
{
    internal class NoPerecedero : Productos
    {
        public string _tipo;

        public NoPerecedero(string _nombre, int _precio, string _tipo) : base(_nombre, _precio)
        {
            this._tipo = _tipo;
        }

        public string Tipo
        {
            get
            {
                return _tipo;
            }
            set
            {
                _tipo = value;
            }
        }

        public override string ToString()
        {
            return _tipo;
        }

        public int Calcular(int _cantidadDeProductos)
        {
            Precio = Precio * _cantidadDeProductos;
            return Precio;
        }
    }
}

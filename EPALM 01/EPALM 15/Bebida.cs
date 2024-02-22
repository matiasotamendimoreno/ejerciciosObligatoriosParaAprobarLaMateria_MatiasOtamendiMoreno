using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPALM_15
{
    internal class Bebida
    {
        public int _id;
        public int _cantidadDeLitros;
        public int _precio;
        public string _marca;

        public Bebida(int _id, int _cantidadDeLitros, int _precio, string _marca)
        {
            this._id = _id;
            this._cantidadDeLitros = _cantidadDeLitros;
            this._precio = _precio;
            this._marca = _marca;
        }

        public int Precio
        {
            get
            {
                return _precio;
            }
            set
            {
                _precio = value;
            }
        }

        public virtual string Mostrar()
        {
            return $"| ID: {_id}, litros: {_cantidadDeLitros}, precio: {_precio} y marca: {_marca}";
        }
    }
}

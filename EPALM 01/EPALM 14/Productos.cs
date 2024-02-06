using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPALM_14
{
    internal class Productos
    {
        public string _nombre;
        public int _precio;

        public Productos(string _nombre, int _precio)
        {
            this._nombre = _nombre;
            this._precio = _precio;
        }

        public string Nombre
        {
            get 
            { 
                return _nombre; 
            }
            set 
            { 
                _nombre = value; 
            }
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

        public int Calcular(int _cantidadDeProductos)
        {
            Precio = Precio * _cantidadDeProductos;
            return Precio;
        }
    }
}

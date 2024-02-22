using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPALM_15
{
    internal class Azucaradas : Bebida
    {
        public int _cantidadDeAzucar;
        public bool _promocion;
        
        public Azucaradas(int _id, int _cantidadDeLitros, int _precio, string _marca, int _cantidadDeAzucar, bool _promocion) : base(_id, _cantidadDeLitros, _precio, _marca)
        {
            this._cantidadDeAzucar = _cantidadDeAzucar;
            this._promocion = _promocion;
        }

        public string Promocion()
        {
            if (_promocion)
            {
                return $"| El precio es de: {(_precio / 100) * 90}.";
            }
            return $"| El precio es de: {_precio}.";
        }

        public string MostrarAzucaradas()
        {
            if (_promocion)
            {
                return $"| El porcentaje en {_marca} de azucar es del {_cantidadDeAzucar} y su promoción está habilitada.";
            }

            return $"| El porcentaje en {_marca} de azucar es del {_cantidadDeAzucar} y su promoción está deshabilitada.";
        }
    }
}

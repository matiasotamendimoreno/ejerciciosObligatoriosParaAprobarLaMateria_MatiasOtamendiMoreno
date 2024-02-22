using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EPALM_15
{
    internal class Mineral : Bebida
    {
        public string _origen;

        public Mineral(int _id, int _cantidadDeLitros, int _precio, string _marca, string _origen) : base(_id, _cantidadDeLitros, _precio, _marca)
        {
            this._origen = _origen;
        }

        public string MineralOrigien()
        {
            return $"| El origen del agua mineral es de {_origen}. La cantidad de litros es de {_cantidadDeLitros}, su precio es de {_precio}, su ID es {_id} y su marca es {_marca}";
        }
    }
}

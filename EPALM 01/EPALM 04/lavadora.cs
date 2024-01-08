using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPALM_04
{
    internal class lavadora : Electrodomestico
    {
        float carga = 5f;
        public float getCarga
        {
            get 
            { 
                return carga; 
            }
        }

        public lavadora(): base()
        {
        }
        public lavadora(int precio, float peso): base(precio, peso)
        {

        }
        public lavadora(int precio, string color, char consumoEnergetico, float peso, float carga): base(precio, color, consumoEnergetico, peso)
        {
            this.carga = carga;
        }

        public override void precioFinal()
        {
            base.precioFinal();

            if(carga > 30)
            {
                precioBase += 50;
            }
        }
    }
}

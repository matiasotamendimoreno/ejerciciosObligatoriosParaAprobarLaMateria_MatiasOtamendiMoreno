using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPALM_04
{
    internal class television : Electrodomestico
    {
        public float resolucion = 20f;
        public bool sintonizadorTDT = false;

        public television(): base()
        { 
        }
        public television(int precio, float peso): base(precio, peso)
        {
        }
        public television(int precio, string color, char consumoEnergetico, float peso, float resolucion, bool sintonizadorTDT) : base(precio, color, consumoEnergetico, peso)
        {
            this.resolucion = resolucion;
            this.sintonizadorTDT = sintonizadorTDT;
        }
        public override void precioFinal()
        {
            base.precioFinal();

            if (resolucion > 40)
            {
                int porcentaje = precioBase / 100;
                porcentaje = porcentaje * 30;
                precioBase = porcentaje;
            }
            if (sintonizadorTDT == true)
            {
                precioBase += 50;
            }
        }
    }
}

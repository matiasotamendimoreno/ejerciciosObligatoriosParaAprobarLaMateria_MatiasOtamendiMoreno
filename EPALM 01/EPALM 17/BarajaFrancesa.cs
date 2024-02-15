using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPALM_17
{
    internal class BarajaFrancesa : Baraja
    {
        List<Carta<PalosBarFrancesa>> _baraja = new List<Carta<PalosBarFrancesa>>();

        public override void crearBaraja()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 1; j < 13; j++)
                {

                }
            }
        }

        public override void mostrarBaraja()
        {
            string _nombreTemp;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 1; j < 12; j++)
                {
                    switch (j)
                    {
                        case 1:
                            _nombreTemp = "";
                            break;
                        case 10:
                            _nombreTemp = "";
                            break;
                        case 11:
                            _nombreTemp = "";
                            break;
                        case 12:
                            _nombreTemp = "";
                            break;
                        default:
                            _nombreTemp = j.ToString();
                            break;
                    }
                }
            }
        }
    }
}

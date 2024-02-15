using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPALM_17
{
    internal class BarajaEspañola : Baraja
    {
        public bool _truco;

        List<Carta<PalosBarEspanola>> _baraja = new List<Carta<PalosBarEspanola>>();

        public BarajaEspañola(bool _truco) : base(_pos)
        {
            this._truco = _truco;
        }
        public override void crearBaraja()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 1; j < 12; j++)
                {
                    if (!((j == 8 || j == 9) && _truco == true))
                    {
                        _baraja.Add(new Carta<PalosBarEspanola>((PalosBarEspanola)i));
                    }
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
                            _nombreTemp = "as";
                            break;
                        case 10:
                            _nombreTemp = "sota";
                            break;
                        case 11:
                            _nombreTemp = "caballo";
                            break;
                        case 12:
                            _nombreTemp = "rey";
                            break;
                        default:
                            _nombreTemp = j.ToString();
                            break;
                    }
                    if (!((j == 8 || j == 9) && _truco == true))
                    {
                        Console.WriteLine($"| {_nombreTemp} de {Convert.ToString((PalosBarEspanola)i)}");
                    }
                }
            }
        }
    }
}

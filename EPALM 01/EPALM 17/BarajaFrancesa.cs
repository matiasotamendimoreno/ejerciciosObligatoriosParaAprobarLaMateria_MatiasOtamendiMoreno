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

        public BarajaFrancesa (int _pos) : base(_pos)
        {
            crearBaraja();
        }

        public override void crearBaraja()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 1; j < 13; j++)
                {
                    _baraja.Add(new Carta<PalosBarFrancesa>((PalosBarFrancesa)i));
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
                        case 12:
                            _nombreTemp = "caballo";
                            break;
                        case 13:
                            _nombreTemp = "rey";
                            break;
                        default:
                            _nombreTemp = j.ToString();
                            break;
                    }
                    Console.WriteLine($"| {_nombreTemp} de {Convert.ToString((PalosBarFrancesa)i)}");
                }
            }
        }

        public bool cartaRoja(Carta<PalosBarFrancesa> c)
        {
            if (c.MostrarPalo() == "DIAMANTE" || c.MostrarPalo() == "DIAMANTE")
            {
                return true;
            }
            return false;
        }
        public bool cartaNegra(Carta<PalosBarFrancesa> c)
        {
            if (c.MostrarPalo() == "TREBOLES" || c.MostrarPalo() == "PICAS")
            {
                return true;
            }
            return false;
        }
    }
}

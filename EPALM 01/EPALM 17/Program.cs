using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPALM_17
{
    enum PalosBarEspanola { OROS, COPAS, ESPADAS, BASTOS}
    enum PalosBarFrancesa { DIAMANTES, PICAS, CORAZONES, TREBOLES }

    internal class Program
    {
        static void Main(string[] args)
        {
            BarajaEspañola _espanolaTruco = new BarajaEspañola(0, true);
            BarajaEspañola _espanolaEnvido = new BarajaEspañola(0, false);

            BarajaFrancesa _segunda = new BarajaFrancesa(0);

            _espanolaTruco.crearBaraja();
            _espanolaEnvido.crearBaraja();
            _segunda.crearBaraja();

            Console.WriteLine("| Baraja Española sin 8 y 9:\n");
            _espanolaTruco.mostrarBaraja();

            Console.WriteLine("\n\n\n| Baraja Española por defecto:\n");
            _espanolaEnvido.mostrarBaraja();

            Console.WriteLine("\n\n\n| Baraja Francesa:\n");
            _segunda.mostrarBaraja();

            Console.ReadKey();
        }
    }
}

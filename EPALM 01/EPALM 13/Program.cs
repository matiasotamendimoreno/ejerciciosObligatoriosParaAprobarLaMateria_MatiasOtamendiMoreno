using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPALM_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random _rnd = new Random();

            List<Comercial> _empleadoComercialLista = new List<Comercial>();
            List<Repartidor> _empleadoDeliveryLista = new List<Repartidor>();

            for (int i = 0; i < 6; i++)
            {
                _empleadoComercialLista.Add(new Comercial("Floppa", _rnd.Next(18, 46), _rnd.Next(500, 1001), _rnd.Next(150, 301)));
                _empleadoDeliveryLista.Add(new Repartidor("Maxwel", _rnd.Next(18, 46), _rnd.Next(500, 1001), $"zona {_rnd.Next(1, 4)}"));

                _empleadoComercialLista[i].Plus();
                _empleadoDeliveryLista[i].Plus();
            }

            Console.WriteLine("| Esta es la lista de comerciales:");

            for (int i = 0; i < _empleadoComercialLista.Count(); i++)
            {
                Console.Write($"| Recibe el PLUS (True/False): {_empleadoComercialLista[i].Plus()}");
                Console.Write($" / {_empleadoComercialLista[i].Nombre}");
                Console.Write($" / {_empleadoComercialLista[i].Edad}");
                Console.Write($" / {_empleadoComercialLista[i].Salario}");
                Console.WriteLine($" / {_empleadoComercialLista[i].Comision}");
            }

            Console.WriteLine("- - -\n| Esta es la lista de repartidores:");

            for (int i = 0; i < _empleadoDeliveryLista.Count(); i++)
            {
                Console.Write($"| Recibe el PLUS (True/False): {_empleadoDeliveryLista[i].Plus()}");
                Console.Write($" / {_empleadoDeliveryLista[i].Nombre}");
                Console.Write($" / {_empleadoDeliveryLista[i].Edad}");
                Console.Write($" / {_empleadoDeliveryLista[i].Salario}");
                Console.Write($" / {_empleadoDeliveryLista[i].Zona}");
                Console.WriteLine($" / {_empleadoDeliveryLista[i].PLUS}");
            }

            Console.ReadKey();
        }
    }
}

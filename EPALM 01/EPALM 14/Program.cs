using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPALM_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random _rnd = new Random();
            List<NoPerecedero> _noPerecederos = new List<NoPerecedero>();
            List<Perecedero> _perecederos = new List<Perecedero>();

            _noPerecederos.Add(new NoPerecedero("Martillo", _rnd.Next(100, 301), "Herramienta"));
            _noPerecederos.Add(new NoPerecedero("Pala", _rnd.Next(100, 301), "Herramienta"));
            _noPerecederos.Add(new NoPerecedero("AK 47", _rnd.Next(100, 301), "Arma"));
            _noPerecederos.Add(new NoPerecedero("Optimus Prime", _rnd.Next(100, 301), "Jueguete"));
            _noPerecederos.Add(new NoPerecedero("Collar de Perlas", _rnd.Next(100, 301), "Bisuterí"));

            _perecederos.Add(new Perecedero("Pizza", _rnd.Next(50, 101), _rnd.Next(1, 4)));
            _perecederos.Add(new Perecedero("Floppa Fruta", _rnd.Next(50, 101), _rnd.Next(1, 4)));
            _perecederos.Add(new Perecedero("Longaniza", _rnd.Next(50, 101), _rnd.Next(1, 4)));
            _perecederos.Add(new Perecedero("Falopa", _rnd.Next(50, 101), _rnd.Next(1, 4)));
            _perecederos.Add(new Perecedero("Pollo", _rnd.Next(50, 101), _rnd.Next(1, 4)));


            Console.WriteLine("| Lista de productos NO PERECEDEROS:");
            for (int i = 0; i < _noPerecederos.Count; i++)
            {
                Console.Write($"| Producto: {_noPerecederos[i].Nombre}");
                Console.Write($" / Precio: {_noPerecederos[i].Precio}");
                Console.WriteLine($" / Tipo de producto: {_noPerecederos[i].Tipo}");
            }

            Console.WriteLine("} - - - - - - - - - - - - - - - - - - - - - - - - -\n| Lista de productos PERECEDEROS:");
            for (int i = 0; i < _perecederos.Count; i++)
            {
                Console.Write($"| Producto: {_perecederos[i].Nombre}");
                Console.Write($" / Precio: {_perecederos[i].Precio}");
                Console.WriteLine($" / Dias a caducar: {_perecederos[i].DiasACaducar}");
            }

            Console.ReadKey();
        }
    }
}

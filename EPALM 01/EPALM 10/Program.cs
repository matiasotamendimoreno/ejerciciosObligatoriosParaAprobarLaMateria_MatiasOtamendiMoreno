using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace EPALM_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Baraja _barajando = new Baraja();
            Random _rnd = new Random();

            Console.WriteLine("| ¿Qué vas a hacer?" +
                "\n| 1. Barajar las cartas." +
                "\n| 2. Pedir la siguiente carta." +
                "\n| 3. Ver las cartas disponibles." +
                "\n| 4. Ver la baraja de cartas." +
                "\n| 5. Dar las cartas." +
                "\n| 6. Ver si ya han salido cartas.\n");

            Console.Write("> Input: ");
            while (true)
            {
                ConsoleKeyInfo _inputCKI = Console.ReadKey();


                if (_inputCKI.Key == ConsoleKey.D1 || _inputCKI.Key == ConsoleKey.NumPad1)
                {
                    Console.WriteLine("| Barajando.");
                    Console.WriteLine("| .");
                    Console.WriteLine("| .");
                    Console.WriteLine("| .");

                    _barajando.Barajar(_rnd);

                    Console.WriteLine("| Cartas barajadas.");
                }
                if (_inputCKI.Key == ConsoleKey.D2 || _inputCKI.Key == ConsoleKey.NumPad2)
                {
                    Console.WriteLine($"| La siguiente carta es: {_barajando.SiguienteCarta()}.");
                }
                if (_inputCKI.Key == ConsoleKey.D3 || _inputCKI.Key == ConsoleKey.NumPad3)
                {
                    Console.WriteLine($"| Las cartas disponibles son: {_barajando.CartasDisponibles()}.");
                }
                if (_inputCKI.Key == ConsoleKey.D4 || _inputCKI.Key == ConsoleKey.NumPad4)
                {
                    Console.WriteLine("| La baraja de cartas es: ");

                    List<string> _barajaDeCartas = new List<string>();
                    _barajaDeCartas = _barajando.MostrarBaraja();

                    for (int i = 0; i < _barajaDeCartas.Count(); i++)
                    {
                        Console.WriteLine($"| {_barajaDeCartas[i]}");
                    }
                }
                if (_inputCKI.Key == ConsoleKey.D5 || _inputCKI.Key == ConsoleKey.NumPad5)
                {
                    Console.Write("> ¿Cuantas cartas quieres?");
                    int _cantidad = Convert.ToInt32(Console.ReadLine());

                    List<string> _cartasADar = _barajando.DarCartas(_cantidad);

                    for (int i = 0; i < _cartasADar.Count(); i++)
                    {
                        Console.WriteLine($"| {_cartasADar[i]}");
                    }
                }
                if (_inputCKI.Key == ConsoleKey.D6 || _inputCKI.Key == ConsoleKey.NumPad6)
                {
                    List<string> _monton = _barajando.CartasDelMonton();

                    for (int i = 0; i < _monton.Count(); i++)
                    {
                        Console.WriteLine($"| {_monton[i]}");
                    }
                }
            }
        }
    }
}

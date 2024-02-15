using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPALM_16
{
    internal class Program
    {
        static string[] recolectarContactos(string _nombreTemp = "", string _numeroTemp = "", bool _telefono = true)
        {
            Console.Write("> Ingrese el NOMBRE del contacto: ");
            _nombreTemp = Console.ReadLine();

            if (_telefono)
            {
                Console.Write("> Ingrese el NÚMERO de teléfono: ");
                _numeroTemp = Console.ReadLine();
            }

            string[] _devolver = { _nombreTemp, _numeroTemp };

            return _devolver;
        }

        static void Main(string[] args)
        {
            Contacto _contacto = new Contacto("", "");
            string[] _datos = new string[2];
            int _numeroMenu;

            Console.Write("> Ingrese cuantos espacios habrá en la agenda (Por defecto 10): ");
            int _nuevoMaximo = Convert.ToInt32(Console.ReadLine());
            Agenda _agenda = _nuevoMaximo == 0 ? new Agenda() : new Agenda(_nuevoMaximo);

            while (true)
            {
                Console.WriteLine("| 1. Añadir un nuevo contacto.\n| 2. Ver agenda.\n| 3. Buscar contacto. \n| 4. Eliminar un contacto. \n| 5. Ver cuanto espacio queda.\n| 6. Ver si un contacto existe.\n| 7. Comrpobar si la agenda está llena.");
                Console.Write("> ");
                _numeroMenu = Convert.ToInt32(Console.ReadLine());

                if (_numeroMenu == 1)
                {
                    _datos = recolectarContactos();
                    _contacto.Nombre = _datos[0];
                    _contacto.NumeroDeTelefono = _datos[1];
                    Console.WriteLine(_agenda.anadirContactos(_contacto));
                }
                if (_numeroMenu == 2)
                {
                    string[] _caso2 = _agenda.listarContactos();

                    for (int i = 0; i < _caso2.Count(); i++)
                    {
                        Console.WriteLine(_caso2[i]);
                    }
                }
                if (_numeroMenu == 3)
                {
                    Console.Write("> Ingrese el NOMBRE del contacto: ");
                    string _caso3 = Console.ReadLine();

                    Console.WriteLine(_agenda.buscarContacto(_caso3).MostrarContactos());
                }
                if (_numeroMenu == 4)
                {
                    _datos = recolectarContactos();
                    _contacto.Nombre = _datos[0];
                    _contacto.NumeroDeTelefono = _datos[1];

                    Console.WriteLine(_agenda.eliminarContactos(_contacto));
                }
                if (_numeroMenu == 5)
                {
                    Console.WriteLine(_agenda.huecosLibres());
                }
                if (_numeroMenu == 6)
                {
                    _datos = recolectarContactos();
                    _contacto.Nombre = _datos[0];
                    _contacto.NumeroDeTelefono = _datos[1];

                    Console.WriteLine(_agenda.existeContacto(_contacto));
                }
                if (_numeroMenu == 7)
                {
                    Console.WriteLine(_agenda.huecosLibres());
                }

                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}

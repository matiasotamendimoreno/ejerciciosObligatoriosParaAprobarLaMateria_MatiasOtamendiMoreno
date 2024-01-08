using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPALM_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Libro libro1 = new Libro(false, "Cronicas de una Muerte Anunciada", "Floppa", 234);
            Libro libro2 = new Libro(true, "Muerte al Mal", "Bingus", 987);

            Console.WriteLine(libro1.MostrarTodo());
            Console.WriteLine(libro2.MostrarTodo());

            Console.WriteLine($"| {(libro1.NumeroDePaginas > libro2.NumeroDePaginas ? $"{libro1.Titulo}" : $"{libro2.Titulo}")} tiene más numero de páginas.");

            while (true)
            {
                Console.ReadKey();
            }
        }
    }
}

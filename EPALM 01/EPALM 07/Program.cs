using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPALM_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Raices ecuacion = new Raices(4, 8, -12);

            Console.WriteLine(ecuacion.calcular());
            Console.ReadKey();
        }
    }
}

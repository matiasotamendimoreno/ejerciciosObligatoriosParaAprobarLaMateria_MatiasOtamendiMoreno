using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EPALM_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Electrodomestico[] arrayElectrodomestico = new Electrodomestico[10];

            arrayElectrodomestico[0] = new Electrodomestico(5000, "blanco", 'a', 32.32f);
            arrayElectrodomestico[1] = new Electrodomestico(12000, "rojo", 'f', 64.00f);
            arrayElectrodomestico[2] = new Electrodomestico(2000, "floppa", 'b', 90.50f);
            arrayElectrodomestico[3] = new Electrodomestico(100, "verde", 'f', 30.20f);
            arrayElectrodomestico[4] = new lavadora(9000, "blanco", 'c', 40.00f, 8.0f);
            arrayElectrodomestico[5] = new lavadora(12000, "appolf", 'f', 50.00f, 8.0f);
            arrayElectrodomestico[6] = new lavadora(1000, "amarillo", 'd', 60.00f, 8.0f);
            arrayElectrodomestico[7] = new lavadora(5000, "negro", 'f', 70.00f, 8.0f);
            arrayElectrodomestico[8] = new television(96969, "bingus", 'e', 50.60f, 30f, true);
            arrayElectrodomestico[9] = new television(96969, "rosa", 'e', 60f, 30f, false);

            int precioElectrodomestico = 0;
            int precioLavadora = 0;
            int precioTelevision = 0;

            foreach (Electrodomestico elect in arrayElectrodomestico)
            {
                elect.precioFinal();

                precioElectrodomestico += elect.precioBase;

                if (elect is television)
                {
                    precioTelevision += elect.precioBase;
                }
                if (elect is lavadora)
                {
                    precioLavadora += elect.precioBase;
                }
            }

            Console.WriteLine($"| Precio total de los electrodomesticos: {precioElectrodomestico}\n| Precio total de las lavadoras: {precioLavadora}\n| Precio total de los televisores:{precioTelevision}");
            Console.ReadKey();
        }
    }
}

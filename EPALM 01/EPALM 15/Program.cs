using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPALM_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int _respuestaMenu;

            Almacen _almacen= new Almacen(4);
            
            Console.WriteLine("\n| 1. Calcular el precio de todas las bebidas. \n" +
                "| 2. Calcular el precio total de una marca de bebidas. \n" +
                "| 3. Calcular el precio total de una estantería. \n" +
                "| 4. Agregar un producto. \n" +
                "| 5. Eliminar un producto. \n" +
                "| 6. Mostrar información. \n" +
                "| 7. Salir.");

            Console.Write("\n> ");
            _respuestaMenu = Convert.ToInt32(Console.ReadLine());

            switch (_respuestaMenu)
            {
                case 1:
                    _almacen.mostrarTodo();
                    break;

                case 2:
                    _almacen.precioTotalMarca();
                    break;

                case 7:
                    break;
            }

            Console.ReadKey();
        }
    }
}

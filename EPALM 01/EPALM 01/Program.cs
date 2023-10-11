using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPALM_01
{
    public class Cuenta
    {
        // Titular.
        public string titular;
        // Cantidad;
        public float cantidad;
        public Cuenta(string titu, float cant)
        {
            titular = titu;
            cantidad = cant;
        }
        public Cuenta(string titu)
        {
            titular = titu;
        }
        public void Ingresar(double CantidadIntro)
        {
            if (CantidadIntro > 0)
            {
                cantidad = cantidad + Convert.ToSingle(CantidadIntro);
                // cantidad += Convert.ToSingle(CantidadIntro);
            }
        }
        public void Retirar(double CantidadIntro)
        {
            if (CantidadIntro < cantidad)
            {
                cantidad = cantidad - Convert.ToSingle(CantidadIntro);
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Cuenta Cuenta1 = new Cuenta("Anastacio", 500f);
            Console.WriteLine(Cuenta1.cantidad);
            Console.WriteLine("| Cantidad original en la cuenta.\n\n");

            Console.Write("> Cantidad a ingresar: ");
            Cuenta1.Ingresar(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("\n\n| Cantidad actual en la cuenta: " + Cuenta1.cantidad);

            Console.Write("> Cantidad a retirar: ");
            Cuenta1.Retirar(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("\n\n| Cantidad actual en la cuenta: " + Cuenta1.cantidad);

            Console.ReadKey();
        }
    }
}


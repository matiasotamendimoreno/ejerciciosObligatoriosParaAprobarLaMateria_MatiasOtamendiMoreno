using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto1
{
    public class Cuenta
    {
        private string titular;
        private double cantidad;
        public Cuenta(string titular, double cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }
        public Cuenta(string titular)
        {
            this.titular= titular;
        }
        public void Ingresar(double cantidad)
        {
            if (cantidad > 0) 
            {
                this.cantidad += cantidad;
            }
        }
        public void Reitrar(double cantidad)
        {
            if (cantidad <= this.cantidad && cantidad > 0)
            { 
                this.cantidad -= cantidad;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Cuenta cuenta1 = new Cuenta("| Hola mundo.");
            Cuenta cuenta2 = new Cuenta("| Adios mundo.", 10000);
            cuenta1.Ingresar(1000);
            cuenta1.Ingresar(-100);
            cuenta2.Reitrar(1000);
            cuenta2.Reitrar(1500000);
            cuenta2.Reitrar(-100);
            Console.ReadKey();
        }
    }
}

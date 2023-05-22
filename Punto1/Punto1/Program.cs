using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    public class Cuenta
    {
        // Atributos
        private string titular;
        private double cantidad;

        // Constructor con titular obligatorio y cantidad opcional
        public Cuenta(string titular, double cantidad = 0)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }

        // Método para ingresar una cantidad a la cuenta
        public void Ingresar(double cantidad)
        {
            if (cantidad > 0)
            {
                this.cantidad += cantidad;
            }
        }

        // Método para retirar una cantidad de la cuenta
        public void Retirar(double cantidad)
        {
            if (cantidad > 0)
            {
                if (this.cantidad - cantidad < 0)
                {
                    this.cantidad = 0;
                }
                else
                {
                    this.cantidad -= cantidad;
                }
            }
        }

        // Getter para obtener la cantidad actual de la cuenta
        public double ObtenerCantidad()
        {
            return this.cantidad;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}

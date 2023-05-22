using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace punto7
{
    public class Raices
    {
        private float a;
        private float b;
        private float c;
        public Raices(float a, float b, float c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        private void ObtenerRaices()
        {
            // (-b±√((b ^ 2) - (4 * a * c)))/ (2 * a)
            float x1;
            float x2;
            x1 = (-b + (float)Math.Sqrt(Math.Pow(b, 2) - (4 * a * c))) / (2 * a);
            x2 = (-b - (float)Math.Sqrt(Math.Pow(b, 2) - (4 * a * c))) / (2 * a);
            Console.WriteLine("| Raiz 1: " + x1);
            Console.WriteLine("| Raiz 2: " + x2);
        }
        private void ObtenerRaiz()
        {
            float x1;
            x1 = (-b + (float)Math.Sqrt(Math.Pow(b, 2) - (4 * a * c))) / (2 * a);
            Console.WriteLine("| Raiz: " + x1);
        }
        private double  ObtenerDiscriminante()
        {
            // (b^2)-4*a*c
            double discriminante;
            discriminante = (Math.Pow(b, 2) - 4 * a * c);
            return discriminante;
        }
        private bool TieneRaices()
        {
            double discriminante = ObtenerDiscriminante();
            if (discriminante >= 0)
            {
                return true;
            }
            else
            { 
                return false; 
            }
        }
        private bool TieneRaiz()
        {
            double discriminante = ObtenerDiscriminante();
            if (discriminante == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Calcular()
        {
            if (TieneRaices())
            {
                ObtenerRaices();
            }
            else if (TieneRaiz())
            {
                ObtenerRaiz();
            }
            else
            {
                Console.WriteLine("| No hay solución.");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Raices raices1 = new Raices(1, 2, 3);
            raices1.Calcular();

            Raices raices2 = new Raices(4, 5, 6);
            raices2.Calcular();

            Console.ReadKey();
        }
    }
}

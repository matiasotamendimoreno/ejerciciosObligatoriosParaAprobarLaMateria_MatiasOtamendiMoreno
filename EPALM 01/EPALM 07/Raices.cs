using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPALM_07
{
    internal class Raices
    {
        int a = 5;
        int b = 3;
        int c = -7;

        public Raices(int a, int b, int c) 
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public string obtenerRaices()
        {
            int x1 = Convert.ToInt32(-b + Math.Sqrt((b ^ 2) - (4 * a * c)) / (2 * a));
            int x2 = Convert.ToInt32(-b - Math.Sqrt((b ^ 2) - (4 * a * c)) / (2 * a));

            return $"| X1 = {x1}\n| X2 = {x2}";
        }

        public string obtenerRaiz()
        {
            int x = Convert.ToInt32(-b + Math.Sqrt((b ^ 2) - (4 * a * c)) / (2 * a));

            return $"| X = {x}";
        }

        public int obtenerDiscriminantes()
        {
            return Convert.ToInt32(Math.Sqrt((b ^ 2) - (4 * a * c)));
        }

        public bool tieneRaices()
        {
            double discriminante = obtenerDiscriminantes();

            return discriminante > 0;
        }

        public bool tieneRaiz()
        {
            double discriminante = obtenerDiscriminantes();

            return discriminante == 0;
        }

        public string calcular()
        {
            if (tieneRaices())
            {
                return $"\n| Las raices de esta función son: {obtenerRaices()}.\n";
            }
            else if (tieneRaiz())
            {
                return $"La raiz de esta función es: {obtenerRaiz()}.\n";
            }

            return "La función especificada no tiene raiz.\n";
        }
    }
}

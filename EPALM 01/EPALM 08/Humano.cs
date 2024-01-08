using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPALM_08
{
    internal class Humano
    {
        public string Nombre;
        public int Edad;
        public string Sexo;
        public bool Falta;
        public double probabilidadFaltar;

        public Random rnd = new Random();

        public Humano() { }

        public Humano(string Nombre, int Edad, string Sexo)
        {
            this.Nombre = Nombre;
            this.Edad = Edad;
            this.Sexo = Sexo;
            this.probabilidadFaltar = 0;
            this.Falta = Faltar();
        }

        public bool Faltar()
        {
            return (rnd.Next(1, 101) > probabilidadFaltar);
        }
    }
}

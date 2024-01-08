using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPALM_08
{
    internal class Alumno : Humano
    {
        public int Nota;

        public Alumno() : base()
        {
            this.probabilidadFaltar = 50;
            this.Falta = this.Faltar();
            this.Nota = rnd.Next(1, 11);
        }

        public Alumno   (string Nombre, int Edad, string Sexo) : base(Nombre, Edad, Sexo)
        {
            this.probabilidadFaltar = 50;
            this.Falta = Faltar();
            this.Nota = rnd.Next(1, 11);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPALM_08
{
    internal class Profesor : Humano
    {
        string[] materiasDisponibles = {"Matemática", "Filosofía", "Física"};

        public string Materia;

        public Profesor() : base()
        {
            this.probabilidadFaltar = 20;
            this.Falta = this.Faltar();
        } 

        public Profesor(string Nombre, int Edad, string Sexo, string Materia) : base(Nombre, Edad, Sexo)
        {
            this.probabilidadFaltar = 20;
            this.Falta = Faltar();
            this.Materia = materiaCheck(Materia);
        }
        
        public bool GetFalta()
        {
            return this.Falta;
        }

        public string materiaCheck(string Materia)
        {
            return (materiasDisponibles.Count(mate => mate == Materia) == 1) ? Materia : materiasDisponibles[0];
        }
    }
}

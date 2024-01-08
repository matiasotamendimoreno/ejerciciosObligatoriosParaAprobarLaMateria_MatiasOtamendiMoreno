using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPALM_08
{
    internal class Aula
    {
        string[] materiasDisponibles = { "Matemática", "Filosofía", "Física" };

        public int ID;
        public int Max_estudiantes;
        public int Max_profesores;
        public string Materia;
        public bool Clase = false;

        public Aula()
        {
            Globals.IDaulta++;
            ID = Globals.IDaulta;
        }

        public Aula(int MaxEstu,string Materia, int MaxProfe = 1)
        {
            Globals.IDaulta++;
            ID = Globals.IDaulta;

            this.Max_estudiantes = MaxEstu;
            this.Max_profesores = MaxProfe;
            this.Materia = materiaCheck(Materia);
        }

        public string materiaCheck(string Materia)
        {
            if (materiasDisponibles.Count(mate => mate == Materia) == 1)
            {
                return Materia;
            }
            return materiasDisponibles[0];
        }
    }
}

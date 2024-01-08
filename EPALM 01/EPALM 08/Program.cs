using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPALM_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Globals.IDaulta = 0;
            Random rnd = new Random();

            Aula aula = new Aula(30, "filosofia");
            Profesor profesor = new Profesor("Raul", 35, "masculino", "filosofia");
            List<Alumno> alumnos = new List<Alumno>();

            for (int i = 0; i < 5; i++)
            {
                alumnos.Add(new Alumno($"Floppa{0 + 1}", rnd.Next(12, 36), $"{(rnd.Next(0, 2) == 1 ? "masculino" : "femenino")}"));
            }

            if (profesor.GetFalta() == false && aula.Materia == profesor.Materia && (alumnos.Count(alu => alu.Falta == false) > (alumnos.Count() / 2)))
            {
                aula.Clase = true;
            }

            if (aula.Clase)
            {
                int alumnosAprobados = alumnos.Count(alu => alu.Nota >= 6 && alu.Sexo == "masculino");
                int alumnasAprobadas = alumnos.Count(alu => alu.Nota >= 6 && alu.Sexo == "femenino");

                Console.WriteLine($"| Alumnos aprobados: {alumnosAprobados}\n| Alumnas aprobadas: {alumnasAprobadas}");
            }

            Console.ReadKey();
        }
    }
}

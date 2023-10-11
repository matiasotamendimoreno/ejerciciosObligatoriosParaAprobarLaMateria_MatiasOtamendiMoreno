using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPALM_02
{
    public class Persona
    {
        const string sexoConst = "H";

        string nombre = "";
        int edad = 0;
        int dni = 0;
        string sexo;
        double peso = 0;
        double altura = 0;

        public string Nombre
        {
            get
            {
                return nombre;
            }
        }
        public int Edad
        {
            get
            {
                return edad;
            }
        }
        public int DNI
        {
            get
            {
                return dni;
            }
        }
        public string Sexo
        {
            get
            {
                return sexo;
            }
        }
        public double Peso
        {
            get
            {
                return peso;
            }
        }
        public double Altura
        {
            get
            {
                return altura;
            }
        }

        public Persona(string nombre, int edad, int dni, string sexo, double peso, double altura)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.dni = dni;
            this.sexo = sexo;
            this.peso = peso;
            this.altura = altura;
        }
        public Persona(string nombre, int edad, string sexo)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.sexo = sexo;
        }
        public Persona()
        {

        }
        public int calcularIMC()
        {
            double resultado = Peso / (Altura * Altura);

            if (resultado > 20)
            {

            }
            if (resultado <= 20 && resultado >= 25)
            {

            }
            if (resultado > 25)
            {

            }

            return 2;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
}

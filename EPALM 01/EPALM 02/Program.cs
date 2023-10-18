using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EOPAM_02
{
    public class Persona
    {
        const string sexoConst = "H";        

        string nombre = "";                 
        int edad = 0;                       
        string dni;                         
        string sexo = sexoConst;            
        double peso = 0;                    
        double altura = 0;                  
        Random rnd = new Random();          

        public string Nombre
        {
            get 
            { 
                return nombre; 
            }
            set 
            { 
                nombre = value; 
            }    
        }

        public int Edad
        {
            get 
            { 
                return edad; 
            }
            set 
            { 
                edad = value; 
            }
        }

        public string DNI
        {
            get 
            {
                return dni; 
            }
            set 
            { 
                dni = value; 
            }
        }
        public string Sexo
        {
            get 
            { 
                return sexo; 
            }
            set 
            { 
                sexo = value; 
            }
        }
        public double Peso
        {
            get 
            { 
                return peso; 
            }
            set 
            {
                peso = value; 
            }
        }
        public double Altura
        {
            get 
            {
                return altura; 
            }
            set 
            { 
                altura = value; 
            }
        }


        public Persona(string nombre, int edad, double peso, double altura)
        {         
            this.nombre = nombre;
            this.edad = edad;
            this.dni = generarDni();
            this.peso = peso;
            this.altura = altura;
        }

        public Persona(string nombre, int edad)
        {                                              
            this.nombre = nombre;
            this.edad = edad;
            this.dni = generarDni();
        }

        public Persona() { }                                                                                

        public int calcularIMC()
        {                                                      
            double resultado = Peso / (Altura * Altura);                                
            int devuelta = 0;                                                           

            if (resultado < 20)
            {
                devuelta = -1;
            }
            //if (resultado <= 20 && resultado >= 25) {
            //    devuelta = 0;
            //}
            if (resultado > 25)
            {
                devuelta = 1;
            }

            return devuelta;
        }

        public bool esMayorDeEdad()
        {
            return edad > 18 ? true : false;                                            
        }

        void comprobarSexo(char sexo)
        {
            if (!(sexo == (char)72 || sexo == (char)77))                                
            {                                                                           
                this.sexo = sexoConst;                                                  
            }                                                                           
            else
            {
                this.sexo = Convert.ToString(sexo);
            }
        }

        string generarDni()
        {

            this.sexo = rnd.Next(0, 2) == 1 ? sexoConst : "M";
            comprobarSexo(Convert.ToChar(this.sexo));                       

            return Convert.ToString(rnd.Next(10000000, 100000000));         
        }
        
        public string mostrarTodo()
        {
            return $"| Nombre: {nombre}.\n Edad: {edad}. \n DNI: {dni}.\n| Sexo: {sexo}, peso: {peso}, altura: {altura}";
        }
    }

    internal class Program
    {
        static public string mensajeIMC(int numero)
        {
            switch (numero)
            {
                case -1:
                    return "| Está por demabjo del peso normal.";
                case 0:
                    return "| Está en el peso ideal.";
                case 1:
                    return "| Debe asistir a un medico.";
            }
            return "Error: Numero no valido.";
        }
        static void Main(string[] args)
        {
            Console.Write("> Nombre: ");
            string nombre = Console.ReadLine();

            Console.Write("> Edad: ");
            int edad = Convert.ToInt32(Console.ReadLine());

            Console.Write("> Peso en kg: ");
            double peso = Convert.ToDouble(Console.ReadLine());

            Console.Write("> Altura en metros: ");
            double altura = Convert.ToDouble(Console.ReadLine());

            Persona juan = new Persona(nombre, edad, peso, altura);
            Persona pepe = new Persona(nombre, edad);
            Persona gabriel = new Persona();

            Console.WriteLine($" Juan: {mensajeIMC(juan.calcularIMC())}");
            Console.WriteLine($" Pepe: {mensajeIMC(pepe.calcularIMC())}");
            Console.WriteLine($" Gabriel:{mensajeIMC(gabriel.calcularIMC())}");

            Console.WriteLine($"| {juan.Nombre}: {(juan.esMayorDeEdad() ? " Es mayor de edad." : " Es menor de edad.")}");
            Console.WriteLine($"| {pepe.Nombre}: {(pepe.esMayorDeEdad() ? " Es mayor de edad." : " Es menor de edad.")}");
            Console.WriteLine($"| {gabriel.Nombre}: {(gabriel.esMayorDeEdad() ? " Es mayor de edad." : " Es menor de edad.")}");

            Console.WriteLine($"| {juan.mostrarTodo()}");
            Console.WriteLine($"| {pepe.mostrarTodo()}");
            Console.WriteLine($"| {gabriel.mostrarTodo()}");

            Console.ReadLine();
        }
    }
}


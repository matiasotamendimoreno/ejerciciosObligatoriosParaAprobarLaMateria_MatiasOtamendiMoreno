using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace EPALM_03
{
    public class Password
    {
        int longitud;
        string contraseña = "";

        public int Longitud
        {
            get
            {
                return longitud;
            }
            set
            {
                longitud = value;
            }
        }
        public string Contraseña
        {
            get
            {
                return contraseña;
            }
            set
            {
                contraseña = value;
            }
        }

        public Password(int longitud = 8)
        {
            this.longitud = longitud;

            generarContraseña();
        }

        public bool esFuerte()
        {
            int Mayusculas = 0;
            int Minusculas = 0;
            int Numeros = 0;

            for (int i = 0; i < longitud; i++)
            {
                if (char.IsUpper(contraseña, i))
                {
                    Mayusculas++;
                }
                if (char.IsLower(contraseña, i))
                {
                    Minusculas++;
                }
                if (char.IsNumber(contraseña, i))
                {
                    Numeros++;
                }
            }

            return (Mayusculas > 2 && Minusculas > 1 && Numeros > 5) ? true : false;
        }
        public string generarContraseña()
        {
            char[] Uppers = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            char[] Lowers = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            
            Random random = new Random();
            List<char> contraseñaEnProgreso = new List<char>();

            for (int i = 0;  i < longitud; i++)
            {
                int generadorDeRedstone = random.Next(1, 4);

                switch(generadorDeRedstone)
                {
                    case 1:
                        contraseñaEnProgreso.Add(Uppers[random.Next(0, Uppers.Count())]);
                        break;
                    case 2:
                        contraseñaEnProgreso.Add(Lowers[random.Next(0, Uppers.Count())]);
                        break;
                    case 3:
                        contraseñaEnProgreso.Add(Convert.ToChar(Convert.ToString(0, Uppers.Count())));
                        break;
                }
            }
            return Convert.ToString(contraseñaEnProgreso.ToArray());
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("> ¿Cuantas contraseñas quieres hacer?: ");
            int NumeroDeContraseñas = Convert.ToInt32(Console.ReadLine());

            bool[] fortalezaDeLaContraseña = new bool[NumeroDeContraseñas];
            Password[] Passwords = new Password[NumeroDeContraseñas];
            for (int i = 0;i < NumeroDeContraseñas; i++)
            {
                Console.WriteLine($"> ¿Cual es la longitud de la contraseña n°{i + 1}?: ");
                int LongitudDeContraseña = Convert.ToInt16(Console.ReadLine());
                Passwords[i] = new Password(LongitudDeContraseña);
                fortalezaDeLaContraseña[i] = Passwords[i].esFuerte();                                                             
                                                                                                                // 
                Console.WriteLine($"contraseña {i + 1}: {Passwords[i].Contraseña}, {fortalezaDeLaContraseña[i]}\n\n");

            }

            Console.ReadKey();
        }
    }
}

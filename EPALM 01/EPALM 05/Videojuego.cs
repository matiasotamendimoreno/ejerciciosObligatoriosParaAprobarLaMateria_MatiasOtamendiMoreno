using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPALM_05
{
    internal class Videojuego : IEntregable
    {
        string titulo = string.Empty;
        int horasEstimadas = 10;
        bool entregado = false;
        string genero = string.Empty;
        string compania = string.Empty;

        public string Titulo
        {
            get
            {
                return titulo;
            }
            set
            {
                titulo = value;
            }
        }
        public int HorasEstimadas
        {
            get
            {
                return horasEstimadas;
            }
            set
            {
                horasEstimadas = value;
            }
        }
        public string Genero
        {
            get
            {
                return genero;
            }
            set
            {
                genero = value;
            }
        }
        public string Compania
        {
            get
            {
                return compania;
            }
            set
            {
                compania = value;
            }
        }

        public Videojuego()
        {
        }

        public Videojuego(string titulo, int horasEstimadas)
        {
            this.titulo = titulo;
            this.horasEstimadas = horasEstimadas;
        }

        public Videojuego(string titulo, int horasEstimadas, string genero, string compania)
        {
            this.titulo = titulo;
            this.horasEstimadas = horasEstimadas;
            this.genero = genero;
            this.compania = compania;
        }
        public string mostrarTodo()
        {
            return $"Titulo: {titulo}. Horas estimadas: {horasEstimadas}. Entregado: {entregado}. Genero: {genero}. Compañia: {compania}.";
        }
        public void entregar()
        {
            entregado = true;
        }
        public void devolver()
        {
            entregado = false;
        }
        public bool isEntregado()
        {
            return entregado;
        }
        public int compareTo(int a)
        {
            return a > horasEstimadas ? a : horasEstimadas;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPALM_05
{
    internal class Serie : IEntregable
    {
        string titulo = string.Empty;
        int ntemporadas = 3;
        bool entregado = false;
        string genero = string.Empty;
        string creador = string.Empty;

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
        public int NTemporadas
        {
            get
            {
                return ntemporadas;
            }
            set
            {
                ntemporadas = value;
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
        public string Creador
        {
            get
            {
                return creador;
            }
            set
            {
                creador = value;
            }
        }

        public Serie()
        {
        }

        public Serie(string titulo, string creador)
        {
            this.titulo = titulo;
            this.creador = creador;
        }

        public Serie(string titulo,int ntemporadas, string genero, string creador)
        {
            this.titulo = titulo;
            this.ntemporadas = ntemporadas;
            this.genero = genero;
            this.creador = creador;
        }
        public string mostrarTodo()
        {
            return $"Titulo: {titulo}. Numero de Temporadas: {ntemporadas}. Entregado: {entregado}. Genero: {genero}. Compañia: {creador}.";
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
            return a > ntemporadas ? a : ntemporadas;
        }
    }
}

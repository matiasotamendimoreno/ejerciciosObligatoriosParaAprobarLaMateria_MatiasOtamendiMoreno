using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EPALM_06;

namespace EPALM_06
{
    internal class Libro
    {
        bool ISBN;
        public string Titulo;
        string Autor;
        public int NumeroDePaginas;

        public Libro(bool iSBN, string titulo, string autor, int numeroDePaginas)
        {
            ISBN = iSBN;
            Titulo = titulo;
            Autor = autor;
            NumeroDePaginas = numeroDePaginas;
        }

        public string MostrarTodo()
        {
            return $"| El libro {Titulo} con ISBN '{ISBN}' creado por {Autor} tiene esta cantidad de paginas: {NumeroDePaginas}";
        }
    }
}

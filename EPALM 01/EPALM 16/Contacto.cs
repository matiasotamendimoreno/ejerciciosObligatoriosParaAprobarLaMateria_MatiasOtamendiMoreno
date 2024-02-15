using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPALM_16
{
    internal class Contacto
    {
        string _nombre = "";
        string _numeroDeTelefono = "";

        public Contacto(string _nombre, string _numeroDeTelefono) 
        {
            this._nombre = _nombre;
            this._numeroDeTelefono = _numeroDeTelefono;
        }

        public string Nombre
        {
            get
            {
                return _nombre;
            }
            set
            {
                _nombre = value;
            }
        }
        public string NumeroDeTelefono
        {
            get
            {
                return _numeroDeTelefono;
            }
            set
            {
                _numeroDeTelefono = value;
            }
        }

        public string MostrarContactos()
        {
            return $"| Nombre del contacto: {_nombre} / Número de teléfono: {_numeroDeTelefono}";
        }
    }
}

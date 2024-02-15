using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPALM_16
{
    internal class Agenda
    {
        List<Contacto> _contactos = new List<Contacto>();
        int _limite;

        public Agenda(int _limite = 10)
        {
            this._limite = _limite;
        }

        public string anadirContactos(Contacto c)
        {
            if (_contactos.Count < _limite)
            {
                if (!_contactos.Exists(con => con.Nombre == c.Nombre))
                {
                    _contactos.Add(c);
                    return "| Se añadió el contacto.";
                }
                return "| Contacto ya existente";
            }
            return "| Agenda llena.";
        }

        public string existeContacto(Contacto c)
        {
            if (_contactos.Exists(con => con.Nombre == c.Nombre && con.NumeroDeTelefono == c.NumeroDeTelefono))
            {
                return $"| Contacto existe: {_contactos.Find(con => con.Nombre == c.Nombre).MostrarContactos()}";
            }
            return "| No existe este contacto.";
        }

        public string[] listarContactos()
        {
            string[] _strings = new string[_contactos.Count()];
            string[] _noHay = { "| No hay contactos." };

            for (int i = 0; i < _contactos.Count(); i++)
            {
                _strings[i] = _contactos[i].MostrarContactos();
            }

            return _strings.Length == 0 ? _noHay : _strings;
        }

        public Contacto buscarContacto(string _nombre)
        {
            return _contactos.Find(con => con.Nombre == _nombre);
        }

        public string eliminarContactos(Contacto c)
        {
            if (_contactos.RemoveAll(con => con.Nombre == c.Nombre && con.NumeroDeTelefono == c.NumeroDeTelefono) >= 1)
            {
                return "| Contacto eliminado.";
            }
            return "| Contacto no encontrado.";
        }

        public string agendaLlena()
        {
            return _contactos.Count() == _limite ? "| La agenda está llena" : "| Aún queda espacio";
        }

        public string huecosLibres()
        {
            return _contactos.Count() == _limite ? "| Agenda sin espacios disponibles." : $"| Agenda con {_limite - _contactos.Count()} espacios disponibles";
        }
    }
}

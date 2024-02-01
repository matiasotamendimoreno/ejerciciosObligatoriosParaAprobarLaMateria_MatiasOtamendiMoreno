using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPALM_12
{
    internal class Jugador
    {
        public int _id;
        public string _jugador;
        public bool _schrodinger;

        public Jugador(int id, string jugador, bool schrodinger)
        {
            _id = id;
            _jugador = jugador;
            _schrodinger = schrodinger;
        }

        public void Dispararse(Revolver r)
        {
            if (r.Disparar())
            {
                _schrodinger = false;
            }

            r.SiguienteBala();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPALM_11
{
    internal class Partido
    {
        string _resultado;
        Random _rnd = new Random();
        
        public string Resultado
        {
            get
            {
                return _resultado;
            }
        }

        public Partido()
        {
            _resultado = $"{_rnd.Next(0,4 )} - {_rnd.Next(0, 4)}";
        }
    }
}

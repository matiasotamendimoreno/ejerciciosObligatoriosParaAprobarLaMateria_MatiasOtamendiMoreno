using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPALM_12
{
    internal class Revolver
    {
        int _posCamara;
        int _posBala;

        public Revolver(Random _rnd)
        {
            _posCamara = _rnd.Next(0, 6);
            _posBala = _rnd.Next(0, 6);
        }

        public bool Disparar()
        {
            return _posBala == _posCamara;
        }

        public void SiguienteBala()
        {
            if (_posCamara < 5)
            {
                _posCamara++;
            }
            else
            {
                _posCamara = 0;
            }
        }
    }
}

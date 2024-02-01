using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPALM_13
{
    internal class Repartidor : Empleado
    {
        public string _zona = "";

        public Repartidor(string _nombre, int _edad, int _salario, string _zona) : base(_nombre, _edad, _salario)
        {
            this._zona = _zona;
        }
        public string Zona
        {
            get
            {
                return _zona;
            }
            set
            {
                _zona = value;
            }
        }

        public override bool Plus()
        {
            if (Edad < 25 && _zona == "zona 3")
            {
                Salario += PLUS;
                return true;
            }

            return false;
        }
    }
}

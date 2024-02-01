using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace EPALM_13
{
    internal class Comercial : Empleado
    {
        double _comision = 0;
        public Comercial(string _nombre, int _edad, int _salario, double _comision) : base(_nombre, _edad, _salario)
        {
            this._comision = _comision;
        }

        public double Comision
        {
            get
            {
                return _comision;
            }
            set
            {
                _comision = value;
            }
        }

        public override bool Plus()
        {
            if (Edad > 30 && Salario > 200)
            {
                Salario += PLUS;
                return true;
            }

            return false;
        }
    }
}

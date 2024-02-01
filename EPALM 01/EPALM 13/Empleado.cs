using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPALM_13
{
    internal class Empleado
    {
        string _nombre;
        int _edad;
        int _salario;

        const int _plus = 300;

        public Empleado(string _nombre, int _edad, int _salario)
        {
            this._nombre = _nombre;
            this._edad = _edad;
            this._salario = _salario;
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
        public int Edad
        {
            get
            {
                return _edad;
            }
            set
            {
                _edad = value;
            }
        }
        public int Salario
        {
            get
            {
                return _salario;
            }
            set
            {
                _salario = value;
            }
        }
        public int PLUS
        {
            get
            {
                return _plus;
            }
        }

        public virtual bool Plus()
        {
            return true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPALM_01
{
    public class Cuenta
    {
        // Titular.
        string titular;
        // Cantidad;
        float cantidad;
        public Cuenta(string titu, float cant)
        {
            titular = titu;
            cantidad = cant;
        }
        public Cuenta(string titu)
        {
            titular = titu;
        }
        public void Ingresar(double CantidadIntro)
        {
            if (CantidadIntro > 0)
            {
                cantidad = cantidad + Convert.ToSingle(CantidadIntro);
                // cantidad += Convert.ToSingle(CantidadIntro);
            }
        }
        public void Retirar(double CantidadIntro)
        {
            if (CantidadIntro > cantidad)
            {
                cantidad = cantidad - Convert.ToSingle(CantidadIntro);
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}


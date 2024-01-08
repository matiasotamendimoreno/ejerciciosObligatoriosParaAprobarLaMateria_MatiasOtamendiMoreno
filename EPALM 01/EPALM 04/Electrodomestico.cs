using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPALM_04
{
    internal class Electrodomestico
    {
        string[] coloresDisponibles = { "blanco", "negro", "rojo", "gris" };
        char[] letrasDisponibles = {'A', 'B', 'C', 'D', 'E', 'F'};

        public int precioBase = 100;
        public string color = "blanco";
        public char consumoEnergetico = (char)102;
        public float peso = 5.0f;

        public int PrecioBase
        {
            get
            {
                return precioBase;
            }
            set
            {
                precioBase = value;
            }
        }
        public string Color
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
            }
        }
        public char ConsumoEnergetico
        {
            get
            {
                return consumoEnergetico;
            }
            set
            {
                consumoEnergetico = value;
            }
        }
        public float Peso
        {
            get
            {
                return peso;
            }
            set
            {
                peso = value;
            }
        }

        public Electrodomestico()
        {
        }
        public Electrodomestico(int precioBase, float peso)
        {
            this.precioBase = precioBase;
            this.peso = peso;
        }
        public Electrodomestico(int precioBase, string color, char consumoEnergetico, float peso)
        {
            this.precioBase = precioBase;
            this.color = color;
            this.consumoEnergetico = consumoEnergetico;
            this.peso = peso;
        }
        private void ValorDeConsumoEnergetico(char letra)
        {
            bool bandera = false;
            for (int i = 0; i < letrasDisponibles.Count(); i++)
            {
                if (letra == letrasDisponibles[i])
                {
                    bandera = true;
                }
                if (!bandera)
                {
                    consumoEnergetico = 'F';
                }
            }
        }
        private void QueColorEs(string color)
        {
            bool bandera = false;
            for (int i = 0; i < coloresDisponibles.Count(); i++)
            {
                if (color == coloresDisponibles[i])
                {
                    bandera = true;
                }
                if (!bandera)
                {
                    color = "blanco";
                }
            }
        }
        public virtual void precioFinal()
        {
            switch (consumoEnergetico)
            {
                case 'A': precioBase += 100; break;
                case 'B': precioBase += 80; break;
                case 'C': precioBase += 60; break;
                case 'D': precioBase += 50; break;
                case 'E': precioBase += 30; break;
                case 'F': precioBase += 10; break;
            }
            if (peso >= 0 && peso <= 19)
            {
                precioBase += 10;
            }
            if (peso >= 20 && peso <= 49)
            {
                precioBase += 50;
            }
            if (peso >= 50 && peso <= 79)
            {
                precioBase += 80;
            }
            if (peso >= 80)
            {
                precioBase += 100;
            }
        }
    }
}

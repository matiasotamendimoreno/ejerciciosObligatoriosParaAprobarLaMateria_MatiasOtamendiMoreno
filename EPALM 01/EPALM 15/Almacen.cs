using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPALM_15
{
    internal class Almacen
    {
        List<Bebida>[,] _estanterias;

        public Almacen(int _cantidadDeEstantes)
        {
            _estanterias = new List<Bebida>[_cantidadDeEstantes, 1];
            for (int i = 0; i < _cantidadDeEstantes; i++)
            {
                _estanterias[i, 0] = new List<Bebida>();
            }
        }

        public string agregarProducto(Bebida _bebida)
        {
            bool _existe = false;

            foreach (List<Bebida> _estante in _estanterias)
            {
                if (_estante.Exists(b => b._id == _bebida._id))
                {
                    _existe = true;
                }
            }

            foreach (List<Bebida> _estante in _estanterias)
            {
                if (_existe == false)
                {
                    if (_estante.Count() < 20)
                    {
                        _estante.Add(_bebida);
                        return "| Producto agregado.";
                    }
                }
                else
                {
                    return "| ID de producto ya existente.";
                }
            }

            return "| Todas las estanterías están llenas.";
        }

        public string eliminarProducto(int _productoID)
        {
            foreach (List<Bebida> _estante in _estanterias)
            {
                for (int i = 0; i < _estante.Count(); i++)
                {
                    if (_estante[i]._id == _productoID)
                    {
                        _estante.RemoveAt(i);
                        return "| Producto eliminado.";
                    }
                }
            }

            return "| Producto no encontrado.";
        }

        public int precioTotal()
        {
            int _precioTotal = 0;

            foreach (List<Bebida> _estante in _estanterias)
            {
                for (int i = 0; i < _estante.Count(); i++)
                {
                    _precioTotal += _estante[i]._precio;
                }
            }

            return _precioTotal;
        }

        public int precioTotalEstante(int _indiceEstante)
        {
            List<Bebida> _estanteX = new List<Bebida>();
            int _precioTotalEstanteX = 0;

            try
            {
                 _estanteX = _estanterias[_indiceEstante, 0];
            }
            catch (Exception e)
            {
                return 0;
            }

            for (int i = 0; i < _estanteX.Count(); i++)
            {
                _precioTotalEstanteX += _estanteX[i]._precio;
            }

            return _precioTotalEstanteX;
        }

        public int precioTotalMarca(string _marca)
        {
            int _precioTotalMarca = 0;

            foreach (List<Bebida> _estante in _estanterias)
            {
                for (int i = 0; i < _estante.Count(); i++)
                {
                    if (_marca == _estante[i]._marca)
                    {
                        _precioTotalMarca += _estante[i]._precio;
                    }
                }
            }

            return _precioTotalMarca;
        }

        public string mostrarTodo()
        {
            string _principal = "";

            for (int i = 0; i < _estanterias.GetLength(0); i++)
            {
                _principal += $"\n| Estantería {i}:\n\n";

                foreach (Bebida _bebida in _estanterias[i, 0])
                {
                    _principal += $"| {_bebida.Mostrar()}\n";
                }

                _principal += $"\n";
            }

            return _principal;
        }
    }
}

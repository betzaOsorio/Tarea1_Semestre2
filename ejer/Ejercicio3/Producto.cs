using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer.Ejercicio3
{
    internal class Producto
    {
        private string nombre;
        private int cantidad;

        public Producto(string nombreProducto, int cantidadProducto)
        {
            nombre = nombreProducto;
            cantidad = cantidadProducto;
        }

        public string GetNombre()
        {
            return nombre;
        }

        public int GetCantidad()
        {
            return cantidad;
        }

        public void IncrementarCantidad(int cantidadAgregar)
        {
            if (cantidadAgregar > 0)
            {
                cantidad += cantidadAgregar;
            }
        }

        public bool RetirarCantidad(int cantidadRetirar)
        {
            if (cantidadRetirar > 0 && cantidadRetirar <= cantidad)
            {
                cantidad -= cantidadRetirar;
                return true;
            }
            return false;
        }
    }
}

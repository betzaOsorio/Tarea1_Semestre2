using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer.Ejercicio3
{
    internal class Inventario
    {
        private Producto[] productos;
        private int totalProductos;

        public Inventario()
        {
            productos = new Producto[100];
            totalProductos = 0;
        }

        private int BuscarProducto(string nombreBuscado)
        {
            for (int i = 0; i < totalProductos; i++)
            {
                if (productos[i].GetNombre() == nombreBuscado)
                {
                    return i;
                }
            }
            return -1;
        }

        public void AgregarProducto(string nombreProducto, int cantidadAgregar)
        {
            if (cantidadAgregar <= 0)
            {
                Console.WriteLine("Cantidad inválida para agregar.");
                return;
            }

            int indice = BuscarProducto(nombreProducto);

            if (indice == -1)
            {
                if (totalProductos < productos.Length)
                {
                    productos[totalProductos] = new Producto(nombreProducto, cantidadAgregar);
                    totalProductos++;
                    Console.WriteLine("Producto agregado: " + nombreProducto);
                }
                else
                {
                    Console.WriteLine("Inventario lleno.");
                }
            }
            else
            {
                productos[indice].IncrementarCantidad(cantidadAgregar);
                Console.WriteLine("Cantidad incrementada para: " + nombreProducto);
            }
        }

        public void RetirarProducto(string nombreProducto, int cantidadRetirar)
        {
            if (cantidadRetirar <= 0)
            {
                Console.WriteLine("Cantidad inválida para retirar.");
                return;
            }

            int indice = BuscarProducto(nombreProducto);

            if (indice == -1)
            {
                Console.WriteLine("Producto no existe en inventario.");
            }
            else
            {
                bool pudoRetirar = productos[indice].RetirarCantidad(cantidadRetirar);
                if (pudoRetirar)
                {
                    Console.WriteLine("Cantidad retirada de: " + nombreProducto);
                }
                else
                {
                    Console.WriteLine("No hay suficiente cantidad para retirar.");
                }
            }
        }

        public void MostrarInventario()
        {
            Console.WriteLine("Inventario completo:");
            for (int i = 0; i < totalProductos; i++)
            {
                Console.WriteLine(productos[i].GetNombre() + " - Cantidad: " + productos[i].GetCantidad());
            }
            if (totalProductos == 0)
            {
                Console.WriteLine("El inventario está vacío.");
            }
        }
    }
}

using System;

namespace ejer.Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Inventario inventario = new Inventario();

            inventario.AgregarProducto("Manzanas", 10);
            inventario.AgregarProducto("Bananas", 5);
            inventario.AgregarProducto("Manzanas", 3);

            inventario.MostrarInventario();

            inventario.RetirarProducto("Bananas", 2);
            inventario.RetirarProducto("Manzanas", 20);

            inventario.MostrarInventario();

            Console.WriteLine("Presiona Enter para salir...");
            Console.ReadLine();
        }
    }
}

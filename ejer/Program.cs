using System;
using ejer;

namespace ejer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Biblioteca miBiblioteca = new Biblioteca();

            
            miBiblioteca.RegistrarLibro("Antes de Diciembre", "Joana Marcus");
            miBiblioteca.RegistrarLibro("Twisted Love", "Ana Huang");
            miBiblioteca.RegistrarLibro("Twisted Games", "Ana Huang");

            
            if (!miBiblioteca.RegistrarLibro("Twisted Love", "Ana Huang"))
            {
                Console.WriteLine("El libro 'Twisted Love' ya está registrado actualmente.");
            }

            
            bool prestado = miBiblioteca.PrestarLibro("Twisted Love", "Betza");
            Console.WriteLine(prestado ? "Préstamo exitoso." : "El libro no está disponible en este momento.");

            
            Console.WriteLine("\nLibros disponibles:");
            foreach (string info in miBiblioteca.ObtenerLibrosDisponibles())
            {
                Console.WriteLine(info);
            }
        }
    }
}

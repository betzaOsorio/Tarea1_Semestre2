using System;

namespace ejer.Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Biblioteca miBiblio = new Biblioteca();

            miBiblio.AgregarLibro("Antes de Diciembre", "Joana Marcus");
            miBiblio.AgregarLibro("Twisted Love", "Ana Huang");
            miBiblio.AgregarLibro("Twisted Games", "Ana Huang");

            if (!miBiblio.AgregarLibro("Twisted Love", "Ana Huang"))
            {
                Console.WriteLine("Ese libro ya está registrado.");
            }

            bool prestado = miBiblio.PrestarLibro("Twisted Love", "Betza");
            Console.WriteLine(prestado ? "Préstamo hecho con éxito." : "No se pudo prestar, no disponible.");

            Console.WriteLine("\nLibros que aún están disponibles:");
            MostrarLibrosDisponibles(miBiblio);
        }

        static void MostrarLibrosDisponibles(Biblioteca biblio)
        {
            string[] disponibles = biblio.VerLibrosDisponibles();

            int i = 0;
            while (i < disponibles.Length)
            {
                Console.WriteLine(disponibles[i]);
                i++;
            }
        }
    }
}


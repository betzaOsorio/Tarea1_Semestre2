using ejer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ejer
{
    public class Biblioteca
    {
        private List<Libro> libros;
        private int contadorId;

        public Biblioteca()
        {
            libros = new List<Libro>();
            contadorId = 1;
        }

        public bool RegistrarLibro(string titulo, string autor)
        {
            if (libros.Any(l => l.Titulo.ToLower() == titulo.ToLower()))
                return false;

            Libro nuevoLibro = new Libro(titulo, autor, contadorId++);
            libros.Add(nuevoLibro);
            return true;
        }

        public bool PrestarLibro(string titulo, string usuario)
        {
            Libro libro = libros.FirstOrDefault(l => l.Titulo.ToLower() == titulo.ToLower() && l.Disponible);

            if (libro == null)
                return false;

            return libro.Prestar(usuario);
        }

        public List<string> ObtenerLibrosDisponibles()
        {
            return libros
                .Where(l => l.Disponible)
                .Select(l => l.ToString())
                .ToList();
        }
    }
}



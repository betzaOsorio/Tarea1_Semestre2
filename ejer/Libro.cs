using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer
{
    public class Libro
    {
        public string Titulo { get; private set; }
        public string Autor { get; private set; }
        public int Id { get; private set; }
        public bool Disponible { get; private set; }
        private string usuarioPrestamo;

        public Libro(string titulo, string autor, int id)
        {
            Titulo = titulo;
            Autor = autor;
            Id = id;
            Disponible = true;
            usuarioPrestamo = string.Empty;
        }

        public bool Prestar(string usuario)
        {
            if (!Disponible)
                return false;

            Disponible = false;
            usuarioPrestamo = usuario;
            return true;
        }

        public void Devolver()
        {
            Disponible = true;
            usuarioPrestamo = string.Empty;
        }

        public override string ToString()
        {
            return $"ID: {Id}, Título: {Titulo}, Autor: {Autor}, Disponible: {Disponible}";
        }
    }
}

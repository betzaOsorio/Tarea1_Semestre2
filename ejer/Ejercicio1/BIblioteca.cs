using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ejer.Ejercicio1
{
    public class Biblioteca
    {
        private Libro[] libros = new Libro[100]; 
        private int totalLibros = 0;
        private int siguienteCodigo = 1;

        public bool AgregarLibro(string nombre, string autor)
        {
           
            for (int i = 0; i < totalLibros; i++)
            {
                if (libros[i].Nombre.ToLower() == nombre.ToLower())
                    return false;
            }

            libros[totalLibros] = new Libro(nombre, autor, siguienteCodigo);
            totalLibros++;
            siguienteCodigo++;
            return true;
        }

        public bool PrestarLibro(string nombre, string persona)
        {
            for (int i = 0; i < totalLibros; i++)
            {
                if (libros[i].Nombre.ToLower() == nombre.ToLower() && libros[i].EstaDisponible)
                {
                    return libros[i].PrestarLibro(persona);
                }
            }
            return false;
        }

        public string[] VerLibrosDisponibles()
        {
            string[] disponibles = new string[totalLibros];
            int contador = 0;

            for (int i = 0; i < totalLibros; i++)
            {
                if (libros[i].EstaDisponible)
                {
                    disponibles[contador] = libros[i].ToString();
                    contador++;
                }
            }

            
            string[] resultadoFinal = new string[contador];
            for (int i = 0; i < contador; i++)
            {
                resultadoFinal[i] = disponibles[i];
            }

            return resultadoFinal;
        }
    }
}


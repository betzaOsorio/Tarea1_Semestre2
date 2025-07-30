using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer.Ejercicio1
{
    public class Libro
    {
        public string Nombre { get; private set; }
        public string Escritor { get; private set; }
        public int Codigo { get; private set; }
        public bool EstaDisponible { get; private set; }
        private string PersonaQuePidio;

        public Libro(string nombre, string escritor, int codigo)
        {
            Nombre = nombre;
            Escritor = escritor;
            Codigo = codigo;
            EstaDisponible = true;
            PersonaQuePidio = "";
        }

        public bool PrestarLibro(string persona)
        {
            if (!EstaDisponible)
                return false;

            EstaDisponible = false;
            PersonaQuePidio = persona;
            return true;
        }

        public void DevolverLibro()
        {
            EstaDisponible = true;
            PersonaQuePidio = "";
        }

        public override string ToString()
        {
            return $"Código: {Codigo}, Nombre: {Nombre}, Autor: {Escritor}, Disponible: {EstaDisponible}";
        }
    }
}
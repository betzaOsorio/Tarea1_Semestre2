using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer
{
    internal class Ejercicio5
    {
        public abstract class Persona
        {
            public string Nombre { get; set; }

            public Persona(string nombre)
            {
                Nombre = nombre;
            }

            public abstract void MostrarPerfil();
        }
    }

} 
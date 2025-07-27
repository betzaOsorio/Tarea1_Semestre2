using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ejer.Ejercicio5;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ejer
{
    internal class Estudiante
    {
        internal class Estudiante : Persona
        {
            public string Grado { get; set; }

            public Estudiante(string nombre, string grado) : base(nombre)
            {
                Grado = grado;
            }

            public override void MostrarPerfil()
            {
                Console.WriteLine($"Estudiante: {Nombre}, Grado: {Grado}");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ejer.Ejercicio5;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ejer
{
    internal class Maestro
    {
        public class Maestro : Persona
        {
            public string Materia { get; set; }

            public Maestro(string nombre, string materia) : base(nombre)
            {
                Materia = materia;
            }

            public override void MostrarPerfil()
            {
                Console.WriteLine($"Maestro: {Nombre}, Materia: {Materia}");
            }
        }
    }
}

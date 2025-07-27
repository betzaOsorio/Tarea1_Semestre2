using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ejer.Ejercicio5;

namespace ejer
{
    internal class Escuela
    {
        public class Escuela
        {
            private List<Persona> personas = new List<Persona>();

            public void AgregarPersona(Persona persona)
            {
                personas.Add(persona);
            }

            public void MostrarPerfiles()
            {
                foreach (var persona in personas)
                {
                    persona.MostrarPerfil();
                }
            }
        }
    }
}

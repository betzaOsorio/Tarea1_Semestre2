using System;

class Program
{
    static void Main(string[] args)
    {
        Escuela miEscuela = new Escuela();

        miEscuela.AgregarPersona(new Estudiante("Anabella", "5to grado"));
        miEscuela.AgregarPersona(new Maestro("Luis", "Matemáticas"));
        miEscuela.AgregarPersona(new Estudiante("Fenando", "3er grado"));
        miEscuela.AgregarPersona(new Maestro("Miguel", "Historia"));

        Console.WriteLine("Perfiles en la escuela:\n");
        miEscuela.MostrarPerfiles();

        Console.ReadKey();
    }
}

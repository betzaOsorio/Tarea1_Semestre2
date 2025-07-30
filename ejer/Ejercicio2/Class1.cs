using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer.Ejercicio2
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            Usuario persona = new Usuario();

            Console.Write("Ingrese su nombre: ");
            persona.nombreUsuario = Console.ReadLine();

            Console.Write("Ingrese su DPI (13 dígitos): ");
            persona.Dpi = Console.ReadLine();

            Console.Write("Cree una contraseña (mínimo 6 caracteres): ");
            persona.Clave = Console.ReadLine();

            Console.Write("Ingrese su contraseña para verificar: ");
            string intento = Console.ReadLine();

            if (persona.Autenticar(intento))
            {
                Console.WriteLine("¡Autenticación exitosa!");
            }
            else
            {
                Console.WriteLine("Contraseña incorrecta.");
            }

            Console.WriteLine("Presione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}


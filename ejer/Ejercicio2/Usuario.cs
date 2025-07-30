using System;


namespace ejer.Ejercicio2
{
    internal class Usuario
    {
        private string dpiUsuario;
        private string claveSecreta;

        public string nombreUsuario;

        public string Dpi
        {
            get { return dpiUsuario; }
            set
            {
                if (value.Length == 13 && EsSoloNumeros(value))
                {
                    dpiUsuario = value;
                }
                else
                {
                    Console.WriteLine("El DPI debe tener exactamente 13 dígitos numéricos.");
                }
            }
        }

        public string Clave
        {
            set
            {
                if (value.Length >= 6)
                {
                    claveSecreta = value;
                }
                else
                {
                    Console.WriteLine("La contraseña debe tener al menos 6 caracteres.");
                }
            }
        }

        public bool Autenticar(string intentoDeClave)
        {
            return intentoDeClave == claveSecreta;
        }

        private bool EsSoloNumeros(string texto)
        {
            foreach (char c in texto)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio4
{
    internal class Ejercicio4
    {
        public abstract class Vehiculo
        {
            public void Encender()
            {
                Console.WriteLine("El vehiculo está encendido");
            }
            public abstract void Conducir();
        }
        public class Carro : Vehiculo
        {
            public override void Conducir()
            {
                Console.WriteLine("Conduciendo el carro");
            }
        }
        public class Motocicleta : Vehiculo
        {
            public override void Conducir()
            {
                Console.WriteLine("Conduciendo la motocicleta");
            }
        }
    }
}
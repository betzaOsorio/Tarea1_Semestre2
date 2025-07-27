using System;
using System.Collections.Generic;
using static ejercicio4.Ejercicio4;

class Program
{
    static void Main()
    {
        List<Vehiculo> vehiculo = new List<Vehiculo>
        {
            new Carro(),
            new Motocicleta()
        };
        foreach (Vehiculo v in vehiculo)
        {
            v.Encender();
            v.Conducir();
            Console.WriteLine();
        }
    }
}

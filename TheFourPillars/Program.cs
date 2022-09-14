using System;
using TheFourPillars.Polymorphism;

namespace TheFourPillars
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testing polymorphism...");

            Animal perrito = new Perro();
            Animal gatito = new Gato();

            perrito.EmitirSonido();
            gatito.EmitirSonido();
        }
    }
}


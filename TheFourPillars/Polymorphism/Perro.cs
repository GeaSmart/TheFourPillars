using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFourPillars.Polymorphism
{
    public class Perro : Animal
    {
        public override void EmitirSonido()
        {
            Console.WriteLine("Guau guau!");
        }
    }
}

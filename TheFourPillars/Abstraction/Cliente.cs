using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFourPillars.Abstraction
{
    public class Cliente
    {
        //Sólo nos enfocamos en los campos relevantes para nuestro software
        public int Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public DateTime FechaRegistro { get; set; }
        public double Credito { get; set; }
    }
}

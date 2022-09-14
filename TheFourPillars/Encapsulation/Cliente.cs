using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFourPillars.Encapsulation
{
    public class Cliente
    {         
        public int Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public DateTime FechaRegistro { get; set; }
        private double Credito { get; set; }

        public void AumentarCredito(double monto)
        {
            this.Credito += monto;
        }        
    }
}

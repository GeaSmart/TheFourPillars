using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFourPillars
{
    public class DocumentoVenta
    {
        public int Id { get; set; }
        public string Serie { get; set; }
        public string Correlativo { get; set; }
        public DateTime FechaEmision { get; set; }
        public double MontoTotal { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Consignacion
    {
        public string EntidadServicios { get; set; }
        public string NumeroRecibo { get; set; }
        public DateTime FechaPago { get; set; }
        public double ValorPagado { get; set; }
        public override string ToString()
        {
            return $"{EntidadServicios};{NumeroRecibo};{FechaPago};{ValorPagado}";
        }

    }
}

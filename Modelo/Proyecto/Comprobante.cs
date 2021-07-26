using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Proyecto
{
    public class Comprobante : IDBEntity
    {
        public int ComprobanteId { get; set; }
        public string Codigo { get; set; }
        public bool EstadoFactura { get; set; }
    }
}

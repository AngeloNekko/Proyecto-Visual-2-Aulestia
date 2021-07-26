using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Proyecto
{
    public class Localizacion: IDBEntity
    {
        public int LocalizacionId { get; set; }
        public string Provincia { get; set; }
        public string Canton { get; set; }
        public string Parroquia { get; set; }
        public Sucursal sucursal { get; set; }
    }
}

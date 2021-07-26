using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Proyecto
{
    public class Sucursal : IDBEntity
    {
        public int SucursalId { get; set; }
        public string NombreSucursal { get; set; }
        public int EmpresaId { get; set; }
        public Empresa empresa { get; set; }
        public int LocalizacionId { get; set; }
        public Localizacion localizacion { get; set; }
    }
}

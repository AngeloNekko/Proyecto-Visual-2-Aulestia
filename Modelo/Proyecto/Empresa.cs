using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Proyecto
{
    public class Empresa : IDBEntity
    {
        public int empresaid { get; set; }
        public string NombreEmpresa { get; set; }
        public List<Empleado> empleado { get; set; }
        public List<Sucursal> sucursal { get; set; }
    }
}

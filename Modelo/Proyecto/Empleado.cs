using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Proyecto
{
    public class Empleado : IDBEntity
    {
        public int Empleadoid { get; set; }
        public string NombreCliente {get; set;}
        public int Edad { get; set; }
        public string FuncionEmpresarial { get; set; }
        public int Empresaid { get; set; }
        public Empresa Empresa { get; set; }
        public int Facturaid { get; set; }
        public Factura Factura { get; set; }
    }
}

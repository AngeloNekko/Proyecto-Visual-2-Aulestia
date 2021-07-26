using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Proyecto
{
    public class Producto : IDBEntity
    {
        public int ProductoId { get; set; }
        public string nombreProducto { get; set; }
        public DateTime FechaLanzamiento { get; set; }
        public float precio { get; set; }
        public int CategoriaId { get; set; }
        public Categoria categoria { get; set; }
        public int Facturaid { get; set; }
        public Factura factura { get; set; }
    }
}

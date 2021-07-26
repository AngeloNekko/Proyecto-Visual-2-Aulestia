using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Proyecto
{
    public class Categoria : IDBEntity
    {
        public int CategoriaId { get; set; }
        public string NombreCategoria { get; set; }
        public Producto Producto { get; set; }
    }
}

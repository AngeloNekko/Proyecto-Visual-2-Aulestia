using System.Collections.Generic;
using Modelo.Proyecto;
using Modelo;
namespace Escenarios
{
    public class Escenario
    {
        public enum ListaTipo
        {
            Localizacion, Empresa, Empleado, Sucursal, Producto, Categoria
        };
        public Dictionary<ListaTipo, IEnumerable<IDBEntity>> datos;

        public Escenario()
        {
            datos = new();
        }
    }
}

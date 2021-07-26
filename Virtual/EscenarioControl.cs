using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Escenarios;
using Modelo.Proyecto;
using static Escenarios.Escenario;

namespace Virtual
{
    class EscenarioControl
    {
        public void Grabar(IEscenario escenario)
        {
            var datos = escenario.Carga();
            using (var db = new SchoolContext())
            {
                //Reiniciamos la Base de datos
                db.Database.EnsureDeleted();
                db.Database.EnsureCreated();
                //Insertamos los datos
                db.localizacion.AddRange((List<Localizacion>)datos[ListaTipo.Localizacion]);
                db.categoria.AddRange((List<Categoria>)datos[ListaTipo.Categoria]);
                db.empleado.AddRange((List<Empleado>)datos[ListaTipo.Empleado]);
                db.empresa.AddRange((List<Empresa>)datos[ListaTipo.Empresa]);
                db.producto.AddRange((List<Producto>)datos[ListaTipo.Producto]);
                db.sucursal.AddRange((List<Sucursal>)datos[ListaTipo.Sucursal]);
                //Genera la persistencia
                db.SaveChanges();
            }
        }
    }
}

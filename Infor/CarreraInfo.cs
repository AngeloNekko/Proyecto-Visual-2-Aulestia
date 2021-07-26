using Infor;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infor
{
    public class CarreraInfo
    {
        public string Publicar(IDBEntity entidad)
        {
            Carrera carrera = (Carrera)entidad;
            return string.Format(
                " {0} \n {1} \n {2}",
                carrera.CarreraId,
                carrera.CostoCredito,
                carrera.Nombre
                );
        }
        public string Publicar(List<Carrera> ListaEntidad)
        {
            string infor = "";
            foreach (var item in ListaEntidad)
            {
                infor += this.Publicar(item);
            }
            return infor;
        }
    }
}

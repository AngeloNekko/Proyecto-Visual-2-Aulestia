using Infor;
using Modelo;
using Modelo.Escuela;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual
{
    public class PeriodoInfo : IEntityInfor
    {        public string Publicar(IDBEntity entidad)
        {
            Periodo perdiodo = (Periodo)entidad;
            return string.Format(
                " {0} \n {1} \n {2} \n {3}",
                perdiodo.PeriodoId,
                perdiodo.Estado,
                perdiodo.FechaInicio,
                perdiodo.FechaFin
                );
        }
        public string Publicar(List<Periodo> ListaEntidad)
        {
            string infor = "";
            foreach(var item in ListaEntidad)
            {
                infor += this.Publicar(item);
            }
            return infor;
        }
    }
}

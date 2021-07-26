using Infor;
using Modelo;
using Modelo.Escuela;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infor
{
    public class prerequisistoInfo
    {
        public string Publicar(IDBEntity entidad)
        {
            Prerequisito pre = (Prerequisito)entidad;
            return string.Format(
                " {0} \n {1}",
                pre.MallaId,
                pre.MateriaId
                );
        }
        public string Publicar(List<Prerequisito> ListaEntidad)
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

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
    public class materiaInfo
    {
        public string Publicar(IDBEntity entidad)
        {
            Materia materia = (Materia)entidad;
            return string.Format(
                " {0} \n {1} \n {2} \n {3}",
                materia.MateriaId,
                materia.Nombre,
                materia.Area,
                materia.Creditos
                );
        }
        public string Publicar(List<Materia> ListaEntidad)
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

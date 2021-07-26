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
    public class mallaInfo
    {
        public string Publicar(IDBEntity entidad)
        {
            Malla malla = (Malla)entidad;
            return string.Format(
                " {0} \n {1} \n {2} \n {3}",
                malla.MallaId,
                malla.Nivel,
                malla.CarreraId,
                malla.MateriaId
                );
        }
        public string Publicar(List<Malla> ListaEntidad)
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

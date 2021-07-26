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
    public class CursosInfo
    {
        public string Publicar(IDBEntity entidad)
        {
            Curso curso = (Curso)entidad;
            return string.Format(
                " {0} \n {1} \n {2} \n {3} \n {4} \n {5} \n {6}",
                curso.CursoId,
                curso.Nombre,
                curso.FechaInicio,
                curso.FechaFin,
                curso.Jornada,
                curso.Periodo,
                curso.Materia
                );
        }
        public string Publicar(List<Curso> ListaEntidad)
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

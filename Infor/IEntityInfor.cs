using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
namespace Infor
{
    public interface IEntityInfor
    {
        public string Publicar(IDBEntity entidad);
    }
}

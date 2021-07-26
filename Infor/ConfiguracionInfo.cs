using Modelo.Escuela;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual
{
    public class ConfiguracionInfo
    {
        static public String Publicar(Configuracion configuracion)
        {
            return string.Format("instruccion: {0} \n Periodo: {1} \n NotaMinima: {2} \n Pesos: {3} {4} {5} \n PeriodoVigente: {6}", 
                configuracion.EscuelaNombre, 
                configuracion.PeriodoVigente, 
                configuracion.NotaMinima,
                configuracion.PesoNota1,
                configuracion.PesoNota2,
                configuracion.PesoNota3,
                configuracion.PeriodoVigenteId
                );
        }
    }
}

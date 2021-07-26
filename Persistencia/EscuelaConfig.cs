using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Virtual;

namespace Persistencia
{
    public class EscuelaConfig
    {
        static public string PersistenciaDestino;
        static public string connectionString;
        static public bool modoVirtual;
        static public string DBMemory;

        static EscuelaConfig() {
            //Lectura de los parámetros del sistema
            PersistenciaDestino = ConfigurationManager.AppSettings["PersistenciaDestino"].ToString();
            connectionString = ConfigurationManager.ConnectionStrings[PersistenciaDestino].ToString();
            //Debug
            Console.WriteLine(PersistenciaDestino + " " + connectionString);
        }

        static public DbContextOptions<SchoolContext> ContextOptions()
        {

            DbContextOptions<SchoolContext> opciones = null;
            modoVirtual = false;
            switch (PersistenciaDestino)
            {
                case "SQLServerProyecto":
                    opciones = new DbContextOptionsBuilder<SchoolContext>()
                        .UseSqlServer(connectionString)
                        .Options;
                    break;
                case "PostgresProyecto":
                    opciones = new DbContextOptionsBuilder<SchoolContext>()
                        .UseNpgsql(connectionString)
                        .Options;
                    break;
                case "memoriaEscuela":
                    if (modoVirtual)
                    {
                        opciones = new DbContextOptionsBuilder<SchoolContext>()
                            .UseInMemoryDatabase(connectionString)
                            .Options;  
                    }
                    break;
                default:
                    break;
            }
            return opciones;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Modelo.Proyecto;
using Persistencia;

namespace Virtual
{
    public class SchoolContext : DbContext
    {
        public DbSet<Localizacion> localizacion { get; set; }
        public DbSet<Categoria> categoria{ get; set; }
        public DbSet<Comprobante> comprobante { get; set; }
        public DbSet<Empleado> empleado { get; set; }
        public DbSet<Empresa> empresa { get; set; }
        public DbSet<Factura> factura { get; set; }
        public DbSet<Producto> producto { get; set; }
        public DbSet<Sucursal> sucursal { get; set; }

        // Constructor vacio
        public SchoolContext() : base()
        {

        }

        // Constructor para pasar la conexión al padre
        public SchoolContext(DbContextOptions<SchoolContext> opciones)
            : base(opciones)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            if (!optionsBuilder.IsConfigured)
            {
                switch (EscuelaConfig.PersistenciaDestino) {
                    case "SQLServerProyecto":
                        optionsBuilder.UseSqlServer(EscuelaConfig.connectionString);
                        break;
                    case "PostgresProyecto":
                        optionsBuilder.UseNpgsql(EscuelaConfig.connectionString);
                        break;
                    case "memoriaEscuela":
                        optionsBuilder.UseInMemoryDatabase(EscuelaConfig.connectionString);
                        break;
                }
            }

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            // Relación uno a muchos; una Empresa tiene varios Empleados
            modelBuilder.Entity<Empleado>()
                .HasOne(mat => mat.Empresa)
                .WithMany(est => est.empleado)
                .HasForeignKey(mat => mat.Empresaid);
            // Relación uno a muchos; una Empresa tiene varias sucursales
            modelBuilder.Entity<Sucursal>()
                .HasOne(mat => mat.empresa)
                .WithMany(est => est.sucursal)
                .HasForeignKey(mat => mat.EmpresaId);
            //relacion uno a uno de localizacion a Sucursal
            modelBuilder.Entity<Localizacion>()
                .HasOne(malla => malla.sucursal)
                .WithOne(mat => mat.localizacion)
                .HasForeignKey<Sucursal>(malla => malla.LocalizacionId);
            //relacion uno a uno de Producto a categoria
            modelBuilder.Entity<Categoria>()
                .HasOne(malla => malla.Producto)
                .WithOne(mat => mat.categoria)
                .HasForeignKey<Producto>(malla => malla.CategoriaId);
            // Relación uno a uno; una Factura tiene un productos
            modelBuilder.Entity<Producto>()
                .HasOne(malla => malla.factura)
                .WithOne(mat => mat.producto)
                .HasForeignKey<Factura>(malla => malla.productoId);
            //relacion uno a uno de factura y empleado
            modelBuilder.Entity<Empleado>()
                .HasOne(malla => malla.Factura)
                .WithOne(mat => mat.empleado)
                .HasForeignKey<Factura>(malla => malla.EmpleadoId);
        }

    }
}

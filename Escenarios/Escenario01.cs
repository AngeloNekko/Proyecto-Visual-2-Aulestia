using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Escenarios.Escenario;
using Modelo.Proyecto;
using Modelo;

namespace Escenarios
{
    public class Escenario01 : Escenario, IEscenario
    {
        public Dictionary<ListaTipo, IEnumerable<IDBEntity>> Carga()
        {
            //Creación de Localizacion
            Localizacion Azuay = new()
            {
                Provincia = "Azuay",
                Canton = "Cuenca",
                Parroquia = "Baños"
            };
            Localizacion Bolivar = new()
            {
                Provincia = "Bolivar",
                Canton = "San Miguel",
                Parroquia = "Bilovan"
            };
            Localizacion Cañar = new()
            {
                Provincia = "Cañar",
                Canton = "Cañar",
                Parroquia = "Ventura"
            };
            Localizacion Cotopaxi = new()
            {
                Provincia = "Cotopaxi",
                Canton = "Pugili",
                Parroquia = "Pugili"
            };
            Localizacion Oro = new()
            {
                Provincia = "El Oro",
                Canton = "Portovelo",
                Parroquia = "Protovelo"
            };
            Localizacion Pichincha = new()
            {
                Provincia = "Pichincha",
                Canton = "Quito",
                Parroquia = "ATAHUALPA"
            };
            List<Localizacion> LtLocal = new()
            {
                Azuay, Bolivar, Cañar, Cotopaxi, Oro, Pichincha
            };

            datos.Add(ListaTipo.Localizacion, LtLocal);
            //Creacion de empresa
            Empresa TQ1 = new()
            {
                NombreEmpresa = "TQ1-Proyecto",
            };
            Empresa TQ2 = new()
            {
                NombreEmpresa = "TQ2-Proyecto",
            };
            Empresa TQ3 = new()
            {
                NombreEmpresa = "TQ3-Proyecto",
            };
            Empresa TQ4 = new()
            {
                NombreEmpresa = "TQ4-Proyecto",
            };
            Empresa TQ5= new()
            {
                NombreEmpresa = "TQ5-Proyecto",
            };
            List<Empresa> LTEmpresa = new()
            {
                TQ1, TQ2, TQ3, TQ4, TQ5
            };
            datos.Add(ListaTipo.Empresa, LTEmpresa);
            //creacion de empleado
            Empleado Riky = new()
            {
                NombreCliente = "Ricky Uno",
                Edad = 45,
                FuncionEmpresarial = "Comerciante",
                Empresa = TQ1
            };
            Empleado Ronald = new()
            {
                NombreCliente = "Ronald Dos",
                Edad = 30,
                FuncionEmpresarial = "Contador",
                Empresa = TQ2
            };
            Empleado Angelo = new()
            {
                NombreCliente = "Angelo Tres",
                Edad = 20,
                FuncionEmpresarial = "Contactante",
                Empresa = TQ3
            };
            Empleado Fernandez = new()
            {
                NombreCliente = "Fernandez Cuatro",
                Edad = 24,
                FuncionEmpresarial = "Sistemas",
                Empresa = TQ4
            };
            Empleado Wilson = new()
            {
                NombreCliente = "Wilson Cinco",
                Edad = 65,
                FuncionEmpresarial = "Concerje",
                Empresa = TQ5
            };
            List<Empleado> LTEmpleados = new()
            {
                Riky,
                Ronald,
                Angelo,
                Fernandez,
                Wilson
            };

            datos.Add(ListaTipo.Empleado, LTEmpleados);
            //Creacion de las sucursales
            Sucursal sucursal1 = new()
            {
                NombreSucursal = "TQ1-Azuay",
                localizacion=Azuay,
                empresa=TQ1
            };
            Sucursal sucursal2 = new()
            {
                NombreSucursal = "TQ1-Quito",
                localizacion = Pichincha,
                empresa = TQ1
            };
            Sucursal sucursal3 = new()
            {
                NombreSucursal = "TQ2-Azuay",
                localizacion = Azuay,
                empresa = TQ2
            };
            Sucursal sucursal4 = new()
            {
                NombreSucursal = "TQ3-Azuay",
                localizacion = Azuay,
                empresa = TQ3
            };
            Sucursal sucursal5 = new()
            {
                NombreSucursal = "TQ4-Cotopaxi",
                localizacion = Cotopaxi,
                empresa = TQ4
            };
            Sucursal sucursal6 = new()
            {
                NombreSucursal = "TQ1-Cotopaxi",
                localizacion = Cotopaxi,
                empresa = TQ1
            };
            Sucursal sucursal7 = new()
            {
                NombreSucursal = "TQ2-Oro ",
                localizacion = Oro,
                empresa = TQ2
            };
            Sucursal sucursal8 = new()
            {
                NombreSucursal = "TQ5-Cañar",
                localizacion = Cañar,
                empresa = TQ5
            };
            Sucursal sucursal9 = new()
            {
                NombreSucursal = "TQ5-pichincha",
                localizacion = Pichincha,
                empresa = TQ5
            };
            Sucursal sucursal10 = new()
            {
                NombreSucursal = "TQ5-Azuay",
                localizacion = Azuay,
                empresa = TQ5
            };
            List<Sucursal> LTSucursal= new()
            {
                sucursal1, sucursal2, sucursal3, sucursal4, sucursal5, sucursal6, sucursal7, sucursal8, sucursal9, sucursal10
            };
            datos.Add(ListaTipo.Sucursal, LTSucursal);
            //Creacion de categoria
            Categoria basica = new()
            {
                NombreCategoria="Categoria Basica"
            };
            Categoria rara = new()
            {
                NombreCategoria = "Categoria Rara"
            };
            Categoria superrara = new()
            {
                NombreCategoria = "Categoria Super rara"
            };
            Categoria anormal = new()
            {
                NombreCategoria = "Categoria anormal"
            };
            List<Categoria> LTCategoria = new()
            {
                basica, rara, superrara, anormal
            };
            datos.Add(ListaTipo.Categoria, LTCategoria);
            //Creacion de producto
            Producto paqueteCarta1 = new()
            {
                nombreProducto="Paqueta Basica",
                FechaLanzamiento= new DateTime(2020, 9, 1),
                categoria=basica,
                precio=5.55f
            };
            Producto paqueteCarta2 = new()
            {
                nombreProducto = "Paqueta Rara",
                FechaLanzamiento = new DateTime(2020, 10, 1),
                categoria = rara,
                precio = 10.55f
            };
            Producto paqueteCarta3 = new()
            {
                nombreProducto = "Paqueta Super Rara",
                FechaLanzamiento = new DateTime(2020, 11, 1),
                categoria = basica,
                precio = 6.33f
            };
            Producto paqueteCarta4 = new()
            {
                nombreProducto = "Paqueta Anormal",
                FechaLanzamiento = new DateTime(2020, 12, 1),
                categoria = anormal,
                precio = 16.52f
            };
            Producto paqueteCarta5= new()
            {
                nombreProducto = "Paqueta Basica 2",
                FechaLanzamiento = new DateTime(2021, 1, 1),
                categoria = basica,
                precio = 10.55f
            };
            Producto paqueteCarta6 = new()
            {
                nombreProducto = "Paqueta Raro 2",
                FechaLanzamiento = new DateTime(2021, 2, 1),
                categoria = rara,
                precio = 11.55f
            };
            Producto paqueteCarta7 = new()
            {
                nombreProducto = "Paqueta Super raro 2",
                FechaLanzamiento = new DateTime(2021, 3, 1),
                categoria = superrara,
                precio = 20.10f
            };
            Producto paqueteCarta8 = new()
            {
                nombreProducto = "Paqueta Anormal 2",
                FechaLanzamiento = new DateTime(2021, 4, 1),
                categoria = anormal,
                precio = 5.12f
            };
            Producto paqueteCarta9 = new()
            {
                nombreProducto = "Paqueta Basica 3",
                FechaLanzamiento = new DateTime(2021, 5, 1),
                categoria = basica,
                precio = 5.25f
            };
            List<Producto> LTProducto = new()
            {
                paqueteCarta1, paqueteCarta2, paqueteCarta3, paqueteCarta4, paqueteCarta5, paqueteCarta6, paqueteCarta7, paqueteCarta8, paqueteCarta9
            };
            datos.Add(ListaTipo.Producto, LTProducto);
            //Retorno el diccionario
            return datos;
        }
    }
}

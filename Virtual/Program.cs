using Modelo.Proyecto;
using Modelo;
using System;
using System.Collections.Generic;
using static Modelo.DBEntity;
using Escenarios;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Virtual
{
    class Program
    {
        static void Main(string[] args)
        {

            var Escenario = new Escenario01();
            var EscenarioControl = new EscenarioControl();
            EscenarioControl.Grabar(Escenario);
            using (var db = new SchoolContext())
            {
                //Generar el codigo del comprobante
                var characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
                var Charsarr = new char[8];
                var random = new Random();

                for (int i = 0; i < Charsarr.Length; i++)
                {
                    Charsarr[i] = characters[random.Next(characters.Length)];
                }

                var resultString = new String(Charsarr);
                //Creacion fanctura 1
                //nombre cliente
                var nombreClie = db.empleado.Single(em=>em.NombreCliente== "Ricky Uno");
                //nombre Producto a comprar
                var producto = db.producto.Single(pro => pro.nombreProducto == "Paqueta Basica 3");
                //Tipo de pago
                string tipo = "Efectivo";
                //Fecha de salida Factura
                DateTime Fecha = new DateTime(2021, 4, 1);
                //Fecha de registado
                DateTime FechaRegis = new DateTime(2021, 4, 2);
                db.factura.Add(GeneramosFactura(db, nombreClie.NombreCliente, producto.nombreProducto, tipo, Fecha, FechaRegis, resultString));
                db.SaveChanges();
                db.comprobante.Add(comprobante(db, resultString));
                db.SaveChanges();
            }
            using (var db = new SchoolContext())
            {
                //Generar el codigo del comprobante
                var characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
                var Charsarr = new char[8];
                var random = new Random();

                for (int i = 0; i < Charsarr.Length; i++)
                {
                    Charsarr[i] = characters[random.Next(characters.Length)];
                }

                var resultString = new String(Charsarr);
                //Creacion fanctura 2
                //nombre cliente
                var nombreClie = db.empleado.Single(em => em.NombreCliente == "Angelo Tres");
                //nombre Producto a comprar
                var producto = db.producto.Single(pro => pro.nombreProducto == "Paqueta Raro 2");
                //Tipo de pago
                string tipo = "Tarjeta";
                //Fecha de salida Factura
                DateTime Fecha = new DateTime(2021, 4, 1);
                //Fecha de registado
                DateTime FechaRegis = new DateTime(2021, 8 , 2);
                db.factura.Add(GeneramosFactura(db, nombreClie.NombreCliente, producto.nombreProducto, tipo, Fecha, FechaRegis, resultString));
                db.SaveChanges();
                db.comprobante.Add(comprobante(db, resultString));
                db.SaveChanges();
            }
            using (var db = new SchoolContext())
            {
                //Generar el codigo del comprobante
                var characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
                var Charsarr = new char[8];
                var random = new Random();

                for (int i = 0; i < Charsarr.Length; i++)
                {
                    Charsarr[i] = characters[random.Next(characters.Length)];
                }

                var resultString = new String(Charsarr);
                //Creacion fanctura 3
                //nombre cliente
                var nombreClie = db.empleado.Single(em => em.NombreCliente == "Wilson Cinco");
                //nombre Producto a comprar
                var producto = db.producto.Single(pro => pro.nombreProducto == "Paqueta Super raro 2");
                //Tipo de pago
                string tipo = "Efectivo";
                //Fecha de salida Factura
                DateTime Fecha = new DateTime(2021, 12, 31);
                //Fecha de registado
                DateTime FechaRegis = new DateTime(2022, 1, 1);
                db.factura.Add(GeneramosFactura(db, nombreClie.NombreCliente, producto.nombreProducto, tipo, Fecha, FechaRegis, resultString));
                db.SaveChanges();
                db.comprobante.Add(comprobante(db, resultString));
                db.SaveChanges();
            }

        }
        public static Factura GeneramosFactura(SchoolContext context, string nombreCliente, string productoCompra, string tipoCompra, DateTime fechaSalida, DateTime fecharegistro, string codigo)
        {
            //1.-consulta Cliente
            Empleado empleado = context.empleado.Single(em => em.NombreCliente == nombreCliente);
            //2.-Consulta de producto
            Producto producto = context.producto.Single(pro => pro.nombreProducto == productoCompra);
            //3.-Sacamos el subtotal = Valor del producto
            float valorParcial;
            float valoriva;
            float valotTotal=0;
            int des;
            valorParcial = producto.precio;
            valoriva = valorParcial * 12;
            if (tipoCompra=="Efectivo")
            {
                des = 50;
            }
            else
            {
                des = 10;
            }
            valotTotal += valorParcial + valoriva - des;
            valotTotal = MathF.Round(valotTotal, 2);
            //3.-Generamos la factura
            Factura factura = new()
            {
                empleado = empleado,
                producto = producto,
                FechaCreacion = fechaSalida,
                FechaRegistro = fecharegistro,
                TipoCompra = tipoCompra,
                Subtotal = valorParcial,
                Descuento = des,
                TotalPagar = valotTotal,
                codCompro= codigo
            };
            return factura;
        }
        public static Comprobante comprobante(SchoolContext context, string factura)
        {
            //1.-Comprobamos la factura
            Factura factu = context.factura.Single(em => em.codCompro == factura);
            //2.-Comporbamos si es valida mediante las fechas
            bool esta;
            DateTime fechainicio = factu.FechaCreacion;
            DateTime fechacompro = factu.FechaRegistro;
            if (fechacompro == fechainicio.AddDays(1))
            {
                esta = true;
            }
            else
            {
                esta = false;
            }
            //3.-registramos comprobante
            Comprobante comprop = new()
            {
                Codigo = factura,
                EstadoFactura=esta
            };
            return comprop;
        }
    }

}

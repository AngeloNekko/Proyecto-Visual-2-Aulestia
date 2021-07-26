using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Proyecto
{
    public class Factura : IDBEntity
    {
        public int FacturaId { get; set; }
        public int EmpleadoId { get; set; }
        public Empleado empleado { get; set;}
        public int productoId { get; set; }
        public Producto producto { get; set; }
        public float Subtotal { get; set; }
        public float Descuento { get; set; }
        public float TotalPagar { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string TipoCompra { get; set; }
        public string codCompro { get; set; }

        public bool comparativo(float Subtotal, string TipoCompra, float TotalPagar)
        {
            bool respu;
            float descuento;
            float iva;
            float Resultado;
            if (TipoCompra=="Efectivo")
            {
                descuento = Subtotal -50;
                iva = Subtotal * 2;
                Resultado = descuento + iva;
                Resultado =MathF.Round(Resultado, 2);

            }
            else
            {
                descuento = Subtotal - 10;
                iva = Subtotal * 2;
                Resultado = descuento + iva;
                Resultado = MathF.Round(Resultado, 2);
            }
            respu = Resultado >0;
            return respu;
        }
        public bool Certificado(DateTime fechai, DateTime fechaCer)
        {
            bool respu;
            DateTime Compartivo = fechai;
            if (Compartivo.AddDays(1)==fechaCer)
            {
                respu = true;
            }
            else
            {
                respu = false;
            }
            return respu;
        }
    }
}

using Modelo.Proyecto;
using System;
using Xunit;

namespace Pruebas
{
    public class PrubasCuantitativas
    {
        [Theory]
        [InlineData(10.51, "Efectivo", 28.98, false)]
        [InlineData(6.99, "Tarjeta",3.98, true)]
        [InlineData(10.16, "Efectivo", 29.68, false)]
        [InlineData(15.68, "Tarjeta", 21.36, true)]
        [InlineData(20.69, "Efectivo", 8.62, true)]
        [InlineData(10.45, "Tarjeta", 10.90, true)]
        [InlineData(5.12, "Efectivo", 39.57, false)]
        [InlineData(2.64, "Tarjeta", 4.92, false)]
        [InlineData(5.42, "Efectivo", 39.16, false)]
        [InlineData(7.46, "Tarjeta", 4.92, true)]
        [InlineData(9.32, "Efectivo", 31.36, false)]
        [InlineData(10.25, "Tarjeta", 10.50, true)]
        [InlineData(15.30, "Efectivo", 19.40, false)]
        [InlineData(14.47, "Tarjeta", 18.94, true)]
        [InlineData(10.51, "Tarjeta", 11.02, true)]
        [InlineData(6.99, "Efectivo", 10.36, false)]
        [InlineData(10.16, "Tarjeta", 10.32, true)]
        [InlineData(15.68, "Efectivo", 18.64, false)]
        [InlineData(20.69, "Tarjeta", 19.65, true)]
        [InlineData(10.45, "Efectivo", 9.10, false)]
        [InlineData(5.12, "Tarjeta", 0.24, true)]
        [InlineData(2.64, "Efectivo", 44.72, false)]
        [InlineData(5.42, "Tarjeta", 0.84, true)]
        [InlineData(7.46, "Efectivo", 6.08, false)]
        [InlineData(9.32, "Tarjeta", 8.64, true)]
        [InlineData(10.25, "Efectivo", 9.25, false)]
        [InlineData(15.30, "Tarjeta", 2.60, true)]
        [InlineData(14.47, "Efectivo", 10.54, false)]




        public void CompraTotal(float sub, string pago, float totalpago, bool resultadoEsperado)
        {
            bool resReal;
            Factura factu= new Factura()
            {
                Subtotal=sub,
                TipoCompra=pago,
                TotalPagar=totalpago
            };
            sub = MathF.Round(sub, 2);
            totalpago= MathF.Round(totalpago, 2);
            resReal = factu.comparativo(sub,pago,totalpago);
            if (resultadoEsperado)
            {
                Assert.True(resReal);
            }
            else
            {
                Assert.False(resReal);
            }
        }
    }
}

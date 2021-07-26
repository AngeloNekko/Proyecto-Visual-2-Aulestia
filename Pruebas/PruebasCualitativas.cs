using Modelo.Proyecto;
using System;
using Xunit;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas
{

    public class PruebasCualitativas
    {
        [Theory]
        [InlineData("2021/6/1", "2021/6/2", true)]
        [InlineData("2021/7/1", "2021/7/8", false)]
        [InlineData("2021/8/2", "2021/8/3", true)]
        [InlineData("2021/9/10", "2021/9/11", true)]
        [InlineData("2021/10/1", "2021/10/8", false)]
        [InlineData("2021/11/2", "2021/11/3", true)]
        [InlineData("2021/6/11", "2021/6/12", true)]
        [InlineData("2021/12/1", "2021/12/10", false)]
        [InlineData("2021/10/2", "2021/10/3", true)]
        [InlineData("2021/4/1", "2021/4/2", true)]
        [InlineData("2021/6/1", "2021/6/8", false)]
        [InlineData("2021/7/2", "2021/7/3", true)]
        [InlineData("2021/4/26", "2021/4/27", true)]
        [InlineData("2021/9/1", "2021/9/8", false)]
        [InlineData("2021/12/31", "2022/1/1", true)]
        [InlineData("2021/10/1", "2021/10/2", true)]
        [InlineData("2021/12/1", "2021/12/8", false)]
        [InlineData("2021/7/24", "2021/7/25", true)]
        [InlineData("2021/5/14", "2021/5/15", true)]
        [InlineData("2021/5/10", "2021/5/8", false)]
        [InlineData("2021/6/2", "2021/6/3", true)]
        [InlineData("2021/1/1", "2021/1/2", true)]
        [InlineData("2021/3/1", "2021/3/8", false)]
        [InlineData("2021/5/2", "2021/5/3", true)]
        [InlineData("2021/8/1", "2021/8/2", true)]
        [InlineData("2022/3/1", "2022/3/8", false)]
        [InlineData("2022/1/2", "2022/1/3", true)]
        [InlineData("2022/10/2", "2022/10/3", true)]

        public void Certificado(string fechaini, string fechaCerti, bool resultadoEsperado)
        {
            bool resReal;
            DateTime ini = new DateTime();
            DateTime ceti = new DateTime();
            ini = DateTime.Parse(fechaini);
            ceti = DateTime.Parse(fechaCerti);

            Factura factu = new Factura()
            {
                FechaCreacion = DateTime.Parse(fechaini),
                FechaRegistro = DateTime.Parse(fechaCerti)
            };
            resReal=factu.Certificado(ini,ceti);
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

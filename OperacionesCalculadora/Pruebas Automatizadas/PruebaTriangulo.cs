using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Pruebas_Automatizadas
{
    [TestClass]
    public class PruebaTriangulo
    {
        [TestMethod]
        public void TrianguloInvalido()
        {
            double primerlado = 5;
            double segundolado = 5;
            double tercerlado = 19;


            ResolverEcuacionCuadratica ecuacionCuadratica = new ResolverEcuacionCuadratica();
            // invoque al método correspondiente
            ecuacionCuadratica.ResolverLaEcuacionCuadratica(primerNumero,
                        segundoNumero, tercerNumero, ref primeraRaizReal, ref segundaRaizReal);

            Assert.IsTrue((primeraRaizEsperada == primeraRaizReal) ||
                          (primeraRaizEsperada == segundaRaizReal));
            Assert.IsTrue((segundaRaizEsperada == primeraRaizReal) ||
                          (segundaRaizEsperada == segundaRaizReal));
        }
    }
}

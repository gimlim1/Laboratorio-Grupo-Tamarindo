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
            double primerlado = -1;
            double segundolado = 2;
            double tercerlado = 3;
            double primeraRaizReal = 0;
            double segundaRaizReal = 0;
            double primeraRaizEsperada = 3;
            double segundaRaizEsperada = -1;

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

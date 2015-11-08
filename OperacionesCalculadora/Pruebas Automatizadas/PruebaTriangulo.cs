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
            double lado1 = 5;
            double lado2 = 5;
            double lado3 = 19;
            OperacionesCalculadora.Validaciones.ValidarTriangulo validar = new OperacionesCalculadora.Validaciones.ValidarTriangulo();

            Assert.IsFalse(validar.Validar(lado1, lado2, lado3));

        }
    }
}

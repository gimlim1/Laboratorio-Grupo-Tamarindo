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

        [TestMethod]
        public void Triangulovalido()
        {
            double lado1 = 5;
            double lado2 = 6;
            double lado3 = 5;
            double areacorrecta = 12;
            double areaprueba;
            double perimetrocorrecto = 16;
            double perimetroprueba;

            OperacionesCalculadora.Acciones.ResolverTriangulo areatriangulo = new OperacionesCalculadora.Acciones.ResolverTriangulo();
            areaprueba = areatriangulo.Resolver(lado1, lado2, lado3,"A");
            perimetroprueba = areatriangulo.Resolver(lado1, lado2, lado3, "P");
            Assert.IsTrue(areacorrecta == areaprueba);
            Assert.IsTrue(perimetrocorrecto == perimetroprueba);
        }





    }
}

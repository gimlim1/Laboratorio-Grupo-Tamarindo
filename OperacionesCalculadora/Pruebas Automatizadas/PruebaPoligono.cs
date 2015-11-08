using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Pruebas_Automatizadas
{
    [TestClass]
    public class PruebaPoligono
    {
        [TestMethod]
        public void PoligonoInvalido()
        {
            double lados = 0;
            double Lvalor = 5;
            
            OperacionesCalculadora.Validaciones.ValidarPoligono validar = new OperacionesCalculadora.Validaciones.ValidarPoligono();

            Assert.IsFalse(validar.Validacionlados(lados));
            Assert.IsFalse(validar.ValidarCero(lados,Lvalor));

        }

        [TestMethod]
        public void Poligonovalido()
        {
            double lados = 6;
            double Lvalor = 4;
            double areacorrecta = 41.57;
            double areaprueba;
            double perimetrocorrecto = 24;
            double perimetroprueba;
            OperacionesCalculadora.Acciones.ResolverPoligono areapoligono = new OperacionesCalculadora.Acciones.ResolverPoligono();
            areaprueba = areapoligono.Resolver(lados,Lvalor, "A");
            perimetroprueba = areapoligono.Resolver(lados, Lvalor, "P");

            Assert.IsTrue(areacorrecta == areaprueba);
            Assert.IsTrue(perimetrocorrecto==perimetroprueba);
        }
    }
}

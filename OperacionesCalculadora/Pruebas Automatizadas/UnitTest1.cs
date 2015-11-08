using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;



namespace Pruebas_Automatizadas
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestingCuadrado()
        {
            //  •	Medida de lado es menor o igual a cero(0).
            //  •	Medida de la altura es menor o igual a cero (0).
            
            //Declarar variables para los parametros reales 
            //Decalrar variables requeridos para los valores reales 
            double areareal = 16;
            double perimetro = 16;
            double ladoerroneo1 = 1;
            double ladoerrone2 = 2;
            double ladoerrone3 = 0;
            double angulo;

            //Declarar variables requeridas para los valores esperados.
            //Construir logica de la prueba.

            OperacionesCalculadora.Acciones.ResolverTriangulo Triangulo = new OperacionesCalculadora.Acciones.ResolverTriangulo();
            Triangulo. 
            

            //Validar que los valores reales son inguales que los esperados
            

        }
    }
}

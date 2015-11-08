using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Pruebas_Automatizadas
{
    [TestClass]
    public class PruebaCuadraticos
    {
        // prueba cuando la altura es menor que cero
        [TestMethod]
        public void PruebaMenorquecero()
        {

            double lado1 = 1;
            double lado2 = 2;
            double altura = -2;
            int figura = 1;
            string Operacion = "A";

            OperacionesCalculadora.Acciones.ResolverCuadraticos resolver = new OperacionesCalculadora.Acciones.ResolverCuadraticos();

            Assert.IsTrue(resolver.Resolver(lado1,lado2,altura,figura,Operacion)==0);
        }

        // prueba cuando un altura es igual a cero
        [TestMethod]
        public void Pruebaigualcero()
        {

            double lado1 = 1;
            double lado2 = 2;
            double altura = 0;
            int figura = 1;
            string Operacion = "A";

            OperacionesCalculadora.Acciones.ResolverCuadraticos resolver = new OperacionesCalculadora.Acciones.ResolverCuadraticos();

            Assert.IsTrue(resolver.Resolver(lado1, lado2, altura, figura, Operacion) == 0);
        }
        //prueba cuando la altura es menor que cero
        [TestMethod]
        public void Prueba_alturamenorquecero()
        {

            double lado1 = 1;
            double lado2 = 4;
            double altura = -3;
            int figura = 1;
            string Operacion = "A";

            OperacionesCalculadora.Acciones.ResolverCuadraticos resolver = new OperacionesCalculadora.Acciones.ResolverCuadraticos();

            Assert.IsTrue(resolver.Resolver(lado1, lado2, altura, figura, Operacion) == 0);
        }

        //Prueba correcta de resolver el cuadratico: rombo, se va resolver el area
        [TestMethod]
        public void PruebaCorrectaRombo()
        {

            double diagonalmenor = 4;
            double diagonalmayor = 7;
            double area = 0;
            double areaesperada = 14;
            int figura = 4;
            string Operacion = "A";

            OperacionesCalculadora.Acciones.ResolverCuadraticos resolver = new OperacionesCalculadora.Acciones.ResolverCuadraticos();
            area = resolver.Resolver(diagonalmenor, diagonalmayor, 0, figura, Operacion);
            Assert.IsTrue(area==areaesperada);
        }
        //Prueba correcta de resolver el cuadratico: trapecio, se va resolver el area
        [TestMethod]
        public void PruebaCorrectaPerimetroTrapecio()
        {

            double lado1 = 10;
            double lado2 = 4;
            double perimetro = 0;
            double perimetroesperado = 23;
            int figura = 6;
            string Operacion = "P";
            OperacionesCalculadora.Acciones.ResolverCuadraticos resolver = new OperacionesCalculadora.Acciones.ResolverCuadraticos();
            perimetro = resolver.Resolver(lado1, lado2, 0, figura, Operacion);
            Assert.IsTrue(perimetro == perimetroesperado);
        }

    }
}
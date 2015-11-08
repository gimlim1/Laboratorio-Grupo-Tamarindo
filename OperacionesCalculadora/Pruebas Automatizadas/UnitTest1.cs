using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Pruebas_Automatizadas
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            OperacionesCalculadora.Acciones.ResolverPoligono resolver = new OperacionesCalculadora.Acciones.ResolverPoligono();
            resolver.Resolver(6, 12, "A");
        }
    }
}

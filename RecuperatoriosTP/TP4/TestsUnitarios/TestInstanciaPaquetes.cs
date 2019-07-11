using System;
using Entidades;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestsUnitarios
{
    [TestClass]
    public class TestInstanciaPaquetes
    {

        [TestMethod]
        public void TestMethod1()
        {
            Correo correo = new Correo();

            Assert.IsNotNull(correo.Paquetes);
        }
    }
}

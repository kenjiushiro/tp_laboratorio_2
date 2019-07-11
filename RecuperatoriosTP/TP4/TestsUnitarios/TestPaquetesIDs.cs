using System;
using Entidades;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestsUnitarios
{
    [TestClass]
    public class TestPaquetesIDs
    {
        [TestMethod]
        [ExpectedException(typeof(TrackingIdRepetidoException))]
        public void TestMethod1()
        {
            Correo correo = new Correo();

            Paquete paquete1 = new Paquete("asdf", "1231231234");
            Paquete paquete2= new Paquete("qwerty", "1231231234");

            correo += paquete1;
            correo += paquete2;

            
        }
    }
}

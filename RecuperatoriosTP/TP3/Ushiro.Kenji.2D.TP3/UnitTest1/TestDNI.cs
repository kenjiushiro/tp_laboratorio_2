using System;
using Entidades;
using EntidadesInstanciables;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest1
{
    [TestClass]
    public class TestDNI
    {
        [TestMethod]
        public void TestValorDNI()
        {
            string dniInvalido = "123asd123";

            Alumno alumno;
            alumno = new Alumno(12, "asdasd", "asdasd", "123", EntidadesAbstractas.Persona.ENacionalidad.Argentino, Universidad.EClases.Laboratorio);

            try
            {
                alumno.StringToDNI = dniInvalido;
            }
            catch (DniInvalidoException e)
            {

            }

            Assert.AreEqual((int)123, alumno.DNI);


        }
    }
}

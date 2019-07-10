using System;
using Entidades;
using EntidadesInstanciables;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest1
{
    [TestClass]
    public class TestExceptions
    {
        [TestMethod]
        public void TestExceptionNacionalidad()
        {
            string expectedMessage = "La nacionalidad no es valida";
            string messageGotten = "";


            Alumno alumno;
            try
            {
                alumno= new Alumno(12, "asdasd", "asdasd", "38521231991", EntidadesAbstractas.Persona.ENacionalidad.Argentino, Universidad.EClases.Laboratorio);

            }
            catch(NacionalidadInvalidaException e)
            {
                messageGotten = e.Message;
            }

            Assert.AreSame(messageGotten, expectedMessage);
        }

        [TestMethod]
        public void TestExceptionDNI()
        {

        }
    }
}

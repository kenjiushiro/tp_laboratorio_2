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
                alumno= new Alumno(12, "asdasd", "asdasd", "123", EntidadesAbstractas.Persona.ENacionalidad.Extranjero, Universidad.EClases.Laboratorio);

            }
            catch(NacionalidadInvalidaException e)
            {
                messageGotten = e.Message;
            }

            Assert.AreEqual(messageGotten, expectedMessage);
            
        }

        [TestMethod]
        public void TestAlumnoRepetidoException()
        {
            string expectedMessage = "El alumno ya esta inscripto";
            string messageGotten = "";

            Universidad uni = new Universidad();
            Alumno al1 = new Alumno(123, "Pepe", "Lopez", "12345", EntidadesAbstractas.Persona.ENacionalidad.Argentino, Universidad.EClases.Laboratorio, Alumno.EEstadoCuenta.AlDia);
            Alumno al2= new Alumno(123, "Carlitos", "Perez", "12345", EntidadesAbstractas.Persona.ENacionalidad.Argentino, Universidad.EClases.Laboratorio, Alumno.EEstadoCuenta.AlDia);

            uni += al1;
            try
            {
                uni += al2;
            }
            catch(AlumnoRepetidoException e)
            {
                messageGotten = e.Message;
            }


            Assert.AreEqual(messageGotten, expectedMessage);

        }
    }
}

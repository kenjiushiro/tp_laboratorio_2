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
        [ExpectedException(typeof(NacionalidadInvalidaException))]
        public void TestExceptionNacionalidad()
        {
            Alumno alumno;
            alumno= new Alumno(12, "asdasd", "asdasd", "123", EntidadesAbstractas.Persona.ENacionalidad.Extranjero, Universidad.EClases.Laboratorio);
        }

        [TestMethod]
        [ExpectedException(typeof(AlumnoRepetidoException))]
        public void TestAlumnoRepetidoException()
        {
            Universidad uni = new Universidad();
            Alumno al1 = new Alumno(123, "Pepe", "Lopez", "12345", EntidadesAbstractas.Persona.ENacionalidad.Argentino, Universidad.EClases.Laboratorio, Alumno.EEstadoCuenta.AlDia);
            Alumno al2= new Alumno(123, "Carlitos", "Perez", "12345", EntidadesAbstractas.Persona.ENacionalidad.Argentino, Universidad.EClases.Laboratorio, Alumno.EEstadoCuenta.AlDia);
            uni += al1;
            uni += al2;
        }
    }
}

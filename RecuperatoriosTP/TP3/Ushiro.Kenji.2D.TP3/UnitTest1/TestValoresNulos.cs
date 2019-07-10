using System;
using EntidadesInstanciables;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest1
{
    [TestClass]
    public class TestValoresNulos
    {
        [TestMethod]
        public void TestMethod1()
        {
            Universidad uni = new Universidad();
            Assert.IsNotNull(uni.Alumnos);
        }
    }
}

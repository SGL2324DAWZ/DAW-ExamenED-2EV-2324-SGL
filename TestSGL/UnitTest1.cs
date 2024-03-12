using ComprobadorDePassword;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ComprobadorDePassword;


namespace TestSGL
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ValidarPassVacio()
        {
            comprobadorDePassword prueba = new ComprobadorDePassword(); // no me funcionan las referencias

            prueba.Test("");

            Assert.AreEqual(-1, prueba.pwd); //si pasamos vacio el resultado del if que se espera es -1
        }

        public void ValidarPassVacio()
        {
            comprobadorDePassword prueba = new ComprobadorDePassword(); // no me funcionan las referencias

            prueba.Test("Aaa");

            Assert.AreEqual(0, prueba.pwd); //si pasamos vacio el resultado del if que se espera es 0
        }
        public void ValidarPassVacio()
        {
            comprobadorDePassword prueba = new ComprobadorDePassword(); // no me funcionan las referencias

            string pwd = prueba.Test("Aaaaaaaaaaaaaaa");

            Assert.IsTrue(pwd); //si pasamos mas de 12 carcateresdeberia dar true
        }
    }
}

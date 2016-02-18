using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Question7;

namespace UnitTest
{
    [TestClass]
    public class UnitTestuppgift7
    {
        TivoliGronaLund objG;

        [TestInitialize]
        public void setup()
        {
            objG = new TivoliGronaLund();
        }
        [TestMethod]
        public void TestOlerChilerd()
        {
            objG.Older(7);
            Assert.AreEqual("Congrats", objG.getMessage());
        }
        [TestMethod]
        public void TestOlderThan()
        {

            objG.Older(10);
            Assert.AreEqual("Younger", objG.getMessage());
        }

        [TestMethod]
        public void TestOlderYoungster()
        {

            objG.Older(16);
            Assert.AreEqual("Adults", objG.getMessage());
        }
       
       
    
    }
}

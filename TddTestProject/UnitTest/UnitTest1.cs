using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TddTestProject;
using TDDQuestion2;

namespace UnitTest
{
 

    [TestClass]
    public class UnitTestQuestion1
    {
        Immigrants immi;

        [TestInitialize]
        public void Setup()
        {
            immi = new Immigrants();
        }

        [TestMethod]
        public void TestSatrtYear()
        {
            Assert.IsFalse(Convert.ToBoolean(immi.getStartYear()));
            Assert.AreEqual(immi.getStartYear(),immi.getStartYear());
            Assert.IsNotNull(immi.getStartYear());
        }

        [TestMethod]
        public void TestEndtYear()
        {
            Assert.IsFalse(Convert.ToBoolean(immi.getEndYear()));
            Assert.AreEqual(immi.setEndYear(),immi.getEndYear());
            Assert.IsNotNull(immi.getEndYear());
        }

        [TestMethod]
        public void TestNumberOfImmigrants()
        {
            double x = immi.getAddImmigrants();
            Assert.AreEqual(x, immi.getAddImmigrants());
        }
        [TestMethod]
        public void TestNumberOfImmigrantsIncoming()
        {
            double x = immi.getIncomingImmigrants();
            Assert.AreEqual(x,immi.getIncomingImmigrants());
        }

        [TestMethod]
        public void TestNumberOfImmigrantsOutgoing()
        {
            Assert.AreEqual(300, immi.getIncomingImmigrants());
        }
    }

    [TestClass]
    public class UnitTestQuestion2
    {
        Temperature objtemper;

        [TestInitialize]
        public void Setup()
        {
            objtemper = new Temperature();
        }

        [TestMethod]
        public void TestsetTemprature()
        {
            objtemper.setTemp(20);
            double x = objtemper.getTemp();
            Assert.AreEqual(20, x);
        }

        [TestMethod]
        public void TestsetTempratureCold()
        {
            objtemper.setTemp(-50);
            double x = objtemper.getTemp();
            Assert.AreEqual(-50, x);
        }

        [TestMethod]
        public void TestsetTempratureWarm()
        {
            objtemper.setTemp(50);
            double x = objtemper.getTemp();
            Assert.AreEqual(50, x);
        }
    }



}

using System;
using MathSoHardLogic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MathSoHardTests
{
    [TestClass]
    public class UnitTest1
    {
        Derivative derivative = new Derivative();
        string testFunction;


        [TestInitialize]
        public void Initialize()
        {
            testFunction = "x^4";
        }

        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsNotNull(derivative.TakeDerivative(testFunction));
            Assert.IsTrue(derivative.TakeDerivative(testFunction) == "4x^3");
        }
    }
}

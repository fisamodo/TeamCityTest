using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vsite.Pood.TeamCityTest;

namespace UnitTestProject
{
    [TestClass]
    public class TestSquared
    {
        [TestMethod]
        public void SquaredReturns4ForArgument2()
        {
            Assert.AreEqual(4, MyMath.Squared(2));
        }
        [TestMethod]
        public void SquaredReturns0ForArgument0()
        {
            Assert.AreEqual(0, MyMath.Squared(0));
        }
        [TestMethod]
        public void SquaredReturns4ForArgumentMinus2()
        {
            Assert.AreEqual(4, MyMath.Squared(-2));
        }
    }
}

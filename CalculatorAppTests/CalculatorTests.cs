using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        [TestMethod()]
        public void sumTest()
        {
            Assert.AreEqual(Calculator.sum(-3.2, 2.1), -1.1);
        }

        [TestMethod()]
        public void minusTest()
        {
            Assert.AreEqual(Calculator.minus(4.25, 1.125), 3.125);
        }

        [TestMethod()]
        public void divideTest()
        {
            Assert.AreEqual(Calculator.divide(12, 4), 3);
        }

        [TestMethod()]
        public void divideByZeroTest()
        {
            Assert.AreEqual(Calculator.divide(12, 0), double.PositiveInfinity);
        }

        [TestMethod()]
        public void multiplyTest()
        {
            Assert.AreEqual(Calculator.multiply(1.5, 12), 18);
        }
    }
}
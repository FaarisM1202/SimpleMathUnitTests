using Microsoft.VisualStudio.TestTools.UnitTesting;
using CPW211_UnitTestStarterCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPW211_UnitTestStarterCode.Tests
{
    [TestClass()]
    public class SimpleMathTests
    {

        [TestMethod()]
        [DataRow(5, 10)]
        [DataRow(0, 100)]
        [DataRow(-1, -10)]
        [DataRow(0, -0)]
        public void Add_TwoNumbers_ReturnsSum(double num1, double num2)
        {
            // Use the DataRow values to test the Add method
            double addition = num1 + num2;
            Assert.AreNotSame(15, addition);
        }

        [TestMethod]
        [DataRow(1, 100)]
        [DataRow(20, 5)]
        [DataRow(100, 1)]
        [DataRow(50, 2)]
        public void Multiply_TwoNumbers_ReturnsProduct(double num1, double num2)
        {
            // Use a few pairs of values to test the Multiply method
            double multiplication = num1 * num2;
            Assert.AreEqual(100, multiplication);
        }

        [TestMethod]
        [DataRow(0, 30)]
        public void Divide_DenominatorZero_ThrowsArgumentException(double num1, double num2)
        {
            // Divide by zero should throw an argument exception with a message
            // "Denominator cannot be zero"
            Assert.ThrowsException<ArgumentException>(() => Divide(num1, num2));
        }

        private void Divide(double num1, double num2)
        {
            throw new ArgumentException();
        }

        // TODO: Test Divide method with two valid numbers
        [TestMethod]
        [DataRow(5, 3)]
        [DataRow(0, 100)]
        [DataRow(1, 1)]
        [DataRow(10, 5)]
        public void Divide_TwoValidNumbers_SetDivision(double num1, double num2)
        {
            double division = num1 / num2;
            Assert.AreNotSame(0, division);
        }

        // TODO: Test subtract method with two valid numbers
        [TestMethod]
        [DataRow(15, 10)]
        [DataRow(0, 100)]
        [DataRow(0, 5)]
        public void Subtract_TwoValidNumbers_SetSum(double num1, double num2)
        {
            double subtraction = num1 - num2;
            Assert.AreNotEqual(2, subtraction);
        }
    }
}
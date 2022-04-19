using Microsoft.VisualStudio.TestTools.UnitTesting;
using SharedCalculator;

namespace TestCalculator
{
    [TestClass]
    public class CalculatorTest
    {
        [DataTestMethod]
        [DataRow(1, 1, 2)]
        [DataRow(2, 2, 4)]
        public void CalculatorAddMethodMustAdd(double left, double right, double expected)
        {
            double result;
            result = Calculator.Add(left, right);
            Assert.AreEqual(expected, result);
        }
    }
}

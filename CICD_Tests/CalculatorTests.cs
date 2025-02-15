using CICD_Core;

namespace CICD_Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void Divide_TwoNumbers_ReturnsCorrectQuotient()
        {
            double result = Calculator.Divide(20, 2);
            Assert.Equal(10, result);
        }

        [Fact]
        public void Divide_NegativeNumbers_ReturnsCorrectQuotient()
        {
            double result = Calculator.Divide(-20, -2);
            Assert.Equal(10, result);
        }

        [Fact]
        public void Divide_DivideByZero()
        {
            Assert.Throws<DivideByZeroException>(() => Calculator.Divide(1, 0));
        }
    }
}
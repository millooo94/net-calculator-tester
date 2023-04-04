using NUnit.Framework;
using net_calculator_tester;

namespace Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        [TestCase(2, 3, 5)]
        [TestCase(2.1f, 3.2f, 5.3f)]
        [TestCase(5, -3, 2)]
        public void Add_ReturnsSum(float num1, float num2, float result)
        {
            var sum = Calculator.Add(num1, num2);
            Assert.That(sum, Is.EqualTo(result));
        }
        [Test]
        [TestCase(3, 2, 1)]
        [TestCase(5.1f, 2.1f, 3)]
        [TestCase(5, -3, 8)]
        public void Subtract_ReturnsDifference(float num1, float num2, float result)
        {
            var diff = Calculator.Subtract(num1, num2);
            Assert.That(diff, Is.EqualTo(result));
        }

        [Test]
        [TestCase(3, 2, 6)]
        [TestCase(4, 8, 32)]
        [TestCase(5, -3, -15)]
        public void Multiply_ReturnsProduct(float num1, float num2, float result)
        {
            var prod = Calculator.Multiply(num1, num2);
            Assert.That(prod, Is.EqualTo(result));
        }

        [Test]
        [TestCase(6, 2, 3)]
        [TestCase(6, 3, 2)]
        [TestCase(-15, -3, 5)]
        public void Divide_ReturnsQuotient(float num1, float num2, float result)
        {
            var quot = Calculator.Divide(num1, num2);
            Assert.That(quot, Is.EqualTo(result));
        }

        [Test]
        public void Divide_ThrowsOnDivideByZero()
        {
            Assert.Throws<DivideByZeroException>(() => Calculator.Divide(4, 0));
        }
    }
}
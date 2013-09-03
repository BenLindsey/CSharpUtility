using Math;
using NUnit.Framework;

namespace MathTests
{
    class FunctionsTests
    {
        [TestCase(0, 1)]
        [TestCase(1, 1)]
        [TestCase(2, 2)]
        [TestCase(6, 720)]
        [TestCase(8, 40320)]
        public void FactorialReturnsCorrectResult(int input, int result)
        {
            Assert.That(Functions.Factorial(input), Is.EqualTo(result));
        }
    }
}

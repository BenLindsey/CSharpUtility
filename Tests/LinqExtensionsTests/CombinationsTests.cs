using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqExtenstions;
using NUnit.Framework;

namespace LinqExtensionsTests
{
    [TestFixture]
    public class CombinationsTests
    {
        public static IEnumerable<TestCaseData> IntEnumerables()
        {
            return new[]
            {
                new TestCaseData(new[] {1}).SetName("1 element"),
                new TestCaseData(new[] {1, 2}).SetName("2 elements"),
                new TestCaseData(new[] {1, 2, 3}).SetName("3 elements"),
                new TestCaseData(new[] {1, 2, 3, 4}).SetName("4 elements"),
                new TestCaseData(new[] {1, 2, 3, 4, 5}).SetName("5 elements")
            };
        }

        [TestCaseSource("IntEnumerables")]
        public void PermutationsReturnsCorrectNumberOfEnumerables(IEnumerable<int> enumerable)
        {
            var enumeratedArray = enumerable as int[] ?? enumerable.ToArray();

            Assert.That(enumeratedArray.Permutations().Count(), 
                Is.EqualTo(Factorial(enumeratedArray.Count())));
        }

        private static int Factorial(int x)
        {
            return x <= 1 ? 1 : x * Factorial(x - 1);
        }
    }
}

using NUnit.Framework;
using CalcLibrary;

namespace CalcLibrary.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        private Calculator _calculator;

        [SetUp]
        public void Setup()
        {
            _calculator = new Calculator();
        }

        [TearDown]
        public void Teardown()
        {
            _calculator = null;
        }

        [TestCase(2, 3, 5)]
        [TestCase(-1, 4, 3)]
        [TestCase(0, 0, 0)]
        public void Add_WhenCalled_ReturnsCorrectSum(int a, int b, int expected)
        {
            var result = _calculator.Add(a, b);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [Ignore("This test is ignored for demo purposes.")]
        public void ThisTestWillBeIgnored()
        {
            Assert.Fail("This test should be skipped.");
        }
    }
}

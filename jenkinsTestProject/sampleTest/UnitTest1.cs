using jenkinsTestProject.Models;
using NUnit.Framework;

namespace sampleTest
{
    public class Tests
    {
        public CalculationService calculationService { get; set; }
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        [Test]
        public void CalculationTest()
        {
            int number1 = 5;
            int number2 = 4;
            int expectedResult = 9;

            var result = calculationService.sum(number1, number2);
            Assert.AreEqual(result, expectedResult);
        }
    }
}
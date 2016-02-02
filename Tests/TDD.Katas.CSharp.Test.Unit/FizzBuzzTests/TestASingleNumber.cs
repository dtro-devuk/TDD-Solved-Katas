using NUnit.Framework;

namespace TDD.Katas.CSharp.Test.Unit.FizzBuzzTests
{
    [Category("Fizz Buzz Kata")]
    public class TestASingleNumber : WhenTestingFizzBuzz
    {
        public void Arrange()
        {
            ActualInputValue = 1;
        }

        [Test]
        public void GivenValidSingleNumber_ItShouldReturnAStringNumber()
        {
            Arrange();
            ActAndAssert();
            Assert.AreEqual("1", _resultFizz);
        }

        [TestCase(1,"1")]
        [TestCase(2, "2")]
        public void GivenValidSingleNumbersBelowTwo_ItShouldReturnTheCorrectStringNumber(int actual, string expectedResult)
        {
            ActualInputValue = actual;

            ActAndAssert();
            Assert.AreEqual(expectedResult, _resultFizz);
        }

        [TestCase(1, "1")]
        [TestCase(2, "2")]
        [TestCase(3, "FIZZ")]
        public void GivenValidSingleNumbersBelowThree_ItShouldReturnTheCorrectString(int actual, string expectedResult)
        {
            ActualInputValue = actual;

            ActAndAssert();
            Assert.AreEqual(expectedResult, _resultFizz);
        }
    }
}

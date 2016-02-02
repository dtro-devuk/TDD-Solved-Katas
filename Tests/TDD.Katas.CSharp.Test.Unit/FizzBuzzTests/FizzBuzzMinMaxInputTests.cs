using NUnit.Framework;

namespace TDD.Katas.CSharp.Test.Unit.FizzBuzzTests
{
    [Category("Fizz Buzz Kata")]
    public class FizzBuzzMinMaxInputTests : WhenTestingFizzBuzz
    {
        #region Test Methods

        [TestCase(-1)]
        [TestCase(0)]
        public void GivenNumberBelowMinimumInput_ReturnEmptyString(int actualInput)
        {
            ActAndAssert();
            Assert.That(_resultFizz, Is.Empty);
        }


        [TestCase(101)]
        public void GivenNumberAboveMaxInput_ReturnEmptyString(int actualInput)
        {
            ActAndAssert();
            Assert.That(_resultFizz, Is.Empty);
        }
        #endregion
    }
}

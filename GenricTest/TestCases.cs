using Genric;
using NUnit.Framework;

namespace GenricTest
{
    public class TestCases
    {
       

        [Test]
        public void GivenMaxInFirst_WhenPrintMaxValue_ThenShouldGiveFirstValue()
        {

            int[] intArray = { 9, 2, 1, 4 };
            int expected = intArray[0];
            GenricMaximum<int> generic = new GenricMaximum<int>();
            int result = generic.PrintMaxValue(intArray);
           
            Assert.AreEqual(expected,result);

        }
        public void GivenMaxInSecond_WhenPrintMaxValue_ThenShouldGiveSecondValue()
        {

            int[] intArray = { 2, 9, 1, 4 };
            int expected = intArray[1];
            GenricMaximum<int> generic = new GenricMaximum<int>();
            int result = generic.PrintMaxValue(intArray);

            Assert.AreEqual(expected, result);

        }
    }
}
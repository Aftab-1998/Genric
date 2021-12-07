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

            Assert.AreEqual(expected, result);

        }
        public void GivenMaxInSecond_WhenPrintMaxValue_ThenShouldGiveSecondValue()
        {

            int[] intArray = { 2, 9, 1, 4 };
            int expected = intArray[1];
            GenricMaximum<int> generic = new GenricMaximum<int>();
            int result = generic.PrintMaxValue(intArray);

            Assert.AreEqual(expected, result);

        }
        public void GivenMaxInThird_WhenPrintMaxValue_ThenShouldGiveThirdValue()
        {

            int[] intArray = { 1, 2, 9, 4 };
            int expected = intArray[2];
            GenricMaximum<int> generic = new GenricMaximum<int>();
            int result = generic.PrintMaxValue(intArray);

            Assert.AreEqual(expected, result);

        }
        public void GivenMaxdoubleFirst_WhenPrintMaxValue_ThenShouldGiveFirstValue()
        {

            double[] doubleArray = { 9.9, 2.2, 1.1, 4.4 };
            double expected = doubleArray[0];
            GenricMaximum<double> generic = new GenricMaximum<double>();
            double result = generic.PrintMaxValue(doubleArray);

            Assert.AreEqual(expected, result);
        }
    }
}
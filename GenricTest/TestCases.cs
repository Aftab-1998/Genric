using Genric;
using NUnit.Framework;

namespace GenricTest
{
    public class TestCases
    {
       

        [Test]
        public void GivenMaxIntFirst_WhenPrintMaxValue_ThenShouldGiveFirstValue()
        {

            int[] intArray = { 9, 2, 1, 4 };
            int expected = intArray[0];
            GenricMaximum<int> generic = new GenricMaximum<int>();
            int result = generic.PrintMaxValue(intArray);
           
            Assert.AreEqual(expected,result);

        }
        public void GivenMaxIntSecond_WhenPrintMaxValue_ThenShouldGiveSecondValue()
        {
             
            int[] intArray = { 2, 9, 1, 4 };
            int expected = intArray[1];
            GenricMaximum<int> generic = new GenricMaximum<int>();
            int result = generic.PrintMaxValue(intArray);

            Assert.AreEqual(expected, result);

        }
        public void GivenMaxIntThird_WhenPrintMaxValue_ThenShouldGiveThirdValue()
        {

            int[] intArray = { 1, 2, 9, 4 };
            int expected = intArray[2];
            GenricMaximum<int> generic = new GenricMaximum<int>();
            int result = generic.PrintMaxValue(intArray);

            Assert.AreEqual(expected, result);

        }
        public void GivenMaxStringFirst_WhenPrintMaxValue_ThenShouldGiveFirstValue()
        {

            string[] stringArray = { "999", "222", "111", "444" };
            string expected = stringArray[0];
            GenricMaximum<string> generic = new GenricMaximum<string>();
            string result = generic.PrintMaxValue(stringArray);

            Assert.AreEqual(expected, result);
        }

        public void GivenMaxStringSecond_WhenPrintMaxValue_ThenShouldGiveSecondValue()
        {

            string[] stringArray = { "Appale", "Banana", "Peach" };
            string expected = stringArray[1];
            GenricMaximum<string> generic = new GenricMaximum<string>();
            string result = generic.PrintMaxValue(stringArray);

            Assert.AreEqual(expected, result);
        }
    }
}
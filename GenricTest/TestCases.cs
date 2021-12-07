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

            Assert.AreEqual(expected, result);

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

        public void GivenMaxStringThird_WhenPrintMaxValue_ThenShouldGiveThirdValue()
        {

            string[] stringArray = { "Appale", "peach", "Banana" };
            string expected = stringArray[2];
            GenricMaximum<string> generic = new GenricMaximum<string>();
            string result = generic.PrintMaxValue(stringArray);
        }

            public void GivenMaxdoubleFirst_WhenPrintMaxValue_ThenShouldGiveFirstValue()
            {

                double[] doubleArray = { 9.9, 2.2, 1.1, 4.4 };
                double expected = doubleArray[0];
                GenricMaximum<double> generic = new GenricMaximum<double>();
                double result = generic.PrintMaxValue(doubleArray);
 

                Assert.AreEqual(expected, result);
             }
        public void GivenMaxdoubleSecond_WhenPrintMaxValue_ThenShouldGiveSecondValue()
        {

            double[] doubleArray = { 2.2, 9.9, 1.1, 4.4 };
            double expected = doubleArray[1];
            GenricMaximum<double> generic = new GenricMaximum<double>();
            double result = generic.PrintMaxValue(doubleArray);


            Assert.AreEqual(expected, result);
        }
        public void GivenMaxdoubleThird_WhenPrintMaxValue_ThenShouldGiveThirdValue()
        {

            double[] doubleArray = { 2.2, 1.1, 9.9, 4.4 };
            double expected = doubleArray[2];
            GenricMaximum<double> generic = new GenricMaximum<double>();
            double result = generic.PrintMaxValue(doubleArray);


            Assert.AreEqual(expected, result);
        }
    }
}
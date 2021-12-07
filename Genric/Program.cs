using Genric;

class program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Find Maximum Number!");

        int[] intArray = { 1, 2, 9,4 };
        GenricMaximum<int> generic = new GenricMaximum<int>();        
        generic.PrintMaxValue(intArray);

        double[] doubleArray = { 1.1, 1.2, 1.3 };
        GenricMaximum<double> genericDouble = new GenricMaximum<double>();
        genericDouble.PrintMaxValue(doubleArray);


        string[] stringArray = { "111", "222", "333" };
        GenricMaximum<string> genericString = new GenricMaximum<string>();
        genericString.PrintMaxValue(stringArray);







    }
}

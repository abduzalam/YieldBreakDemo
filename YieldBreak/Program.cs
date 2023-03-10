internal partial class Program
{
    private static void Main(string[] args)
    {
        //  IEnumerable<int> years = Utility.GenerateRandomYears();

       // IEnumerable<int> years = Utility.GenerateRandomYearsWithYieldBreak();

        foreach (var y in Utility.GenerateRandomYearsWithYieldBreak())
            Console.WriteLine(y.ToString());
    }
}
internal partial class Program
{
    private static void Main(string[] args)
    {
        IEnumerable<int> years = Utility.GenerateRandomYears();

        foreach(var y in years)
            Console.WriteLine(y.ToString());
    }
}
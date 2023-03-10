public static class Utility
{
    private static readonly Random random = new();
    public static IEnumerable<int> GenerateRandomYears()
    {
        int year;
        while (true)
        {
            year = random.Next(2000, 2023);
            yield return year;
        }
    }

    public static IEnumerable<int> GenerateRandomYearsWithYieldBreak()
    {
        int year;
        while (true)
        {
            year = random.Next(1900, 2023);
            yield return year;

            if (year % 4 == 0)
            {
                Console.WriteLine($"{Environment.NewLine}Encountered Leap Year:{year}");
                yield break;
            }
        }
    }
}
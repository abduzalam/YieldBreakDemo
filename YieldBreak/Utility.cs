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
}
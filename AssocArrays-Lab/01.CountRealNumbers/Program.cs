namespace _01.CountRealNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            SortedDictionary<double, int> countNumbers = new();

            foreach (double number in numbers)
            {
                if (!countNumbers.ContainsKey(number))
                {
                    countNumbers.Add(number, 0);
                }

                countNumbers[number]++;
            }

            foreach (KeyValuePair<double, int> kvp in countNumbers)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}

namespace _03.Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            double average = numbers.Average();

            int[] result = numbers.Where(x => x > average)
                .OrderByDescending(x => x)
                .Take(5)
                .ToArray();

            if (result.Any())
            {
                Console.WriteLine(string.Join(" ", result));
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}

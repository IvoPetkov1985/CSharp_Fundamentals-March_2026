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
            int[] filtered = Array.FindAll(numbers, x => x > average);
            Array.Sort(filtered);
            Array.Reverse(filtered);

            string result = filtered.Length > 0
                ? string.Join(" ", filtered.Take(5))
                : "No";

            Console.WriteLine(result);
        }
    }
}

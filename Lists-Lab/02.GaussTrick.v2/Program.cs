namespace _02.GaussTrick.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int count = numbers.Count;

            for (int i = 0; i < count / 2; i++)
            {
                int firstValue = numbers[i];
                int lastValue = numbers[^1];
                numbers[i] = firstValue + lastValue;
                numbers.RemoveAt(numbers.Count - 1);
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}

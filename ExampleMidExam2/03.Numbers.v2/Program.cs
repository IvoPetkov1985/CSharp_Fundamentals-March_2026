namespace _03.Numbers.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            double average = numbers.Average();
            numbers = numbers.Where(x => x > average).ToList();
            numbers = numbers.OrderByDescending(x => x).Take(5).ToList();

            if (numbers.Count > 0)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}

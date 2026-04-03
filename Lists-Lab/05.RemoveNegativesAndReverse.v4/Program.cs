namespace _05.RemoveNegativesAndReverse.v4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputNumbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] positiveNumbers = Array.FindAll(inputNumbers, x => x >= 0);
            Array.Reverse(positiveNumbers);
            
            if (positiveNumbers.Length > 0)
            {
                Console.WriteLine(string.Join(" ", positiveNumbers));
            }
            else
            {
                Console.WriteLine("empty");
            }
        }
    }
}

namespace _06.EvenAndOddSubtraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int result = inputArray.Where(x => x % 2 == 0).Sum() -
                inputArray.Where(x => x % 2 != 0).Sum();

            Console.WriteLine(result);
        }
    }
}

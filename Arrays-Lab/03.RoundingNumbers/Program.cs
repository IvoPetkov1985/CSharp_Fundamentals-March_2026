namespace _03.RoundingNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] realNumbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            int[] roundedNumbers = realNumbers
                .Select(x => (int)Math.Round(x, MidpointRounding.AwayFromZero))
                .ToArray();

            for (int i = 0; i < realNumbers.Length; i++)
            {
                Console.WriteLine($"{realNumbers[i]} => {roundedNumbers[i]}");
            }
        }
    }
}

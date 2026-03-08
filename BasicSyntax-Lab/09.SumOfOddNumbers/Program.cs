namespace _09.SumOfOddNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbersCount = int.Parse(Console.ReadLine());
            int number = 1;
            int[] numbers = new int[numbersCount];

            for (int i = 0; i < numbersCount; i++)
            {
                Console.WriteLine(number);
                numbers[i] = number;
                number += 2;
            }

            Console.WriteLine($"Sum: {numbers.Sum()}");
        }
    }
}

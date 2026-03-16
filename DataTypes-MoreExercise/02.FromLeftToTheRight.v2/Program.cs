namespace _02.FromLeftToTheRight.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfLines; i++)
            {
                long[] numbers = Console.ReadLine()
                    .Split(" ")
                    .Select(long.Parse)
                    .ToArray();

                long leftNumber = numbers.First();
                long rightNumber = numbers.Last();
                long maxNumber = Math.Abs(Math.Max(leftNumber, rightNumber));

                int sumDigits = 0;

                while (maxNumber > 0)
                {
                    sumDigits += (int)(maxNumber % 10);
                    maxNumber /= 10;
                }

                Console.WriteLine(sumDigits);
            }
        }
    }
}

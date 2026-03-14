using System.Numerics;

namespace _02.FromLeftToTheRight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());

            for (int line = 0; line < numberOfLines; line++)
            {
                string input = Console.ReadLine();

                BigInteger[] numbers = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(BigInteger.Parse)
                    .ToArray();

                BigInteger leftNumber = numbers.First();
                BigInteger rightNumber = numbers.Last();
                BigInteger maxNumber = BigInteger.Max(leftNumber, rightNumber);

                string numAsString = BigInteger.Abs(maxNumber).ToString();
                int sumDigits = 0;

                for (int i = 0; i < numAsString.Length; i++)
                {
                    int digit = int.Parse(numAsString[i].ToString());
                    sumDigits += digit;
                }

                Console.WriteLine(sumDigits);
            }
        }
    }
}

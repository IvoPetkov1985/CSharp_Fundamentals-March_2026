namespace _10.MultiplyEvensByOdds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = Math.Abs(int.Parse(Console.ReadLine()));
            Console.WriteLine(GetMultipleOfEvenAndOdds(number));
        }

        static int GetMultipleOfEvenAndOdds(int number)
        {
            int firstMultiplyer = GetSumOfEvenDigits(number);
            int secondMultiplyer = GetSumOfOddDigits(number);
            return firstMultiplyer * secondMultiplyer;
        }

        static int GetSumOfEvenDigits(int number)
        {
            int copyNumber = number;
            int evenSum = 0;

            while (copyNumber > 0)
            {
                int digit = copyNumber % 10;

                if (digit % 2 == 0)
                {
                    evenSum += digit;
                }

                copyNumber /= 10;
            }

            return evenSum;
        }

        static int GetSumOfOddDigits(int number)
        {
            int copyNumber = number;
            int oddSum = 0;

            while (copyNumber > 0)
            {
                int digit = copyNumber % 10;

                if (digit % 2 != 0)
                {
                    oddSum += digit;
                }

                copyNumber /= 10;
            }

            return oddSum;
        }
    }
}

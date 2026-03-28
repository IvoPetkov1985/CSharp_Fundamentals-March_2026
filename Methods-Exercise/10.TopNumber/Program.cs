namespace _10.TopNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int endValue = int.Parse(Console.ReadLine());
            int startValue = 1;

            for (int i = startValue; i <= endValue; i++)
            {
                int currentNumber = i;

                if (IsSumDigitsDivisibleBy8(currentNumber) 
                    && ContainsOddDigit(currentNumber))
                {
                    Console.WriteLine(currentNumber);
                }
            }
        }

        static bool IsSumDigitsDivisibleBy8(int number)
        {
            int sumDigits = 0;

            while (number > 0)
            {
                int digit = number % 10;
                sumDigits += digit;
                number /= 10;
            }

            return sumDigits % 8 == 0;
        }

        static bool ContainsOddDigit(int number)
        {
            while (number > 0)
            {
                int digit = number % 10;

                if (digit % 2 != 0)
                {
                    return true;
                }

                number /= 10;
            }

            return false;
        }
    }
}

namespace _05.SpecialNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());

            for (int number = 1; number <= inputNumber; number++)
            {
                int numberCopy = number;
                int sumDigits = 0;

                while (numberCopy > 0)
                {
                    int digit = numberCopy % 10;
                    sumDigits += digit;
                    numberCopy /= 10;
                }

                if (sumDigits == 5 || sumDigits == 7 || sumDigits == 11)
                {
                    Console.WriteLine($"{number} -> True");
                }
                else
                {
                    Console.WriteLine($"{number} -> False");
                }
            }
        }
    }
}

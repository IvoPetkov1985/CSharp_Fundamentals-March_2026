namespace _02.SumDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());
            int sumDigits = 0;
            int copyNumber = inputNumber;

            while (true)
            {
                if (copyNumber == 0)
                {
                    break;
                }

                int digit = copyNumber % 10;
                sumDigits += digit;
                copyNumber /= 10;
            }

            Console.WriteLine(sumDigits);
        }
    }
}

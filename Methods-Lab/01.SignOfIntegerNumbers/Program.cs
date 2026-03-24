namespace _01.SignOfIntegerNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            PrintSign(number);
        }

        static void PrintSign(int number)
        {
            string result = string.Empty;

            if (number > 0)
            {
                result = $"The number {number} is positive.";
            }
            else if (number < 0)
            {
                result = $"The number {number} is negative.";
            }
            else if (number == 0)
            {
                result = $"The number {number} is zero.";
            }

            Console.WriteLine(result);
        }
    }
}

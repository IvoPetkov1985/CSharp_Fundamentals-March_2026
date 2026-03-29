namespace _05.MultiplicationSign
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            int[] numbers = new int[3] { firstNumber, secondNumber, thirdNumber };
            Console.WriteLine(FindProductSign(numbers));
        }

        static string FindProductSign(int[] ints)
        {
            if (ints.Contains(0))
            {
                return "zero";
            }

            int[] negativeNumbers = ints.Where(x => x < 0).ToArray();

            if (negativeNumbers.Length % 2 != 0)
            {
                return "negative";
            }
            else
            {
                return "positive";
            }
        }
    }
}

namespace _01.SmallestOfThreeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            Console.WriteLine(GetSmallestNumber(firstNumber, secondNumber, thirdNumber));
        }

        static int GetSmallestNumber(int num1, int num2, int num3)
        {
            int[] numbers = new int[3] { num1, num2, num3 };
            int minNumber = numbers.Min();
            return minNumber;
        }
    }
}

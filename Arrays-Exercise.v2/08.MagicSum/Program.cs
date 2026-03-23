namespace _08.MagicSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int magicSum = int.Parse(Console.ReadLine());

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    int firstNumber = numbers[i];
                    int secondNumber = numbers[j];

                    if (firstNumber + secondNumber == magicSum)
                    {
                        Console.WriteLine($"{firstNumber} {secondNumber}");
                    }
                }
            }
        }
    }
}

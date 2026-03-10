namespace _04.PrintAndSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            int[] numbers = new int[secondNumber - firstNumber + 1];

            for (int i = firstNumber; i <= secondNumber; i++)
            {
                numbers[i - firstNumber] = i;
            }

            Console.WriteLine(string.Join(" ", numbers));
            Console.WriteLine($"Sum: {numbers.Sum()}");
        }
    }
}

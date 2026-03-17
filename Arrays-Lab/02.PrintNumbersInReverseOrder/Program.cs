namespace _02.PrintNumbersInReverseOrder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbersCoumnt = int.Parse(Console.ReadLine());

            int[] numbers = new int[numbersCoumnt];

            for (int i = 0; i < numbersCoumnt; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                numbers[i] = currentNumber;
            }

            for (int i = numbers.Length - 1; i >= 1; i--)
            {
                Console.Write(numbers[i] + " ");
            }

            Console.WriteLine(numbers[0]);
        }
    }
}

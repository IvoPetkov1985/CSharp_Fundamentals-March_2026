namespace _01.Messaging
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string inputText = Console.ReadLine();
            string message = string.Empty;

            foreach (int currentNumber in numbers)
            {
                int sum = 0;
                int copyNumber = currentNumber;

                while (copyNumber > 0)
                {
                    int digit = copyNumber % 10;
                    sum += digit;
                    copyNumber /= 10;
                }

                int index = sum % inputText.Length;
                char symbol = inputText[index];
                message += symbol;
                inputText = inputText.Remove(index, 1);
            }

            Console.WriteLine(message);
        }
    }
}

namespace _01.Messaging
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string text = Console.ReadLine();
            string message = string.Empty;

            foreach (int number in numbers)
            {
                int sumDigits = 0;
                int numberCopy = number;

                while (numberCopy > 0)
                {
                    sumDigits += numberCopy % 10;
                    numberCopy /= 10;
                }

                int index = sumDigits % text.Length;
                message += text[index];
                text = text.Remove(index, 1);
            }

            Console.WriteLine(message);
        }
    }
}

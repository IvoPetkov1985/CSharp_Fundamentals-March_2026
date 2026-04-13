namespace _08.LettersChangeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            double totalSum = 0;

            foreach (string text in input)
            {
                char firstLetter = text.First();
                char secondLetter = text.Last();
                double number = double.Parse(text.Substring(1, text.Length - 2));
                int firstLetterPosition = GetLetterPosition(firstLetter);
                int secondLetterPosition = GetLetterPosition(secondLetter);

                if (char.IsUpper(firstLetter))
                {
                    number /= firstLetterPosition;
                }
                else
                {
                    number *= firstLetterPosition;
                }

                if (char.IsUpper(secondLetter))
                {
                    number -= secondLetterPosition;
                }
                else
                {
                    number += secondLetterPosition;
                }

                totalSum += number;
            }

            Console.WriteLine($"{totalSum:F2}");
        }

        static int GetLetterPosition(char letter)
        {
            return letter.ToString().ToLower().First() - 96;
        }
    }
}

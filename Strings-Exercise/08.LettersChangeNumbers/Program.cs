namespace _08.LettersChangeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] strings = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            double totalSum = 0;

            for (int i = 0; i < strings.Length; i++)
            {
                string text = strings[i];

                char firstLetter = text[0];
                text = text.Remove(0, 1);

                char lastLetter = text[text.Length - 1];
                text = text.Remove(text.Length - 1, 1);

                double number = double.Parse(text);

                int firstLetterPosition = CalculateLetterPosition(firstLetter);
                int lastLetterPosition = CalculateLetterPosition(lastLetter);

                if (char.IsUpper(firstLetter))
                {
                    number /= firstLetterPosition;
                }
                else
                {
                    number *= firstLetterPosition;
                }

                if (char.IsUpper(lastLetter))
                {
                    number -= lastLetterPosition;
                }
                else
                {
                    number += lastLetterPosition;
                }

                totalSum += number;
            }

            Console.WriteLine($"{totalSum:F2}");
        }

        static int CalculateLetterPosition(char letter)
        {
            int startUpperCase = 65;
            int startLowerCase = 97;

            if (char.IsUpper(letter))
            {
                return letter - startUpperCase + 1;
            }
            else
            {
                return letter - startLowerCase + 1;
            }
        }
    }
}

namespace _07.MaxSequenceOfEqualElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] numbersAsStr = Console.ReadLine()
                .Split();

            int counter = 1;
            int bestCounter = 0;
            string bestElement = string.Empty;

            for (int i = 0; i < numbersAsStr.Length - 1; i++)
            {
                if (numbersAsStr[i] == numbersAsStr[i + 1])
                {
                    counter++;
                }
                else
                {
                    counter = 1;
                }

                if (counter > bestCounter)
                {
                    bestElement = numbersAsStr[i];
                    bestCounter = counter;
                }
            }

            string result = string.Empty;

            for (int i = 0; i < bestCounter; i++)
            {
                result += $"{bestElement} ";
            }

            Console.WriteLine(result.TrimEnd());
        }
    }
}

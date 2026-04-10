namespace _02.CharacterMultiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] strings = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string firstStr = strings[0];
            string secondStr = strings[1];

            int maxLength = Math.Max(firstStr.Length, secondStr.Length);
            int totalSum = 0;

            for (int i = 0; i < maxLength; i++)
            {
                if (i < firstStr.Length && i < secondStr.Length)
                {
                    totalSum += firstStr[i] * secondStr[i];
                }
                else if (i < firstStr.Length)
                {
                    totalSum += firstStr[i];
                }
                else if (i < secondStr.Length)
                {
                    totalSum += secondStr[i];
                }
            }

            Console.WriteLine(totalSum);
        }
    }
}

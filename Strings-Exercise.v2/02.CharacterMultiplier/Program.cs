namespace _02.CharacterMultiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] strings = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string firstString = strings.First();
            string secondString = strings.Last();

            int maxLength = Math.Max(firstString.Length, secondString.Length);
            int sum = 0;

            for (int i = 0; i < maxLength; i++)
            {
                int firstMultiplier = i < firstString.Length ? firstString[i] : 1;
                int secondMultiplier = i < secondString.Length ? secondString[i] : 1;
                sum += firstMultiplier * secondMultiplier;
            }

            Console.WriteLine(sum);
        }
    }
}

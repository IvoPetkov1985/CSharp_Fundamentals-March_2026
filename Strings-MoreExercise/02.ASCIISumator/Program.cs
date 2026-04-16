namespace _02.ASCIISumator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            char[] inputArray = input.ToCharArray();
            char[] sortedChars = GetCharsSorted(firstChar, secondChar);
            char smaller = sortedChars.First();
            char bigger = sortedChars.Last();
            char[] selectedChars = Array.FindAll(inputArray, c => c > smaller && c < bigger);
            int sumChars = GetCharsSum(selectedChars);

            Console.WriteLine(sumChars);
        }

        static char[] GetCharsSorted(char char1, char char2)
        {
            char[] chars = { char1, char2 };
            Array.Sort(chars);
            return chars;
        }

        static int GetCharsSum(char[] chars)
        {
            int sum = 0;

            foreach (char c in chars)
            {
                sum += c;
            }

            return sum;
        }
    }
}

using System.Text;

namespace _02.RepeatStrings.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            StringBuilder builder = new();

            foreach (string word in words)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    builder.Append(word);
                }
            }

            Console.WriteLine(builder.ToString());
        }
    }
}

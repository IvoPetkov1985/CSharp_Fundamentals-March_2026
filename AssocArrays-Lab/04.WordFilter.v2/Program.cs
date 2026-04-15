namespace _04.WordFilter.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string[] filteredWords = Array.FindAll(words, w => w.Length % 2 == 0);
            Console.WriteLine(string.Join(Environment.NewLine, filteredWords));
        }
    }
}

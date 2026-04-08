namespace _01.ReverseStrings.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string word = Console.ReadLine();

                if (word == "end")
                {
                    break;
                }

                string reversed = string.Join(string.Empty, word.ToCharArray().Reverse());
                Console.WriteLine($"{word} = {reversed}");
            }
        }
    }
}

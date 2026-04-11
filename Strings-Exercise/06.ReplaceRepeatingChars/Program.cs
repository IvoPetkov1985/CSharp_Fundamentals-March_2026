namespace _06.ReplaceRepeatingChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            char current = text[0];

            for (int i = 1; i < text.Length; i++)
            {
                char c = text[i];

                if (c == current)
                {
                    text = text.Remove(i, 1);
                    i--;
                }
                else
                {
                    current = c;
                }
            }

            Console.WriteLine(text);
        }
    }
}

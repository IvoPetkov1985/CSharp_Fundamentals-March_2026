namespace _06.MiddleCharacters.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            PrintMiddleCharacters(text);
        }

        static void PrintMiddleCharacters(string text)
        {
            string line = string.Empty;

            for (int i = 0; i < text.Length; i++)
            {
                if ((text.Length % 2 == 0 && i == text.Length / 2 - 1)
                    || i == text.Length / 2)
                {
                    line += text[i];
                }
            }

            Console.WriteLine(line);
        }
    }
}

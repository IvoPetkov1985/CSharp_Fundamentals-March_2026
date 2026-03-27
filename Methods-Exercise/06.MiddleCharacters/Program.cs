namespace _06.MiddleCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputText = Console.ReadLine();
            PrintCharacters(inputText);
        }

        static void PrintCharacters(string text)
        {
            string result = string.Empty;

            if (text.Length % 2 == 0)
            {
                for (int i = 0; i < text.Length; i++)
                {
                    if (i == text.Length / 2 - 1 || i == text.Length / 2)
                    {
                        result += text[i];
                    }
                }
            }
            else
            {
                for (int i = 0; i < text.Length; i++)
                {
                    if (i == text.Length / 2)
                    {
                        result += text[i];
                    }
                }
            }

            Console.WriteLine(result);
        }
    }
}

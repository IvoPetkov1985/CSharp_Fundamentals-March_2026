using System.Text;

namespace _06.ReplaceRepeatingChars.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            StringBuilder builder = new();

            char current = text[0];
            builder.Append(current);

            for (int i = 1; i < text.Length; i++)
            {
                if (text[i] == current)
                {
                    continue;
                }
                else
                {
                    current = text[i];
                    builder.Append(text[i]);
                }
            }

            Console.WriteLine(builder.ToString());
        }
    }
}

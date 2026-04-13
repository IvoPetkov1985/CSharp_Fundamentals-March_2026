using System.Text;

namespace _06.ReplaceRepeatingChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputText = Console.ReadLine();
            StringBuilder output = new();

            for (int i = 0; i < inputText.Length; i++)
            {
                output.Append(inputText[i]);

                while (i < inputText.Length - 1 && inputText[i] == inputText[i + 1])
                {
                    i++;
                }
            }

            Console.WriteLine(output.ToString());
        }
    }
}

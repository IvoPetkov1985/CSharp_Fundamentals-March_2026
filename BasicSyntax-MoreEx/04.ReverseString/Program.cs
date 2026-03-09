namespace _04.ReverseString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputText = Console.ReadLine();
            string outputText = string.Empty;

            for (int i = inputText.Length - 1; i >= 0; i--)
            {
                outputText += inputText[i];
            }

            Console.WriteLine(outputText);
        }
    }
}

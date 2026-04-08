namespace _03.Substring.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string substringToRemove = Console.ReadLine();
            string text = Console.ReadLine();

            while (text.Contains(substringToRemove))
            {
                text = text.Replace(substringToRemove, string.Empty);
            }

            Console.WriteLine(text);
        }
    }
}

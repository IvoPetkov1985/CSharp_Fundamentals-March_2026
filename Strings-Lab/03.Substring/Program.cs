namespace _03.Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stringToRemove = Console.ReadLine();
            string text = Console.ReadLine();

            while (text.IndexOf(stringToRemove) != -1)
            {
                int index = text.IndexOf(stringToRemove);
                text = text.Remove(index, stringToRemove.Length);
            }

            Console.WriteLine(text);
        }
    }
}

namespace _05.DecryptingMessage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int numberOfLines = int.Parse(Console.ReadLine());
            string message = string.Empty;

            for (int i = 0; i < numberOfLines; i++)
            {
                char letter = char.Parse(Console.ReadLine());
                letter += (char)key;
                message += letter;
            }

            Console.WriteLine(message);
        }
    }
}

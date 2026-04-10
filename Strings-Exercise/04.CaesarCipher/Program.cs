namespace _04.CaesarCipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            string encrypted = message = new string(message.Select(c => (char)(c + 3)).ToArray());
            Console.WriteLine(encrypted);
        }
    }
}

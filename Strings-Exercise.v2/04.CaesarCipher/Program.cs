using System.Text;

namespace _04.CaesarCipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputText = Console.ReadLine();
            StringBuilder builder = new();

            foreach (char symbol in inputText)
            {
                char encrypredSymbol = (char)(symbol + 3);
                builder.Append(encrypredSymbol);
            }

            Console.WriteLine(builder.ToString());
        }
    }
}

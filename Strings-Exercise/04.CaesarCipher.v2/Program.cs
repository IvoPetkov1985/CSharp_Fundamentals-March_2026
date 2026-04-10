using System.Text;

namespace _04.CaesarCipher.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            StringBuilder builder = new();

            foreach (char letter in message)
            {
                builder.Append((char)(letter + 3));
            }

            Console.WriteLine(builder.ToString());
        }
    }
}

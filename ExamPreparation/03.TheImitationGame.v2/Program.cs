using System.Text;

namespace _03.TheImitationGame.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            StringBuilder builder = new(message);
            string inputLine = Console.ReadLine();

            while (inputLine != "Decode")
            {
                string[] arguments = inputLine
                    .Split("|", StringSplitOptions.RemoveEmptyEntries);

                string command = arguments[0];

                switch (command)
                {
                    case "Move":
                        int lettersCount = int.Parse(arguments[1]);

                        if (lettersCount > 0 && lettersCount <= builder.Length)
                        {
                            string substring = builder.ToString().Substring(0, lettersCount);
                            builder.Remove(0, lettersCount);
                            builder.Append(substring);
                        }

                        break;

                    case "Insert":
                        int index = int.Parse(arguments[1]);
                        string value = arguments[2];

                        if (index >= 0 && index <= builder.Length)
                        {
                            builder.Insert(index, value);
                        }

                        break;

                    case "ChangeAll":
                        string searched = arguments[1];
                        string replacement = arguments[2];
                        builder.Replace(searched, replacement);
                        break;
                }

                inputLine = Console.ReadLine();
            }

            Console.WriteLine($"The decrypted message is: {builder.ToString()}");
        }
    }
}

using System.Text;

namespace _01.SecretChat.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string concealedMessage = Console.ReadLine();
            StringBuilder message = new(concealedMessage);
            string inputLine = Console.ReadLine();

            while (inputLine != "Reveal")
            {
                string[] arguments = inputLine
                    .Split(":|:", StringSplitOptions.RemoveEmptyEntries);
                string command = arguments[0];

                if (command == "InsertSpace")
                {
                    int insertIndex = int.Parse(arguments[1]);
                    message.Insert(insertIndex, " ");
                    Console.WriteLine(message);
                }
                else if (command == "Reverse")
                {
                    string substringToReverse = arguments[1];

                    if (message.ToString().Contains(substringToReverse))
                    {
                        int startIndex = message.ToString().IndexOf(substringToReverse);
                        message.Remove(startIndex, substringToReverse.Length);
                        string reversed = new string(substringToReverse.Reverse().ToArray());
                        message.Append(reversed);
                        Console.WriteLine(message);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if (command == "ChangeAll")
                {
                    string oldSubstring = arguments[1];
                    string newSubstring = arguments[2];
                    message.Replace(oldSubstring, newSubstring);
                    Console.WriteLine(message);
                }

                inputLine = Console.ReadLine();
            }

            Console.WriteLine($"You have a new text message: {message}");
        }
    }
}

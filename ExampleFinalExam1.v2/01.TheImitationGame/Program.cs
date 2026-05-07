using System.Text;

namespace _01.TheImitationGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string encryptedMessage = Console.ReadLine();
            StringBuilder message = new(encryptedMessage);
            string input = Console.ReadLine();

            while (input != "Decode")
            {
                string[] commandInfo = input
                    .Split("|", StringSplitOptions.RemoveEmptyEntries);
                string command = commandInfo[0];

                switch (command)
                {
                    case "Move":
                        int numberOfLetters = int.Parse(commandInfo[1]);
                        string substringToMove = message.ToString().Substring(0, numberOfLetters);
                        message.Remove(0, numberOfLetters);
                        message.Append(substringToMove);
                        break;
                    case "Insert":
                        int indexToInsert = int.Parse(commandInfo[1]);
                        string substringToInsert = commandInfo[2];
                        message.Insert(indexToInsert, substringToInsert);
                        break;
                    case "ChangeAll":
                        string oldSubstring = commandInfo[1];
                        string newSubstring = commandInfo[2];
                        message.Replace(oldSubstring, newSubstring);
                        break;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"The decrypted message is: {message}");
        }
    }
}

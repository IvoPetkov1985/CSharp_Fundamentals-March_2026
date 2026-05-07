namespace _01.TheImitationGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            string commandLine = Console.ReadLine();

            while (commandLine != "Decode")
            {
                string[] commandInfo = commandLine
                    .Split("|", StringSplitOptions.RemoveEmptyEntries);
                string command = commandInfo[0];

                if (command == "Move")
                {
                    int numberOfLetters = int.Parse(commandInfo[1]);
                    string substring = message.Substring(0, numberOfLetters);
                    message = message.Remove(0, numberOfLetters);
                    message += substring;
                }
                else if (command == "Insert")
                {
                    int indexToInsert = int.Parse(commandInfo[1]);
                    string value = commandInfo[2];
                    message = message.Insert(indexToInsert, value);
                }
                else if (command == "ChangeAll")
                {
                    string oldSubstring = commandInfo[1];
                    string newSubstring = commandInfo[2];
                    message = message.Replace(oldSubstring, newSubstring);
                }

                commandLine = Console.ReadLine();
            }

            Console.WriteLine($"The decrypted message is: {message}");
        }
    }
}

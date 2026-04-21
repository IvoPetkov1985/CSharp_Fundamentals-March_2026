namespace _03.TheImitationGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            string commandLine = Console.ReadLine();

            while (commandLine != "Decode")
            {
                string[] arguments = commandLine
                    .Split("|", StringSplitOptions.RemoveEmptyEntries);

                string command = arguments[0];

                if (command == "Move")
                {
                    int lettersCount = int.Parse(arguments[1]);

                    if (lettersCount > 0 && lettersCount <= message.Length)
                    {
                        string substring = message.Substring(0, lettersCount);
                        message = message.Remove(0, lettersCount);
                        message += substring;
                    }
                }
                else if (command == "Insert")
                {
                    int index = int.Parse(arguments[1]);
                    string value = arguments[2];

                    if (index >= 0 && index <= message.Length)
                    {
                        message = message.Insert(index, value);
                    }
                }
                else if (command == "ChangeAll")
                {
                    string oldSubstring = arguments[1];
                    string newSubstring = arguments[2];
                    message = message.Replace(oldSubstring, newSubstring);
                }

                commandLine = Console.ReadLine();
            }

            Console.WriteLine($"The decrypted message is: {message}");
        }
    }
}

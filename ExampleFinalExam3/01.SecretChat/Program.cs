namespace _01.SecretChat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            string instructionLine = Console.ReadLine();

            while (instructionLine != "Reveal")
            {
                string[] arguments = instructionLine
                    .Split(":|:", StringSplitOptions.RemoveEmptyEntries);

                string command = arguments[0];

                if (command == "InsertSpace")
                {
                    int index = int.Parse(arguments[1]);
                    message = message.Insert(index, " ");
                    Console.WriteLine(message);
                }
                else if (command == "Reverse")
                {
                    string substring = arguments[1];
                    int startIndex = message.IndexOf(substring);

                    if (startIndex > -1)
                    {
                        message = message.Remove(startIndex, substring.Length);
                        string newSubstring = new string(substring.ToCharArray().Reverse().ToArray());
                        message += newSubstring;
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
                    message = message.Replace(oldSubstring, newSubstring);
                    Console.WriteLine(message);
                }

                instructionLine = Console.ReadLine();
            }

            Console.WriteLine($"You have a new text message: {message}");
        }
    }
}

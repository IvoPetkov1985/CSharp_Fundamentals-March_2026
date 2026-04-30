namespace _01.Registration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string desiredUsername = Console.ReadLine();
            string commandLine = Console.ReadLine();

            while (commandLine != "Registration")
            {
                string[] arguments = commandLine
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = arguments[0];

                if (command == "Letters")
                {
                    string letterType = arguments[1];

                    switch (letterType)
                    {
                        case "Lower":
                            desiredUsername = desiredUsername.ToLower();
                            break;
                        case "Upper":
                            desiredUsername = desiredUsername.ToUpper();
                            break;
                    }

                    Console.WriteLine(desiredUsername);
                }
                else if (command == "Reverse")
                {
                    int startIndex = int.Parse(arguments[1]);
                    int endIndex = int.Parse(arguments[2]);

                    if (startIndex >= 0 && startIndex < desiredUsername.Length &&
                        endIndex >= 0 && endIndex < desiredUsername.Length &&
                        endIndex >= startIndex)
                    {
                        string substring = desiredUsername.Substring(startIndex, endIndex - startIndex + 1);
                        string reversed = new string(substring.Reverse().ToArray());
                        Console.WriteLine(reversed);
                    }
                }
                else if (command == "Substring")
                {
                    string substring = arguments[1];

                    if (desiredUsername.Contains(substring))
                    {
                        int startIndex = desiredUsername.IndexOf(substring);
                        desiredUsername = desiredUsername.Remove(startIndex, substring.Length);
                        Console.WriteLine(desiredUsername);
                    }
                    else
                    {
                        Console.WriteLine($"The username {desiredUsername} doesn't contain {substring}.");
                    }
                }
                else if (command == "Replace")
                {
                    char charToReplace = char.Parse(arguments[1]);
                    desiredUsername = desiredUsername.Replace(charToReplace, '-');
                    Console.WriteLine(desiredUsername);
                }
                else if (command == "IsValid")
                {
                    char charToValidate = char.Parse(arguments[1]);

                    if (desiredUsername.Contains(charToValidate))
                    {
                        Console.WriteLine("Valid username.");
                    }
                    else
                    {
                        Console.WriteLine($"{charToValidate} must be contained in your username.");
                    }
                }

                commandLine = Console.ReadLine();
            }
        }
    }
}

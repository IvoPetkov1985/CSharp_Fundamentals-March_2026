namespace _01.ActivationKeys.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string activationKey = Console.ReadLine();
            string commandLine = Console.ReadLine();

            while (commandLine != "Generate")
            {
                string[] tokens = commandLine
                    .Split(">>>", StringSplitOptions.RemoveEmptyEntries);
                string command = tokens[0];

                if (command == "Contains")
                {
                    string searchedSubstring = tokens[1];

                    if (activationKey.Contains(searchedSubstring))
                    {
                        Console.WriteLine($"{activationKey} contains {searchedSubstring}");
                    }
                    else
                    {
                        Console.WriteLine("Substring not found!");
                    }
                }
                else if (command == "Flip")
                {
                    string casing = tokens[1];
                    int startIndex = int.Parse(tokens[2]);
                    int endIndex = int.Parse(tokens[3]);
                    string substring = activationKey.Substring(startIndex, endIndex - startIndex);
                    activationKey = activationKey.Remove(startIndex, endIndex - startIndex);

                    switch (casing)
                    {
                        case "Upper":
                            substring = substring.ToUpper();
                            break;
                        case "Lower":
                            substring = substring.ToLower();
                            break;
                    }

                    activationKey = activationKey.Insert(startIndex, substring);
                    Console.WriteLine(activationKey);
                }
                else if (command == "Slice")
                {
                    int startIndex = int.Parse(tokens[1]);
                    int endIndex = int.Parse(tokens[2]);
                    activationKey = activationKey.Remove(startIndex, endIndex - startIndex);
                    Console.WriteLine(activationKey);
                }

                commandLine = Console.ReadLine();
            }

            Console.WriteLine($"Your activation key is: {activationKey}");
        }
    }
}

using System.Text;

namespace _01.Registration.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            StringBuilder builder = new(username);
            string inputLine = Console.ReadLine();

            while (inputLine != "Registration")
            {
                string[] arguments = inputLine
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string command = arguments[0];

                switch (command)
                {
                    case "Letters":
                        string lettersType = arguments[1];
                        string converted = string.Empty;

                        if (lettersType == "Lower")
                        {
                            converted = builder.ToString().ToLower();
                        }
                        else if (lettersType == "Upper")
                        {
                            converted = builder.ToString().ToUpper();
                        }

                        builder.Clear();
                        builder.Append(converted);
                        Console.WriteLine(builder);
                        break;
                    case "Reverse":
                        int startIndex = int.Parse(arguments[1]);
                        int endIndex = int.Parse(arguments[2]);

                        if (startIndex >= 0 && startIndex < builder.Length &&
                            endIndex >= 0 && endIndex < builder.Length &&
                            endIndex >= startIndex)
                        {
                            string partToReverse = builder.ToString()
                                .Substring(startIndex, endIndex - startIndex + 1);
                            string reversed = new string(partToReverse.Reverse().ToArray());
                            Console.WriteLine(reversed);
                        }

                        break;
                    case "Substring":
                        string substringToCut = arguments[1];
                        int index = builder.ToString().IndexOf(substringToCut);

                        if (index != -1)
                        {
                            builder.Remove(index, substringToCut.Length);
                            Console.WriteLine(builder);
                        }
                        else
                        {
                            Console.WriteLine($"The username {builder} doesn't contain {substringToCut}.");
                        }

                        break;
                    case "Replace":
                        char charToReplace = char.Parse(arguments[1]);
                        builder.Replace(charToReplace, '-');
                        Console.WriteLine(builder);
                        break;
                    case "IsValid":
                        char validateChar = char.Parse(arguments[1]);
                        if (builder.ToString().Contains(validateChar))
                        {
                            Console.WriteLine("Valid username.");
                        }
                        else
                        {
                            Console.WriteLine($"{validateChar} must be contained in your username.");
                        }
                        break;
                }

                inputLine = Console.ReadLine();
            }
        }
    }
}

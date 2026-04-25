using System.Text;

namespace _03.GoldenTreasure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            string commandLine = Console.ReadLine();

            StringBuilder builder = new();

            while (commandLine != "Error")
            {
                string[] tokens = commandLine
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string command = tokens[0];

                if (command == "Infuse")
                {
                    string charcters = tokens[1];
                    builder.Append(charcters);
                    Console.WriteLine(builder.ToString());
                }
                else if (command == "Transpose")
                {
                    int firstIndex = int.Parse(tokens[1]);
                    int secondIndex = int.Parse(tokens[2]);

                    if (firstIndex >= 0 && firstIndex < builder.Length &&
                        secondIndex >= 0 && secondIndex < builder.Length)
                    {
                        char temp = builder[firstIndex];
                        builder[firstIndex] = builder[secondIndex];
                        builder[secondIndex] = temp;
                        Console.WriteLine(builder.ToString());
                    }
                    else
                    {
                        Console.WriteLine("Failed attempt to unlock the treasure");
                    }
                }
                else if (command == "Retrace")
                {
                    int index = int.Parse(tokens[1]);
                    string part = builder.ToString().Substring(0, index + 1);
                    string reversed = new string(part.ToCharArray().Reverse().ToArray());
                    builder.Remove(0, index + 1);
                    builder.Insert(0, reversed);
                    Console.WriteLine(builder.ToString());
                }
                else if (command == "Destroy")
                {
                    string character = tokens[1];

                    if (builder.ToString().Contains(character))
                    {
                        builder.Replace(character, string.Empty);
                        Console.WriteLine(builder.ToString());
                    }
                    else
                    {
                        Console.WriteLine($"Character {character} is invalid");
                    }
                }
                else if (command == "Freeze")
                {
                    int counter = 0;
                    bool isError = false;

                    while (counter < 2)
                    {
                        commandLine = Console.ReadLine();

                        if (commandLine == "Error")
                        {
                            isError = true;
                            break;
                        }

                        counter++;
                    }

                    if (isError)
                    {
                        break;
                    }
                }

                if (builder.ToString() == password)
                {
                    Console.WriteLine("The Golden Treasure has been unlocked!");
                    break;
                }

                commandLine = Console.ReadLine();
            }

            if (commandLine == "Error")
            {
                Console.WriteLine($"The string {builder.ToString()} does not match the password {password}!");
            }
        }
    }
}

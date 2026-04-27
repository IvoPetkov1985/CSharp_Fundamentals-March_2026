using System.Text;

namespace _01.ActivationKeys
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string activationKey = Console.ReadLine();
            StringBuilder builder = new(activationKey);
            string commandLine = Console.ReadLine();

            while (commandLine != "Generate")
            {
                string[] arguments = commandLine
                    .Split(">>>", StringSplitOptions.RemoveEmptyEntries);
                string command = arguments.First();

                if (command == "Contains")
                {
                    string substring = arguments[1];

                    if (builder.ToString().Contains(substring))
                    {
                        Console.WriteLine($"{builder.ToString()} contains {substring}");
                    }
                    else
                    {
                        Console.WriteLine("Substring not found!");
                    }
                }
                else if (command == "Flip")
                {
                    string flipType = arguments[1];
                    int startIndex = int.Parse(arguments[2]);
                    int endIndex = int.Parse(arguments[3]);
                    string partToChange = builder.ToString().Substring(startIndex, endIndex - startIndex);
                    builder.Remove(startIndex, endIndex - startIndex);

                    switch (flipType)
                    {
                        case "Upper":
                            partToChange = partToChange.ToUpper();
                            break;
                        case "Lower":
                            partToChange = partToChange.ToLower();
                            break;
                    }

                    builder.Insert(startIndex, partToChange);
                    Console.WriteLine(builder.ToString());
                }
                else if (command == "Slice")
                {
                    int startIndex = int.Parse(arguments[1]);
                    int endIndex = int.Parse(arguments[2]);
                    builder.Remove(startIndex, endIndex - startIndex);
                    Console.WriteLine(builder.ToString());
                }

                commandLine = Console.ReadLine();
            }

            Console.WriteLine($"Your activation key is: {builder.ToString()}");
        }
    }
}

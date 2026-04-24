namespace _01.WorldTour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stops = Console.ReadLine();
            string commandLine = Console.ReadLine();

            while (commandLine != "Travel")
            {
                string[] arguments = commandLine
                    .Split(":", StringSplitOptions.RemoveEmptyEntries);

                string command = arguments[0];

                if (command == "Add Stop")
                {
                    int index = int.Parse(arguments[1]);
                    string text = arguments[2];

                    if (index >= 0 && index < stops.Length)
                    {
                        stops = stops.Insert(index, text);
                    }

                    Console.WriteLine(stops);
                }
                else if (command == "Remove Stop")
                {
                    int startIndex = int.Parse(arguments[1]);
                    int endIndex = int.Parse(arguments[2]);

                    if (startIndex >= 0 && startIndex < stops.Length &&
                        endIndex >= 0 && endIndex < stops.Length)
                    {
                        stops = stops.Remove(startIndex, endIndex - startIndex + 1);
                    }

                    Console.WriteLine(stops);
                }
                else if (command == "Switch")
                {
                    string oldValue = arguments[1];
                    string newValue = arguments[2];

                    if (stops.Contains(oldValue))
                    {
                        stops = stops.Replace(oldValue, newValue);
                    }

                    Console.WriteLine(stops);
                }

                commandLine = Console.ReadLine();
            }

            Console.WriteLine($"Ready for world tour! Planned stops: {stops}");
        }
    }
}

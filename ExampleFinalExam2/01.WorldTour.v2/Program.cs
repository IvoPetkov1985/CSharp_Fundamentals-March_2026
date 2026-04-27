using System.Text;

namespace _01.WorldTour.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stops = Console.ReadLine();
            StringBuilder builder = new(stops);
            string commandLine = Console.ReadLine();

            while (commandLine != "Travel")
            {
                string[] tokens = commandLine
                    .Split(":", StringSplitOptions.RemoveEmptyEntries);
                string command = tokens[0];

                if (command == "Add Stop")
                {
                    int index = int.Parse(tokens[1]);
                    string substring = tokens[2];

                    if (index >= 0 && index <= builder.Length)
                    {
                        builder.Insert(index, substring);
                    }
                }
                else if (command == "Remove Stop")
                {
                    int startIndex = int.Parse(tokens[1]);
                    int endIndex = int.Parse(tokens[2]);

                    if (startIndex >= 0 && startIndex < builder.Length &&
                        endIndex >= 0 && endIndex < builder.Length &&
                        endIndex >= startIndex)
                    {
                        builder.Remove(startIndex, endIndex - startIndex + 1);
                    }
                }
                else if (command == "Switch")
                {
                    string oldSubstring = tokens[1];
                    string newSubstring = tokens[2];
                    builder.Replace(oldSubstring, newSubstring);
                }

                Console.WriteLine(builder.ToString());
                commandLine = Console.ReadLine();
            }

            Console.WriteLine($"Ready for world tour! Planned stops: {builder.ToString()}");
        }
    }
}

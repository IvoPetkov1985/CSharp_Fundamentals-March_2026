namespace _03.HouseParty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int commandsCount = int.Parse(Console.ReadLine());
            List<string> guestList = new();

            for (int i = 0; i < commandsCount; i++)
            {
                string commandLine = Console.ReadLine();
                string[] tokens = commandLine.Split();
                string name = tokens[0];

                if (!tokens.Contains("not"))
                {
                    if (!guestList.Contains(name))
                    {
                        guestList.Add(name);
                    }
                    else
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    }
                }
                else
                {
                    if (!guestList.Remove(name))
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }
                }
            }

            Console.WriteLine(string.Join(Environment.NewLine, guestList));
        }
    }
}

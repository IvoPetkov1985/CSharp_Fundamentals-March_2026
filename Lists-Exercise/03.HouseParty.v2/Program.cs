namespace _03.HouseParty.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int linesCount = int.Parse(Console.ReadLine());
            List<string> names = new();

            for (int i = 0; i < linesCount; i++)
            {
                string line = Console.ReadLine();
                string[] tokens = line.Split();
                string name = tokens[0];

                if (tokens.Length == 3)
                {
                    if (names.IndexOf(name) == -1)
                    {
                        names.Add(name);
                    }
                    else
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    }
                }
                else if (tokens.Length == 4)
                {
                    if (names.IndexOf(name) != -1)
                    {
                        names.Remove(name);
                    }
                    else
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }
                }
            }

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}

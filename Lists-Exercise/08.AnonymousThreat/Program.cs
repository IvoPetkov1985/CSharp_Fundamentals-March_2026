namespace _08.AnonymousThreat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> strings = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string commandLine = Console.ReadLine();

            while (commandLine != "3:1")
            {
                string[] tokens = commandLine
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = tokens[0];
                int startIndex = int.Parse(tokens[1]);

                if (command == "merge")
                {
                    int endIndex = int.Parse(tokens[2]);

                    if (startIndex < 0)
                    {
                        startIndex = 0;
                    }

                    if (startIndex >= strings.Count)
                    {
                        startIndex = strings.Count - 1;
                    }

                    if (endIndex < 0)
                    {
                        endIndex = 0;
                    }

                    if (endIndex >= strings.Count)
                    {
                        endIndex = strings.Count - 1;
                    }

                    List<string> fragmentToMerge = strings.GetRange(startIndex, endIndex - startIndex + 1);
                    strings.RemoveRange(startIndex, endIndex - startIndex + 1);
                    string concatenated = string.Empty;

                    foreach (string fragment in fragmentToMerge)
                    {
                        concatenated += fragment;
                    }

                    strings.Insert(startIndex, concatenated);
                }
                else if (command == "divide")
                {
                    int partitions = int.Parse(tokens[2]);
                    string text = strings.ElementAt(startIndex);
                    strings.RemoveAt(startIndex);
                    int fragmentLength = text.Length / partitions;

                    List<string> rangeToInsert = new();

                    for (int i = 1; i < partitions; i++)
                    {
                        string fragmentToAdd = text.Substring(0, fragmentLength);
                        rangeToInsert.Add(fragmentToAdd);
                        text = text.Remove(0, fragmentLength);
                    }

                    rangeToInsert.Add(text);
                    strings.InsertRange(startIndex, rangeToInsert);
                }

                commandLine = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", strings));
        }
    }
}

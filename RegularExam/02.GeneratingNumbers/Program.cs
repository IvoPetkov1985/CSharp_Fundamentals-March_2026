namespace _02.GeneratingNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string commandLine = Console.ReadLine();

            while (commandLine != "END")
            {
                string[] tokens = commandLine
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string command = tokens[0];

                if (command == "add")
                {
                    int[] numbersToAdd = tokens.Skip(3).Select(int.Parse).ToArray();
                    numbers.InsertRange(0, numbersToAdd);
                }
                else if (command == "remove")
                {
                    if (tokens[1] == "greater")
                    {
                        int value = int.Parse(tokens[3]);
                        numbers.RemoveAll(x => x > value);
                    }
                    else if (tokens[1] == "at")
                    {
                        int index = int.Parse(tokens[3]);

                        if (index >= 0 && index < numbers.Count)
                        {
                            numbers.RemoveAt(index);
                        }
                    }
                }
                else if (command == "replace")
                {
                    int valueToReplace = int.Parse(tokens[1]);
                    int replacement = int.Parse(tokens[2]);
                    int indexOfReplacement = numbers.IndexOf(valueToReplace);

                    if (indexOfReplacement > -1)
                    {
                        numbers.RemoveAt(indexOfReplacement);
                        numbers.Insert(indexOfReplacement, replacement);
                    }
                }
                else if (command == "find")
                {
                    string numbersType = tokens[1];

                    switch (numbersType)
                    {
                        case "even":

                            List<int> evenNumbers = numbers.Where(x => x % 2 == 0).ToList();
                            Console.WriteLine(string.Join(" ", evenNumbers));

                            break;
                        case "odd":

                            List<int> oddNumbers = numbers.Where(x => x % 2 != 0).ToList();
                            Console.WriteLine(string.Join(" ", oddNumbers));

                            break;
                    }
                }

                commandLine = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}

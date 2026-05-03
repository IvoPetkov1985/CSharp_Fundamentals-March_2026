namespace _03.MemoryGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> elements = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string commandLine = Console.ReadLine();
            int moves = 0;

            while (commandLine != "end")
            {
                moves++;

                int[] indices = commandLine
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                int firstIndex = indices[0];
                int secondIndex = indices[1];

                if (!IsIndexValid(firstIndex, elements) || !IsIndexValid(secondIndex, elements) || firstIndex == secondIndex)
                {
                    int indexToInsert = elements.Count / 2;
                    elements.Insert(indexToInsert, $"-{moves}a");
                    elements.Insert(indexToInsert, $"-{moves}a");
                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                }
                else if (elements[firstIndex] == elements[secondIndex])
                {
                    string elementToRemove = elements[firstIndex];
                    elements.RemoveAll(e => e == elementToRemove);
                    Console.WriteLine($"Congrats! You have found matching elements - {elementToRemove}!");
                }
                else if (elements[firstIndex] != elements[secondIndex])
                {
                    Console.WriteLine("Try again!");
                }

                if (elements.Count == 0)
                {
                    Console.WriteLine($"You have won in {moves} turns!");
                    break;
                }

                commandLine = Console.ReadLine();
            }

            if (commandLine == "end" && elements.Count > 0)
            {
                Console.WriteLine("Sorry you lose :(");
                Console.WriteLine(string.Join(" ", elements));
            }
        }

        static bool IsIndexValid(int index, List<string> collection)
        {
            if (index < 0 || index >= collection.Count)
            {
                return false;
            }

            return true;
        }
    }
}

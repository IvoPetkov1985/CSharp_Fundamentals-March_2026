namespace _03.Inventory.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> journal = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string inputLine = Console.ReadLine();

            while (inputLine != "Craft!")
            {
                string[] arguments = inputLine
                    .Split(" - ", StringSplitOptions.RemoveEmptyEntries);
                string command = arguments[0];
                string[] itemArguments = arguments[1]
                    .Split(":", StringSplitOptions.RemoveEmptyEntries);
                string item = itemArguments[0];

                switch (command)
                {
                    case "Collect":

                        if (!journal.Contains(item))
                        {
                            journal.Add(item);
                        }

                        break;
                    case "Drop":
                        int dropIndex = journal.IndexOf(item);

                        if (dropIndex > -1)
                        {
                            journal.RemoveAt(dropIndex);
                        }

                        break;
                    case "Combine Items":
                        string newItem = itemArguments[1];
                        int oldItemIndex = journal.IndexOf(item);

                        if (oldItemIndex > -1)
                        {
                            journal.Insert(oldItemIndex + 1, newItem);
                        }

                        break;
                    case "Renew":
                        if (journal.Remove(item))
                        {
                            journal.Add(item);
                        }

                        break;
                }

                inputLine = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", journal));
        }
    }
}

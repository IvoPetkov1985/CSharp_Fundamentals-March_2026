namespace _02.ShoppingList.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> groceries = Console.ReadLine()
                .Split("!", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Go Shopping!")
                {
                    break;
                }

                string[] tokens = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = tokens[0];
                string item = tokens[1];

                switch (command)
                {
                    case "Urgent":
                        if (groceries.Contains(item) == false)
                        {
                            groceries.Insert(0, item);
                        }
                        break;
                    case "Unnecessary":
                        groceries.Remove(item);
                        break;
                    case "Correct":
                        string newItem = tokens[2];
                        int itemIndex = groceries.IndexOf(item);
                        if (itemIndex != -1)
                        {
                            groceries[itemIndex] = newItem;
                        }
                        break;
                    case "Rearrange":
                        if (groceries.Remove(item) == true)
                        {
                            groceries.Add(item);
                        }
                        break;
                }
            }

            Console.WriteLine(string.Join(", ", groceries));
        }
    }
}

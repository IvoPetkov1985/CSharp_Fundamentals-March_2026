namespace _03.Inventory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> inventory = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string inputLine = Console.ReadLine();

            while (inputLine != "Craft!")
            {
                string[] arguments = inputLine
                    .Split(" - ", StringSplitOptions.RemoveEmptyEntries);

                string command = arguments[0];
                string item = arguments[1];

                if (command == "Collect")
                {
                    if (inventory.Contains(item) == false)
                    {
                        inventory.Add(item);
                    }
                }
                else if (command == "Drop")
                {
                    inventory.Remove(item);
                }
                else if (command == "Combine Items")
                {
                    string[] itemsInfo = item.Split(":");
                    string oldItem = itemsInfo.First();
                    string newItem = itemsInfo.Last();
                    int itemIndex = inventory.IndexOf(oldItem);

                    if (itemIndex > -1)
                    {
                        int newItemIndex = itemIndex + 1;
                        inventory.Insert(newItemIndex, newItem);
                    }
                }
                else if (command == "Renew")
                {
                    bool isItemRemoved = inventory.Remove(item);

                    if (isItemRemoved == true)
                    {
                        inventory.Add(item);
                    }
                }

                inputLine = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", inventory));
        }
    }
}

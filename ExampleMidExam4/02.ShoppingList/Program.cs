namespace _02.ShoppingList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> groceries = Console.ReadLine()
                .Split("!", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string commandLine = Console.ReadLine();

            while (commandLine != "Go Shopping!")
            {
                string[] arguments = commandLine
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string command = arguments[0];
                string product = arguments[1];

                switch (command)
                {
                    case "Urgent":

                        if (groceries.Contains(product) == false)
                        {
                            groceries.Insert(0, product);
                        }

                        break;

                    case "Unnecessary":
                        groceries.Remove(product);
                        break;

                    case "Correct":
                        string newProduct = arguments[2];
                        int productIndex = groceries.IndexOf(product);

                        if (productIndex > -1)
                        {
                            groceries.RemoveAt(productIndex);
                            groceries.Insert(productIndex, newProduct);
                        }

                        break;

                    case "Rearrange":
                        bool isRemoved = groceries.Remove(product);

                        if (isRemoved == true)
                        {
                            groceries.Add(product);
                        }

                        break;
                }

                commandLine = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", groceries));
        }
    }
}

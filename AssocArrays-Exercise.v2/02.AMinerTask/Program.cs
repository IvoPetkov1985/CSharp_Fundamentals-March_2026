namespace _02.AMinerTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> resourcesMap = new();

            while (true)
            {
                string resource = Console.ReadLine();

                if (resource == "stop")
                {
                    break;
                }

                int quantity = int.Parse(Console.ReadLine());

                if (!resourcesMap.ContainsKey(resource))
                {
                    resourcesMap.Add(resource, quantity);
                }
                else
                {
                    resourcesMap[resource] += quantity;
                }
            }

            foreach (KeyValuePair<string, int> resourceInfo in resourcesMap)
            {
                Console.WriteLine($"{resourceInfo.Key} -> {resourceInfo.Value}");
            }
        }
    }
}

namespace _02.AMinerTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> resources = new();
            string inputResource = Console.ReadLine();

            while (inputResource != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());

                if (!resources.ContainsKey(inputResource))
                {
                    resources.Add(inputResource, 0);
                }

                resources[inputResource] += quantity;
                inputResource = Console.ReadLine();
            }

            foreach (KeyValuePair<string, int> kvp in resources)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}

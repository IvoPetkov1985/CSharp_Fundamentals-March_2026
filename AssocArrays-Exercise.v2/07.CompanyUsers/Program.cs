namespace _07.CompanyUsers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, HashSet<string>> companiesMap = new();

            while (true)
            {
                string inputLine = Console.ReadLine();

                if (inputLine == "End")
                {
                    break;
                }

                string[] arguments = inputLine.Split(" -> ");
                string companyName = arguments[0];
                string employeeId = arguments[1];

                companiesMap.TryAdd(companyName, new HashSet<string>());
                companiesMap[companyName].Add(employeeId);
            }

            foreach (KeyValuePair<string, HashSet<string>> comapnyInfo in companiesMap)
            {
                Console.WriteLine(comapnyInfo.Key);

                foreach (string id in comapnyInfo.Value)
                {
                    Console.WriteLine($"-- {id}");
                }
            }
        }
    }
}

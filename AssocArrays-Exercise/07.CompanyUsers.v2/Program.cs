namespace _07.CompanyUsers.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, HashSet<string>> agenda = new();

            string inputLine = null;
            while ((inputLine = Console.ReadLine()) != "End")
            {
                string[] tokens = inputLine.Split(" -> ");
                string companyName = tokens[0];
                string userId = tokens[1];

                if (!agenda.ContainsKey(companyName))
                {
                    agenda.Add(companyName, new HashSet<string>());
                }

                agenda[companyName].Add(userId);
            }

            foreach (KeyValuePair<string, HashSet<string>> companyInfo in agenda)
            {
                Console.WriteLine(companyInfo.Key);

                foreach (string id in companyInfo.Value)
                {
                    Console.WriteLine($"-- {id}");
                }
            }
        }
    }
}

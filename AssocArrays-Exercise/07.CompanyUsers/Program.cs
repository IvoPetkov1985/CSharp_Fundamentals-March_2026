using System.Text;

namespace _07.CompanyUsers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> companies = new();
            string inputLine = Console.ReadLine();

            while (inputLine != "End")
            {
                string[] tokens = inputLine.Split(" -> ");
                string companyName = tokens[0];
                string employeeId = tokens[1];

                if (!companies.ContainsKey(companyName))
                {
                    companies[companyName] = new List<string>();
                }

                if (!companies[companyName].Contains(employeeId))
                {
                    companies[companyName].Add(employeeId);
                }

                inputLine = Console.ReadLine();
            }

            StringBuilder builder = new();

            foreach (KeyValuePair<string, List<string>> companyInfo in companies)
            {
                builder.AppendLine(companyInfo.Key);

                foreach (string id in companyInfo.Value)
                {
                    builder.AppendLine($"-- {id}");
                }
            }

            Console.WriteLine(builder.ToString().TrimEnd());
        }
    }
}

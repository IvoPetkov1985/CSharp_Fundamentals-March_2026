using System.Text.RegularExpressions;

namespace _02.MatchPhoneNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string phoneNumbers = Console.ReadLine();
            string phonePattern = @"\+359( |-)2\1\d{3}\1\d{4}\b";
            MatchCollection phones = Regex.Matches(phoneNumbers, phonePattern);
            string[] validPhones = phones.Select(p => p.Value).ToArray();
            Console.WriteLine(string.Join(", ", validPhones));
        }
    }
}

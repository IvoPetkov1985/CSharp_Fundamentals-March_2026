using System.Text.RegularExpressions;

namespace _02.MatchPhoneNumber.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string phoneNumbers = Console.ReadLine();
            string pattern = @"\+359([ \-])2\1\d{3}\1\d{4}\b";
            MatchCollection collection = Regex.Matches(phoneNumbers, pattern);
            string[] validPhones = new string[collection.Count];

            for (int i = 0; i < collection.Count; i++)
            {
                validPhones[i] = collection[i].Value;
            }

            Console.WriteLine(string.Join(", ", validPhones));
        }
    }
}

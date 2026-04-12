using System.Text.RegularExpressions;

namespace _01.ValidUsernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine()
                .Split(", ");

            foreach (string name in usernames)
            {
                if (IsLengthValid(name) && AreAllCharctersValid(name))
                {
                    Console.WriteLine(name);
                }
            }
        }

        static bool IsLengthValid(string username)
        {
            if (username.Length < 3 || username.Length > 16)
            {
                return false;
            }

            return true;
        }

        static bool AreAllCharctersValid(string username)
        {
            Regex pattern = new(@"^[A-Za-z0-9_-]*$");

            if (pattern.IsMatch(username))
            {
                return true;
            }

            return false;
        }
    }
}

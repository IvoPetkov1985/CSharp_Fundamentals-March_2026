namespace _01.ValidUsernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            foreach (string username in usernames)
            {
                if (IsLengthValid(username) && AreAllCharactersValid(username))
                {
                    Console.WriteLine(username);
                }
            }
        }

        static bool IsLengthValid(string username)
        {
            if (username.Length > 3 && username.Length < 16)
            {
                return true;
            }

            return false;
        }

        static bool AreAllCharactersValid(string username)
        {
            if (username.All(c => char.IsLetterOrDigit(c) || c == '_' || c == '-'))
            {
                return true;
            }

            return false;
        }
    }
}

namespace _01.ValidUsernames.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            foreach (string username in usernames)
            {
                bool isLengthValid = false;
                bool areCharsValid = false;

                if (username.Length >= 3 && username.Length <= 16)
                {
                    isLengthValid = true;
                }

                if (username.All(c => char.IsLetterOrDigit(c) || c == '_' || c == '-'))
                {
                    areCharsValid = true;
                }

                if (isLengthValid && areCharsValid)
                {
                    Console.WriteLine(username);
                }
            }
        }
    }
}

namespace _01.PasswordReset
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            string inputLine = Console.ReadLine();

            while (inputLine != "Done")
            {
                string[] arguments = inputLine
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = arguments[0];

                switch (command)
                {
                    case "TakeOdd":
                        char[] passwordAsArr = password.ToCharArray();
                        passwordAsArr = passwordAsArr.Where((x, i) => i % 2 != 0).ToArray();
                        password = new string(passwordAsArr);
                        Console.WriteLine(password);
                        break;
                    case "Cut":
                        int startIndex = int.Parse(arguments[1]);
                        int count = int.Parse(arguments[2]);
                        password = password.Remove(startIndex, count);
                        Console.WriteLine(password);
                        break;
                    case "Substitute":
                        string oldSubstring = arguments[1];
                        string newSubstring = arguments[2];

                        if (password.Contains(oldSubstring))
                        {
                            password = password.Replace(oldSubstring, newSubstring);
                            Console.WriteLine(password);
                        }
                        else
                        {
                            Console.WriteLine("Nothing to replace!");
                        }

                        break;
                }

                inputLine = Console.ReadLine();
            }

            Console.WriteLine($"Your password is: {password}");
        }
    }
}

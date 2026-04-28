using System.Text;

namespace _01.PasswordReset
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();
            StringBuilder password = new(inputString);
            string commandLine = Console.ReadLine();

            while (commandLine != "Done")
            {
                string[] tokens = commandLine
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = tokens[0];

                if (command == "TakeOdd")
                {
                    StringBuilder oddTaken = new();

                    for (int i = 1; i < password.Length; i += 2)
                    {
                        oddTaken.Append(password[i]);
                    }

                    password = oddTaken;
                    Console.WriteLine(password);
                }
                else if (command == "Cut")
                {
                    int startIndex = int.Parse(tokens[1]);
                    int length = int.Parse(tokens[2]);
                    password.Remove(startIndex, length);
                    Console.WriteLine(password);
                }
                else if (command == "Substitute")
                {
                    string oldSubstring = tokens[1];
                    string newSubstring = tokens[2];

                    if (password.ToString().Contains(oldSubstring))
                    {
                        password.Replace(oldSubstring, newSubstring);
                        Console.WriteLine(password);
                    }
                    else
                    {
                        Console.WriteLine("Nothing to replace!");
                    }
                }

                commandLine = Console.ReadLine();
            }

            Console.WriteLine($"Your password is: {password}");
        }
    }
}

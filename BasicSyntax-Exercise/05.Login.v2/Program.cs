namespace _05.Login.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string correctPassword = string.Empty;

            for (int i = 0; i < username.Length; i++)
            {
                char symbol = username[username.Length - 1 - i];
                correctPassword += symbol;
            }

            int counter = 0;

            while (true)
            {
                string inputPassword = Console.ReadLine();

                if (inputPassword == correctPassword)
                {
                    counter = 0;
                    Console.WriteLine($"User {username} logged in.");
                    break;
                }

                counter++;

                if (counter < 4)
                {
                    Console.WriteLine("Incorrect password. Try again.");
                }
                else
                {
                    Console.WriteLine($"User {username} blocked!");
                    break;
                }
            }
        }
    }
}

namespace _05.Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string validPassword = new string(username.ToArray().Reverse().ToArray());

            int counter = 0;
            string inputPassword = Console.ReadLine();

            while (inputPassword != validPassword)
            {
                counter++;

                if (counter == 4)
                {
                    Console.WriteLine($"User {username} blocked!");
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect password. Try again.");
                }

                inputPassword = Console.ReadLine();
            }

            if (inputPassword == validPassword)
            {
                Console.WriteLine($"User {username} logged in.");
            }
        }
    }
}

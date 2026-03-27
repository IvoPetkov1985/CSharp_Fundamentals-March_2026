namespace _04.PasswordValidator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            bool isPasswordValid = true;

            if (IsLengthValid(password) == false)
            {
                isPasswordValid = false;
                Console.WriteLine("Password must be between 6 and 10 characters");
            }

            if (AreAllSymbolsValid(password) == false)
            {
                isPasswordValid = false;
                Console.WriteLine("Password must consist only of letters and digits");
            }

            if (IsDigitCountValid(password) == false)
            {
                isPasswordValid = false;
                Console.WriteLine("Password must have at least 2 digits");
            }

            if (isPasswordValid == true)
            {
                Console.WriteLine("Password is valid");
            }
        }

        static bool IsLengthValid(string password)
        {
            if (password.Length >= 6 && password.Length <= 10)
            {
                return true;
            }

            return false;
        }

        static bool AreAllSymbolsValid(string password)
        {
            for (int i = 0; i < password.Length; i++)
            {
                if (!char.IsDigit(password[i]) && !char.IsLetter(password[i]))
                {
                    return false;
                }
            }

            return true;
        }

        static bool IsDigitCountValid(string password)
        {
            int counter = 0;

            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsDigit(password[i]))
                {
                    counter++;
                }
            }

            return counter >= 2;
        }
    }
}

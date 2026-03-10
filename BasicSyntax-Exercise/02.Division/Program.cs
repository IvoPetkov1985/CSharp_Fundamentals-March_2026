namespace _02.Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());
            string output = string.Empty;

            if (inputNumber % 10 == 0)
            {
                output = "The number is divisible by 10";
            }
            else if (inputNumber % 7 == 0)
            {
                output = "The number is divisible by 7";
            }
            else if (inputNumber % 6 == 0)
            {
                output = "The number is divisible by 6";
            }
            else if (inputNumber % 3 == 0)
            {
                output = "The number is divisible by 3";
            }
            else if (inputNumber % 2 == 0)
            {
                output = "The number is divisible by 2";
            }
            else
            {
                output = "Not divisible";
            }

            Console.WriteLine(output);
        }
    }
}

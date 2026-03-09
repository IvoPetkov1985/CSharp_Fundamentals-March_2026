namespace _02.EnglishNameOfTheLastDigit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());
            Console.WriteLine(GetSpelling(inputNumber));
        }

        static string GetSpelling(int number)
        {
            int lastDigit = number % 10;

            switch (lastDigit)
            {
                case 1: return "one";
                case 2: return "two";
                case 3: return "three";
                case 4: return "four";
                case 5: return "five";
                case 6: return "six";
                case 7: return "seven";
                case 8: return "eight";
                case 9: return "nine";
                case 0: return "zero";
                default: return string.Empty;
            }
        }
    }
}

namespace _06.TriplesOfLatinLetters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());
            int initialCode = 97;

            for (int i = 0; i < inputNumber; i++)
            {
                for (int j = 0; j < inputNumber; j++)
                {
                    for (int k = 0; k < inputNumber; k++)
                    {
                        char firstLetter = (char)(i + initialCode);
                        char secondLetter = (char)(j + initialCode);
                        char thirdLetter = (char)(k + initialCode);
                        Console.WriteLine($"{firstLetter}{secondLetter}{thirdLetter}");
                    }
                }
            }
        }
    }
}

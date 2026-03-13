namespace _06.TriplesOfLatinLetters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());
            int startLetterNum = 97;

            for (int a1 = startLetterNum; a1 < startLetterNum + inputNumber; a1++)
            {
                for (int a2 = startLetterNum; a2 < startLetterNum + inputNumber; a2++)
                {
                    for (int a3 = startLetterNum; a3 < startLetterNum + inputNumber; a3++)
                    {
                        Console.WriteLine($"{(char)a1}{(char)a2}{(char)a3}");
                    }
                }
            }
        }
    }
}

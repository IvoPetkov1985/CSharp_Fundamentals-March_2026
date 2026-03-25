namespace _09.GreaterOfTwoValues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dataType = Console.ReadLine();

            switch (dataType)
            {
                case "int":
                    int firstNum = int.Parse(Console.ReadLine());
                    int secondNum = int.Parse(Console.ReadLine());
                    Console.WriteLine(GetMax(firstNum, secondNum));
                    break;
                case "char":
                    char firstChar = char.Parse(Console.ReadLine());
                    char secondChar = char.Parse(Console.ReadLine());
                    Console.WriteLine(GetMax(firstChar, secondChar));
                    break;
                case "string":
                    string firstString = Console.ReadLine();
                    string secondString = Console.ReadLine();
                    Console.WriteLine(GetMax(firstString, secondString));
                    break;
            }
        }

        static int GetMax(int firstValue, int secondValue)
        {
            return Math.Max(firstValue, secondValue);
        }

        static char GetMax(char firstValue, char secondValue)
        {
            if (firstValue > secondValue)
            {
                return firstValue;
            }

            return secondValue;
        }

        static string GetMax(string firstValue, string secondValue)
        {
            if (firstValue.CompareTo(secondValue) == 1)
            {
                return firstValue;
            }

            return secondValue;
        }
    }
}

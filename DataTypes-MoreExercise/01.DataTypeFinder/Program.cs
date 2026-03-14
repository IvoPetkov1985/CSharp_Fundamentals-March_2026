namespace _01.DataTypeFinder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string inputLine = Console.ReadLine();

                if (inputLine == "END")
                {
                    break;
                }

                bool isInteger = int.TryParse(inputLine, out int value);
                bool isDouble = double.TryParse(inputLine, out double db);
                bool isChar = char.TryParse(inputLine, out char c);
                bool isBool = bool.TryParse(inputLine, out bool b);

                string outputType = string.Empty;

                if (isInteger == true)
                {
                    outputType = "integer";
                }
                else if (isDouble == true)
                {
                    outputType = "floating point";
                }
                else if (isChar == true)
                {
                    outputType = "character";
                }
                else if (isBool == true)
                {
                    outputType = "boolean";
                }
                else
                {
                    outputType = "string";
                }

                Console.WriteLine($"{inputLine} is {outputType} type");
            }
        }
    }
}

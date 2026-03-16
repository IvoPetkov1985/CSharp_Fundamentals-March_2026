namespace _01.DataTypeFinder.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string type = string.Empty;

            while (input != "END")
            {
                if (int.TryParse(input, out int result))
                {
                    type = "integer";
                }
                else if (double.TryParse(input, out double number))
                {
                    type = "floating point";
                }
                else if (char.TryParse(input, out char c))
                {
                    type = "character";
                }
                else if (bool.TryParse(input, out bool b))
                {
                    type = "boolean";
                }
                else
                {
                    type = "string";
                }

                Console.WriteLine($"{input} is {type} type");

                input = Console.ReadLine();
            }
        }
    }
}
